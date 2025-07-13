# 🔌 Async Command Pattern – Smart Home Automation

This project demonstrates a clean, extensible implementation of the **Command Design Pattern** in C# with full **asynchronous command execution**, **undo/redo functionality**, and a simulated **smart home control system**.

---

## 📦 Project Structure

```
/CommandPattern
│
├── Command/
│ ├── PowerON.cs
│ ├── PowerOFF.cs
│ ├── SetTimer.cs
│ └── Interface/ICommandLine.cs
│
├── Devices/
│ ├── Fan.cs
│ ├── AC.cs
│ ├── Lights.cs
│ └── Interface/IDevices.cs
│
├── Invoker/
│ └── Invoker.cs
│
├── Worker/
│ └── BGWorker.cs
│
└── Program.cs (Main Entry Point)
```

---

## 🎯 Pattern Highlights

| Pattern Element | Description |
|------------------|-------------|
| `ICommandLine`   | Command interface with `Execute()` method (async)  
| `PowerON / OFF`, `SetTimer` | Concrete command classes  
| `IDevices`       | Receiver interface for smart appliances  
| `Fan`, `AC`, `Lights` | Receiver implementations  
| `Invoker`        | Manages the command queue, undo/redo stack  
| `BGWorker`       | Background executor running queued commands  

---

## 🚀 Features

✅ Clean separation of concerns  
✅ Fully async task execution  
✅ Queue-based command processor  
✅ Undo and Redo capability using `Stack`  
✅ Scalable for multiple device types  
✅ Easy to extend (composite commands, scheduling, persistence)

---

## 💡 Sample Output

```
Fan - Power ON
Fan - Timer Set to : 13:35:00
Fan - Power OFF
AC - Power ON
AC - Power OFF
Light - Power ON
```

---

## 🔁 Undo/Redo Behavior

- `Invoker.Undo()` → removes last queued command and stores it in a stack  
- `Invoker.Redo()` → re-enqueues the last undone command

```csharp
Invoker.Undo(); // Removes Light PowerON
Invoker.Redo(); // Re-adds Light PowerON
```

---

## 🧱 UML Class Diagram
# 📌 Overview:
This diagram shows the relationship between:
- Command Interface & Implementations
- Device Interface & Implementations
- Invoker (Command Queue)
- Background Worker

```
+----------------------+
|   <<interface>>      |
|   ICommandLine       |
|----------------------|
| + Execute(): Task    |
+----------------------+
        ▲
        |
+---------------+     +---------------+     +----------------+
|  PowerON      |     |  PowerOFF     |     |  SetTimer      |
+---------------+     +---------------+     +----------------+
| - device       |     | - device      |     | - device       |
|                |     |               |     | - minutes      |
| + Execute()    |     | + Execute()   |     | + Execute()    |
+---------------+     +---------------+     +----------------+

                 Uses
                   |
+-----------------------------+
| <<interface>>               |
| IDevices                    |
|-----------------------------|
| + TurnON(): Task            |
| + TurnOFF(): Task           |
| + SetTimer(minutes): Task   |
+-----------------------------+
        ▲           ▲           ▲
        |           |           |
    +-------+   +--------+   +--------+
    |  Fan  |   |   AC   |   | Lights |
    +-------+   +--------+   +--------+

+-----------------------------+
|        Invoker              |
+-----------------------------+
| - cmdQueue: Queue<ICommandLine>  |
| - undoCmd: Stack<ICommandLine>   |
|-----------------------------|
| + AddCommand()              |
| + Undo()                    |
| + Redo()                    |
| + GetList()                 |
+-----------------------------+

+-----------------------------+
|        BGWorker             |
+-----------------------------+
| + BgRunner(): Task          |
| (Continuously dequeues and |
|  executes from cmdQueue)   |
+-----------------------------+
```
---

## 🔁 UML Sequence Diagram
# 📌 Use Case: Turning On Devices & Undoing a Command

```
User
 |
 | AddCommand(PowerON_Fan)
 |--------------------------------------> Invoker
 |                                       |
 | AddCommand(SetTimer_Fan)
 |--------------------------------------> Invoker
 |                                       |
 | AddCommand(PowerOFF_Fan)
 |--------------------------------------> Invoker
 |                                       |
 | AddCommand(PowerON_Lights)
 |--------------------------------------> Invoker
 |
 | Undo() 
 |--------------------------------------> Invoker
 |                                       |
 |                                       | Pushes last command to undo stack
 |
 | Redo()
 |--------------------------------------> Invoker
 |                                       | Pops from undo stack
 |                                       | Enqueues back to cmdQueue
 |
 | Execution triggered
 |--------------------------------------> BGWorker
 |                                       |
 |      Dequeues cmd -> Execute() ------> ICommandLine (PowerON)
 |      Dequeues cmd -> Execute() ------> ICommandLine (SetTimer)
 |      ...
```

---

## 🧠 Future Enhancements
- Add UnExecute() method to fully reverse a command
- Implement CompositeCommand to batch device instructions
- Persist executed commands to database or file
- Add retry/error-handling policies for devices
- Simulate real-time sensors and triggers

---

## 📚 Learning Objectives
- Understand the Command Design Pattern
- Implement async-safe patterns in C#
- Design undo/redo stacks in queue-based systems
- Apply SOLID principles and clean architecture