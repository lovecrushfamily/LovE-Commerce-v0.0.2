using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DLL;

namespace BUS
{
    public class Account : Account_ , Entity
    {
        
        public  Account(Account_ account)
        {
            AccountID = account.AccountID;
            UserName = account.UserName;
            Password = account.Password;
            AuthenticatedEmail = account.AuthenticatedEmail;
            Role = account.Role;
            DateOfRegister = account.DateOfRegister;
            RememberLogin = account.RememberLogin;
            Online = account.Online;           
        }

        public void Create()
        {
            DAO.Account.Add(this);
        }

        public void Update()
        {
            DAO.Account.Update(this);
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

        public bool ChangePassword()
        {
            return false;

        }
        public static Account[] GetAccounts()
        {
            return DAO.Account.Select().Select(a => new Account(a)).ToArray();
        }

    }
}
