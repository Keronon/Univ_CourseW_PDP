namespace Email_Service
{
    public class File_data
    {
        public string full_name;
        public string short_name;
        public string extention;

        public File_data(string _full_name, string _short_name)
        {
            full_name  = _full_name;
            short_name = _short_name;
            extention  = short_name.Substring(short_name.LastIndexOf('.') + 1);
        }

        public override string ToString()
        {
            return short_name;
        }
    }
}
