using System;
using System.Windows.Forms;

namespace Email_Service
{
    public partial class FORM_Login : Form
    {
        public Profile profile;

        public FORM_Login() { InitializeComponent(); }

        private void BTN_ok_Click(object sender, EventArgs e)
        {
            profile = new Profile(TXT_name.Text, TXT_email.Text, TXT_password.Text, CHECK_remember.Checked, Crypto_module.Get_new_keys_pair() );
        }
    }
}
