# Strategy Design Pattern (C#)

## 💡 What is Strategy Pattern?

The Strategy Pattern allows you to define a family of algorithms, encapsulate each one, and make them interchangeable. It enables the algorithm to vary independently from clients that use it.

---

## 🧱 Components in This Example

| Component         | Role                        |
|------------------|-----------------------------|
| `IDiscount`       | Strategy Interface           |
| `NoDiscount`      | Concrete Strategy (0%)       |
| `NormalDiscount`  | Concrete Strategy (5%)       |
| `StudentDiscount` | Concrete Strategy (10%)      |
| `DiscountContext` | Context to resolve & apply   |
| `DiscountType`    | Enum for strategy selection  |

---

## ✅ Key Takeaways

- Open/Closed Principle: Add new strategies without changing existing code.
- Behavior encapsulated in separate classes.
- Promotes code flexibility and testability.

---

## 📊 UML Diagram

```mermaid
classDiagram
    IDiscount <|.. NoDiscount
    IDiscount <|.. NormalDiscount
    IDiscount <|.. StudentDiscount
    DiscountContext --> IDiscount
    DiscountContext --> DiscountType

    class IDiscount {
        +double ApplyDiscount(double amount)
    }

    class NoDiscount
    class NormalDiscount
    class StudentDiscount

    class DiscountContext {
        +ResolveDiscountStrategy(type)
        +ApplyDiscount(strategy, amount)
    }

    class DiscountType {
        <<enum>>
        +None
        +Normal
        +Student
    }
```

---

## ▶️ Example Output

```
Amount : 10
Student Discount : 9
No Discount : 10
Normal Discount : 9.5
```


---

## ✅ 3. Sequence Diagram (Discount Strategy)

```mermaid
sequenceDiagram
    participant Client
    participant Context
    participant Strategy

    Client->>Context: ResolveDiscountStrategy(Student)
    Context->>Strategy: new StudentDiscount()
    Context-->>Client: StudentDiscount instance

    Client->>Context: ApplyDiscount(discount, 10)
    Context->>Strategy: ApplyDiscount(10)
    Strategy-->>Context: 9
    Context-->>Client: 9
```

---

## 👨‍💻 Developer

Designed and implemented by **Kishore**  
Senior .NET Full-Stack Developer  
System Design & Clean Architecture Enthusiast  
[GitHub: @Kishi05](https://github.com/Kishi05)