# Design Patterns

## 🧠 What are Design Patterns?
Design Patterns are proven solutions to common software design problems. They offer best practices and standard approaches to build robust, scalable, and maintainable systems. Each pattern serves a unique purpose—whether it's creating objects efficiently, structuring code flexibly, or managing object behaviors effectively. Understanding these patterns is crucial for crafting quality software and excelling in system design interviews and enterprise architecture roles.

> This repository contains categorized and structured implementations of all essential design patterns in C#. Each pattern folder includes clean, real-world-inspired examples.

---

## ✅ Creational Patterns

These patterns are related to object creation mechanisms.

### 1. Singleton

Ensures a class has only one instance and provides a global access point.

### 2. Factory Method

Defines an interface for creating an object, letting subclasses decide the instantiation.

### 3. Abstract Factory

Creates families of related or dependent objects without specifying their concrete classes.

### 4. Builder

Constructs a complex object step by step and provides flexibility in the construction process.

### 5. Prototype

Creates new objects by cloning an existing object.

### 6. Object Pool *(Optional)*

Maintains a pool of pre-instantiated reusable objects to reduce the overhead of object creation.

---

## ✅ Structural Patterns

These patterns deal with object composition and typically help ensure flexibility and efficiency.

### 1. Adapter

Converts one interface to another that clients expect.

### 2. Bridge

Separates abstraction from implementation so both can vary independently.

### 3. Composite

Treats individual objects and compositions of objects uniformly.

### 4. Decorator

Adds behavior to objects dynamically without altering their class.

### 5. Facade

Provides a unified interface to a set of interfaces in a subsystem.

### 6. Flyweight

Reduces memory usage by sharing common parts of object states.

### 7. Proxy

Provides a surrogate or placeholder to control access to an object.

### 8. Service Locator *(Optional)*

Provides a registry for services or dependencies — a form of manual Dependency Injection.

---

## ✅ Behavioral Patterns

These patterns deal with communication between objects and responsibilities.

### 1. Chain of Responsibility

Passes a request along a chain of handlers until it's processed.

### 2. Command

Encapsulates a request as an object, allowing undo/redo and queuing.

### 3. Interpreter

Defines a grammar for interpreting sentences in a language.

### 4. Iterator

Provides a way to sequentially access elements without exposing the underlying structure.

### 5. Mediator

Defines an object that encapsulates how a set of objects interact.

### 6. Memento

Captures and restores an object's internal state without violating encapsulation.

### 7. Observer

Notifies multiple objects about state changes.

### 8. State

Allows an object to alter its behavior when its internal state changes.

### 9. Strategy

Defines a family of algorithms, encapsulates them, and makes them interchangeable.

### 10. Template Method

Defines the program skeleton in a base class but lets subclasses override specific steps.

### 11. Visitor

Separates algorithms from object structures to add new operations without modifying them.

### 12. Null Object

Implements a do-nothing version of an interface to eliminate null checks.

### 13. Specification *(Optional)*

Encapsulates business rules that can be recombined using logic operations (AND, OR, NOT).

---

## 📌 Notes

* Optional patterns are valuable for deeper understanding but not always essential.
* Folder structure follows a convention: `Pattern.Interface`, `Pattern.Concrete`, `Pattern.Client`, etc.

---

Happy Learning! 🚀
