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

### 📦 Visual Studio Installer Project

- Built using **Visual Studio Installer Projects**.
- **Outputs:**
  - `EDPProjSetup.msi`
  - `setup.exe`
- 📂 Output Location:  
  `EDPProjSetup/Debug/`

---

### 📦 Inno Setup Installer

- Built using **Inno Setup** with a custom script.
- 📁 **Files Located in the Base Directory:**
  - `SBR_EDP_Csharp_Installer_Final.iss` – Inno Setup script file  
  - `SBR_EDP_Installer.exe` – Final compiled Inno Setup installer  
  - `mysql-installer-community-8.0.42.0.msi` – MySQL installer  
  - `setup_mysql.bat` – Batch file for silent MySQL setup and database import  
  - `init_db.sql`, `SBRDB.sql` – SQL dump files for initializing database schema and data

- The Inno Setup installer automates:
  - Application installation
  - Silent MySQL installation (if not already installed)
  - Database initialization via SQL dump files

📹 **Demo Video of the Working Installer**  
[▶️ Watch on YouTube](https://youtu.be/tIzYXG6OYH4)

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

## 📂 Reports

- 📁 **Templates:**
  - `reportTemplate/userlist.xlsx` – Pre-formatted Excel template used for generating user list reports

- 📁 **Generated Reports:**
  - `generatedReports/files/` – Folder where dynamically created Excel reports are saved
 
---

## 👤 Developer

**Shakira B. Regalado**  
Bachelor of Science in Information Technology  
**BSIT 3B**
