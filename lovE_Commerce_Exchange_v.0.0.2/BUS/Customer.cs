using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class Customer  : DLL.Customer_
    {
        //public string CustomerId;
        //public string CustomerName;
        //public string Gender;
        //public string PhoneNumber;
        //public string Image;
        //public bool ShopOwner;
        //public string DateOfBirth;
        //public string Address;

        public Customer() { }   

        public void Update()
        {

        }

        public static Customer[] GetCustomers()
        {
            return DAO.Customer.Select() as Customer[];
        }
    }
}
