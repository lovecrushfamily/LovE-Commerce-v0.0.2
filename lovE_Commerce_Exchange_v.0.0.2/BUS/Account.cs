using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
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

        public void Add()
        {
            Password = Password.EncryptPassword();
            AccountID = DAO.Account.Add(this).ToString();
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
            string randomPassword = dbMail.CreatePassword(10);
            string[] content = dbMail.ReadRecoveryPassword().Split('?');
            dbMail.SendMail(AuthenticatedEmail, "Your verify code", htmlCode: content[0] + randomPassword + content[1])
                ;
            Password = SendEmailCode(email: AuthenticatedEmail).EncryptPassword();
            DAO.Account.Update(this);
        }

        public static string SendEmailCode(string email)
        {
            string verifyCode = dbMail.RandomVerifyCodeGenerator();
            string[] content = dbMail.ReadVerifyCodeMail().Split('?');
            dbMail.SendMail(email,"Your verify code", htmlCode: content[0] + verifyCode + content[1]);
            return verifyCode;
        }
        

        public bool ChangePassword()
        {
            return false;

        }
        public static Account[] GetAccounts()
        {
            return DAO.Account.Select().Select(a => new Account(a)).ToArray();
        }

        

        public bool VerifyExisted()
        {
            throw new NotImplementedException();
        }

        public Account SetRememberLoginOn()
        {
            RememberLogin = true;
            return this;
        }
        public Account SetRememberLoginOff()
        {
            RememberLogin = false;
            return this;
        }
    }
    public static class  SupportedFunctionAccount
    {
        public static Account GetStaffAccount(this Account[] accounts, CensorStaff staff)
        {
            return accounts.Single(account => account.AccountID == staff.StaffID);
        }

    }
}
