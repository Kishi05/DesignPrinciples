namespace Memento
{
    internal class Config
    {
        Dictionary<int,ConfigMemento> memento = new Dictionary<int, ConfigMemento>();
        public string ConnectionString { get; set; }
        public string Logging {  get; set; }
        public string APIURL { get; set; }

        public void Restore(int? version = null)
        {
            ConfigMemento? _backup = null;
            if (version == null)
            {
                _backup = memento.OrderByDescending(x => x.Key).FirstOrDefault().Value;
            }
            else
            {
                _backup = memento.FirstOrDefault(x => x.Key == version).Value;
                if (_backup == null)
                {
                    Console.WriteLine("\nInvalid Version Number - Restore Failed");
                    Console.WriteLine("No changes made to current state !\n");
                }
            }

            if (_backup == null) return;

            ConfigMemento restoreConfig = _backup;
            ConnectionString = restoreConfig._connectionString;
            Logging = restoreConfig._logging;
            APIURL = restoreConfig._APIURL;
        }

        public void BackUP()
        {
            memento.Add((memento.Count + 1), new ConfigMemento(ConnectionString, Logging, APIURL));
        }

        public string CurrentState()
        {
            return $"Connection String : {ConnectionString}\nLogging : {Logging}\nAPIURL : {APIURL}";
        }

        public Dictionary<int, ConfigMemento> GetVersions()
        {
            return memento;
        }

    }
}
