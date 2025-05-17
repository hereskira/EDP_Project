# 📚 Library Management System

A desktop-based Library Management System built with **Visual Studio (Windows)** for the main application and **MySQL** as the database. This system efficiently manages books, members, and loans within a library environment.

---

## 🌿 Project Branches

- **`master` branch**  
  ➤ Contains the complete **Visual Studio Windows application** (C#), including the GUI and core functionalities.

- **`backend/setup` branch** *(Discontinued)*  
  ➤ Previously contained backend logic and setup scripts developed in **VS Code (Mac)**. No longer maintained.

---

## 🧩 Database Design

The system uses **8 main relational tables**:

| Table         | Description                                      |
|---------------|--------------------------------------------------|
| `authors`     | Stores book author information                   |
| `books`       | Catalog of all books in the library              |
| `categories`  | Genres or types of books                         |
| `employees`   | Records of library staff                         |
| `loans`       | Tracks borrow/return activities                  |
| `members`     | Information on library members                   |
| `publishers`  | Book publishers                                  |
| `users`       | User accounts and access credentials             |

---

## ⚙️ Installer

- Built using **Visual Studio Installer Projects**
- Output located in:  
  📁 `EDPProjSetup/Debug`

---

## 💡 Features

- Manage book inventory and categorization
- Register and manage members and employees
- Issue and return books with due date tracking
- Mark overdue and paid loans
- Login System  
- Forgot Password and Recovery  
- List of System Users (with CRUD functions: Create, Read, Update, Delete)  
- Primary Transactions using Triggers, Functions, Procedures, and Events  
- Report Generation using MS Excel (with search and filtering capabilities)

---

## 👤 Developer

**Shakira B. Regalado**  
Bachelor of Science in Information Technology  
**BSIT 3B**
