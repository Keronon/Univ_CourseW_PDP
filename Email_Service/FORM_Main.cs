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



        #endregion VARIABLES

        // ! ===== ===== ===== ===== =====

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

            TXT_from    .ReadOnly = true; TXT_from .Text = "";
            TXT_to      .ReadOnly = true; TXT_to   .Text = "";
            TXT_topic   .ReadOnly = true; TXT_topic.Text = "";
            TEXT_mail   .ReadOnly = true; TEXT_mail.Text = "";
            BTN_append.Enabled = false; BTN_append.Show();
            BTN_send  .Enabled = false; BTN_send.Text = "Отправить";
        }

        private void Mail_send()
        {
            TXT_from .ReadOnly = true;
            TXT_to   .ReadOnly = false;
            TXT_topic.ReadOnly = false;
            TEXT_mail.ReadOnly = false;
            BTN_append.Enabled = true; BTN_append.Show();
            BTN_send  .Enabled = true; BTN_send.Text = "Отправить";
        }

        private void Mail_receive()
        {
            TXT_from .ReadOnly = true;
            TXT_to   .ReadOnly = true;
            TXT_topic.ReadOnly = true;
            TEXT_mail.ReadOnly = true;
            BTN_append.Enabled = true; BTN_append.Hide();
            BTN_send.Enabled   = true; BTN_send.Text = "Ответить";
        }

        private void Refresh_mails() // ! ->
        {

        }

        #endregion FUNCTIONS

        // ! ===== ===== ===== ===== =====

        #region FORM

        public FORM_Main()
        {
            InitializeComponent();

            State_no_user();
        }

        private void PIC_avatar_MouseEnter(object sender, EventArgs e)
        {
            PIC_avatar.BackColor = Color.Khaki;
        }
        private void PIC_avatar_MouseLeave(object sender, EventArgs e)
        {
            PIC_avatar.BackColor = Color.LightCyan;
        }

        // !! MENU profile

        private void MENU_ITEM_add_Click(object sender, EventArgs e)
        {
            using (FORM_Login login = new FORM_Login())
            {
                if (login.ShowDialog() == DialogResult.OK)
                {
                    State_on_user();

                    MENU_ITEM_profile.Items.Add(login.profile);
                    MENU_ITEM_profile.SelectedItem = login.profile;
                    if (RADIO_mail_all.Checked) Refresh_mails();
                    else RADIO_mail_all.Checked = true;
                }
            }
        }

        // !! =====

        private void BTN_new_chain_Click(object sender, EventArgs e)
        {
            Mail_send();

            TXT_from .Text = MENU_ITEM_profile.SelectedItem.ToString();
            TXT_to   .Text = "";
            TXT_topic.Text = "";
            TEXT_mail.Text = "";
        }

        #endregion FORM

        private void BTN_send_Click(object sender, EventArgs e)
        {
            if (BTN_send.Text == "Отправить")
            {

            }
            else // "Ответить"
            {
                Mail_send();
                TXT_to   .ReadOnly = true;
                TXT_topic.ReadOnly = true;
                TEXT_mail.Text = "";
            }
        }
    }
}
