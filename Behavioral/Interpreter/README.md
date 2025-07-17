# 🧠 Interpreter Design Pattern – C# Implementation

## 📌 Purpose

The **Interpreter pattern** defines a grammar and provides an interpreter to evaluate sentences in the grammar.
Used to interpret expressions like mathematical formulas, rules, or scripted instructions.

This project interprets simple arithmetic + equality expressions like:

```csharp
"5 + 3 == 4 + 4"
```

It recursively parses and evaluates to `true`.

---

## 👨‍💼 Real-World Analogy

Think of a calculator that understands:

* Numbers
* Operations like `+`, `-`
* Comparisons like `==`

And you can **extend** it easily to understand more operators (`*`, `/`, `!=`, etc.).

---

## 📦 Folder Structure

```
Interpreter/
│
├── Interface/
│   └── IExpression.cs
│
├── Expressions/
│   ├── NumberExpression.cs
│   ├── AddExpression.cs
│   ├── SubtractExpression.cs
│   └── CompareExpression.cs
│
└── Program.cs
```

---

## 🔁 Sequence Flow

```mermaid
sequenceDiagram
    participant Main
    participant Parser
    participant ExpressionTree
    participant Interpreter

    Main->>Parser: Parse "5 + 3 == 4 + 4"
    Parser->>ExpressionTree: Build AST (Add, Compare)
    Main->>Interpreter: Interpret(AST)
    Interpreter->>ExpressionTree: Evaluate left: (5+3)
    Interpreter->>ExpressionTree: Evaluate right: (4+4)
    ExpressionTree->>Interpreter: Result: true
    Interpreter->>Main: Print result
```

---

## 🔧 UML Diagram

```mermaid
classDiagram
    class IExpression {
        +Interpret(): int or bool
    }

    class NumberExpression {
        -number: int
        +Interpret(): int
    }

    class AddExpression {
        -left: IExpression
        -right: IExpression
        +Interpret(): int
    }

    class SubtractExpression {
        -left: IExpression
        -right: IExpression
        +Interpret(): int
    }

    class CompareExpression {
        -left: IExpression
        -right: IExpression
        +Interpret(): bool
    }

    IExpression <|.. NumberExpression
    IExpression <|.. AddExpression
    IExpression <|.. SubtractExpression
    IExpression <|.. CompareExpression
```

---

## 🧪 Example

```csharp
string input = "5 + 3 == 4 + 4";
// Output: Result: True
```

---