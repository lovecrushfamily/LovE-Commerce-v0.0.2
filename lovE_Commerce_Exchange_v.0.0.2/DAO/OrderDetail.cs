using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DLL;
namespace DAO
{
    public class OrderDetail
    {
        public static void Add(OrderDetail_ orderDetail_)
        {
            MyConnection.ExecuteNonQuery($"sp_insertOrderDetail {orderDetail_.OrderId}," +
                                                                $"{orderDetail_.ProductId}," +
                                                                $"{orderDetail_.Quantity}," +
                                                                $"'{orderDetail_.UnitPrice}'," +
                                                                $"'{orderDetail_.Discount}'" +
                                                                $"{orderDetail_.VoucherID}");

        }
        public static void Update(OrderDetail_ orderDetail_)
        {

        }
        public static void Delete(OrderDetail_ orderDetail_)
        {

        }
    }
}
