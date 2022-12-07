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
    public partial class FORM_Login : Form
    {
        public Profile profile;

        public FORM_Login()
        {
            InitializeComponent();
        }

        private void BTN_ok_Click(object sender, EventArgs e)
        {
            // ! profile = new Profile(TXT_name.Text, TXT_email.Text, TXT_password.Text, CHECK_remember.Checked);
            profile = new Profile("", "Rubert.007@yandex.ru", "zijyiyrjorjshwnq", false);
        }
    }

    public class Profile
    {
        public string name;
        public string email;
        public string password;
        public bool   remember;
        public char   server;

        public Profile(string name, string email, string password, bool remember)
        {
            this.name = name;
            this.email = email;
            this.password = password;
            this.remember = remember;
                 if (email.EndsWith("@gmail.com")) this.server = 'G';
            else if (email.Contains("@yandex."))   this.server = 'Y';
            else                                   this.server = 'N';
        }

        override public string ToString()
        {
            return email;
        }
    }
}
