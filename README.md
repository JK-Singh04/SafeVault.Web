# 🔐 SafeVault: Secure Authentication & Authorization System  

![SafeVault Logo](https://via.placeholder.com/600x200?text=SafeVault)  

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

```bash
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

##SafeVault: Secure Authentication & Authorization System
#📌 Project Overview
SafeVault is a secure authentication and authorization system built using ASP.NET Core, Razor Pages, and SQL Server. It implements best security practices such as JWT-based authentication, role-based access control (RBAC), input validation, SQL injection prevention, and XSS protection.

#🚀 Features
✅ User Authentication (Login, Signup with secure password hashing)
✅ Role-Based Access Control (RBAC) (Admin/User roles)
✅ JWT Authentication (Secure token handling via HTTP-only cookies)
✅ SQL Injection Prevention (Parameterized queries)
✅ XSS Protection (HTML encoding of user input)
✅ Unit Tests for Security (NUnit & xUnit test cases)
✅ Secure Database Integration (SQL Server)

#🔧 Technologies Used
Backend: ASP.NET Core, C#
Frontend: Razor Pages (ASP.NET)
Database: SQL Server (SSMS)
Authentication: JWT (JSON Web Tokens), BCrypt for password hashing
Security Measures: SQL injection prevention, XSS mitigation, Role-based access
Testing Frameworks: NUnit, xUnit

#🛠️ Installation & Setup
1️⃣ Clone the Repository
git clone https://github.com/YourGitHubUsername/SafeVault.git
cd SafeVault.Web
2️⃣ Configure Database
Open appsettings.json and update your SQL Server connection string:
"ConnectionStrings": {
    "DefaultConnection": "Server=YOUR_SERVER;Database=SafeVaultDB;Trusted_Connection=True;"
}
Run Database Migration
dotnet ef database update
3️⃣ Run the Application
dotnet run
Application will run at http://localhost:5000/

#🔍 Security Measures Implemented
🔹 SQL Injection Prevention → Uses parameterized queries (@parameter)
🔹 XSS Protection → Uses HTML encoding for user inputs
🔹 JWT-Based Authentication → Tokens stored in HTTP-only cookies
🔹 Password Security → Uses BCrypt hashing for password storage
🔹 RBAC (Role-Based Access Control) → Users assigned Admin/User roles
🔹 Unit Tests for Security → Ensures authentication & security features work

#✅ Unit Testing with NUnit & xUnit
Run security tests using:

dotnet test
✔ SQL Injection Tests
✔ XSS Protection Tests
✔ Authentication Tests
✔ RBAC (Role-Based Access) Tests

#🚀 Deployment
Build & Publish the Application
dotnet publish -c Release -o publish
Host on IIS / Azure / Docker / GitHub Pages

#📜 License
This project is open-source under the MIT License.

#📬 Contact & Contributions
🔹 If you find security vulnerabilities, please report them via GitHub Issues.
🔹 Contributions are welcome! Fork and submit pull requests.

📌 GitHub Repository: SafeVault.Web

🔥 Secure Your Applications with SafeVault! 🚀







