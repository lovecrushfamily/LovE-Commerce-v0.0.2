using System;
using System.Collections.Generic;
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

        }
        public static ShoppingCart_[] Select()
        {
            return new ShoppingCart_[0] { };

        }
    }
}
