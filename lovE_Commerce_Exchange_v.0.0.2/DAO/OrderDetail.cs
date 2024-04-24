using System;
using System.Collections.Generic;
using System.Data;
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
                                                                $"'{orderDetail_.Discount}'," +
                                                                $"{orderDetail_.VoucherID}");

        }
        public static void Update(OrderDetail_ orderDetail_)
        {
            MyConnection.ExecuteNonQuery($"sp_updateOrderDetail {orderDetail_.OrderDetailId}, " +
                                                            $"  {orderDetail_.OrderDetailConfirmState}");
        }
        public static void Delete(OrderDetail_ orderDetail_)
        {
            MyConnection.ExecuteNonQuery($"sp_deleteOrderDetail {orderDetail_.OrderDetailId}");

        }
        public static IEnumerable<OrderDetail_> Select()
        {
            foreach(DataRow row in MyConnection.ExecuteDataTable("sp_selectOrderDetail").Rows)
            {
                yield return new OrderDetail_()
                {
                    OrderDetailId = row["OrderDetailID"].ToString(),
                    OrderId = row["OrderID"].ToString(),
                    ProductId = row["ProductID"].ToString(),
                    Quantity = row["Quantity"].ToString(),
                    UnitPrice = row["UnitPrice"].ToString(),
                    OrderDetailConfirmState = row["OrderDetailConfirmState"].ToString().ToBool(),
                    Discount = row["Discount"].ToString(),
                    VoucherID = row["VoucherID"].ToString()
                };
            }
        }
    }
}
