using System;
using System.Collections.Generic;

namespace Email_Service
{
    public class Profile
    {
        public string Name     { get; set; }
        public string Email    { get; set; }
        public string Password { get; set; }
        public bool   Remember { get; set; }
        public char   Server   { get; set; }
        public List<Keys_Core> Keys { get; }
        public Tuple<string, string> Sign_keys { get; set; }
        public Dictionary<string, byte[]> Signs { get; }

        public Profile(string name, string email, string password, bool remember, Tuple<string, string> sign_keys,
                       char server = 'N', List<Keys_Core> keys = null, Dictionary<string, byte[]> signs = null)
        {
            Name      = name;
            Email     = email.ToLower();
            Password  = password;
            Remember  = remember;
            Sign_keys = sign_keys;

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
