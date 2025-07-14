# 🏭 Factory Method Pattern — Payment Gateway Demo

## Pattern Category
**Creational Design Pattern**

## ⚡ Intent
> “Define an interface for creating an object, but let subclasses decide which class to instantiate.”  
> — *Gang of Four*

In simpler terms: **move the `new` keyword out of your business logic** so choosing a class becomes just a data decision.

---

## Project Purpose
Simulate a checkout flow where a user chooses **Credit Card** or **UPI**.  
The program:

1. Prompts for the payment method.  
2. Uses **`PaymentFactory`** to create the correct `Payment` instance.  
3. Gathers method‑specific details.  
4. Processes the payment.

---

## Key Classes

| File | Role | Notes |
|------|------|-------|
| `Payment` *(abstract)* | Product | Declares `PaymentDetails()` & `ProcessPayment()`. |
| `CreditCardPayment` | Concrete Product | Handles card data & processing. |
| `UPIPayment` | Concrete Product | Handles UPI ID & processing. |
| `PaymentFactory` | **Factory Method** | Static creator that returns a `Payment` based on `PaymentType`. |
| `Program.cs` | Client | Consumes the factory; never calls `new` for products. |

---

## 🧱 Class Diagram (UML)

```
                   +--------------------+
                   |  <<abstract>>      |
                   |      Payment       |
                   +--------------------+
                   | + PaymentDetails() |
                   | + ProcessPayment() |
                   +--------------------+
                      ▲             ▲
                      |             |
     +-------------------+     +-------------------+
     | CreditCardPayment |     |   UPIPayment      |
     +-------------------+     +-------------------+
     | + PaymentDetails()|     | + PaymentDetails()|
     | + ProcessPayment()|     | + ProcessPayment()|
     +-------------------+     +-------------------+

                   +--------------------------+
                   |    PaymentFactory        |
                   +--------------------------+
                   | + PaymentMethod(         |
                   |   type: PaymentType):    |
                   |   Payment                |
                   +--------------------------+

                           ▲
                           |
                    +---------------+
                    |   Program.cs  |
                    +---------------+
                    | - Uses Factory|
                    | - Accepts only|
                    |   Payment obj |
                    +---------------+

                   +-----------------+
                   |  PaymentType     |
                   +-----------------+
                   | + CreditCard     |
                   | + UPI            |
                   +-----------------+

```

---

## Sample Run

```
Choose Payment Type
(1) Credit Card (2) UPI
Select Payment Type:
1

Enter Card Details :

Enter Card Number :
1234 5678 9012 3456

Enter Card Holder Name :
Bruce Wayne

Enter Expiration Date :
12/31/2027

Payment will now process...

Credit Card Payment Processed

Payment Completed Successfully
```

---

## 📂 Folder Structure

```
/FactoryMethodPayment/
│
├── Factory/ # Console project root
  ├── Abstract/
  │ └── Payment.cs
  ├── Enum/
  │ └── PaymentType.cs
  ├── Factory/
  │ └── PaymentFactory.cs
  ├── CreditCardPayment.cs
  ├── UPIPayment.cs
  └── Program.cs
```

---

## 👨‍💻 Author

Designed and implemented by **Kishore**  
Senior .NET Full-Stack Developer  
System Design & Clean Architecture Enthusiast  
[GitHub: @Kishi05](https://github.com/Kishi05)