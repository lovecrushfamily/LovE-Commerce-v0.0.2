using DLL;
using System;
using System.Collections.Generic;
using System.Data;
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
                                                            $"{customer_.Gender.ToInt()}," +
                                                            $"'{customer_.PhoneNumber}'," +
                                                            $"'default.png'," +
                                                            $"'2000-1-1'," +
                                                            $"'updating'");
        }
        public static void Update(Customer_ customer_)
        {
            string[] date = customer_.DateOfBirth.Split(' ')[0].Split('-');
            MyConnection.ExecuteNonQuery($"sp_updateCustomer {customer_.CustomerId}," +
                                                            $"'{customer_.CustomerName}'," +
                                                            $"{customer_.Gender}," +
                                                            $"'{customer_.PhoneNumber}'," +
                                                            $"'{customer_.Image}'," +
                                                            $"{customer_.ShopOwner}," +
                                                            $"'{date[0] + '/' + date[1] +'/' + date[2]}'," +
                                                            $"'{customer_.Address}'");
        }

        public static void Delete(Customer_ customer_)
        {
            MyConnection.ExecuteNonQuery($"sp_deleteCustomer {customer_.CustomerId}");
        }

        public static IEnumerable<Customer_> Select()
        {
            foreach(DataRow row in MyConnection.ExecuteDataTable("sp_selectCustomer").Rows)
            {
                yield return new Customer_()
                {
                    CustomerId = row["CustomerID"].ToString(),
                    CustomerName = row["CustomerName"].ToString(),
                    Gender = row["Gender"].ToString(),
                    PhoneNumber = row["PhoneNumber"].ToString(),
                    Image = row["Image_"].ToString(),
                    ShopOwner = row["ShopOwner"].ToString().ToBool(),
                    DateOfBirth = row["DateOfBirth"].ToString(),
                    Address = row["Address_"].ToString()
                };
            }
        }
    }
}
