using MimeKit;
using MailKit;
using MailKit.Net.Imap;
using MailKit.Net.Smtp;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Email_Service
{
    public partial class FORM_Main : Form
    {
        #region VARIABLES

        Profile profile;
        Mail    cur_mail;

        SmtpClient smtp_client;
        ImapClient imap_client;

        #endregion VARIABLES

        // # ===== ===== ===== ===== =====

        #region FUNCTIONS

        // # FORM states

        private void State_mail_none()
        {
            TXT_from  .ReadOnly = true;  TXT_from .Text = "";
            TXT_to    .ReadOnly = true;  TXT_to   .Text = "";
            TXT_topic .ReadOnly = true;  TXT_topic.Text = "";
            TEXT_mail .ReadOnly = true;  TEXT_mail.Text = "";
            BTN_attach.Enabled  = false; BTN_attach.Show();
            BTN_send  .Enabled  = false; BTN_send.Text = "Отправить";
            cur_mail = null;
        }

        private void State_mail_send()
        {
            TXT_from  .ReadOnly = true; TXT_from.Text = profile.ToString();
            TXT_to    .ReadOnly = false;
            TXT_topic .ReadOnly = false;
            TEXT_mail .ReadOnly = false;
            BTN_attach.Enabled  = true; BTN_attach.Show();
            BTN_send  .Enabled  = true; BTN_send.Text = "Отправить";
        }

        private void State_mail_read()
        {
            TXT_from  .ReadOnly = true;
            TXT_to    .ReadOnly = true;
            TXT_topic .ReadOnly = true;
            TEXT_mail .ReadOnly = true;
            BTN_attach.Enabled  = true; BTN_attach.Hide();
            BTN_send  .Enabled  = true; BTN_send.Text = "Ответить";
        }

        // # =====

        private bool Connect_clients(Profile profile)
        {
            if (imap_client.IsConnected || smtp_client.IsConnected)
            {
                imap_client.Disconnect(true);
                smtp_client.Disconnect(true);
            }

            if (profile.server == 'N')
            {
                MessageBox.Show("Домен указанной почты не поддерживается");
                return false;
            }
            else if (profile.server == 'G')
            {
                imap_client.Connect("imap.gmail.com", 993, true);
                smtp_client.Connect("smtp.gmail.com", 465, true);

                RADIO_mail_receive  .Enabled = false;
                RADIO_mail_important.Enabled = true;
            }
            else if (profile.server == 'Y')
            {
                imap_client.Connect("imap.yandex.ru", 993, true);
                smtp_client.Connect("smtp.yandex.ru", 465, true);

                RADIO_mail_receive  .Enabled = true;
                RADIO_mail_important.Enabled = false;
            }

            try
            {
                imap_client.Authenticate(profile.email, profile.password);
                smtp_client.Authenticate(profile.email, profile.password);
            }
            catch
            {
                MessageBox.Show("Вход в аккаунт неудался\nПроверьте, пожалуйста, данные для входа");
                imap_client.Disconnect(true);
                smtp_client.Disconnect(true);
                return false;
            }

            return true;
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

            imap_client = new ImapClient();
            smtp_client = new SmtpClient();
        }
        private void FORM_Main_FormClosing(object sender, FormClosingEventArgs e) // ! ->
        {
            imap_client.Dispose();
            smtp_client.Dispose();

            // +++ Save profiles
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
            Refresh_mails();
        }

        private void BTN_new_chain_Click(object sender, EventArgs e)
        {
            State_mail_none();
            State_mail_send();
        }

        private void LIST_mails_SelectedIndexChanged(object sender, EventArgs e) // ! =>
        {
            cur_mail = LIST_mails.SelectedItem as Mail;
            TXT_from.Text = cur_mail.from;
            // +++ Show mail
            State_mail_read();
        }

        // # MENU profile

        private void MENU_ITEM_profile_SelectedIndexChanged(object sender, EventArgs e)
        {
            profile = MENU_ITEM_profile.SelectedItem as Profile;
            if (Connect_clients(profile))
            {
                BTN_new_chain          .Enabled = true;
                FLOW_PANEL_mail_folders.Enabled = true;
                MENU_ITEM_refresh      .Enabled = true;
                MENU_ITEM_logout       .Enabled = true;
                SPLIT_container.Panel2 .Enabled = true;

                RADIO_mail_all.Checked = true;
                State_mail_none();
                Refresh_mails();
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
                        if (profile.email == login.profile.email) contains = true;
                    }
                    if (contains) return;

                    MENU_ITEM_profile.Items.Add(login.profile);
                    MENU_ITEM_profile.SelectedItem = login.profile;
                }
            }
        }

        private void MENU_ITEM_refresh_Click(object sender, EventArgs e)
        {
            Refresh_mails();
        }

        private void MENU_ITEM_logout_Click(object sender, EventArgs e)
        {
            MENU_ITEM_profile.Items.Remove(MENU_ITEM_profile.SelectedItem);
        }

        // # =====
        // # RADIOs mail folders

        private void Refresh_mails() // ! ->
        {
            // +++ Get list of all local mails

            var inbox = imap_client.Inbox;
            inbox.Open(FolderAccess.ReadOnly);
            foreach (var mail_data in inbox.Fetch(0, -1, MessageSummaryItems.EmailId))
            {
                bool new_mail = true;
                foreach (Mail mail in LIST_mails.Items)
                {
                    if (mail.UID == mail_data.EmailId) new_mail = false;
                }
                if (new_mail)
                {
                    // +++ Add new local mail to JSON and save attached
                }
            }

                 if (RADIO_mail_all      .Checked) RADIO_mail_all_CheckedChanged(new object(), new EventArgs());
            else if (RADIO_mail_sent     .Checked) RADIO_mail_sent_CheckedChanged(new object(), new EventArgs());
            else if (RADIO_mail_receive  .Checked) RADIO_mail_receive_CheckedChanged(new object(), new EventArgs());
            else if (RADIO_mail_important.Checked) RADIO_mail_important_CheckedChanged(new object(), new EventArgs());
            else if (RADIO_mail_drafts   .Checked) RADIO_mail_drafts_CheckedChanged(new object(), new EventArgs());
            else if (RADIO_mail_spam     .Checked) RADIO_mail_spam_CheckedChanged(new object(), new EventArgs());
            else if (RADIO_mail_trash    .Checked) RADIO_mail_trash_CheckedChanged(new object(), new EventArgs());
        }
        private void RADIO_mail_all_CheckedChanged(object sender, EventArgs e) // ! ->
        {
            // +++ Get list of all local mails at JSON-file with Mail's data
        }

        private void RADIO_mail_sent_CheckedChanged(object sender, EventArgs e) // ! ->
        {
            // +++ Get list of sent local mails at JSON-file with Mail's data
        }

        private void RADIO_mail_receive_CheckedChanged(object sender, EventArgs e) // ! ->
        {
            // +++ Get list of receive local mails at JSON-file with Mail's data
        }

        private void RADIO_mail_important_CheckedChanged(object sender, EventArgs e) // ! ->
        {
            // +++ Get list of important local mails at JSON-file with Mail's data
        }

        private void RADIO_mail_drafts_CheckedChanged(object sender, EventArgs e) // ! ->
        {
            // +++ Get list of draft local mails at JSON-file with Mail's data
        }

        private void RADIO_mail_spam_CheckedChanged(object sender, EventArgs e) // ! ->
        {
            // +++ Get list of spam local mails at JSON-file with Mail's data
        }

        private void RADIO_mail_trash_CheckedChanged(object sender, EventArgs e) // ! ->
        {
            // +++ Get list of trash local mails at JSON-file with Mail's data
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
        private void BTN_send_Click(object sender, EventArgs e) // ! ->
        {
            if (BTN_send.Text == "Отправить")
            {
                if (TXT_to.Text == "") { MessageBox.Show("Укажите получателя"); return; }

                var mail = new MimeMessage();
                        mail.From.Add(new MailboxAddress(profile.name, profile.email));
                try   { mail.To  .Add(new MailboxAddress(TXT_to.Text,  TXT_to.Text)); }
                catch { MessageBox.Show("Ошибка отправки\nПроверьте адрес получателя"); }
                mail.Subject = TXT_topic.Text;

                var builder = new BodyBuilder();
                builder.HtmlBody = MarkupConverter.RtfToHtmlConverter.ConvertRtfToHtml(TEXT_mail.Rtf);
                for (int i = 0; i < LIST_attached.Items.Count; i++) // файлы
                {
                    builder.Attachments.Add((LIST_attached.Items[i] as File_data).full_name);
                }
                mail.Body = builder.ToMessageBody();

                // +++ if (TXT_to.ReadOnly) mail.InReplyTo = mail.MessageId;

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
                State_mail_send();
                if (TXT_to.Text == profile.name || TXT_to.Text == profile.email)
                {
                    TXT_from.Text = profile.email;
                    TXT_to  .Text = TXT_from.Text;
                }
                TXT_to   .ReadOnly = true;
                TXT_topic.ReadOnly = true;
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
        public System.Collections.Generic.List<string> attached;

        public Mail(string _UID, string _from, string _to, string _topic, string _time, System.Collections.Generic.List<string> _attached)
        {
            UID      = _UID;
            from     = _from;
            to       = _to;
            topic    = _topic;
            time     = _time;
            attached = _attached;
        }

        public override string ToString()
        {
            return $"   От: {from}\n Кому: {to}\n{topic}\nвремя: {time} -- [приложений: {attached.Count}]";
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
