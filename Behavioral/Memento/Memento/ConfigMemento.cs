namespace Memento
{
    internal class ConfigMemento
    {
        internal string _connectionString { get; set; }
        internal string _logging { get; set; }
        internal string _APIURL { get; set; }

        public ConfigMemento(string ConnectionString, string Logging, string APIURL)
        {
            _APIURL = APIURL;
            _connectionString = ConnectionString;
            _logging = Logging;
        }

        public override string ToString()
        {
            return $"Connection String : {_connectionString}\nLogging : {_logging}\nAPIURL : {_APIURL}";
        }
    }
}
