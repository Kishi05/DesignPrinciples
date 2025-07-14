# Prototype Design Pattern — User Cloning Demo

## Pattern Category
Creational Design Pattern

## Intent
Specify the kinds of objects to create using a prototypical instance, and create new objects by copying this prototype.

## Overview
This demo shows cloning of `User` objects with shallow and deep copies. The shallow copy duplicates the reference to nested objects, while the deep copy creates full independent copies to avoid unintended side-effects.

## Key Components

| Class        | Role                                     |
|--------------|------------------------------------------|
| `User`       | Prototype object supporting shallow and deep cloning. |
| `Address`    | Nested object referenced by `User`.      |

---

## 📂 Folder Structure

```
/PrototypeDemo/
│
├── Entities/
│ ├── Address.cs
│ ├── User.cs
│
└── Program.cs
```

---

## 🧱 Class Diagram (UML)

```
+----------------+       +----------------+
|     User       |<>-----|    Address     |
+----------------+       +----------------+
| - Name         |       | - Street       |
| - Email        |       | - City         |
| - Phone        |       | - PostalCode   |
| - Address      |       +----------------+
+----------------+
| + Clone()      |
| + DeepClone()  |
+----------------+
```

---

## Sample Output

```
      Shallow Clone

Name          : Sam
Email         : sam@dp.com
Phone         : 9876543210
Street        : Castle Ave
City          : Hogwards
PostalCode    : OWLXII

Updating Address -> Postal Code Value
Old Value : OWLXII -> HOGPS01

Name          : Sam
Email         : sam@dp.com
Phone         : 9876543210
Street        : Castle Ave
City          : Hogwards
PostalCode    : HOGPS01

       Deep Clone

Name          : Sam
Email         : sam@dp.com
Phone         : 9876543210
Street        : Castle Ave
City          : Hogwards
PostalCode    : HOGPS01

Updating Address -> Postal Code Value
Old Value : HOGPS01 -> HOGPS01

Name          : Sam
Email         : sam@dp.com
Phone         : 9876543210
Street        : Castle Ave
City          : Hogwards
PostalCode    : HOGPS01
```

---

## 👨‍💻 Author

Designed and implemented by **Kishore**  
Senior .NET Full-Stack Developer  
System Design & Clean Architecture Enthusiast  
[GitHub: @Kishi05](https://github.com/Kishi05)