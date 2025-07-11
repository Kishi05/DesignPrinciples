# 💡 Bridge Pattern – User Notification System

This project demonstrates the **Bridge Design Pattern**, combined with **Factory**, **Adapter**, and **Singleton** principles.  
It delivers user‑facing onboarding messages through various channels (Email, SMS, Cloud) while providing a **fallback mechanism** for resilience.

---

## 📦 Project Structure

```
BridgePattern/
├── Adapter/
│   ├── Email.cs
│   ├── SMS.cs
│   ├── CloudMessage.cs
│   └── Interface/
│       └── INotification.cs
├── Bridge/
│   └── UserNotificationBridge.cs
├── Entity/
│   └── User.cs
├── Events/
│   ├── WelcomeMessage.cs
│   ├── Credentials.cs
│   └── Benefits.cs
├── Factory/
│   ├── NotificationServiceFactory.cs
│   └── NotificationServiceType.cs
├── NotificationServices/
│   ├── EmailService.cs
│   ├── SMSService.cs
│   └── CloudService.cs
├── NotificationFailureException.cs
└── Program.cs

```

---

## 🧠 Design Patterns Used

| Pattern      | Purpose |
|--------------|---------|
| **Bridge**   | Decouples *what* is sent (`WelcomeMessage`, `Credentials`, `Benefits`) from *how* it’s delivered (Email, SMS, Cloud). |
| **Adapter**  | Wraps third‑party or legacy services so they conform to the `INotification` interface. |
| **Factory**  | Supplies the correct adapter (`Email`, `SMS`, `CloudMessage`) at runtime. |
| **Singleton**| Ensures only one instance of each concrete service class exists. |
| **Custom Exception** | `NotificationFailureException` triggers graceful fallback if a channel fails. |

---

## ✅ Functional Workflow

1. A `User` object stores channel preferences (`isEmailOpted`, `isChatOpted`, etc.).
2. `UserNotificationBridge.isNewJoiner()` orchestrates message flow:
   - Attempts Email first (if opted in).
   - On `NotificationFailureException`, falls back to the Cloud channel.
3. `MessagingService()` sends three event‑specific messages:
   - **WelcomeMessage** – greeting
   - **Credentials** – login details
   - **Benefits** – HR benefits

---

## 🧪 Quick Example

```csharp
var user = new User
{
    Id            = Guid.NewGuid(),
    Name          = "Sam",
    Email         = "sam@dp.net",
    PhoneNumber   = "9876543210",
    isEmailOpted  = true,
    isChatOpted   = true
};

var bridge = new UserNotificationBridge();
bridge.isNewJoiner(user);
```

Console output (if Email succeeds):

```
Email :
From: designPatter@dp.com
To  : sam@dp.net
Message :
    Welcome to our Team !!

Email :
From: designPatter@dp.com
To  : sam@dp.net
Message :
    Please find attached your UserName and OTP.

Email :
From: designPatter@dp.com
To  : sam@dp.net
Message :
    Health Benefits are ready to avail..!
```

If Email fails, you’ll see:

```
[Fallback Triggered] Email failed: <details>. Switching to Cloud.
Cloud :
9876543210 : Welcome to our Team !!
...
```

---

## 🔥 Key Features

- Open/Closed compliant: add new channels or message types without altering existing code.
- Single‑responsibility classes (WelcomeMessage, Credentials, Benefits).
- Thread‑safe singletons for service reuse.
- Simple console logging for fallback visibility (plug into ILogger / Serilog easily).
- Ready for dependency‑injection adoption.

---

## 👨‍💻 Author

Designed and implemented by **Kishore**  
Senior .NET Full-Stack Developer  
System Design & Clean Architecture Enthusiast  
[GitHub: @Kishi05](https://github.com/Kishi05)