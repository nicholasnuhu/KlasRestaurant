using KlasRestaurant.Application.Commons.Interface.Authentication;
using KlasRestaurant.Application.Commons.Interface.Persistence;
using KlasRestaurant.Domain.Entities;

namespace KlasRestaurant.Application.Services.Authentication;

public class AuthenticationService : IAuthenticationService
{
    private readonly IJwtTokenGenerator _jwtTokenGenerator;
    private readonly IUserRepository _userRepository;

    public AuthenticationService(IJwtTokenGenerator jwtTokenGenerator, IUserRepository userRepository)
    {
        _jwtTokenGenerator = jwtTokenGenerator;
        _userRepository = userRepository;
    }

    public AuthenticationServiceResponse Login(string email, string password)
    {
        //check if user email exists
        var user = _userRepository.GetUserByEmail(email);
        if(user is null)
            throw new Exception("Email does not exist");
        //check if password is correct
        if(user.Password != password)
            throw new Exception("Password is incorrect");
        //generate token
        var token = _jwtTokenGenerator.GenerateToken(user);
        var Authresponse = new AuthenticationServiceResponse(
            user,
            token);
            return Authresponse;
    }

    public AuthenticationServiceResponse Register(string firstName, string lastName, string email, string password, string confirmPassword)
    {
        //validate if the given user already exists
        var user = _userRepository.GetUserByEmail(email);
        if(user is not null)
            throw new Exception("User with the given email already exists");
        //Create user(generate id) and persist to database
        
        var newUser = new User
        {
            FirstName = firstName,
            LastName = lastName,
            Email = email,
            Password = password,
            ConfirmPassword = confirmPassword
        };

        _userRepository.AddUser(newUser);
        //generate token
        var token = _jwtTokenGenerator.GenerateToken(newUser);
        var Authresponse = new AuthenticationServiceResponse(
            newUser,
            token);

            return Authresponse;
    }
}