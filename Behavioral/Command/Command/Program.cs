using Command.Command;
using Command.Command.Interface;
using Command.Devices;
using Command.Devices.Interface;
using Command.Invoker;
using Command.Worker;

await BGWorker.BgRunner();

IDevices fan = new Fan();
IDevices ac = new AC();
IDevices light = new Lights();

ICommandLine command1 = new PowerON(fan);
Invoker.AddCommand(command1);

ICommandLine command2 = new SetTimer(fan,20);
Invoker.AddCommand(command2);

ICommandLine command3 = new PowerOFF(fan);
Invoker.AddCommand(command3);

await Task.Delay(1000);

ICommandLine command4 = new PowerON(ac);
Invoker.AddCommand(command4);

await Task.Delay(1000);

ICommandLine command5 = new PowerON(light);
Invoker.AddCommand(command5);

Invoker.Undo();

await Task.Delay(1000);

ICommandLine command6 = new PowerOFF(ac);
Invoker.AddCommand(command6);

await Task.Delay(1000);

Invoker.Redo();

Console.ReadKey();