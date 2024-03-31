using DLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class Customer
    {
        public static void Add(Customer_ customer_)
        {
            MyConnection.ExecuteNonQuery($"sp_insertCustomer {customer_.CustomerId}," +
                                                            $"'{customer_.CustomerName}'," +
                                                            $"{customer_.Gender}," +
                                                            $"'{customer_.PhoneNumber}'," +
                                                            $"'{customer_.Image}'," +
                                                            $"'{customer_.DateOfBirth}'," +
                                                            $"'{customer_.Address}'");

        }
        public static void Update(Customer_ customer_)
        {

        }
        public static void Delete(Customer_ customer_)
        {

        }
    }
}
