# 💳 Visitor Pattern – Payment Processing System

---

## 📖 What is the Visitor Pattern?

The **Visitor Design Pattern** allows you to add new operations to existing class hierarchies **without modifying their structure**. Instead of polluting your core domain objects with multiple methods, you externalize the logic into **Visitor classes**.

**Use Case in this Project:**  
We want to perform different kinds of payment operations (`OneTime`, `Recurring`, `Refund`) on a `Payment` object, based on different **payment methods** like `UPI` and `CreditCard`, without modifying `Payment` or duplicating logic.

---

## 🧠 Key Points to Remember

| Key Aspect              | Description                                                                 |
|-------------------------|-----------------------------------------------------------------------------|
| 🔄 Separation of Concerns | Logic is moved out of the `Payment` class into `Visitors`.                     |
| ➕ Open/Closed Principle | Easily add new operations (`Logging`, `Audit`) without touching core objects. |
| 🧱 Extensibility         | You can plug in new payment methods (e.g., PayPal) or new operations easily. |
| 🧵 Thread Safety         | Uses `Lazy<T>` to ensure thread-safe singleton instances of visitors.         |
| 🤝 Double Dispatch       | Enables method execution based on both **visitor and element types**.        |

---

## ✅ UML Class Diagram

```
          +--------------------------+
          |        Payment           |
          +--------------------------+
          | - Amount: decimal        |
          +--------------------------+
          | +OneTimePayment(): void  |
          | +RecurringPayment(): void|
          | +PaymentRefund(): void   |
          +--------------------------+

                        ▲
                        |
                        |   accepts PaymentType
                        |
                        v

          +------------------------------+
          |      IPaymentVisitor         | <interface>
          +------------------------------+
          | +ProcessPayment(p, type):    |
          |       IPaymentVisitor        |
          | +Logging(): IPaymentVisitor  |
          +------------------------------+
             ▲                    ▲
             |                    |
             |                    |
   +----------------+     +----------------+
   |   CreditCard   |     |      UPI       |
   +----------------+     +----------------+
   | <<Singleton>>  |     | <<Singleton>>  |
   +----------------+     +----------------+
   | Implements     |     | Implements     |
   | IPaymentVisitor|     | IPaymentVisitor|
   +----------------+     +----------------+

            ▲
            |
            |
   +-------------------+
   |     Facade        |
   +-------------------+
   | +GetVisitor(type):|
   |   IPaymentVisitor |
   +-------------------+

               ▲
               |
   +---------------------------+
   |     PaymentMethodType     | <enum>
   +---------------------------+
   | CreditCard, UPI, etc.     |
   +---------------------------+

   +---------------------------+
   |      PaymentType          | <enum>
   +---------------------------+
   | OneTime, Recurring, Refund|
   +---------------------------+

   ```

---

## 🏗️ Project Structure

```
VisitorPatternDemo/
│
├── Enum/
│ └── PaymentType.cs
│
├── Visitors/
│ ├── Interface/
│ │ └── IPaymentVisitor.cs
│ ├── CreditCard.cs
│ └── UPI.cs
│
├── Facade.cs
├── Payment.cs
└── Program.cs
```

---

## 🧾 Enums

```csharp
public enum PaymentType
{
    OneTimePayment = 1,
    RecurringPayment = 2,
    Refund = 3
}

public enum PaymentMethodType
{
    CreditCard = 1,
    UPI = 2
}
```

---

## 🧱 Core Components

🔹 Payment.cs
Encapsulates the payment amount and the actual operation logic for:

-OneTimePayment()
-RecurringPayment()
-PaymentRefund()

🔹 IPaymentVisitor.cs

```
interface IPaymentVisitor
{
    IPaymentVisitor ProcessPayment(Payment payment, PaymentType type);
    IPaymentVisitor Logging();
}
```

## 🚀 Sample Usage (Program.cs)

```
using Visitor;
using Visitor.Enum;

Facade.GetVisitor(PaymentMethodType.CreditCard)
      .ProcessPayment(new Payment(10), PaymentType.OneTimePayment)
      .Logging();

Facade.GetVisitor(PaymentMethodType.UPI)
      .ProcessPayment(new Payment(50), PaymentType.RecurringPayment)
      .Logging();
```

# Output

```
[ CreditCard ] One Time Payment: Paid 10
[ CreditCard ] - Logging
[ UPI ] One Time Payment: Paid 50
[ UPI ] - Logging
```

---

## 👨‍💻 Author

Designed and implemented by **Kishore**  
Senior .NET Full-Stack Developer  
System Design & Clean Architecture Enthusiast  
[GitHub: @Kishi05](https://github.com/Kishi05)