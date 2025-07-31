using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_3
{
    internal class BasicAuthenticationService : IAuthenticationService
    {
        public bool AuthenticateUser(string username, int password)
        {
            if (username == "ehab" && password == 123) { return true; }
            return false;
        }

      
        public bool AuthorizeUser(string username, int password, string role)
        {
            if (username == "ehab" && password == 123 && role=="admin") { return true; }
            return false;
        }
    }
}
