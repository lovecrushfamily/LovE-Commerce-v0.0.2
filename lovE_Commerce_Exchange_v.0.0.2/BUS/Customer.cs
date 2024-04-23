using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class Customer : DLL.Customer_, Entity
    {

        public Customer(DLL.Customer_ customer_)
        {
            CustomerId = customer_.CustomerId;    
            CustomerName = customer_.CustomerName;
            Gender  = customer_.Gender;
            PhoneNumber = customer_.PhoneNumber;
            Image = customer_.Image;
            ShopOwner = customer_.ShopOwner;
            DateOfBirth = customer_.DateOfBirth;    
            Address = customer_.Address;
        }

        public void Add()
        {
            DAO.Customer.Add(this);
        }

        public void Update()
        {
            DAO.Customer.Update(this);

        }

        public static Customer[] GetCustomers()
        {
            return DAO.Customer.Select().Select(c => new Customer(c)).ToArray();
        }

        public Customer SetShopOwnerOn()
        {
            ShopOwner = true;
            return this;
        }
    }
}
