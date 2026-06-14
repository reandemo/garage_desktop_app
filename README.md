# REAN-PRO Store Management System

A modern Store Management System built with **WPF (.NET)** and **Material Design In XAML**.

## Current Features

### 1. Login Screen (FrmUserLogin)

The Login Screen provides a modern and user-friendly interface for users to access the system.

#### Features

* Material Design UI
* Custom Window Style
* Username Authentication
* Password Authentication
* Enter Key Login Support
* Application Exit Menu
* Draggable Window
* Responsive Card Layout
* Custom Logo Support

#### Login Actions

* Sign In
* Create Store
* Exit Application

---

### 2. Store Setup Screen (FrmStoreSetup)

The Store Setup Screen allows users to configure the system before first use.

#### Features

* Material Design UI
* Modern Registration Form
* Close Button
* Custom Window Style
* Store Information Setup
* Administrator Account Creation

#### Store Information

Users can configure:

* System Type

  * Store Management
  * Garage Management
  * Restaurant Management
  * POS System
  * Pharmacy Management

* Store Name

* Phone Number

* Location

  * PP - Phnom Penh
  * KPT - Kampot
  * KPS - Sihanoukville

* Administrator Username

* Administrator Password

* Confirm Password

#### Available Actions

* Create Store
* Back To Login
* Close Window

---

## Technology Stack

### Frontend

* WPF (.NET)
* XAML
* MaterialDesignInXamlToolkit

### Architecture

Current Project Structure:

Store_Online

├── Assets

├── Users

│   ├── FrmUserLogin.xaml

│   └── FrmStoreSetup.xaml

├── ResourceDictionary

├── Resources

└── App.xaml

---

## Application Flow

Current Workflow:

Login Screen
↓
Create Store
↓
Store Setup
↓
Create Administrator Account
↓
Return To Login
↓
Sign In

---

## Current Status

### Completed

* Login UI
* Store Setup UI
* Material Design Theme
* Form Navigation
* Window Controls
* User Experience Improvements

### In Progress

* Database Connection
* SQL Server Integration
* User Authentication
* Store Registration Logic

---

## Next Development Phase

The next milestone is implementing SQL Server integration.

### Planned Features

* SQL Server Connection
* Store Registration Save Function
* User Authentication
* Password Encryption
* Dashboard
* User Management
* Product Management
* Sales Management
* Reporting System

### Future Roadmap

Phase 1

* Database Connection
* Login Validation
* Dashboard

Phase 2

* User Management
* Product Management

Phase 3

* Sales & POS

Phase 4

* Reports & Analytics

---

## Author

REAN-PRO

Created for learning, sharing knowledge, and helping developers build modern business applications using WPF and C#.
