# 📚 BlogVerse – ASP.NET Core MVC Blogging Platform

**BlogVerse** is a full-featured blogging platform built using **ASP.NET Core MVC**, designed to empower writers and readers to connect through interactive and meaningful content. It supports secure user authentication, blog creation, editing, and engaging community features like likes and comments.

This project is part of an academic assignment showcasing core concepts in ASP.NET MVC, Entity Framework, authentication, and modern web development practices.

---


## 📌 Project Overview

The goal of BlogVerse is to provide an intuitive, secure, and visually appealing platform for users to create, explore, and manage blog content. It demonstrates:

- MVC architecture for clean code separation
- Secure login and registration using ASP.NET Identity
- Real-time content loading using AJAX
- CRUD operations on blog content using Entity Framework
- SQL Server integration for relational data storage

---

## 🚀 Features

### 👤 User Features
- ✅ Register & Login with ASP.NET Identity (password hashing, session management)
- 🌗 Toggle between Light/Dark Mode
- 📖 Explore blogs by category, tags, and author
- 🔍 Live search and dynamic filtering
- ❤️ Like, Comment, and Save blogs
- 📂 View Reading History and Saved Posts
- 🔔 Get notified about posts from followed authors

### ✍️ Writer Features
- ✍️ Draft, Publish, Edit, and Delete blog posts
- ✨ Use TinyMCE Rich Text Editor for content formatting
- 📊 Dashboard for:
  - Post overview
  - Drafts and published blogs
  - Views and likes analytics

### 📢 Additional Features
- 🦄 Responsive hero section with call-to-action
- 🔥 Trending blogs popup (shown after 30 seconds)
- 🎯 “Why BlogVerse?” grid on homepage
- 🛎️ Smooth, dynamic interactions using AJAX

---

## 🧩 Project Modules

| Module | Description |
|--------|-------------|
| **Authentication** | ASP.NET Identity-based secure login, registration, password hashing, session handling |
| **Dashboard & Blog Management** | Personalized dashboard for blog CRUD, drafts, and engagement tracking |
| **Viewing & Interaction** | Public and private blog views, comments, likes, reactions |
| **Database Management** | SQL Server database via Entity Framework Core for storing blogs, users, comments |
| **AJAX** | Asynchronous blog filtering, live search, comment submission |
| **API Integration** | (Future) REST API for external access or AI-based blog generation |

---

## 🛠 Technology Stack

| Layer       | Technology Used                |
|-------------|-------------------------------|
| Frontend    | HTML, CSS, Bootstrap, JavaScript |
| Backend     | ASP.NET Core MVC (C#)         |
| Database    | SQL Server via EF Core        |
| Auth System | ASP.NET Core Identity         |
| Rich Editor | TinyMCE Rich Text Editor      |
| Interactivity | AJAX & JavaScript           |

---

## 📸 Screenshots

> Upload and insert your screenshots below using the format:

```markdown
### 🏠 Landing Page  
![Landing Page](link-to-image)

### 🔐 Login / Register  
![Login](link)

### ✍️ Blog Editor  
![Editor](link)

### 📊 Dashboard  
![Dashboard](link)

### 📖 Blog Detail with Comments  
![Blog Detail](link)
⚙️ Getting Started
✅ Prerequisites
.NET SDK 6.0+

Visual Studio 2022 / Visual Studio Code

SQL Server

🚀 How to Run Locally
Clone the repository

bash
Copy
Edit
git clone https://github.com/your-username/BlogVerse.git
Open the solution

Open BlogVerse.sln in Visual Studio.

Configure database

Open appsettings.json

Replace the connection string with your SQL Server credentials

Apply migrations and update DB

Open Package Manager Console and run:

bash
Copy
Edit
Update-Database
Run the project

Press F5 or click the green ▶️ button to launch the application

