# MyFinancialCrm - Finansal Yönetim Sistemi

[TR]

**C# Windows Forms ve Entity Framework ile Geliştirilmiş Finansal Kaynak Yönetimi Uygulaması**

[![C#](https://img.shields.io/badge/Language-C%23-blue.svg)](https://docs.microsoft.com/en-us/dotnet/csharp/)
[![Windows Forms](https://img.shields.io/badge/Platform-Windows%20Forms-blue.svg)](https://docs.microsoft.com/en-us/dotnet/desktop/winforms/)
[![Entity Framework](https://img.shields.io/badge/ORM-Entity%20Framework-blueviolet.svg)](https://docs.microsoft.com/en-us/ef/)
[![SQL Server](https://img.shields.io/badge/Database-SQL%20Server-lightgrey.svg)](https://www.microsoft.com/en-us/sql-server)

---

## 💻 Proje Hakkında

Bu proje, **C# Windows Forms** platformunda geliştirilmiş, bir işletmenin veya bireyin finansal hareketlerini, banka işlemlerini, faturalarını ve genel giderlerini yönetmesini sağlayan modüler bir **Finansal Yönetim Sistemi**'dir.

Uygulama, veri erişimi için **Entity Framework** kullanır ve kullanıcıya finansal veriler üzerinde tam **CRUD** (Create, Read, Update, Delete) kontrolü sunar.

### ⚙️ Teknik Altyapı

* **Platform:** C# Windows Forms
* **Veri Erişim Teknolojisi:** Entity Framework (DB Context Adı: `FinancialCrmDbEntities1`)
* **Veritabanı:** SQL Server
* **Raporlama:** Windows Forms'un `Chart` bileşenleri ile dinamik grafikler.

---

## ✨ Ana Özellikler ve Modüller

| Modül | Form Adı | Ana İşlevler |
| :--- | :--- | :--- |
| **Dashboard** | `FrmDashboard` | Toplam bakiye, son işlemler, banka bakiyesi ve fatura dağılımı grafikleri. |
| **Banka İşlemleri** | `FrmBankProcess` | Banka hareketlerini **ekleme, silme, güncelleme** ve listeleme (BankTitle ile JOIN). |
| **Gider Yönetimi** | `FrmSpendings` | Giderlerin kategori bazında (Dropdown ile) **CRUD** işlemleri. Giderlerin toplam tutar ve adet grafiklerinin gösterimi. |
| **Faturalar** | `FrmBilling` | Tekrarlayan faturaların/ödemelerin **CRUD** işlemleri. |
| **Ayarlar** | `FrmSettings` | Kullanıcı bilgilerini (Ad, Soyad, Şifre) güncelleme. |

---
---

# MyFinancialCrm - Financial Management System

[EN]

## 💻 About the Project

This is a modular **Financial Management System** developed using **C# Windows Forms**. It is designed to help businesses or individuals manage their financial movements, bank transactions, bills, and general expenditures.

The application leverages **Entity Framework** for simplified data access, providing users with full **CRUD** (Create, Read, Update, Delete) control over their financial data.

### ⚙️ Technical Stack

* **Platform:** C# Windows Forms
* **Data Access Technology:** Entity Framework (DB Context: `FinancialCrmDbEntities1`)
* **Database:** SQL Server
* **Reporting:** Dynamic charts created using Windows Forms' built-in `Chart` components.

---

## ✨ Core Features and Modules

The application is structured into several modules covering key aspects of financial management:

| Module | Form Name | Key Functionalities |
| :--- | :--- | :--- |
| **Dashboard** | `FrmDashboard` | Displays total balance, last transactions, and dynamic charts for bank balances and bill distribution. |
| **Bank Operations** | `FrmBankProcess` | **CRUD** operations (Add, Delete, Update, List) for bank transactions, including joining with Bank Title. |
| **Expense Management** | `FrmSpendings` | **CRUD** operations for expenses, categorized via a dropdown. Shows charts for total expense count and amount per category. |
| **Billing** | `FrmBilling` | **CRUD** operations for managing recurring bills and payments. |
| **Settings** | `FrmSettings` | User profile management (Name, Surname, Password update). |

---

## 🚀 How to Run

1.  **Clone the Repository:**
    ```bash
    git clone [https://github.com/abdullahhaktan/CSharpBootcampFinalProject](https://github.com/abdullahhaktan/CSharpBootcampFinalProject)
    cd MyFinancialCrm
    ```

2.  **Database Setup (Entity Framework):**
    * Configure your SQL Server database to match the Entity Framework context (`FinancialCrmDbEntities1`).
    * Ensure the necessary tables (`Users`, `Banks`, `Bills`, etc.) are present and configured correctly.

3.  **Build and Run:**
    * Open the `.sln` file in Visual Studio.
    * Build the solution and run the application (**F5**). The application will start with the `FrmLogin` screen.


---
---

## Ekran Fotoğrafları

<img width="589" alt="image" src="https://github.com/user-attachments/assets/3c03e9e4-56d6-405a-9bf4-09878e37abf5" />

 ![image](https://github.com/user-attachments/assets/054418fc-6906-4b66-8164-895a2151e7ed)

![image](https://github.com/user-attachments/assets/07ecb526-fcd1-4c8e-b41d-793ccfc2dfdb)

![image](https://github.com/user-attachments/assets/180e168f-3871-4c95-8392-573895781faa)

![image](https://github.com/user-attachments/assets/cfbc541c-2f83-47ed-91bb-52f04c257b32)

![image](https://github.com/user-attachments/assets/e6f9c1a8-4987-4102-9cb3-ef98d7fc0368)
![image](https://github.com/user-attachments/assets/9ddb6138-0986-4a4e-bfbd-545ee07652af)
![image](https://github.com/user-attachments/assets/94497f9e-9044-4627-a028-bb0bf19b17e5)

