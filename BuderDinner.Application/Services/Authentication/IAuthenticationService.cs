namespace BuderDinner.Application.Services.Authentication;

public interface IAuthenticationService
{
    AuthenticationResult Login(string email, string Password);

    AuthenticationResult Register(string firstName, string lastName, string email, string password);
}