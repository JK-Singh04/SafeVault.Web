using Microsoft.AspNetCore.Routing;
using NUnit.Framework;
using System;
using System.Web;
using Microsoft.Data.SqlClient;

namespace SafeVault.Tests
{
    [TestFixture]
    public class SecurityTests
    {
        private const string connectionString = "Your_Connection_String_Here";

        [Test]
        public void TestSQLInjectionPrevention()
        {
            string maliciousInput = "'; DROP TABLE Users; --";
            bool isInjected = CheckSQLInjection(maliciousInput);
            Assert.That(isInjected, Is.False, "SQL Injection vulnerability found!");
        }

        private bool CheckSQLInjection(string input)
        {
            try
            {
                using (var conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (var cmd = new SqlCommand("SELECT * FROM Users WHERE Username = @Username", conn))
                    {
                        cmd.Parameters.AddWithValue("@Username", input);
                        using (var reader = cmd.ExecuteReader())
                        {
                            return reader.HasRows;
                        }
                    }
                }
            }
            catch
            {
                return true;
            }
        }

        [Test]
        public void TestXSSPrevention()
        {
            string xssInput = "<script>alert('XSS Attack!');</script>";
            string sanitizedOutput = HttpUtility.HtmlEncode(xssInput);
            Assert.That(xssInput, Is.Not.EqualTo(sanitizedOutput), "XSS vulnerability detected!");
        }

        [Test]
        public void TestUserAuthentication()
        {
            string testUsername = "testUser";
            string testPassword = "SecureP@ssw0rd";
            bool isAuthenticated = AuthenticateUser(testUsername, testPassword);
            Assert.That(isAuthenticated, Is.True, "User authentication failed!");
        }

        private bool AuthenticateUser(string username, string password)
        {
            using (var conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (var cmd = new SqlCommand("SELECT COUNT(1) FROM Users WHERE Username = @Username AND PasswordHash = HASHBYTES('SHA2_256', @Password)", conn))
                {
                    cmd.Parameters.AddWithValue("@Username", username);
                    cmd.Parameters.AddWithValue("@Password", password);
                    int count = (int)cmd.ExecuteScalar();
                    return count > 0;
                }
            }
        }

        [Test]
        public void TestRBAC()
        {
            string adminRole = GetUserRole("adminUser");
            string userRole = GetUserRole("regularUser");

            Assert.That(adminRole, Is.EqualTo("Admin"), "Admin user role incorrect!");
            Assert.That(userRole, Is.EqualTo("User"), "Regular user role incorrect!");
        }

        private string GetUserRole(string username)
        {
            using (var conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (var cmd = new SqlCommand("SELECT Role FROM Users WHERE Username = @Username", conn))
                {
                    cmd.Parameters.AddWithValue("@Username", username);
                    var result = cmd.ExecuteScalar();
                    return result?.ToString() ?? string.Empty;
                }
            }
        }

    }
}
