
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class Order  : DLL.Order_, Entity
    {

        public Order(DLL.Order_ order_)
        {
            OrderId = order_.OrderId;
            CustomerID = order_.CustomerID;
            TotalAmount = order_.TotalAmount;
            Date = order_.Date;
            CustomerOrderState = order_.CustomerOrderState;
            OrderConfirmState = order_.OrderConfirmState;
            ReceivedState = order_.ReceivedState;           
        }


        public void Add()
        {

        }

        public void Remove()
        {

        }

        public void UpdateReceivedState()
        {

        }

        public void UpdateCustomerOrderState()
        {

        }

        public void UpdateOrderConfirmState()
        {

        }

        public static Order[] GetOrders()
        {
            return DAO.Order.Select().Select(c => new Order(c)).ToArray();
        }
    }
}
