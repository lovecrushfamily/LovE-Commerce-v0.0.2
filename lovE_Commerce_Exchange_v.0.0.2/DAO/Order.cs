using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DLL;
namespace DAO
{
    public class Order
    {
        public static int Add(Order_ order_)
        {
            return MyConnection.ExcuteScalar($"sp_insertOrder {order_.CustomerID}," +
                                                            $"'{order_.TotalAmount}'");

        }
        public static void Update(Order_ order_)
        {
            int CustomerOrderState = order_.CustomerOrderState ? 1 : 0;
            int OrderConfirmState = order_.OrderConfirmState ? 1 : 0;
            int ReceivedState = order_.ReceivedState ? 1 : 0;
            MyConnection.ExecuteNonQuery($"sp_updateOrder {order_.OrderId}," +
                                                            $"{CustomerOrderState}," +
                                                            $"{OrderConfirmState}," +
                                                            $"{ ReceivedState}");
        }
        public static void Delete(Order_ order_)
        {
            MyConnection.ExecuteNonQuery($"sp_deleteOrder {order_.OrderId}");

        }
        public static IEnumerable<Order_> Select()
        {
            foreach(DataRow row in MyConnection.ExecuteDataTable("sp_selectOrder").Rows)
            {
                yield return new Order_()
                {
                    OrderId = row["OrderID"].ToString(),
                    CustomerID = row["CustomerID"].ToString(),
                    TotalAmount = row["TotalAmount"].ToString(),
                    Date = row["DateOrder"].ToString(),
                    CustomerOrderState = row["CustomerOrderState"].ToString().ToBool(),
                    OrderConfirmState = row["OrderConfirmState"].ToString().ToBool(),
                    ReceivedState = row["ReceivedState"].ToString().ToBool()
                };
            }
        }
    }
}
