# 🔐 SafeVault: Secure Authentication & Authorization System  


SafeVault is a **secure authentication system** built using **ASP.NET Core & SQL Server**. It includes **JWT authentication, role-based access control (RBAC), SQL injection prevention, and XSS protection**.  

---

## 🚀 Features  

| Feature                  | Description |
|--------------------------|-------------|
| ✅ **User Authentication** | Secure login & signup with password hashing |
| ✅ **Role-Based Access** | Admin/User roles with authorization |
| ✅ **JWT Authentication** | Token storage in **HTTP-only cookies** |
| ✅ **SQL Injection Prevention** | Uses parameterized queries |
| ✅ **XSS Protection** | HTML encoding for user inputs |
| ✅ **Unit Tests** | Security testing with **NUnit & xUnit** |

---

## 🛠️ Tech Stack  

- **Backend:** ASP.NET Core, C#  
- **Frontend:** Razor Pages (ASP.NET)  
- **Database:** SQL Server (SSMS)  
- **Authentication:** JWT, BCrypt for password hashing  
- **Security:** SQL Injection & XSS Protection  
- **Testing:** NUnit, xUnit  

---

## 📂 Project Structure  

SafeVault.Web/
│-- Controllers/       # Authentication & Role-Based Access API
│-- Models/            # User, Role, and Authentication Models
│-- Views/             # Razor UI (Login, Signup, Dashboard)
│-- Services/          # Authentication & Security Services
│-- Data/              # Database Context & Migrations
│-- Tests/             # Security & Authentication Unit Tests
│-- wwwroot/           # Frontend assets (CSS, JS)
│-- appsettings.json   # Configuration file (Database, JWT)
│-- Program.cs         # Application entry point
│-- Startup.cs         # Middleware & Dependency Injection

---

# 🔍 Security Measures Implemented
🔹 SQL Injection Prevention → Uses parameterized queries (@parameter)
🔹 XSS Protection → Uses HTML encoding for user inputs
🔹 JWT-Based Authentication → Tokens stored in HTTP-only cookies
🔹 Password Security → Uses BCrypt hashing for password storage
🔹 RBAC (Role-Based Access Control) → Users assigned Admin/User roles
🔹 Unit Tests for Security → Ensures authentication & security features work

---

# 📬 Contact & Contributions
🔹 If you find security vulnerabilities, please report them via GitHub Issues.
🔹 Contributions are welcome! Fork and submit pull requests.

# 📌 GitHub Repository: SafeVault.Web

# 🔥 Secure Your Applications with SafeVault! 🚀







