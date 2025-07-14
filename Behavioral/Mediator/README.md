# 🧠 Mediator Design Pattern — Message Broadcasting System

## 📌 Pattern Category
**Behavioral Design Pattern**

---

## 📖 What is the Mediator Pattern?

The **Mediator Pattern** defines an object that **encapsulates how a set of objects interact**, promoting loose coupling by preventing direct communication between objects and instead forcing them to communicate through a **central mediator**.

### 🔍 Why Use It?
- Reduces complexity when multiple objects communicate.
- Avoids tightly coupled components.
- Improves **maintainability**, **testability**, and **scalability**.

---

## 🎯 Purpose of This Project

This implementation demonstrates the **Mediator Pattern** using a **messaging system**, where:
- A **Sender** broadcasts messages.
- Multiple **Receivers** are subscribed.
- A central **Mediator (Message)** coordinates registration and message flow.

This helps learners understand:
- How objects can interact indirectly via a mediator.
- How to build event-driven communication systems with loose coupling.

---

## 🧱 Key Components

| Class/Component       | Role              | Description                                                                 |
|-----------------------|-------------------|-----------------------------------------------------------------------------|
| `SenderAbstract`      | Abstract Colleague| Defines broadcast, subscribe, and unsubscribe operations.                   |
| `Sender`              | Concrete Colleague| Implements abstract sender, represents a message source.                    |
| `ReceiverAbstract`    | Abstract Colleague| Contract for reacting to incoming messages.                                 |
| `Receiver`            | Concrete Colleague| Subscribes to sender updates, triggers events on update.                    |
| `Message`             | **Mediator**       | Central orchestrator that wires sender and receivers together.             |

---

## ⚙️ Features Demonstrated

- ✅ Register multiple receivers to a sender.
- ✅ Send messages via mediator with optional sender names.
- ✅ Trigger receiver updates using event-based handling.
- ✅ Demonstrate both manual and mediator-managed message flow.

---

## 💡 Real-World Mapping

This pattern is applicable in scenarios like:
- Chat apps or pub-sub systems.
- Form field validation flows.
- Notification/event hubs.
- UI component communication (e.g., dialog triggers).

---

## 🧰 Folder Structure

```
/MediatorPattern/
│
├── From/
│ ├── Sender.cs // Concrete sender
│ └── SenderAbstract.cs // Base sender with broadcast logic
│
├── Reciever/
│ ├── Receiver.cs // Concrete receiver with Update implementation
│ └── ReceiverAbstract.cs // Receiver contract
│
├── Facade/
│ └── Message.cs // Mediator: coordinates sender/receivers
│
├── Program.cs // Client demo: creates sender, receivers, and sends messages
```

---

## 🧪 Sample Output

```
Receiver : Jackie
------------ Message ------------
: Hi From Mark !

Receiver : Antony
------------ Message ------------
System : BroadCast from system..!
```

---

## 👨‍💻 Author

Designed and implemented by **Kishore**  
Senior .NET Full-Stack Developer  
System Design & Clean Architecture Enthusiast  
[GitHub: @Kishi05](https://github.com/Kishi05)