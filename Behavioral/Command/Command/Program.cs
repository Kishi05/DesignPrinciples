using Command.Devices;
using Command.Devices.Interface;
using Command.Invoker;
using Command.Worker;

BGWorker.BgRunner();

ISHACommand fanCMD = new Fan();
fanCMD.TurnON();
Invoker.AddCommand(fanCMD);

ISHACommand fanCMD1 = new Fan();
fanCMD1.TurnOFF();
Invoker.AddCommand(fanCMD1);

ISHACommand fanCMD2 = new Fan();
fanCMD2.SetTimer(10);
Invoker.AddCommand(fanCMD2);

Invoker.Undo();

Invoker.Redo();

Task.Delay(1000).Wait();

AC ac1 = new AC();
ac1.TurnON();
Invoker.AddCommand(ac1);

Task.Delay(1000).Wait();

Lights lights = new Lights();
lights.TurnON();
Invoker.AddCommand(lights);

Task.Delay(1000).Wait();

AC ac2 = new AC();
ac2.TurnOFF();
Invoker.AddCommand(ac2);

Console.ReadKey();