using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Interfaces
{
    interface IAuthenticationService
    {
        public bool AuthenticateUser(string? userName, string? password);

        public bool AuthorizeUser(string? userName, string? role);

    }
}
