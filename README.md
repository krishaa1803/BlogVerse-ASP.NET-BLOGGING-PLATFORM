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


### 🏠 Landing Page  
![image](https://github.com/user-attachments/assets/5851728b-b9a7-466e-b37d-9799ff08a033)


### 🔐 Login / Register  
![image](https://github.com/user-attachments/assets/2d991909-f14d-48f4-b185-806c41cf671a)
![image](https://github.com/user-attachments/assets/76e03b7b-719d-469b-af5a-d0d049f7622a)


### ✍️ User logs in  
![image](https://github.com/user-attachments/assets/573a29b1-9d54-4f69-b580-5239ba489faa)


### 📊 Writer's Dashboard  
![image](https://github.com/user-attachments/assets/b4831b49-300f-41bc-8307-f20bdba3a5dc)
![image](https://github.com/user-attachments/assets/9dda1270-38c7-4a4a-a1be-cfa9d5c81808)


### 📖 Analytics 
![image](https://github.com/user-attachments/assets/caef615d-75a5-4aba-9252-23f9331f9548)


---

## ⚙️ Getting Started

### ✅ Prerequisites

- [.NET SDK 6.0+](https://dotnet.microsoft.com/en-us/download)
- [Visual Studio 2022](https://visualstudio.microsoft.com/) or [VS Code](https://code.visualstudio.com/)
- [SQL Server](https://www.microsoft.com/en-us/sql-server/sql-server-downloads)

---

## 🚀 How to Run Locally

Follow the steps below to set up and run the BlogVerse ASP.NET Core MVC project on your local machine:

---

### ✅ 1. Clone the Repository

```bash
git clone https://github.com/your-username/BlogVerse.git
````

> Replace `your-username` with your actual GitHub username.

---

### ✅ 2. Open the Solution

* Navigate to the cloned project folder.
* Open the `BlogVerse.sln` file in **Visual Studio 2022** or later.

---

### ✅ 3. Configure the Database

* Open `appsettings.json` located at `BlogVerse/BlogVerse/appsettings.json`.
* Replace the connection string with your local SQL Server settings:

```json
"ConnectionStrings": {
  "DefaultConnection": "Server=YOUR_SERVER_NAME;Database=BlogVerseDB;Trusted_Connection=True;MultipleActiveResultSets=true"
}
```

---

### ✅ 4. Apply Migrations and Update the Database

* In Visual Studio:

  * Go to `Tools → NuGet Package Manager → Package Manager Console`
* Run:

```bash
Update-Database
```

This will create the necessary tables and schema in SQL Server.

---

### ✅ 5. Run the Project

* Press `F5` or click the green ▶️ **Start** button in Visual Studio

Your project will launch at:

```
https://localhost:44364/
```

✅ BlogVerse is now up and running on your local machine!

````

---

