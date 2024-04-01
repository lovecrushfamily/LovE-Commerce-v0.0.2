using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DLL;

namespace DAO
{
    public class ShoppingCart
    {
        public static void Add(ShoppingCart_ shoppingCart_)
        {
            MyConnection.ExecuteNonQuery($"sp_insertShoppingCart {shoppingCart_.CustomerId}, " +
                                                                $"{shoppingCart_.ProducID}");

        }
        public static void Delete(ShoppingCart_ shoppingCart_)
        {
            MyConnection.ExecuteNonQuery($"sp_deleteShoppingCart {shoppingCart_.CustomerId}, " +
                                                                $"{shoppingCart_.ProducID}");

        }

        public static IEnumerable<ShoppingCart_> Select()
        {
            foreach ( DataRow row in MyConnection.ExecuteDataTable("sp_selectShoppingCart").Rows)
            {
                yield return new ShoppingCart_()
                {
                    CustomerId = row["CustomerID"].ToString(),
                    ProducID = row["ProductID"].ToString()
                };
            }
        }
    }
}
