using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DLL;


namespace DAO
{
    public class Account
    {
        public static int Add(Account_ account)
        {
            return MyConnection.ExcuteScalar($"sp_insertAccount '{account.UserName}', " +
                                                                $"'{account.Password}', " +
                                                                $"'{account.AuthenticatedEmail}'" +
                                                                $"{account.Role}");
        }
        public static void Update(Account_ account)
        {

        }
        public static void Delete(Account_ account)
        {

        }
        public static void Select()
        {

        }

    }
}
