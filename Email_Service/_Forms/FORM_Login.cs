using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Security.Cryptography;

namespace Email_Service
{
    public partial class FORM_Login : Form
    {
        public Profile profile;

        public FORM_Login() { InitializeComponent(); }

        private void BTN_ok_Click(object sender, EventArgs e)
        {
            RSACryptoServiceProvider RSA = new RSACryptoServiceProvider();
            profile = new Profile(TXT_name.Text, TXT_email.Text, TXT_password.Text, CHECK_remember.Checked, RSA.ToXmlString(true));
        }
    }

    public class Profile
    {
        public string Name     { get; set; }
        public string Email    { get; set; }
        public string Password { get; set; }
        public bool   Remember { get; set; }
        public char   Server   { get; set; }
        public List<Keys_Core> Keys { get; }
        public string Sign_key { get; set; }
        public Dictionary<string, byte[]> Signs { get; }

        public Profile(string name, string email, string password, bool remember, string sign_key,
                       char server = 'N', List<Keys_Core> keys = null, Dictionary<string, byte[]> signs = null)
        {
            Name     = name;
            Email    = email.ToLower();
            Password = password;
            Remember = remember;
            Sign_key = sign_key;

            if (server == 'N')
                     if (email.EndsWith("@gmail.com")) Server = 'G';
                else if (email.EndsWith("@yandex.ru")) Server = 'Y';
                else                                   Server = 'N';
            else Server = server;

            if (keys  == null) Keys  = new List<Keys_Core>();
            else Keys = keys;
            if (signs == null) Signs = new Dictionary<string, byte[]>();
            else Signs = signs;
        }

        override public string ToString()
        {
            return Email;
        }
    }
}
