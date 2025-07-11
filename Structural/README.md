# 🔔 Notification System using Adapter + Factory + Singleton (C#)

This project demonstrates a **modular, extensible notification system** built using key object-oriented design patterns:

- ✅ **Adapter Pattern** – standardizes third-party services under a unified interface
- ✅ **Factory Pattern** – encapsulates object creation logic for notification services
- ✅ **Singleton Pattern** – ensures only one instance per service for efficiency

---

## 📦 Project Structure

```
Adapter.sln
│
├── Entity/
│ └── User.cs → Represents the notification receiver
│
├── Adapter/
| ├── Interface/
│	└── INotification.cs → Common interface for all channels
│ ├── SMS.cs → Adapter for SMSService
│ ├── Email.cs → Adapter for EmailService
│ └── CloudMessage.cs → Adapter for CloudService
│
├── Factory/
│ └── NotificationServiceFactory.cs → Returns appropriate adapter using enums
│
├── NotificationServices/
│ ├── SMSService.cs → Singleton for sending SMS
│ ├── EmailService.cs → Singleton for sending emails
│ └── CloudService.cs → Singleton for cloud-based messages
│
└── Program.cs → Main execution logic (driven by user preferences)
```


---

## 🧠 Design Pattern Usage

### 🔹 Adapter Pattern
Each notification type (SMS, Email, Cloud) adapts its specific service into the standard `INotification` interface. This allows the main program to use all services interchangeably.

### 🔹 Factory Pattern
The `NotificationServiceFactory` returns the right adapter based on user preference (`NotificationServiceType` enum).

### 🔹 Singleton Pattern
Services (`SMSService`, `EmailService`, `CloudService`) are instantiated only once to save resources and avoid duplicate object creation.

---

## 🧪 How It Works

1. A `User` object is created with `isSMSOpted`, `isEmailOpted`, and `isChatOpted` flags.
2. For each opted-in channel, the `NotificationServiceFactory` selects the appropriate `INotification` adapter.
3. The adapter invokes the respective Singleton service to send the message.

---

## ✅ Sample Output

```
SMS :
To : 9876543210
Message :
Welcome to Adapter Design Pattern

Email :
From: designPatter@dp.com
To : sam@dp.net
Message :
Welcome to Adapter Design Pattern

Cloud :
9876543210 : Welcome to Adapter Design Pattern
```

---

## 👨‍💻 Author

Built by Kishore — showcasing mastery of clean architecture with design patterns.
