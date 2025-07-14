# 🧠 Builder Design Pattern — Payment Builder Demo

## 📌 Pattern Category
Creational Design Pattern

## Intent
Separate the construction of a complex object from its representation so that the same construction process can create different representations.

## Overview
This demo simulates building different payment objects (Credit Card, UPI) via fluent builders that collect input step-by-step before producing immutable payment instances.

## 🧱 Key Components

| Class                  | Role                               |
|------------------------|----------------------------------|
| `Payment` (abstract)   | Base class defining payment behavior. |
| `CreditCardPayment`    | Concrete payment holding card info.    |
| `UPIPayment`           | Concrete payment holding UPI info.     |
| `IPaymentBuilder`      | Builder interface for constructing payments. |
| `CreditCardBuilder`    | Fluent builder collecting card details. |
| `UPIBuilder`           | Fluent builder collecting UPI ID.      |
| `PaymentBuilderFactory`| Factory returning appropriate builder instance. |
| `Program.cs`           | Client interacting with builder factory and builders.|

## Sample Console Run

```
Choose Payment Type
(1) Credit Card (2) UPI
Select Payment Type:
1

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

## 🧱 Class Diagram (UML)

```
                 +--------------------+
                 |   <<abstract>>     |
                 |      Payment       |
                 +--------------------+
                 | + InitiatePayment()|
                 | + ProcessPayment() |
                 +--------------------+
                       ▲          ▲
              +------------------+ +--------------+
              | CreditCardPayment| |  UPIPayment  |
              +------------------+ +--------------+
              | - CardNumber     | | - UPIID      |
              | - CardHolder     | +--------------+
              | - Expiration     |
              +------------------+

                 +-----------------------------+
                 |  IPaymentBuilder            |
                 +-----------------------------+
                 | + Build(): IPaymentBuilder  |
                 +-----------------------------+
                       ▲            ▲
          +------------------+   +--------------+
          | CreditCardBuilder |  | UPIBuilder   |
           +------------------+  +--------------+
          | + GetCardNumber() |  | + GetUPIID() |
          | + GetHolderName() |  +--------------+
          | + GetExpiryDate() |
          | + PaymentObject() |
          +-------------------+

                  +-----------------------+
                  |  PaymentBuilderFactory|
                  +-----------------------+
                  | + PaymentMethod(type):|
                  |   IPaymentBuilder     |
                  +-----------------------+

                       ▲
                       |
                  +-------------+
                  |  Program.cs |
                  +-------------+
                  | - Client    |
                  +-------------+

```

---

## 📂 Folder Structure

```
/BuilderPaymentDemo/
│
├── Builder/
│ ├── Abstract/
│ │ └── Payment.cs
│ ├── Builder/
│ │ ├── Interface/
│ │ │ └── IPaymentBuilder.cs
│ │ ├── CreditCardBuilder.cs
│ │ └── UPIBuilder.cs
│ ├── Enum/
│ │ └── PaymentType.cs
│ ├── Factory/
│ │ └── PaymentBuilderFactory.cs
│ ├── CreditCardPayment.cs
│ ├── UPIPayment.cs
│ └── Program.cs
```

---

## 👨‍💻 Author

Designed and implemented by **Kishore**  
Senior .NET Full-Stack Developer  
System Design & Clean Architecture Enthusiast  
[GitHub: @Kishi05](https://github.com/Kishi05)
