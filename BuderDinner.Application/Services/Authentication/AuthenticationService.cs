namespace BuderDinner.Application.Services.Authentication;

public class AuthenticationService : IAuthenticationService
{
    public AuthenticationResult Register(string firstName, string lastName, string email, string password)
    {
        return new AuthenticationResult(Guid.NewGuid(), firstName, lastName, email, "Token");
    }

    public AuthenticationResult Login(string email, string Password)
    {
        return new AuthenticationResult(Guid.NewGuid(), "FirstName", "LastName", email, "Token");
    }
}