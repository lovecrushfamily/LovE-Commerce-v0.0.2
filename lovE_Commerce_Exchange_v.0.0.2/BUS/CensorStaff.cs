using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class CensorStaff  : DLL.CensorStaff_
    {

        public CensorStaff() { }

        //public string StaffID;
        //public string StaffName;
        //public string PhoneNumber;
        //public string Image;
        //public string DateOfBirth;
        //public string Gender;


        public void UpdatePersonalInformation()
        {

        }

        public void Add()
        {

        }

        public static CensorStaff[] GetCensorStaff()
        {
            return DAO.CensorStaff.Select() as CensorStaff[];
        }


    }
}
