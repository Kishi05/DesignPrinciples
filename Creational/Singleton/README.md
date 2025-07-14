# 📄 Singleton Design Pattern – LogConsole

## 📌 Pattern Type
**Creational Design Pattern**

---

## 🧠 What is the Singleton Pattern?

The **Singleton Pattern** ensures a class has **only one instance** and provides a **global point of access** to it.

This is useful when exactly **one object** is needed to coordinate actions across the system (e.g., logging, config, etc.).

---

## ✅ Purpose of This Example

This project implements a thread-safe Singleton logger `LogConsole` that:
- Prevents multiple instances from being created
- Provides both **instance-based** and **static method** access
- Demonstrates logging at different levels (`Debug`, `Info`, `Warning`, `Error`)

---

## 🧱 Key Components

| Component     | Description                                                                 |
|---------------|-----------------------------------------------------------------------------|
| `LogConsole`  | Singleton class. Holds private constructor and static logging methods       |
| `Instance`    | Thread-safe global access to the only instance of `LogConsole`             |
| `Debug`, `Info`, etc. | Static methods that internally use the singleton instance            |

---

## 📁 Folder Structure

```
Singleton/
│
├── Program.cs                  --> Entry point for testing
└── LogConsole.cs               --> Singleton logger implementation
```

---

## 🧱 Class Diagram (UML)

```
+-----------------------------+
| LogConsole				  | <<Singleton>>
+-----------------------------+
| - _instance : LogConsole    |
| - _instanceLock : object    |
+-----------------------------+
| + Instance : LogConsole     |
| + Debug(msg) : void         |
| + Info(msg) : void          |
| + Warning(msg) : void       |
| + Error(msg) : void         |
| - LogDebug(msg) : void      |
| - LogInfo(msg) : void       |
| - LogWarning(msg) : void    |
| - LogError(msg) : void      |
+-----------------------------+
```

---

## 🔁 Why Both Static & Instance?
You can use LogConsole.Instance.LogInfo(...) when you want to control instance-based extensions like logging levels, targets, etc.
You can use static facade methods (LogConsole.Info(...)) for ease and API clarity.

---

## 🧪 Example Usage

```csharp
using Singleton;

LogConsole.Debug("Debug message");
LogConsole.Info("Info message");
LogConsole.Warning("Warning message");
LogConsole.Error("Error message");
```

---

## 👨‍💻 Author

Designed and implemented by **Kishore**  
Senior .NET Full-Stack Developer  
System Design & Clean Architecture Enthusiast  
[GitHub: @Kishi05](https://github.com/Kishi05)
