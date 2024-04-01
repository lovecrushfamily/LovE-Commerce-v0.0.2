using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class ShoppingCart: DLL.ShoppingCart_
    {
        public ShoppingCart() : base() { }

        //public string CustomerId;
        //public string ProducID;

        public void AddProduct(Product product)
        {
            DAO.ShoppingCart.Add(this);
        }

        public void RemoveProduct()
        {

        }

        public static ShoppingCart[] GetShoppingCarts()
        {
            return DAO.ShoppingCart.Select() as ShoppingCart[]; 
        }
    }
}
