namespace app_back_.Services
{
    public interface ILoginService
    {
        bool Login(string email, string password);
    }
}
