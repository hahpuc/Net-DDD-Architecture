using BuderDinner.Application.Common.Interfaces.Authentication;

namespace BuderDinner.Application.Services.Authentication;

public class AuthenticationService : IAuthenticationService
{
    private readonly IJwtTokenGenerator _jwtTokenGenerator;

    public AuthenticationService(IJwtTokenGenerator iwtTokenGenerator)
    {
        _jwtTokenGenerator = iwtTokenGenerator;
    }

    public AuthenticationResult Register(string firstName, string lastName, string email, string password)
    {

        // Check if user exist 

        // Create user

        // Create JWT Token 
        var userId = Guid.NewGuid();
        var token = _jwtTokenGenerator.GenerateToken(userId, firstName, lastName);

        return new AuthenticationResult(userId,
                                        firstName,
                                        lastName,
                                        email,
                                        token);
    }

    public AuthenticationResult Login(string email, string Password)
    {
        return new AuthenticationResult(Guid.NewGuid(),
                                        "FirstName",
                                        "LastName",
                                        email,
                                        "Token");
    }
}