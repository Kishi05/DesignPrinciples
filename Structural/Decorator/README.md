# 🎯 Decorator Pattern – Real-World System Implementation

This project demonstrates a multi-pattern orchestration system built around the **Decorator Pattern**, extended with **Adapter**, **Builder**, **Bridge**, and **Factory** design patterns.

---
```
                    +------------------------+
                    |     INotification      |<<interface>>
                    +------------------------+
                    | + SendMessage()        |
                    +------------------------+
                             ▲
                             |
   +-------------------------+---------------------------+
   |                         |                           |
+----------+       +----------------+         +-----------------+
|   Email  |       |      SMS       |         |  CloudMessage   |
+----------+       +----------------+         +-----------------+
| +SendMessage()   | +SendMessage() |         | +SendMessage()  |
| Singleton        | Singleton      |         | Singleton       |
+----------+       +----------------+         +-----------------+

                             ▲
                             |
                   +------------------------+
                   | NotificationDecorator  |<<abstract>>
                   +------------------------+
                   | -INotification _notif  |
                   | +SendMessage()         |
                   +------------------------+
                             ▲
             +---------------+---------------+
             |                               |
+----------------------------+   +-----------------------------+
| LogNotificationDecorator   |   | RetryNotificationDecorator  |
+----------------------------+   +-----------------------------+
| +SendMessage()             |   | +SendMessage(retry logic)   |
+----------------------------+   +-----------------------------+

                             ▲
                             |
                 +------------------------------+
                 |  DecoratorPipelineBuilder     |
                 +------------------------------+
                 | +WithLogging()               |
                 | +WithRetry()                 |
                 | +Build()                     |
                 +------------------------------+

Bridge Layer:
+--------------------------+
|  UserNotificationBridge  |
+--------------------------+
| - isNewJoiner()          |
| - MessagingService()     |
+--------------------------+
        |
        +--------------------------------------------------------------+
        |                         |                       |            |
+----------------+     +----------------+      +----------------+     ...
| WelcomeMessage |     |  Credentials   |      |    Benefits    |
+----------------+     +----------------+      +----------------+
| Uses Pipeline   |     | Uses Logging   |      | No Decorators  |
+----------------+     +----------------+      +----------------+

Factory:
+------------------------------+
| NotificationServiceFactory   |
+------------------------------+
| + GetServe(serviceType)      |
+------------------------------+
```

---

## 🏗️ Project Structure

```
Decorator/
├── Adapter/
│   ├── Interface/            # INotification interface
│   ├── Decorator/            # Concrete decorators (Log, Retry)
│   └──                       # Adapter classes (Email, SMS, Cloud)
├── Builder/                  # Fluent pipeline builder for decorators
├── Bridge/                   # Orchestrates fallback + sequencing
├── Entity/                   # User domain model
├── Events/                   # Notification use cases (Welcome, Credentials, Benefits)
├── Factory/                  # Singleton service factory
├── NotificationServices/     # Third-party/legacy services (EmailService, SMSService, CloudService)
├── NotificationFailureException.cs
└── Program.cs                # Entry point
```

---

## 🔧 Patterns Used

| Pattern | Role |
|--------|------|
| **Decorator** | Add logging and retry logic without altering core notification logic |
| **Adapter** | Unifies Email, SMS, Cloud APIs under `INotification` |
| **Builder** | Enables fluent chaining of decorators |
| **Bridge** | Separates joiner logic from notification service logic |
| **Factory** | Returns the correct adapter instance |

---

## 💡 Decorator Pipeline Example

```csharp
INotification notification = new DecoratorPipelineBuilder(NotificationServiceType.Email)
                                .WithLogging()
                                .WithRetry(3)
                                .Build();
```

---

## 📦 Use Cases

- `WelcomeMessage`: Logging + Retry
- `Credentials`: Logging
- `Benefits`: Raw notification

```csharp
WelcomeMessage message = new WelcomeMessage(NotificationServiceType.Email);
message.SendMessage(user, "Welcome to our team!");
```

---

## 🔄 Fallback Logic (Bridge Pattern)

```csharp
try {
    // Email notification
} catch (NotificationFailureException) {
    // Fallback to Cloud
}
```

---

## 🧪 Test Scenario

```csharp
User user = new User {
    Name = "Sam",
    Email = "sam@dp.net",
    PhoneNumber = "9876543210",
    isEmailOpted = true,
    isChatOpted = true,
};

UserNotificationBridge bridge = new UserNotificationBridge();
bridge.isNewJoiner(user);
```

---

## 📊 Future Enhancements

- Add `ILogger` abstraction
- Support `WithFallback()` as decorator
- Load decorator pipeline via JSON config
- Add `CircuitBreakerDecorator`
- Unit test decorators individually

---

## 🧠 Summary

This solution exemplifies how the Decorator Pattern can be strategically scaled in an enterprise-grade architecture by seamlessly integrating it with complementary design patterns such as Adapter, Builder, Bridge, and Factory. The result is a flexible, extensible, and maintainable system that adheres to clean code principles and promotes separation of concerns—ideal for real-world, production-level applications. It allows:

- Flexible extension of notification behavior
- Loose coupling of business logic
- Configurable pipelines
- Testable and maintainable code

---

## ✅ Status: Production-ready educational template

Can be used as:
- A teaching template for teams
- An interview-ready portfolio project
- A boilerplate for microservice-style notification modules

---

## 👨‍💻 Author

Designed and implemented by **Kishore**  
Senior .NET Full-Stack Developer  
System Design & Clean Architecture Enthusiast  
[GitHub: @Kishi05](https://github.com/Kishi05)