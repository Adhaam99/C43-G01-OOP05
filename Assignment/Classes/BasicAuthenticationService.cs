using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Classes
{
    class BasicAuthenticationService: IAuthenticationService
    {
        public BasicAuthenticationService(string? userName, string? password, string? role)
        {
            UserName = userName;
            Password = password;
            Role = role;
        }

        public string? UserName { get; set; }

        public string? Password { get; set; }

        public string? Role { get; set; }
        public bool AuthenticateUser(string? userName, string? password)
        {
            
            if (UserName == userName && Password == password)
                return true;
            else
                return false;
        }

        public bool AuthorizeUser(string? userName, string? role)
        {

            if (UserName == userName && Role == role)
              return true;
            else
                return false;
            
        }

    }

}
