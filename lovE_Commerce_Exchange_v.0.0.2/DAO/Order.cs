using System;
using System.Collections.Generic;
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

        }
        public static void Delete(Order_ order_)
        {

        }
    }
}
