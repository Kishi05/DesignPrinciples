# 🛡️ Proxy Design Pattern (Async) — Payment Receipt Use Case

## 📘 Overview

This demo illustrates the **Proxy Design Pattern** using a **payment receipt** scenario. The proxy simulates a delay in generating a receipt (like a real-world backend process), and shows how a proxy object can handle interim feedback until the real object becomes available.

---

## 🤖 What is a Proxy?

> A **proxy** is an object that acts as a *substitute or placeholder* for another object to control access, delay instantiation, or add extra logic before/after delegating the call.

In this example:
- The **real object** (PaymentReceipt) takes 5 seconds to generate a receipt.
- The **proxy object** (PaymentReceiptProxy) immediately returns a "Processing..." placeholder until the real receipt is ready.

---

## 🎮 Real-Life Analogy

> **“While a game loads, it shows tips or artwork until it's ready.”**  
This example mirrors that behavior — the UI doesn't block, but shows interim data ("Processing…") until the backend finishes.

---

## 🧠 Technical Flow

### Interfaces

```csharp
public interface IPaymentReceipt
{
    Task<Receipt> GetReceipt();
}
```

### Real Object

```csharp
public class PaymentReceipt : IPaymentReceipt
{
    public async Task<Receipt> GetReceipt()
    {
        await Task.Delay(5000); // Simulates delay in generating actual receipt
        return new Receipt { Confirmation = "AGSUY8K6DI" };
    }
}
```

### Proxy Object

```csharp
public class PaymentReceiptProxy : IPaymentReceipt
{
    private static readonly Receipt receipt = new Receipt { Confirmation = "Processing.." };
    private PaymentReceipt? PaymentReceipt { get; set; }
    private bool paymentInitiated = false;
    private bool paymentSuccess = false;
    private Receipt? _receipt;

    public Task<Receipt> GetReceipt()
    {
        if (paymentSuccess)
        {
            return Task.FromResult(_receipt!); // Return real receipt
        }
        else
        {
            if (!paymentInitiated)
            {
                paymentInitiated = true;
                _ = Task.Run(async () =>
                {
                    PaymentReceipt ??= new PaymentReceipt();
                    Receipt result = await PaymentReceipt.GetReceipt();
                    Interlocked.Exchange(ref _receipt, result);
                    paymentSuccess = true;
                });
            }

            return Task.FromResult(GetproxyReceipt()); // Return proxy
        }
    }

    private Receipt GetproxyReceipt()
    {
        return receipt;
    }
}
```

### Usage Example

```csharp
IPaymentReceipt receiptProxy = new PaymentReceiptProxy();

Receipt proxy1 = await receiptProxy.GetReceipt();
Console.WriteLine(proxy1.ToString()); // Outputs: "Processing..."

await Task.Delay(2000);

Receipt proxy2 = await receiptProxy.GetReceipt();
Console.WriteLine(proxy2.ToString()); // Still: "Processing..."

await Task.Delay(2000);

Receipt proxy3 = await receiptProxy.GetReceipt();
Console.WriteLine(proxy3.ToString()); // Might still be processing...

await Task.Delay(2000);

Receipt final = await receiptProxy.GetReceipt();
Console.WriteLine(final.ToString());  // Now returns: "Confirmation : AGSUY8K6DI"
```

---

## 📌 Key Learnings

- The **proxy** avoids unnecessary delays for the caller.
- It enables **non-blocking UI flow** while background processing continues.
- Once data is ready, it **automatically returns the real object**.
- Ideal for scenarios like:
  - ✅ Lazy loading
  - ✅ Caching
  - ✅ Network latency buffering
  - ✅ Virtual representation of expensive objects

---

## 📎 Related Design Patterns

- Virtual Proxy: Delays object creation until absolutely needed.
- Remote Proxy: Represents an object in another address space.
- Protection Proxy: Adds access control.

---

## 👨‍💻 Author

Designed and implemented by **Kishore**  
Senior .NET Full-Stack Developer  
System Design & Clean Architecture Enthusiast  
[GitHub: @Kishi05](https://github.com/Kishi05)
