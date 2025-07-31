using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_3
{
    internal interface IAuthenticationService
    {

        bool AuthenticateUser(string username, int password);
        bool AuthorizeUser(string username, int password ,string role );

    }



}
