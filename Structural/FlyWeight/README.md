# 🧠 Flyweight Pattern - Shipping Route Optimization

This project demonstrates the **Flyweight Design Pattern** in C# using a domain-centric model around **Employees**, **Countries**, **Ships**, and **Ship Routes**.

Flyweight is used here to **minimize memory usage** by **sharing immutable objects (Country)** across multiple entities.

---

## 🧩 Pattern Overview

### What is Flyweight?

> Flyweight is a structural design pattern focused on minimizing memory use by sharing data among many objects. This is done when the instances have common internal (intrinsic) state that can be reused.

In this case:
- Each `Employee` refers to a shared instance of `Country`.
- Each `ShipRoute` refers to shared `Country`, `Employee`, and `Ship` objects.

---

## 🧱 Components

| Component        | Description                                                                 |
|------------------|-----------------------------------------------------------------------------|
| `Country`        | Flyweight object — reused across employees and routes.                     |
| `Employee`       | Entity with a reference to a flyweight `Country` instance.                 |
| `Ship`           | Represents transport vessels.                                               |
| `ShipRoute`      | Connects an `Employee`, a `Ship`, and From/To `Country` objects.            |
| `LoadData`       | Lazy-loads and caches reusable country, employee, and ship data.            |

---

## 🗂️ Folder Structure

```
FlyWeight/
├── Entities/
│ ├── Country.cs
│ ├── Employee.cs
│ ├── Ship.cs
│ └── ShipRoute.cs
├── LoadData.cs
└── Program.cs
```

---

## 🚀 Execution Flow

1. `Program.cs` creates an instance of `LoadData`.
2. Lazy properties initialize and cache:
   - Shared `Country` list (used as Flyweights).
   - `Employee`, `Ship`, and `ShipRoute` instances.
3. Data is rendered in a structured report format, showing shared reference reuse.
4. Includes a delay between outputs to visualize flow and behavior.

---

## 🔁 Sample Output Snippet

```
Total Routes Loaded: 5

/* --------------------------- Report --------------------------- */
Employee Details => ID : 8f... , Name : Alice
Ship Details => ID : a1... , Name : SS Enterprise, YearOfMake : 01-01-2015
Ship Route => From : India TO : Japan
```


---

## ✅ Flyweight Insights

- **Memory Efficiency**: Countries are created once and shared — ideal for large-scale object graphs.
- **Thread-Safe Lazy Loading**: Only loads on first access.
- **Encapsulation**: `LoadData` encapsulates instantiation and protects against duplicate references.

---

## 🧠 Key Learnings

- **Avoid Deep Cloning** of shared objects unless state mutation is intended.
- `GetXByName()` methods help centralize lookups and maintain integrity.
- Using `IReadOnlyList<T>` reinforces immutability and proper flyweight behavior.

---

## 👨‍💻 Author

Designed and implemented by **Kishore**  
Senior .NET Full-Stack Developer  
System Design & Clean Architecture Enthusiast  
[GitHub: @Kishi05](https://github.com/Kishi05)