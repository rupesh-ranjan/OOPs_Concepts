namespace OOPs_Concepts
{
    public class HttpCookie
    {
        private readonly Dictionary<string, string> _cookies;
        public DateTime Expiry { get; set; }
        public HttpCookie()
        {
            _cookies = new Dictionary<string, string>();
        }

        public string this[string name]
        {
            get 
            {
                return _cookies[name];
            }
            set 
            {
                _cookies[name] = value;
            }
        }
    }
    
}