using DLL;
using System;
using System.Collections.Generic;
using System.Data;
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
            MyConnection.ExecuteNonQuery($"sp_updateStaff {censorStaff_.StaffID}," +
                                                            $"'{censorStaff_.StaffName}'," +
                                                            $"'{censorStaff_.PhoneNumber}'," +
                                                            $"'{censorStaff_.Image}'," +
                                                            $"'{censorStaff_.DateOfBirth}'," +
                                                            $"{censorStaff_.Gender}");
        }

        public static IEnumerable<CensorStaff_> Select()
        {
            foreach (DataRow row in MyConnection.ExecuteDataTable("sp_selectStaff").Rows)
            {
                yield return new CensorStaff_()
                {
                    StaffID = row["StaffID"].ToString(),
                    StaffName = row["StaffName"].ToString(),
                    PhoneNumber = row["PhoneNumber"].ToString(),
                    Image = row["Image_"].ToString(),
                    DateOfBirth = row["DateOfBirth"].ToString(),
                    Gender = row["Gender"].ToString()
                };
            }
        }
    }
}
