using DLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class CensorStaff
    {
        public static void Add(CensorStaff_ censorStaff_)
        {
            MyConnection.ExecuteNonQuery($"sp_insertStaff {censorStaff_.StaffID}," +
                                                        $"'{censorStaff_.StaffName}'," +
                                                        $"'{censorStaff_.PhoneNumber}'," +
                                                        $"'{censorStaff_.Image}'," +
                                                        $"'{censorStaff_.DateOfBirth}'," +
                                                        $"{censorStaff_.Gender}");

        }
        public static void Update(CensorStaff_ censorStaff_)
        {

        }
        public static void Delete(CensorStaff_ censorStaff_)
        {

        }
    }
}
