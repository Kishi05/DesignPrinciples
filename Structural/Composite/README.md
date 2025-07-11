# 👥 Composite Pattern – Dependency Tree (C#)

This project demonstrates the **Composite Design Pattern** using a real-world example of employees and their dependents. The pattern allows you to treat individual objects and compositions of objects uniformly.

---

## 🧠 What is the Composite Pattern?

> The **Composite Pattern** is a structural design pattern that lets you compose objects into tree structures and work with these structures as if they were individual objects.

It enables:

- Uniform treatment of both **individual objects** (leaves) and **groups of objects** (composites)
- Recursive composition, enabling deep hierarchical models
- Clean object-oriented abstraction of real-world trees like family trees, file systems, org charts, etc.

---

## 📦 Use Case: Employee–Dependent Tree

### 🔹 Real-World Mapping

- **Employee** = Composite node (can have dependents)
- **Dependent** = Leaf node (cannot have children)
- **DependencyChart** = Manages root-level employees and prints the full tree

---

## 🏗️ Project Structure

```
Composite/
├── Person.cs # Abstract base (Component)
├── Employee.cs # Composite node
├── Dependent.cs # Leaf node
├── DependencyChart.cs # Tree root manager
├── Program.cs # Entry point and sample usage
```

---

## 🧩 Key Components

### 🔸 Person (Abstract)
Defines the interface for both `Employee` and `Dependent`, including:
- `Add()`
- `Remove()`
- `PrintTree()`

### 🔸 Employee (Composite)
Can:
- Hold multiple dependents (`peopleList`)
- Recursively print the full tree

### 🔸 Dependent (Leaf)
- Cannot have children
- Throws exceptions on `Add()` or `Remove()`

### 🔸 DependencyChart
- Holds multiple root-level employees
- Supports adding, removing, and printing charts

---

## 🔄 Sample Code

```csharp
Employee employee1 = new Employee(1, "Sam", "Mr", 30, "Self");
Dependent dependent1 = new Dependent(3, "June", "Mrs", 30, "Spouse");
employee1.Add(dependent1);

Employee employee2 = new Employee(4, "Jack", "Mr", 30, "Self");
employee2.Add(new Dependent(6, "Rose", "Mrs", 30, "Spouse"));
employee2.Add(new Dependent(7, "Mary", "Mrs", 30, "Mother"));
employee2.Add(new Dependent(9, "John", "Master", 1, "Child"));

DependencyChart chart = new DependencyChart();
chart.AddRoot(employee1);
chart.AddRoot(employee2);

chart.PrintChart();
```

---

## 🖨️ Sample Output
```
Employee : Mr.Sam
Dependents :
	Mrs.June [Spouse]

Employee : Mr.Jack
Dependents :
	Mrs.Rose [Spouse]
	Mrs.Mary [Mother]
	Master.John [Child]
```
---

## 📌 Design Pattern Benefits Used

- ✅ Polymorphism for unified traversal (PrintTree)
- ✅ Encapsulation of dependents via composite logic
- ✅ Open/Closed Principle – Adding new person types (e.g., Interns) doesn’t affect existing code
- ✅ SRP – Each class has a single responsibility (Person, Composite, Leaf, Manager)

---

## 👨‍💻 Author

Designed and implemented by **Kishore**  
Senior .NET Full-Stack Developer  
System Design & Clean Architecture Enthusiast  
[GitHub: @Kishi05](https://github.com/Kishi05)
