using MimeKit;
using MailKit;
using MailKit.Net.Imap;
using MailKit.Net.Smtp;

using System;
using System.IO;
using System.Linq;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Threading.Tasks;

using System.Xml.Linq;
using System.Text.Json;

namespace Email_Service
{
    public partial class FORM_Main : Form
    {
        #region VARIABLES

        private const string PATH_profiles      = @"Profiles\";
        private const string PATH_profiles_json = @"Profiles\profiles.json";
        private const string PATH_attachments   = @"\Mails\Attachments\";
        private const string PATH_storage       = @"\Mails\storage.xml";
        private const string NEW_storage        = @"<?xml version=""1.0"" encoding=""utf-8""?>
<mails>

  <sent>
  </sent>

  <important>
  </important>

  <drafts>
  </drafts>

  <spam>
  </spam>

  <trash>
  </trash>

  <other>
  </other>

</mails>";

        private Profile profile;
        private Mail    cur_mail;

        private bool       connected;
        private SmtpClient smtp_client;
        private ImapClient imap_client;

        private bool cancel;
        private Task refreshing;

        #endregion VARIABLES

        // # ===== ===== ===== ===== =====

        #region FUNCTIONS

        // # FORM states

        private void State_mail_none()
        {
            TXT_from .ReadOnly = true; TXT_from .Text = "";
            TXT_to   .ReadOnly = true; TXT_to   .Text = "";
            TXT_topic.ReadOnly = true; TXT_topic.Text = "";
            TXT_time .Text = "";
            TEXT_mail.ReadOnly = true; TEXT_mail.Text = "";

            RADIO_mail_all    .Checked = RADIO_mail_sent     .Checked =
            RADIO_mail_receive.Checked = RADIO_mail_important.Checked =
            RADIO_mail_drafts .Checked = RADIO_mail_spam     .Checked =
            RADIO_mail_trash  .Checked = false;

            LIST_attached.Items.Clear();
            BTN_attach   .Enabled = false; BTN_attach   .Show();
            CHECK_encrypt.Enabled = false; CHECK_encrypt.Show();
            CHECK_sign   .Enabled = false; CHECK_sign   .Show();
            BTN_send     .Enabled = false; BTN_send.Text = "Отправить";

            BROWSER_mail .Hide();
            PIC_encrypted.Hide();
            PIC_signed   .Hide();

            cur_mail = null;
        }

        private void State_mail_send()
        {
            TXT_from .ReadOnly = true; TXT_from.Text = profile.ToString();
            TXT_to   .ReadOnly = false;
            TXT_topic.ReadOnly = false;
            TEXT_mail.ReadOnly = false;
            LBL_time.Hide(); TXT_time.Hide(); BROWSER_mail.Hide();

            BTN_attach   .Enabled = true; BTN_attach   .Show();
            CHECK_encrypt.Enabled = true; CHECK_encrypt.Show();
            CHECK_sign   .Enabled = true; CHECK_sign   .Show();
            BTN_send     .Enabled = true; BTN_send.Text = "Отправить";
        }

        private void State_mail_read()
        {
            TXT_from .ReadOnly = true;
            TXT_to   .ReadOnly = true;
            TXT_topic.ReadOnly = true;
            TEXT_mail.ReadOnly = true;
            LBL_time.Show(); TXT_time.Show(); BROWSER_mail.Show();

            BTN_attach   .Enabled = true; BTN_attach   .Hide();
            CHECK_encrypt.Enabled = true; CHECK_encrypt.Hide();
            CHECK_sign   .Enabled = true; CHECK_sign   .Hide();
            BTN_send.Enabled      = true; BTN_send.Text = "Ответить";
        }

        // # =====

        private async void Connect_clients(Profile profile)
        {
            if (refreshing != null && !refreshing.IsCompleted) { cancel = true; await refreshing; cancel = false; }
            if (imap_client.IsConnected || smtp_client.IsConnected)
            {
                imap_client.Disconnect(true);
                smtp_client.Disconnect(true);
                connected = false;
            }

            if (profile.Server == 'N')
            {
                MessageBox.Show("Домен указанной почты не поддерживается");
                return;
            }
            else if (profile.Server == 'G')
            {
                imap_client.Connect("imap.gmail.com", 993, true);
                smtp_client.Connect("smtp.gmail.com", 465, true);

                RADIO_mail_important.Enabled = true;
            }
            else if (profile.Server == 'Y')
            {
                imap_client.Connect("imap.yandex.ru", 993, true);
                smtp_client.Connect("smtp.yandex.ru", 465, true);

                RADIO_mail_important.Enabled = false;
            }

            try
            {
                imap_client.Authenticate(profile.Email, profile.Password);
                smtp_client.Authenticate(profile.Email, profile.Password);
            }
            catch
            {
                MessageBox.Show("Вход в аккаунт неудался\nПроверьте, пожалуйста, данные для входа");
                imap_client.Disconnect(true);
                smtp_client.Disconnect(true);
                return;
            }

            TIMER_refresher.Start();
            connected = true;
            return;
        }

        private void Process_inbox(IMailFolder folder, XElement storage, XElement write_to = null)
        {
            if (folder == null) return;

            try { folder.Open(FolderAccess.ReadOnly); } catch { return; }
            foreach (var mail_data in folder.Fetch(0, -1, MessageSummaryItems.UniqueId))
            {
                bool new_mail = true;
                foreach (XElement mail in storage.Descendants("mail"))
                {
                    string _old = mail.Attribute("UID").Value;
                    string _new = mail_data.UniqueId.ToString();
                    if (_old == _new) { new_mail = false; break; }
                }
                if (new_mail)
                {
                    MimeMessage mail;
                    try { mail = folder.GetMessage(mail_data.UniqueId); } catch { continue; }
                    List<string> files = new List<string>();
                    foreach (var attached in mail.Attachments)
                    {
                        var file = (MimePart)attached;
                        string name = file.FileName.Replace(' ', '_').Replace('(', '_').Replace(')', '_').Replace('&', '_').Replace('<', '_').Replace('>', '_');
                        try
                        {
                            using (var stream = File.Create(PATH_profiles + profile.Email + PATH_attachments + name))
                                file.Content.DecodeTo(stream);

                            files.Add(name);
                        }
                        catch { }
                    }
                    XElement x_mail = new XElement("mail",
                                          new XAttribute("UID",        mail_data.UniqueId.ToString()),
                                          new XAttribute("from",       mail.From.ToString()),
                                          new XAttribute("to",         mail.To.ToString()),
                                          new XAttribute("topic",      mail.Subject),
                                          new XAttribute("time",       mail.Date.ToString("g")),
                                          new XAttribute("text_plain", mail.TextBody ?? ""),
                                          new XAttribute("text_html",  mail.HtmlBody ?? "")
                                          );
                    foreach (string file in files) x_mail.Add(new XElement(file));
                    if (write_to == null) storage.Add(x_mail);
                    else                 write_to.Add(x_mail);
                }
            }
        }
        private void Refresh_mails()
        {
            XDocument storage = XDocument.Load(PATH_profiles + profile.Email + PATH_storage);

            if (cancel) return; Process_inbox(imap_client.GetFolder(SpecialFolder.Sent),      storage.Root.Element("sent"));
            if (cancel) return; Process_inbox(imap_client.GetFolder(SpecialFolder.Important), storage.Root.Element("important"));
            if (cancel) return; Process_inbox(imap_client.GetFolder(SpecialFolder.Drafts),    storage.Root.Element("drafts"));
            if (cancel) return; Process_inbox(imap_client.GetFolder(SpecialFolder.Junk),      storage.Root.Element("spam"));
            if (cancel) return; Process_inbox(imap_client.GetFolder(SpecialFolder.Trash),     storage.Root.Element("trash"));

            if (cancel) return; Process_inbox(imap_client.Inbox, storage.Root, storage.Root.Element("other"));
            storage.Save(PATH_profiles + profile.Email + PATH_storage);

                 if (RADIO_mail_all      .Checked) RADIO_mail_all      .Invoke(new Action(() => RADIO_mail_all      .Checked = true));
            else if (RADIO_mail_sent     .Checked) RADIO_mail_sent     .Invoke(new Action(() => RADIO_mail_sent     .Checked = true));
            else if (RADIO_mail_receive  .Checked) RADIO_mail_receive  .Invoke(new Action(() => RADIO_mail_receive  .Checked = true));
            else if (RADIO_mail_important.Checked) RADIO_mail_important.Invoke(new Action(() => RADIO_mail_important.Checked = true));
            else if (RADIO_mail_drafts   .Checked) RADIO_mail_drafts   .Invoke(new Action(() => RADIO_mail_drafts   .Checked = true));
            else if (RADIO_mail_spam     .Checked) RADIO_mail_spam     .Invoke(new Action(() => RADIO_mail_spam     .Checked = true));
            else if (RADIO_mail_trash    .Checked) RADIO_mail_trash    .Invoke(new Action(() => RADIO_mail_trash    .Checked = true));
        }

        #endregion FUNCTIONS

        // # ===== ===== ===== ===== =====

        #region FORM

        private void NOTIFY_ICON_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            WindowState = FormWindowState.Normal;
            Activate();
        }

        public FORM_Main()
        {
            InitializeComponent();

            if (!Directory.Exists(PATH_profiles))      Directory.CreateDirectory(PATH_profiles);
            if (!File     .Exists(PATH_profiles_json)) File     .WriteAllText(PATH_profiles_json, "{}");
            if (File.ReadAllBytes(PATH_profiles_json).Length > 4)
            using (FileStream stream = new FileStream(PATH_profiles_json, FileMode.OpenOrCreate))
            {
                MENU_ITEM_profile.Items.AddRange(JsonSerializer.Deserialize<Profile[]>(stream));
            }

            imap_client = new ImapClient();
            smtp_client = new SmtpClient();
        }
        private async void FORM_Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            imap_client.Dispose();
            smtp_client.Dispose();

            using (FileStream stream = new FileStream(PATH_profiles_json, FileMode.OpenOrCreate))
            {
                var options = new JsonSerializerOptions { WriteIndented = true };
                Profile[] profiles = MENU_ITEM_profile.Items.Cast<Profile>().Where(x => x.Remember).ToArray();
                JsonSerializer.Serialize(stream, profiles, options);
            }

            if (refreshing != null && !refreshing.IsCompleted) { cancel = true; await refreshing; cancel = false; }
        }

        private void PIC_avatar_MouseEnter(object sender, EventArgs e)
        {
            PIC_avatar.BackColor = Color.Khaki;
        }
        private void PIC_avatar_MouseLeave(object sender, EventArgs e)
        {
            PIC_avatar.BackColor = Color.LightCyan;
        }

        private void TIMER_refresher_Tick(object sender, EventArgs e)
        {
            if (refreshing.IsCompleted) refreshing = Task.Run(() => {
                PIC_loading.Invoke(new Action(() => PIC_loading.Show()));
                Refresh_mails();
                PIC_loading.Invoke(new Action(() => PIC_loading.Hide()));
            });
        }

        private void BTN_new_chain_Click(object sender, EventArgs e)
        {
            State_mail_none();
            State_mail_send();
        }

        private void LIST_mails_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (LIST_mails.SelectedItem == null) return;
            cur_mail = LIST_mails.SelectedItem as Mail;
            TXT_from .Text = cur_mail.from;
            TXT_to   .Text = cur_mail.to;
            TXT_topic.Text = cur_mail.topic;
            TXT_time .Text = cur_mail.time;

            BROWSER_mail.DocumentText = "0";
            BROWSER_mail.Document.OpenNew(true);
            BROWSER_mail.Document.Write(cur_mail.text_plain + "<br/>");
            BROWSER_mail.Document.Write(cur_mail.text_html);
            BROWSER_mail.Refresh();

            LIST_attached.Items.Clear();
            LIST_attached.Items.AddRange(cur_mail.attached.ToArray());
            State_mail_read();
        }

        // # MENU profile

        private async void MENU_ITEM_profile_SelectedIndexChanged(object sender, EventArgs e)
        {
            profile = MENU_ITEM_profile.SelectedItem as Profile;
            Connect_clients(profile);
            if (connected)
            {
                BTN_new_chain          .Enabled = true;
                FLOW_PANEL_mail_folders.Enabled = true;
                MENU_ITEM_refresh      .Enabled = true;
                MENU_ITEM_logout       .Enabled = true;
                SPLIT_container.Panel2 .Enabled = true;

                if (!Directory         .Exists(PATH_profiles + profile.Email + PATH_attachments))
                     Directory.CreateDirectory(PATH_profiles + profile.Email + PATH_attachments);

                if (!File      .Exists(PATH_profiles + profile.Email + PATH_storage))
                     File.WriteAllText(PATH_profiles + profile.Email + PATH_storage, NEW_storage);

                State_mail_none();
                RADIO_mail_all.Checked = true;
                if (refreshing != null && !refreshing.IsCompleted) { cancel = true; await refreshing; cancel = false; }
                refreshing = Task.Run(() => {
                    PIC_loading.Invoke(new Action(() => PIC_loading.Show()));
                    Refresh_mails();
                    PIC_loading.Invoke(new Action(() => PIC_loading.Hide()));
                });
            }
            else
            {
                MENU_ITEM_profile.Items.Remove(profile);
                profile = null;
            }
        }

        private void MENU_ITEM_add_Click(object sender, EventArgs e)
        {
            using (FORM_Login login = new FORM_Login())
            {
                if (login.ShowDialog() == DialogResult.OK)
                {
                    bool contains = false;
                    foreach (Profile profile in MENU_ITEM_profile.Items)
                    {
                        if (profile.Email == login.profile.Email) contains = true;
                    }
                    if (contains) return;

                    MENU_ITEM_profile.Items.Add(login.profile);
                    MENU_ITEM_profile.SelectedItem = login.profile;
                }
            }
        }

        private void MENU_ITEM_refresh_Click(object sender, EventArgs e)
        {
            if (refreshing.IsCompleted) refreshing = Task.Run(() => {
                PIC_loading.Invoke(new Action(() => PIC_loading.Show()));
                Refresh_mails();
                PIC_loading.Invoke(new Action(() => PIC_loading.Hide()));
            });
        }

        private void MENU_ITEM_logout_Click(object sender, EventArgs e)
        {
            MENU_ITEM_profile.Items.Remove(MENU_ITEM_profile.SelectedItem);
        }

        // # =====
        // # RADIOs mail folders

        private void Get_mails(XElement storage)
        {
            foreach (XElement x_mail in storage.Elements("mail"))
            {
                List<string> attachments = new List<string>();
                foreach (XElement attached in x_mail.Elements()) attachments.Add(attached.Name.LocalName);

                Mail mail = new Mail(x_mail.Attribute("UID")       .Value,
                                     x_mail.Attribute("from")      .Value,
                                     x_mail.Attribute("to")        .Value,
                                     x_mail.Attribute("topic")     .Value,
                                     x_mail.Attribute("time")      .Value,
                                     x_mail.Attribute("text_plain").Value,
                                     x_mail.Attribute("text_html") .Value,
                                     attachments);
                LIST_mails.Items.Add(mail);
            }
        }

        private void RADIO_mail_all_CheckedChanged(object sender, EventArgs e)
        {
            if (!RADIO_mail_all.Checked) return;
            XDocument storage = XDocument.Load(PATH_profiles + profile.Email + PATH_storage);
            LIST_mails.Items.Clear();
            foreach (XElement folder in storage.Root.Elements())
                Get_mails(folder);
        }

        private void RADIO_mail_sent_CheckedChanged(object sender, EventArgs e)
        {
            if (!RADIO_mail_sent.Checked) return;
            XDocument storage = XDocument.Load(PATH_profiles + profile.Email + PATH_storage);
            LIST_mails.Items.Clear();
            Get_mails(storage.Root.Element("sent"));
        }

        private void RADIO_mail_receive_CheckedChanged(object sender, EventArgs e)
        {
            if (!RADIO_mail_receive.Checked) return;
            XDocument storage = XDocument.Load(PATH_profiles + profile.Email + PATH_storage);
            LIST_mails.Items.Clear();
            Get_mails(storage.Root.Element("other"));
        }

        private void RADIO_mail_important_CheckedChanged(object sender, EventArgs e)
        {
            if (!RADIO_mail_important.Checked) return;
            XDocument storage = XDocument.Load(PATH_profiles + profile.Email + PATH_storage);
            LIST_mails.Items.Clear();
            Get_mails(storage.Root.Element("important"));
        }

        private void RADIO_mail_drafts_CheckedChanged(object sender, EventArgs e)
        {
            if (!RADIO_mail_drafts.Checked) return;
            XDocument storage = XDocument.Load(PATH_profiles + profile.Email + PATH_storage);
            LIST_mails.Items.Clear();
            Get_mails(storage.Root.Element("drafts"));
        }

        private void RADIO_mail_spam_CheckedChanged(object sender, EventArgs e)
        {
            if (!RADIO_mail_spam.Checked) return;
            XDocument storage = XDocument.Load(PATH_profiles + profile.Email + PATH_storage);
            LIST_mails.Items.Clear();
            Get_mails(storage.Root.Element("spam"));
        }

        private void RADIO_mail_trash_CheckedChanged(object sender, EventArgs e)
        {
            if (!RADIO_mail_trash.Checked) return;
            XDocument storage = XDocument.Load(PATH_profiles + profile.Email + PATH_storage);
            LIST_mails.Items.Clear();
            Get_mails(storage.Root.Element("trash"));
        }

        // # =====
        // # CHECKs text format

        private void CHECK_b_CheckedChanged(object sender, EventArgs e)
        {
            TEXT_mail.SelectionFont = new Font(TEXT_mail.Font, TEXT_mail.SelectionFont.Style ^ FontStyle.Bold);
        }
        private void CHECK_i_CheckedChanged(object sender, EventArgs e)
        {
            TEXT_mail.SelectionFont = new Font(TEXT_mail.Font, TEXT_mail.SelectionFont.Style ^ FontStyle.Italic);
        }
        private void CHECK_u_CheckedChanged(object sender, EventArgs e)
        {
            TEXT_mail.SelectionFont = new Font(TEXT_mail.Font, TEXT_mail.SelectionFont.Style ^ FontStyle.Underline);
        }

        private void TEXT_mail_MouseDown(object sender, MouseEventArgs e)
        {
            CHECK_b.Checked = TEXT_mail.SelectionFont.Bold;
            CHECK_i.Checked = TEXT_mail.SelectionFont.Italic;
            CHECK_u.Checked = TEXT_mail.SelectionFont.Underline;
        }

        // # =====

        private void BTN_attach_Click(object sender, EventArgs e)
        {
            if (DIALOG_append.ShowDialog() == DialogResult.OK)
            {
                for (int i = 0; i < DIALOG_append.FileNames.Length; i++)
                {
                    File_data file = new File_data(DIALOG_append.FileNames[i], DIALOG_append.SafeFileNames[i]);
                    LIST_attached.Items.Add(file);
                }
            }
        }
        private void BTN_send_Click(object sender, EventArgs e)
        {
            if (BTN_send.Text == "Отправить")
            {
                if (TXT_to.Text == "") { MessageBox.Show("Укажите получателя"); return; }

                var mail = new MimeMessage();
                        mail.From.Add(new MailboxAddress(profile.Name, profile.Email));
                try   { mail.To  .Add(new MailboxAddress(TXT_to.Text,  TXT_to.Text)); }
                catch { MessageBox.Show("Ошибка отправки\nПроверьте адрес получателя"); }
                mail.Subject = TXT_topic.Text;

                var builder = new BodyBuilder();
                builder.HtmlBody = RtfPipe.Rtf.ToHtml(TEXT_mail.Rtf);
                for (int i = 0; i < LIST_attached.Items.Count; i++) // файлы
                {
                    builder.Attachments.Add((LIST_attached.Items[i] as File_data).full_name);
                }
                mail.Body = builder.ToMessageBody();

                try
                {
                    smtp_client.Send(mail);
                }
                catch
                {
                    MessageBox.Show("Ошибка отправки\nПроверьте адрес получателя\nЕсли ошибку устранить не удаётся\nто ничего уже не поделать");
                    return;
                }

                MessageBox.Show("Сообщение отправлено");

                State_mail_none();
            }
            else // # BTN_send.Text == "Ответить"
            {
                if (TXT_to.Text.ToLower().Contains(profile.Email.ToLower()))
                {
                    int from = TXT_from.Text.IndexOf('<') + 1;
                    int to   = TXT_from.Text.IndexOf('>');
                    TXT_to.Text   = from == 0 ? TXT_from.Text : TXT_from.Text.Substring(from, to - from);
                }
                else
                {
                    int from = TXT_to.Text.IndexOf('<') + 1;
                    int to   = TXT_to.Text.IndexOf('>');
                    TXT_to.Text   = from == 0 ? TXT_from.Text : TXT_to.Text.Substring(from, to - from);
                }
                State_mail_send();
                TXT_to   .ReadOnly = true;
                TXT_topic.ReadOnly = true;
                TXT_time .Text = "";
                TEXT_mail.Text = "";
                LIST_attached.Items.Clear();
            }
        }

        private void LIST_attached_DoubleClick(object sender, EventArgs e) // ! =>
        {
            // +++ Show file
        }
        private void MENU_ITEM_detach_Click(object sender, EventArgs e)
        {
            if (LIST_attached.SelectedItem == null)
                MessageBox.Show("Выберите файлы чтобы открепить");
            while (LIST_attached.SelectedItems.Count > 0)
                LIST_attached.Items.Remove(LIST_attached.SelectedItems[0]);
        }

        #endregion FORM
    }

    public class Mail
    {
        public string UID;
        public string from;
        public string to;
        public string topic;
        public string time;
        public string text_plain;
        public string text_html;
        public List<string> attached;

        public Mail(string _UID, string _from, string _to, string _topic, string _time, string _text_plain, string _text_html, List<string> _attached)
        {
            UID       = _UID;
            from      = _from;
            to        = _to;
            topic     = _topic;
            time      = _time;
            text_plain = _text_plain;
            text_html = _text_html;
            attached  = _attached;
        }

        public override string ToString()
        {
            return $"{from} > {to} : {topic} [{time}] {{{attached.Count}}}]";
        }
    }

    public class File_data
    {
        public string full_name;
        public string short_name;
        public string extention;

        public File_data(string _full_name, string _short_name)
        {
            full_name  = _full_name;
            short_name = _short_name;
            extention  = short_name.Substring(short_name.LastIndexOf('.') + 1);
        }

        public override string ToString()
        {
            return short_name;
        }
    }
}
