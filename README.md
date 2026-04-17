# 🎓 Student Management System API

A secure and scalable **Student Management System API** built using ASP.NET Core Web API with JWT Authentication.

---

## 🚀 Features

* 📌 Get all students
* ➕ Add new student
* ✏️ Update student
* ❌ Delete student
* 🔐 JWT Authentication (secure APIs)
* ⚠️ Global Exception Handling Middleware
* 📄 Swagger API Documentation
* 🧱 Layered Architecture (Controller, Service, Repository)

---

## 🛠️ Tech Stack

* ASP.NET Core Web API
* Entity Framework Core
* SQL Server
* JWT Authentication
* Swagger

---

## 📁 Project Structure

```
StudentManagementAPI
│
├── Controllers      → API endpoints  
├── Services         → Business logic  
├── Repositories     → Data access  
├── Models           → Entity models  
├── Data             → DbContext  
├── Middleware       → Exception handling  
```

---

## 🗄️ Database Setup

Run the following SQL:

```sql
CREATE DATABASE StudentDB;

USE StudentDB;

CREATE TABLE Students (
    Id INT PRIMARY KEY IDENTITY,
    Name NVARCHAR(100),
    Email NVARCHAR(100),
    Age INT,
    Course NVARCHAR(100),
    CreatedDate DATETIME DEFAULT GETDATE()
);
```

---

## ⚙️ Setup Instructions

### 1️⃣ Clone Repository

```
git clone https://github.com/saurab09876/student-management-api.git
```

---

### 2️⃣ Configure Database

Create `appsettings.json`:

```json
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=.;Database=StudentDB;Trusted_Connection=True;TrustServerCertificate=True;"
  }
}
```

---

### 3️⃣ Run Project

* Open in Visual Studio
* Press **F5**

---

## 🔐 Authentication (JWT)

### Login API

```
POST /api/auth/login?username=admin&password=123
```

---

### Use Token

Swagger → Authorize:

```
Bearer YOUR_TOKEN
```

---

## 📡 API Endpoints

| Method | Endpoint          | Description      |
| ------ | ----------------- | ---------------- |
| GET    | /api/student      | Get all students |
| POST   | /api/student      | Add student      |
| PUT    | /api/student      | Update student   |
| DELETE | /api/student/{id} | Delete student   |

---

## ⚠️ Error Handling

* Global Exception Middleware implemented
* Returns proper error responses

---

## 🔒 Security

* JWT Authentication
* Protected APIs


---

## 👨‍💻 Author

**Saurab**

---

## ⭐ Notes

This project was built as part of a technical assignment and demonstrates clean architecture and API development best practices.
