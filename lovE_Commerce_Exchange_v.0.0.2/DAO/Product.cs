using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DLL;

namespace DAO
{
    public class Product
    {
        public static void Add(Product_ product_)
        {
            MyConnection.ExecuteNonQuery($"sp_insertProduct {product_.ProductId}," +
                                                            $"'{product_.ProductName}'," +
                                                            $"'{product_.Description}'," +
                                                            $"'{product_.Price}'," +
                                                            $"{product_.Quantity}," +
                                                            $"'{product_.AttributeList}'," +
                                                            $"'{product_.MainImage}'," +
                                                            $"'{product_.ExtraImageList}'," +
                                                            $"{product_.CategoryID}," +
                                                            $"{product_.ShopID}");

        }
        public static void Update(Product_ product_)
        {

        }
        public static void Delete(Product_ product_)
        {

        }
    }
}
