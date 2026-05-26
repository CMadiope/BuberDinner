using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ErrorOr;

namespace BuberDinner.Domain.Common.Errors
{
    public static partial class Errors
    {
        public class Authentication
        {
            public static Error InvalidCredentials => Error.Validation(code: "InvalidCredentials", description: "Invalid email or password.");
        }
    }
}