# ☕ Store_Online

Modern **Multi-Business Management System** built with **WPF (.NET 8)**, **Laravel 13 REST API**, and **MySQL**.

> A single desktop platform designed to support multiple business domains including **Coffee Shop (POS)**, **Garage**, **Hotel/Resort**, and future modules through a shared architecture.

---

# ✨ Current Features

## 🔐 Authentication
- Login via Laravel REST API
- Token-based authentication
- User Profile
- Change Password
- Logout with custom confirmation dialog
- Session management (in progress)

## 🖥 Desktop UI
- WPF (.NET 8)
- Material Design in XAML
- Modern dashboard
- Sidebar navigation
- Status bar
- Responsive layouts
- Professional icons

## 🔔 Alert Framework

Custom reusable alert framework.

### Notification
- Success
- Error
- Warning
- Information

### Dialog
- Confirm Logout
- Confirm Delete
- Confirm Save
- Confirm Update
- Custom Yes / No

Future:
- Input Dialog
- Progress Dialog
- Loading Overlay

---

# 🏗 Project Structure

```text
Store_Online
│
├── Alerts
│   ├── Base
│   ├── Dialogs
│   ├── Models
│   ├── Services
│   └── Controls
│
├── Assets
├── Controls
├── MainForms
├── Models
├── Modules
├── Resources
├── Services
│   └── ApiService.cs
├── Styles
├── Users
├── Views
│
├── App.xaml
└── MainWindow.xaml
```

---

# ☕ Current Modules

## Coffee POS
- Login
- Dashboard
- POS
- Products
- Reports
- Users
- Settings

## Garage
- Under Development

## Hotel / Resort
- Under Development

---

# 🌐 Backend

- Laravel 13
- REST API
- MySQL
- JSON API
- Authentication
- Multi-module ready

---

# 🛠 Technology

## Frontend
- WPF .NET 8
- C#
- XAML
- Material Design in XAML

## Backend
- Laravel 13
- PHP 8+
- REST API

## Database
- MySQL

---

# 🚀 Architecture

```text
WPF Desktop
      │
      ▼
ApiService
      │
      ▼
Laravel REST API
      │
      ▼
MySQL
```

---

# 📋 Roadmap

## Completed
- WPF project structure
- Laravel API integration
- Material Design UI
- Notification Service
- Dialog Service
- Custom confirmation dialogs
- Login window
- Main windows
- Multi-language foundation (RESX)
- Modular architecture foundation

## In Progress
- Permission system
- Session service
- Navigation service
- Loading service
- Input dialog
- Progress dialog

## Planned
- Garage module
- Hotel module
- Resort module
- Inventory
- Reports
- Auto update
- Mobile application

---

# 👨‍💻 Developer

**JOIN CODER**

GitHub:
https://github.com/reanprogramming

---

# 📄 License

MIT License
