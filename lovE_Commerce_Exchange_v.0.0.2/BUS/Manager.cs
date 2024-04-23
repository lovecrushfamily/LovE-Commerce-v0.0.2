using DLL;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class Manager: Manager_ , Entity
    {
        public Manager(Manager_ manager_)
        {
            USerName = manager_.USerName;
            Password = manager_.Password;
            ManagerName = manager_.ManagerName;
            Role = manager_.Role;
        }
        
        public static string GetAdminFilePath()
        {
            string currentDirectory = @Directory.GetCurrentDirectory().Substring(1, Directory.GetCurrentDirectory().Length - 14);
            return ("D" + @currentDirectory + "Manager\\administrator.txt").Replace("\\", "/");
        }

        public static string ReadAdminFileData()
        {
            return File.ReadAllText(GetAdminFilePath());
        }

        public static void WriteAdminFileData(string data)
        {
            File.WriteAllText(GetAdminFilePath(), data);
        }


    }
}
