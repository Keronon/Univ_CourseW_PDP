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
        public string Name     { get; set; }
        public string Email    { get; set; }
        public string Password { get; set; }
        public bool   Remember { get; set; }
        public char   Server   { get; set; }

        public Profile(string Name, string Email, string Password, bool Remember, char Server = 'N')
        {
            this.Name     = Name;
            this.Email    = Email;
            this.Password = Password;
            this.Remember = Remember;
            if (Server == 'N')
                     if (Email.EndsWith("@gmail.com")) this.Server = 'G';
                else if (Email.EndsWith("@yandex.ru")) this.Server = 'Y';
                else                                   this.Server = 'N';
            else this.Server = Server;
        }

        override public string ToString()
        {
            return Email;
        }
    }
}
