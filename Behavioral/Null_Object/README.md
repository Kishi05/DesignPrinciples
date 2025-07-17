# Null Object Design Pattern – C# Implementation

The **Null Object Pattern** is a behavioral design pattern that provides a default object to replace `null`. Instead of checking for `null` values, we use an object that implements the required interface but with **no-op behavior**.

---

## 🧠 Purpose

To avoid `null` checks and ensure smooth code execution by providing a "do-nothing" implementation of an interface.

---

## 📦 Components

- `ILogger`: Interface
- `ConsoleLogger`, `FileLogger`: Concrete Loggers
- `NullLogger`: Implements ILogger but does nothing
- `UserService`: Depends on ILogger to log activity

---

## 🧬 UML Class Diagram

```mermaid
classDiagram
    ILogger <|.. ConsoleLogger
    ILogger <|.. FileLogger
    ILogger <|.. NullLogger
    UserService --> ILogger

    class ILogger {
        +void Log(string)
    }

    class ConsoleLogger {
        +void Log(string)
    }

    class FileLogger {
        +void Log(string)
    }

    class NullLogger {
        +void Log(string)
    }

    class UserService {
        -ILogger _logger
        +RegisterUser(string)
    }
```

---

## 🔁 Sequence Diagram

```mermaid
sequenceDiagram
    participant Main
    participant Logger as ILogger
    participant Service as UserService

    Main->>Logger: new NullLogger()
    Main->>Service: new UserService(logger)
    Main->>Service: RegisterUser("Sam")
    Service->>Logger: Log("User 'Sam' registered.")
    Logger-->>Service: (Does nothing if NullLogger)

```

---

## 🚀 Sample Usage

```
using NullObject.Interface;
using NullObject.Logger;
using NullObject.Service;

ILogger logger = new NullLogger(); // or new ConsoleLogger(), FileLogger()
UserService service = new(logger);
service.RegisterUser("Sam");
```

---

## Output (With ConsoleLogger)

```csharp
[Console] User 'Sam' registered.
```

## ✅ Output (With NullLogger)

```pgsql
(nothing is logged, no error thrown)
```

---

## 🧠 Benefits

- Avoids null checks
- Implements Open/Closed Principle
- Clean and readable code
- Easily testable and swappable logger behavior

---

## 👨‍💻 Developer

Designed and implemented by **Kishore**  
Senior .NET Full-Stack Developer  
System Design & Clean Architecture Enthusiast  
[GitHub: @Kishi05](https://github.com/Kishi05)