using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public  class dbMail
    {
        public static void SendMail(string email, string header, string htmlCode)
        {
            MyConnection.ExecuteNonQuery($"sendmail '{email}', '{header}', '{htmlCode}'");
        }
        //public static void
        public static string ReadVerifyCodeMail()
        {
            string currentDirectory = @Directory.GetCurrentDirectory().Substring(1, Directory.GetCurrentDirectory().Length - 14);
            string verifyEmailPath = "D" + @currentDirectory + @"MailTemplate\" + "VerifyEmailCode.html";
            return File.ReadAllText(verifyEmailPath.Replace("\\", "/"), UTF8Encoding.UTF8);
        }
        public static string RandomVerifyCodeGenerator()
        {
            Random random = new Random();
            return random.Next(100000, 999999).ToString();
        }
     
        public static string CreatePassword(int length)
        {
            const string valid = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
            StringBuilder res = new StringBuilder();
            Random rnd = new Random();
            while (0 < length--)
            {
                res.Append(valid[rnd.Next(valid.Length)]);
            }
            return res.ToString();
        }

        public static string ReadRecoveryPassword()
        {
            string currentDirectory = @Directory.GetCurrentDirectory().Substring(1, Directory.GetCurrentDirectory().Length - 14);
            string forgetPaswordPath = "D" + @currentDirectory + @"MailTemplate\" + "ForgetPasswordMail.html";
            return File.ReadAllText(forgetPaswordPath.Replace("\\", "/"),  UTF8Encoding.UTF8);


        }
    }
}
