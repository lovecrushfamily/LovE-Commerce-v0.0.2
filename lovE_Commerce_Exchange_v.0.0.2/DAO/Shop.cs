using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DLL;

namespace DAO
{
    public class Shop
    {
        public static void Add(Shop_ shop_)
        {
            MyConnection.ExecuteNonQuery($"sp_insertShop '{shop_.ShopName}'," +
                                                        $"'{shop_.Description}'," +
                                                        $"'{shop_.Address}'," +
                                                        $"'{shop_.PhoneNumber}'," +
                                                        $"'{shop_.Image}'," +
                                                        $"{shop_.ShopOwner}");
        }
        public static void Update(Shop_ shop_)
        {
            MyConnection.ExecuteNonQuery($"sp_updateShop {shop_.ShopId}," +
                                                        $"'{shop_.ShopName}'," +
                                                        $"'{shop_.Description}'," +
                                                        $"'{shop_.Address}'," +
                                                        $"'{shop_.Image}'");
        }
        public static void Delete(Shop_ shop_)
        {
            MyConnection.ExecuteNonQuery($"sp_deleteShop {shop_.ShopId}");
        }
        public static IEnumerable<Shop_> Select()
        {
            foreach( DataRow row in MyConnection.ExecuteDataTable("sp_selectShop").Rows)
            {
                yield return new Shop_()
                {
                    ShopId = row["ShopID"].ToString(),
                    ShopName = row["ShopName"].ToString(),
                    Description = row["Description_"].ToString(),
                    Address = row["Address_"].ToString(),
                    PhoneNumber = row["PhoneNumber"].ToString(),
                    Date = row["Date_"].ToString(),
                    Image = row["Image_"].ToString(),
                    ShopOwner  = row["OwnerID"].ToString()
                    
                };
            }
        }
    }
}
