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
            profile = new Profile(TXT_name.Text, TXT_email.Text, TXT_password.Text, CHECK_remember.Checked);
        }
    }

    public class Profile
    {
        public string name;
        public string email;
        public string password;
        public bool   remember;
        public char   server;

        public Profile(string _name, string _email, string _password, bool _remember)
        {
            name     = _name;
            email    = _email;
            password = _password;
            remember = _remember;
                 if (email.EndsWith("@gmail.com")) server = 'G';
            else if (email.EndsWith("@yandex.ru")) server = 'Y';
            else                                   server = 'N';
        }

        override public string ToString()
        {
            return email;
        }
    }
}
