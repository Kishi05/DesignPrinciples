# 🧠 Memento Design Pattern — Config Versioning System

## 📌 Pattern Category
**Behavioral Design Pattern**

---

## 📖 What is the Memento Pattern?

The **Memento Pattern** allows you to:
> "Capture an object’s internal state and store it in such a way that it can be restored later, without violating the principle of encapsulation."

### 🔍 Why Use It?
Sometimes, we want to:
- Save the state of an object temporarily (e.g., before changes).
- Restore that state later (like undo functionality).
- Do all this **without exposing internal object structure** to the outside world.

This pattern is useful in:
- Editors (Undo/Redo)
- Game checkpoints
- Form auto-saves
- Configuration/version control systems

---

## 🧠 Purpose of This Project

This repository demonstrates the **Memento Pattern** using a real-world, practical scenario:
> Managing **application configuration values** such as logging levels, API URLs, and connection strings.

We:
- Allow edits to a `Config` object.
- Capture each version using the Memento pattern.
- Provide options to view version history or revert to any past version.

This not only shows **how the pattern works**, but also **why it’s useful**.

---

## 🧱 Key Components

| Class             | Role        | Description                                                                 |
|------------------|-------------|-----------------------------------------------------------------------------|
| `Config`          | Originator  | The main object whose state changes and needs to be saved or restored.     |
| `ConfigMemento`   | Memento     | Stores the internal state of `Config` securely.                            |
| `Facade`          | Caretaker   | Acts as the middle layer to manage backups, restores, and user operations. |

---

## ⚙️ Features Demonstrated

- ✅ Save configuration state to version history.
- ✅ Undo recent change by restoring the latest version.
- ✅ Restore to a **specific version**.
- ✅ View all historical versions with complete details.
- ✅ Handle invalid restore requests safely.

---

## 📁 Folder Structure

```
/Memento/                      
│
├── Memento/                  
│   ├── Config.cs             ← Originator class
│   ├── ConfigMemento.cs      ← Memento class
│   ├── Facade.cs             ← Caretaker class
│   └── Program.cs            ← Entry point (Main method to demo usage)
│
├── Memento.sln               

```

---

## 🧪 Sample Output

```
New Object :
Connection String : Connection String Value
Logging : Warning
APIURL : http://api.dp.com/

After Update 1 :
Connection String : Connection String Value
Logging : Debug
APIURL : https://newapi.dp.com

--------------------------------------------------------

                           Versions
Found : 1 version(s)

Version : 1
Connection String : Connection String Value
Logging : Warning
APIURL : http://api.dp.com/

--------------------------------------------------------

After Undo :
Connection String : Connection String Value
Logging : Warning
APIURL : http://api.dp.com

...
Invalid Version Number - Restore Failed
No changes made to current state !

Connection String : Connection String Value
Logging : Information
APIURL : https://localapi.dp.com

```

---

## 👨‍💻 Author

Designed and implemented by **Kishore**  
Senior .NET Full-Stack Developer  
System Design & Clean Architecture Enthusiast  
[GitHub: @Kishi05](https://github.com/Kishi05)