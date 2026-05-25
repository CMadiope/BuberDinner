using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BuberDinner.Application.Common.Authentication;
using BuberDinner.Application.Common.Interfaces.Persistence;
using BuberDinner.Domain.Entities;

namespace BuberDinner.Application.Services.Authentication
{
    public class AuthenticationService : IAuthenticationService
    {
        private readonly IJwtTokenGenerator _jwtTokenGenerator;
        private readonly IUserRepository _userRepository;

        public AuthenticationService(IJwtTokenGenerator jwtTokenGenerator, IUserRepository userRepository)
        {
            _jwtTokenGenerator = jwtTokenGenerator;
            _userRepository = userRepository;
        }

        public AuthenticationResult Register(string firstName, string lastName, string email, string password)
        {
            // check if user exists
            if (_userRepository.GetUserByEmail(email) is not null)
            {
                throw new InvalidOperationException("User with this email already exists.");
            }

            // Create user (generate unique id)
            var user = new User
            {
                FirstName = firstName,
                LastName = lastName,
                Email = email,
                Password = password
            };
            _userRepository.Add(user);

            // Create JWT token
            var token = _jwtTokenGenerator.GenerateToken(user);

            return new AuthenticationResult(user, token);
        }
        public AuthenticationResult Login(string email, string password)
        {
            // check if user exists
            if (_userRepository.GetUserByEmail(email) is not User user)
            {
                throw new InvalidOperationException("User with this email does not exist.");
            }

            // check if password is correct
            if (user.Password != password)
            {
                throw new InvalidOperationException("Invalid password.");
            }


            // Create JWT token
            var token = _jwtTokenGenerator.GenerateToken(user);

            return new AuthenticationResult(user, token);
        }


    }
}