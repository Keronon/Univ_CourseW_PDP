using MailKit.Security;
using MimeKit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Email_Service
{
    public partial class FORM_Main : Form
    {
        #region VARIABLES

        Profile profile;
        MimeMessage mail;

        #endregion VARIABLES

        // # ===== ===== ===== ===== =====

        #region FUNCTIONS

        private void State_no_user()
        {
            BTN_new_chain          .Enabled = false;
            FLOW_PANEL_mail_folders.Enabled = false;
            MENU_ITEM_refresh      .Enabled = false;
            MENU_ITEM_logout       .Enabled = false;
            SPLIT_container.Panel2 .Enabled = false;
        }

        private void State_on_user()
        {
            BTN_new_chain          .Enabled = true;
            FLOW_PANEL_mail_folders.Enabled = true;
            MENU_ITEM_refresh      .Enabled = true;
            MENU_ITEM_logout       .Enabled = true;
            SPLIT_container.Panel2 .Enabled = true;
            RADIO_mail_all.Select();

            TXT_from    .ReadOnly = true; TXT_from .Text = "";
            TXT_to      .ReadOnly = true; TXT_to   .Text = "";
            TXT_topic   .ReadOnly = true; TXT_topic.Text = "";
            TEXT_mail   .ReadOnly = true; TEXT_mail.Text = "";
            BTN_attach.Enabled = false; BTN_attach.Show();
            BTN_send  .Enabled = false; BTN_send.Text = "Отправить";
        }

        private void Mail_send()
        {
            TXT_from .ReadOnly = true;
            TXT_to   .ReadOnly = false;
            TXT_topic.ReadOnly = false;
            TEXT_mail.ReadOnly = false;
            BTN_attach.Enabled = true; BTN_attach.Show();
            BTN_send  .Enabled = true; BTN_send.Text = "Отправить";
        }

        private void Mail_receive()
        {
            TXT_from .ReadOnly = true;
            TXT_to   .ReadOnly = true;
            TXT_topic.ReadOnly = true;
            TEXT_mail.ReadOnly = true;
            BTN_attach.Enabled = true; BTN_attach.Hide();
            BTN_send.Enabled   = true; BTN_send.Text = "Ответить";
        }

        private void Refresh_mails() // ! ->
        {

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

            State_no_user();
        }
        private void FORM_Main_FormClosing(object sender, FormClosingEventArgs e) // ! ->
        {
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

        // # MENU profile

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

                    using (var client = new MailKit.Net.Smtp.SmtpClient())
                    {
                        if (login.profile.server == 'G') client.Connect("smtp.gmail.com", 465, true);
                        if (login.profile.server == 'Y') client.Connect("smtp.yandex.ru", 465, true);
                        try
                        {
                            client.Authenticate(login.profile.email, login.profile.password);
                            client.Disconnect(true);
                        }
                        catch (AuthenticationException)
                        {
                            MessageBox.Show("Вход в аккаунт неудался\nПроверьте, пожалуйста, данные для входа");
                            client.Disconnect(true);
                            return;
                        }
                    }

                    State_on_user();

                    MENU_ITEM_profile.Items.Add(login.profile);
                    MENU_ITEM_profile.SelectedItem = login.profile;
                    if (RADIO_mail_all.Checked) Refresh_mails();
                    else RADIO_mail_all.Checked = true;
                }
            }
        }

        private void MENU_ITEM_profile_SelectedIndexChanged(object sender, EventArgs e)
        {
            profile = MENU_ITEM_profile.SelectedItem as Profile;

            State_on_user();
        }

        // # =====

        private void BTN_new_chain_Click(object sender, EventArgs e)
        {
            Mail_send();

            TXT_from .Text = profile.ToString();
            TXT_to   .Text = "";
            TXT_topic.Text = "";
            TEXT_mail.Text = "";
        }

        private void LIST_mails_SelectedIndexChanged(object sender, EventArgs e)
        {
            mail = LIST_mails.SelectedItem as MimeMessage;
        }

        // # CHECKs text format

        private void CHECK_b_CheckedChanged(object sender, EventArgs e)
        {
            FontStyle font = FontStyle.Regular;
            if (TEXT_mail.SelectionFont.Italic)    font = font | FontStyle.Italic;
            if (TEXT_mail.SelectionFont.Underline) font = font | FontStyle.Underline;
            if (CHECK_b.Checked)                   font = font | FontStyle.Bold;
            TEXT_mail.SelectionFont = new Font(TEXT_mail.Font, font);
        }
        private void CHECK_i_CheckedChanged(object sender, EventArgs e)
        {
            FontStyle font = FontStyle.Regular;
            if (TEXT_mail.SelectionFont.Bold)      font = font | FontStyle.Bold;
            if (TEXT_mail.SelectionFont.Underline) font = font | FontStyle.Underline;
            if (CHECK_i.Checked)                   font = font | FontStyle.Italic;
            TEXT_mail.SelectionFont = new Font(TEXT_mail.Font, font);
        }
        private void CHECK_u_CheckedChanged(object sender, EventArgs e)
        {
            FontStyle font = FontStyle.Regular;
            if (TEXT_mail.SelectionFont.Bold)   font = font | FontStyle.Bold;
            if (TEXT_mail.SelectionFont.Italic) font = font | FontStyle.Italic;
            if (CHECK_u.Checked)                font = font | FontStyle.Underline;
            TEXT_mail.SelectionFont = new Font(TEXT_mail.Font, font);
        }

        private void TEXT_mail_SelectionChanged(object sender, EventArgs e)
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
                var message = new MimeMessage();
                message.From.Add(new MailboxAddress(profile.name, profile.email));
                message.To.Add(new MailboxAddress(TXT_to.Text,  TXT_to.Text));
                message.Subject = TXT_topic.Text;

                var builder = new BodyBuilder();
                builder.HtmlBody = MarkupConverter.RtfToHtmlConverter.ConvertRtfToHtml(TEXT_mail.Rtf);
                for (int i = 0; i < LIST_attached.Items.Count; i++) // файлы
                {
                    builder.Attachments.Add((LIST_attached.Items[i] as File_data).full_name);
                }
                message.Body = builder.ToMessageBody();

                // +++ if (TXT_to.ReadOnly) message.InReplyTo = mail.MessageId;

                using (var client = new MailKit.Net.Smtp.SmtpClient())
                {
                    if (profile.server == 'G') client.Connect("smtp.gmail.com", 465, true);
                    if (profile.server == 'Y') client.Connect("smtp.yandex.ru", 465, true);
                    client.Authenticate(profile.email, profile.password);

                    client.Send(message);
                    client.Disconnect(true);
                }

                MessageBox.Show("Сообщение отправлено");

                // +++ Update mailbox and select sent mail
                Mail_receive(); // ! <-
            }
            else // # "Ответить"
            {
                Mail_send();
                if (TXT_to.Text == profile.name || TXT_to.Text == profile.email)
                {
                    TXT_from.Text = profile.email;
                    TXT_to.Text   = TXT_from.Text;
                }
                TXT_to   .ReadOnly = true;
                TXT_topic.ReadOnly = true;
                TEXT_mail.Text = "";
                LIST_attached.Items.Clear();
            }
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

    public class File_data
    {
        public string full_name;
        public string short_name;
        public string extention;

        public File_data(string full_name, string short_name)
        {
            this.full_name  = full_name;
            this.short_name = short_name;
            this.extention  = short_name.Substring(short_name.LastIndexOf('.') + 1);
        }

        public override string ToString()
        {
            return short_name;
        }
    }
}
