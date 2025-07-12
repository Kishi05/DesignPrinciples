# 🛂 Leave Management System – Async Chain of Responsibility with Proxy

This is a simulation of a **Leave Approval Workflow** using the **Chain of Responsibility** pattern combined with the **Proxy pattern** to introduce asynchronous background processing.

---

## 🧩 Design Patterns Used

- **Chain of Responsibility** – to route leave requests through multiple levels of approvers (TL → Manager → HR).
- **Proxy** – to simulate delayed background review without blocking the main console.
- **Facade** – to encapsulate the flow through a single interaction point for the client.

---

## 🔁 Approval Logic

| Approver | Condition                          | Action                  |
|----------|-------------------------------------|--------------------------|
| **TL**   | Leave days == 1                     | Approves directly        |
|          | Else                                | Forwards to Manager      |
| **Manager** | Leave days < 3                   | Approves                 |
|          | Else                                | Forwards to HR           |
| **HR**   | Leave days < 5                      | Approves                 |
|          | Else                                | Rejects                  |

All approvers add a short delay to simulate time taken for review.

---

## ⚙️ How It Works

- `TLProxy` starts the request **asynchronously** in a background task using `Task.Run`.
- The chain of approvers runs in the background (TL → Manager → HR).
- While the chain is executing, the console remains active, allowing you to:
  - Apply a new leave request (only once at a time)
  - Check the current status (polls `finalStatus` and trail log)
- Status is updated internally and can be fetched on demand.

---

## 🖥️ Console Menu Flow

```text
Leave Management System
1) Apply Leave
2) Check Status
3) Print Status
Enter choice:
```

🟢 Option 1: Triggers the request asynchronously

🟡 Option 2 & 3: Polls and prints the current approval trail and status

---
### 📁 File Structure

```text
COR/
├── Abstract/
│   └── Approver.cs         # Base class for all approvers
├── TL.cs                   # Team Lead logic
├── Manager.cs              # Manager logic
├── HR.cs                   # HR logic
├── TLProxy.cs              # Proxy for background TL review
├── LeaveManagementFacade.cs # Encapsulates the entire workflow
└── Program.cs              # Console app entry point
```

---

### 📦 Status Tracking
- Approval trail is stored in a Dictionary<string, string> in each approver.
- finalStatus reflects the overall approval state:
- Pending, Approved, or Rejected.

---

### 🚀 Sample Output

```text
Main: Request Initiated
TL: Escalated to Manager
Manager: Escalated to HR
HR: Approved

Current Status: Approved
```
