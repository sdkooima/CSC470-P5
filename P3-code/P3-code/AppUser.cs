using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P3_code
{
    public class AppUser
    {
        public AppUser()
        {

        }

        public AppUser(int fail)
        {
            UserName = "No user found";
            Password = "No user found";
            FirstName = "No user found";
            LastName = "No user found";
            EmailAddress = "No user found";
            IsAuthenticated = false;
        }

        public string UserName;
        public string Password;
        public string FirstName;
        public string LastName;
        public string EmailAddress;
        public bool IsAuthenticated;
    }
}
