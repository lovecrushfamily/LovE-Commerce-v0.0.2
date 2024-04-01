using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class OrderDetail  : DLL.OrderDetail_
    {
        public OrderDetail() { }

        //public string OrderDetailId;
        //public string OrderId;
        //public string ProductId;
        //public string Quantity;
        //public string UnitPrice;
        //public string OrderDetailConfirmState;
        //public string Discount;
        //public string VoucherID;
                      
        public void Add()
        {

        }
        public void UpdateShopConfirmation()
        {

        }

        public static OrderDetail[] GetOrderDetails()
        {
            return DAO.OrderDetail.Select() as OrderDetail[];
        }

    }
}
