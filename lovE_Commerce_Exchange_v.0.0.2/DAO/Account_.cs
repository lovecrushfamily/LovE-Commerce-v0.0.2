using System;
using System.Collections.Generic;
using System.Data;
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
            MyConnection.ExecuteNonQuery($"sp_updateAccount {account.AccountID}," +
                                                            $"'{account.Password}'," +
                                                            $"'{account.AuthenticatedEmail}'," +
                                                            $"{account.RememberLogin}," +
                                                            $"{account.Online}");
        }
        public static void Delete(Account_ account)
        {
            MyConnection.ExecuteNonQuery($"sp_deleteAccount {account.AccountID}");

        }
        public static IEnumerable<Account_> Select()
        {
            foreach (DataRow row in MyConnection.ExecuteDataTable("sp_selectAccount").Rows)
            {
                yield return new Account_()
                {
                    AccountID = row["AccountID"].ToString(),
                    UserName = row["Username"].ToString(),
                    Password = row["Password_"].ToString(),
                    AuthenticatedEmail = row["AuthenticatedEmail"].ToString(),
                    Role = row["Role_"].ToString(),
                    DateOfRegister = row["DateOfRegistry"].ToString(),
                    RememberLogin = row["RememberLogin"].ToString().ToBool(),
                    Online = row["Online_"].ToString().ToBool()
                };
            }
        }
    }
}

