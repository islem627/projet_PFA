using Microsoft.Extensions.Logging;

namespace app_back_.Services
{
    public class LoginService : ILoginService
    {
        private readonly ILogger<LoginService> _logger;

        public LoginService(ILogger<LoginService> logger)
        {
            _logger = logger;
        }

        public bool Login(string email, string password)
        {
            _logger.LogInformation("Validating credentials for user: {Email}", email);

            // Dummy logic for authentication (replace with real authentication logic)
            if (email == "john.doe@example.com" && password == "Password123")
            {
                _logger.LogInformation("Authentication successful for user: {Email}", email);
                return true;
            }

            _logger.LogWarning("Authentication failed for user: {Email}", email);
            return false;
        }
    }
}
