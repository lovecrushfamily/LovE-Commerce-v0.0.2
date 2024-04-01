using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DLL;

namespace BUS
{
    public class Account : Account_
    {
        //public string AccountID;
        //public string UserName;
        //public string Password;
        //public string AuthenticatedEmail;
        //public string Role;
        //public string DateOfRegister;
        //public bool RememberLogin;
        //public bool Online;

        public void Create()
        {
            DAO.Account.Add(this);

        }

        public void UpdateEmail()
        {

        }

        public void Delete()
        {
            DAO.Account.Delete(this);
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
        public static Account[] GetAccounts()
        {
            return DAO.Account.Select() as Account[];
        }

    }
}
