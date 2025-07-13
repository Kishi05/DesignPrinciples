# 🛰️ Observer Design Pattern — Messaging System (C#)

## 📚 Pattern Type
**Behavioral**

## 🧠 Purpose
The **Observer Design Pattern** defines a one-to-many relationship between a **Sender** (subject) and multiple **Receivers** (observers). When the sender broadcasts a message, all subscribed receivers are notified instantly.

---

## 📖 What is the Observer Pattern?

The **Observer Pattern** is a behavioral design pattern that defines a **one-to-many dependency** between objects so that when one object (the **Subject**) changes state, all its dependents (the **Observers**) are automatically notified.

> 🔄 Example: Think of a news app (Sender) notifying all subscribers (Receivers) when a breaking news alert is pushed.

---
## 🏗️ System Architecture

This project demonstrates an event-driven, extensible messaging system built using the **Observer Pattern**, enhanced with a **Facade layer** and **Fluent API**.

### 💡 Key Components

| Component      | Responsibility                                                                 |
|----------------|---------------------------------------------------------------------------------|
| `SenderAbstract` | Abstract base for all message broadcasters                                      |
| `Sender`         | Concrete sender implementation                                                 |
| `ReceiverAbstract` | Defines the update contract for all receivers                                 |
| `Receiver`        | Implements receiver logic and triggers events on message reception             |
| `Message`         | **Facade** to simplify subscriptions and message flow with **method chaining** |

---

## 🚀 Features

- ✅ Event-Driven Receivers via `EventHandler<SenderAbstract>`
- ✅ Fluent API for intuitive method chaining
- ✅ Facade abstraction (`Message`) for clean orchestration
- ✅ Decoupled sender-receiver communication
- ✅ Easily extendable (e.g., logging, filtering, history)

---

## 🔧 How It Works

1. `Sender` (derived from `SenderAbstract`) has a list of `ReceiverAbstract` subscribers.
2. Receivers subscribe via `sender.Subscribe(...)`.
3. The sender sends a message using `sender.Send("message")`, which:
   - Stores the message
   - Triggers `Broadcast()` internally
   - Calls `Update(this)` on all subscribed receivers
4. Each `Receiver` handles the update through the `MessageReceived` event and displays the output.

---
## 🧪 Sample Usage

```csharp
using Observer.Facade;

Message msg = new Message("Sam");

msg.AddReceiver("Jackie")
   .AddReceiver("Leo")
   .Send("Hello, Observers!");
```

## 📤 Output

```
Receiver : Jackie
 ------------  Message  ------------
Sam : Hello, Observers!

Receiver : Leo
 ------------  Message  ------------
Sam : Hello, Observers!

```

---

## 📂 Folder Structure

```
├── From/
│   ├── Sender.cs
│   └── Abstract/
│       └── SenderAbstract.cs
├── Receiver/
│   ├── Receiver.cs
│   └── Abstract/
│       └── ReceiverAbstract.cs
├── Facade/
│   └── Message.cs
└── Program.cs
```

---

## 🧱 Class Diagram (UML)

```
           +------------------+
           | SenderAbstract   |
           +------------------+
           | - Name           |
           | - Message        |
           | - receivers[]    |
           +------------------+
           | +Subscribe()     |
           | +Unsubscribe()   |
           | +Send()          |
           | +BroadCast()     |
           +------------------+
                    ▲
                    |
           +--------+--------+
           |     Sender       |
           +------------------+

           +------------------+
           | ReceiverAbstract |
           +------------------+
           | +Update()        |
           +------------------+
                    ▲
                    |
           +--------+--------+
           |     Receiver     |
           |  +MessageReceived|
           +------------------+

           +------------------+
           |    Message (Facade)
           +------------------+
           | +AddReceiver()   |
           | +RemoveReceiver()|
           | +Send()          |
           +------------------+
```

---

## 👨‍💻 Author

Designed and implemented by **Kishore**  
Senior .NET Full-Stack Developer  
System Design & Clean Architecture Enthusiast  
[GitHub: @Kishi05](https://github.com/Kishi05)