# 💳 Abstract Payment System — Creational Pattern Example

## 📌 Pattern Category
**Creational Design Pattern** — Abstract Base Class with Polymorphism

---

## 🎯 Purpose of This Project

This project simulates a basic **Payment Gateway** where different payment types like **Credit Card** and **UPI** share a common interface but implement their own behavior.

It demonstrates:
- How to create **interchangeable object hierarchies**
- How to use **polymorphism** to process different payment types
- How to extend payment types without modifying existing code

---

## 🧱 Key Components

| Class              | Role                      | Description                                  |
|-------------------|---------------------------|----------------------------------------------|
| `Payment`         | Abstract Base Class       | Declares contract: `PaymentDetails()`, `ProcessPayment()` |
| `CreditCardPayment` | Concrete Implementation   | Accepts card details and processes payment   |
| `UPIPayment`      | Concrete Implementation    | Accepts UPI ID and simulates payment         |
| `Program.cs`      | Client                     | Demonstrates dynamic switching of payment mode |

---

## 📦 Features

- ✅ Runtime switching between payment types
- ✅ Console input-based simulation
- ✅ Error handling for invalid inputs
- ✅ Extensible architecture (e.g., add WalletPayment, NetBanking, etc.)

---

## 📂 Folder Structure

```
/AbstractPaymentSystem/
│
├── Abstract/                         
│
│   ├── Abstract/
│   │   └── Payment.cs               ← Abstract base class: defines contract
│
│   ├── CreditCardPayment.cs         ← Concrete class: implements card payment
│   ├── UPIPayment.cs                ← Concrete class: implements UPI payment
│
├── Program.cs                        ← Console entry point to demonstrate usage
```

---

## 🧪 Sample Output

```
Enter Card Details :

Enter Card Number :
1234567890123456

Enter Card Holder Name :
Tony Stark

Enter Expiration Date :
08/30/2026

Payment will now process...

Credit Card Payment Processed

Enter UPI Details :

Enter UPI ID :
tony@upi

Payment will now process...

UPI Payment Processed
```


---

## 🧰 Extension Ideas

- 🔁 Add a Factory Method to create payment objects dynamically
- 🛡️ Add validation and encryption simulation
- 🧪 Integrate unit testing for input/output logic
- 📤 Add logging/auditing of processed payments

---

## 👨‍💻 Author

Designed and implemented by **Kishore**  
Senior .NET Full-Stack Developer  
System Design & Clean Architecture Enthusiast  
[GitHub: @Kishi05](https://github.com/Kishi05)