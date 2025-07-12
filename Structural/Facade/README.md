# 🏛️ Facade Pattern – Notification Service (C# Implementation)

This project demonstrates the **Facade Design Pattern** in C# by creating a simplified and unified interface (`NotificationServiceFacade`) to interact with multiple underlying notification subsystems (SMS, Email, and Cloud).

---

## 📌 What is the Facade Pattern?

> The **Facade Pattern** provides a unified interface to a set of interfaces in a subsystem. It defines a higher-level interface that makes the subsystem easier to use.

In other words, the client doesn’t need to know the complex internal structure — the **Facade handles that orchestration**.

---

## 🧠 Problem Statement

In a real-world enterprise application, you may have:
- Multiple messaging platforms (SMS, Email, Cloud/Chat)
- Legacy or third-party libraries with different interfaces
- Conditional execution depending on user preferences

Managing all these can lead to:
- Tight coupling between components
- Code duplication across services
- Difficult onboarding and maintainability

---

## ✅ Solution using Facade

We build:
- A **common interface (`INotification`)** to unify the APIs
- A set of **adapters (Email, SMS, Cloud)** that implement this interface
- A **Factory** to provide correct service instance
- A **static Facade class** that accepts a `User` and handles service routing based on preferences

---

## 🗂️ Project Structure

```bash
Facade/
│
├── Adapter/
│   ├── Interface/
│   │   └── INotification.cs         # Common notification interface
│   │
│   ├── Email.cs                     # Adapter for EmailService
│   ├── SMS.cs                       # Adapter for SMSService
│   └── CloudMessage.cs             # Adapter for CloudService
│
├── Entity/
│   └── User.cs                      # User model with notification preferences
│
├── Facade/
│   └── NotificationServiceFacade.cs # High-level simplified interface
│
├── Factory/
│   ├── NotificationServiceFactory.cs
│   └── NotificationServiceType.cs
│
├── NotificationServices/            # Simulated third-party notification services
│   ├── EmailService.cs
│   ├── SMSService.cs
│   └── CloudService.cs
│
└── Program.cs                        # Entry point of the application

```

---

```
Program.cs
    |
    V
NotificationServiceFacade.SendNotification(user)
    |
    +--> if SMS opted:    SMSAdapter.SendMessage()
    +--> if Email opted:  EmailAdapter.SendMessage()
    +--> if Chat opted:   CloudAdapter.SendMessage()
```

---

## 🔧 Key Design Patterns Used


| Pattern   | Role                                                               |
| --------- | ------------------------------------------------------------------ |
| Facade    | Hides the complexity of notification subsystems                    |
| Adapter   | Wraps 3rd-party or legacy services to fit into `INotification`     |
| Singleton | Ensures a single instance per service (for lightweight simulation) |
| Factory   | Returns the correct notification adapter at runtime                |

---

## 🧼 Why Static Facade?

> The NotificationServiceFacade is marked static to:
- Emphasize that it's stateless
- Simplify usage during demonstration
- Avoid object lifecycle management for such a lightweight task

---

## 👨‍💻 Author

Designed and implemented by **Kishore**  
Senior .NET Full-Stack Developer  
System Design & Clean Architecture Enthusiast  
[GitHub: @Kishi05](https://github.com/Kishi05)