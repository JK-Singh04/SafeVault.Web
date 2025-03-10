using System.Text.RegularExpressions;

namespace SafeVault.Web.Security
{
    public class InputValidator
    {
        public static bool IsValidInput(string input)
        {
            // Prevent SQL Injection and XSS
            string pattern = @"[;'\-\-]|(<script)|(\bSELECT\b|\bDROP\b|\bINSERT\b|\bDELETE\b)";
            return !Regex.IsMatch(input, pattern, RegexOptions.IgnoreCase);
        }
    }
}
