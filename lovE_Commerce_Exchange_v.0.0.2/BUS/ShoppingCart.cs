using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DLL;

namespace BUS
{
    public class ShoppingCart: ShoppingCart_ , Entity
    {
        public ShoppingCart(ShoppingCart_ shoppingCart_)
        {
            CustomerId = shoppingCart_.CustomerId;
            ProducID = shoppingCart_.ProducID;
        }

        public void AddProduct()
        {
            DAO.ShoppingCart.Add(this);
        }

        public void RemoveProduct()
        {

        }

        public static ShoppingCart[] GetShoppingCarts()
        {
            return DAO.ShoppingCart.Select().Select(c => new ShoppingCart(c)).ToArray(); 
        }
    }
}
