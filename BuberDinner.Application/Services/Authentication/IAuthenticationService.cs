using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BuberDinner.Application.Common.Errors;
using ErrorOr;
using FluentResults;

namespace BuberDinner.Application.Services.Authentication
{
    public interface IAuthenticationService
    {
        ErrorOr<AuthenticationResult> Register(string firstName, string lastName, string email, string password);
        ErrorOr<AuthenticationResult> Login(string email, string password);
    }
}