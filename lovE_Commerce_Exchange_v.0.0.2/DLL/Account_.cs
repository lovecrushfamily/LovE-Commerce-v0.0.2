using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLL
{
    public class Account_
    {
        public string AccountID;        // necessary
        public string UserName;
        public string Password;          // updatable
        public string AuthenticatedEmail; // updatable
        public string Role;
        public string DateOfRegister;
        public bool RememberLogin;           // updateable
        public bool Online;                 // updatable
    }
}
