using System;
using app_back_.Models;
using Microsoft.EntityFrameworkCore;
namespace app_back_.Services
{
    public class LogoutService : ILogoutService
    {
        public bool Logout(string email)
        {
            if (!string.IsNullOrEmpty(email))
            {
                // Here you could add logic to invalidate the JWT token, clear session, etc.
                Console.WriteLine($"User with email {email} has been logged out.");

                // Assume logout was successful
                return true;
            }

            // Logout failed if email was not valid
            return false;
        }
    }
}
