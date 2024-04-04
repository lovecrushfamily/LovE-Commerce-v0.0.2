using DLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class CensorStaff  : DLL.CensorStaff_, Entity
    {

        public CensorStaff(CensorStaff_ bas)
        {
            StaffID = bas.StaffID;
            StaffName = bas.StaffName;
            PhoneNumber = bas.PhoneNumber;
            Image = bas.Image;
            DateOfBirth = bas.DateOfBirth;
            Gender = bas.Gender;
        }

        public void UpdatePersonalInformation()
        {

        }

        public void Add()
        {

        }

        public static CensorStaff[] GetCensorStaff()
        {
            return DAO.CensorStaff.Select().Select(c => new CensorStaff(c)).ToArray();
        }


    }
}
