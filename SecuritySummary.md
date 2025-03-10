# Security Summary – SafeVault Capstone Project

## 🛑 Identified Vulnerabilities:
1️⃣ **SQL Injection Risk:**  
   - Found in user authentication query.
   - Fixed by implementing **parameterized queries**.

2️⃣ **XSS Vulnerability:**  
   - Found in input fields where users could enter JavaScript.
   - Fixed using **input validation** and `HttpUtility.HtmlEncode()`.

3️⃣ **Weak Password Storage:**  
   - Previously stored plaintext passwords.
   - Fixed by implementing **SHA2-256 hashing with salt**.

4️⃣ **Role-Based Access Control (RBAC) Bypass:**  
   - Previously, users could access admin routes.
   - Fixed by enforcing **role checks in middleware**.

## 🔧 How Microsoft Copilot Assisted:
✔ Suggested **parameterized queries** to prevent SQL injection.  
✔ Recommended **input validation functions** for XSS prevention.  
✔ Provided **secure hashing methods** for password storage.  
✔ Helped implement **JWT-based authentication**.  

## ✅ Final Fixes Implemented:
🔹 SQL Injection prevention ✅  
🔹 XSS Attack mitigation ✅  
🔹 Secure password storage (SHA2-256) ✅  
🔹 Role-Based Authorization ✅  

---
