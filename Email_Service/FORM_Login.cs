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
        public User profile;

        public FORM_Login()
        {
            InitializeComponent();

            // +++ !!!

            profile.email    = "KerononS.learn@gmail.com"; // ! Rubert.007@yandex.ru
            profile.password = "IdzanagiBurden0w0";        // ! 2jj1fh7tvr2H

            // +++ !!!
        }
    }

    public struct User
    {
        public string email;
        public string password;
        public bool   remember;

        override public string ToString()
        {
            return email;
        }
    }
}
