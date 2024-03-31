using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class Account
    {
        public string AccountID;
        public string UserName;
        public string Password;
        public string AuthenticatedEmail;
        public string Role;
        public string DateOfRegister;
        public bool RememberLogin;
        public bool Online;


        public void Create()
        {

        }

        public void UpdateEmail()
        {

        }

        public void Delete()
        {

        }

        public void RecoveryPassword()
        {

        }

        public void SendEmailCode()
        {

        }

        public bool ChangePassword(string newPassword, string oldPassword)
        {
            return false;

        }

    }
}
