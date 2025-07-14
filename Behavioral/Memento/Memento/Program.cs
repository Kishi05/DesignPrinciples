using Memento;

Config config = new Config()
{
    ConnectionString="Connection String Value",
    Logging = "Warning",
    APIURL = "http://api.dp.com/"
};

Facade facade = new Facade(config);
Console.WriteLine("New Object : ");
facade.GetCurrentState();


facade.Edit(); // Captures Above State into memento
facade.Config.Logging = "Debug";
facade.Config.APIURL = "https://newapi.dp.com";
Console.WriteLine("After Update 1 :\n");
facade.GetCurrentState();


facade.ViewVersions();


facade.Cancel();
Console.WriteLine("After Undo :\n");
facade.GetCurrentState();

facade.Edit(); // Captures Above State into memento
facade.Config.Logging = "Verbose";
facade.Config.APIURL = "https://newapi.dp.com";
Console.WriteLine("After Update 1 :\n");
facade.GetCurrentState();


facade.Edit(); // Captures Above State into memento
facade.Config.Logging = "Error";
facade.Config.APIURL = "https://coreapi.dp.com";
Console.WriteLine("After Update 2 :\n");
facade.GetCurrentState();


facade.Edit(); // Captures Above State into memento
facade.Config.Logging = "Information";
facade.Config.APIURL = "https://localapi.dp.com";
Console.WriteLine("After Update 3 :\n");
facade.GetCurrentState();

facade.ViewVersions();

facade.RestoreVersion(6);
facade.GetCurrentState();