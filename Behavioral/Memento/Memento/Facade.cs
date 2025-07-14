namespace Memento
{
    internal class Facade
    {
        private Config _config;

        public Config Config
        {
            get { return _config; }
        }

        public Facade(Config Config)
        {
            _config = Config;
        }

        public void Edit()
        {
            _config.BackUP();
        }

        public void RestoreVersion(int version)
        {
            _config.Restore(version);
        }

        public void Cancel()
        {
            _config.Restore();
        }

        public void GetCurrentState()
        {
            Console.WriteLine(_config.CurrentState()+"\n");
        }

        public void ViewVersions()
        {
            var versions = _config.GetVersions();

            if(versions is null)
            {
                Console.WriteLine("No Versions Exist !");
            }
            else
            {
                Console.WriteLine("--------------------------------------------------------\n");

                Console.WriteLine("                           Versions                       ");

                Console.WriteLine($"Found : {versions.Count} version(s)\n");

                foreach (KeyValuePair<int, ConfigMemento> verson in versions)
                {
                    Console.WriteLine("Version : " + verson.Key);
                    Console.WriteLine(verson.Value.ToString());
                    Console.WriteLine();
                }

                Console.WriteLine("--------------------------------------------------------");
            }
        }

    }
}
