using System.Collections.Generic;

namespace Email_Service
{
    public class Mail
    {
        public string UID;
        public string from;
        public string to;
        public string topic;
        public string time;
        public string text_plain;
        public string text_html;
        public List<string> attached;
        public string encrypted;
        public string signed;

        public Mail(string _UID,        string _from,      string       _to,       string _topic,     string _time,
                    string _text_plain, string _text_html, List<string> _attached, string _encrypted, string _signed)
        {
            UID        = _UID;
            from       = _from;
            to         = _to;
            topic      = _topic;
            time       = _time;

            text_plain = _text_plain;
            text_html  = _text_html;
            attached   = _attached;
            encrypted  = _encrypted;
            signed     = _signed;
        }

        public override string ToString()
        {
            return $"{from} > {to} : {topic} [{time}] {{{attached.Count}}}]";
        }
    }
}
