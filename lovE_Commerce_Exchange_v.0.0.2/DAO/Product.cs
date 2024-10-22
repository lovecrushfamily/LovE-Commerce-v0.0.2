﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DLL;

namespace DAO
{
    public class Product

        //.Replace('\'', '’')
    {
        public static void Add(Product_ product_)
        {
            MyConnection.ExecuteNonQuery($"sp_insertProduct "+
                                                            $"'{product_.ProductName}'," +
                                                            $"'{product_.Description.Replace('\'', '’')}'," +
                                                            $"'{product_.Price}'," +
                                                            $"{product_.Quantity}," +
                                                            $"'{string.Join(",", product_.AttributeList)}'," +
                                                            $"'{product_.MainImage}'," +
                                                            $"'{string.Join(",",product_.ExtraImageList)}'," +
                                                            $"{product_.CategoryID}," +
                                                            $"{product_.ShopID}");

        }
        public static void Update(Product_ product_)
        {
            int altBanState = product_.BannedState? 1: 0;
            int altReviewState = product_.ReviewState ? 1 : 0;
            MyConnection.ExecuteNonQuery($"sp_updateProduct {product_.ProductId}," +
                                                            $"'{product_.ProductName}'," +
                                                            $"'{product_.Description}'," +
                                                            $"'{product_.Price}'," +
                                                            $"{product_.Quantity}," +
                                                            $"'{string.Join(",", product_.AttributeList)}'," +
                                                            $"'{product_.MainImage}'," +
                                                            $"'{string.Join(",", product_.ExtraImageList)}'," +
                                                            $"{altBanState}," +
                                                            $"{altReviewState}," +
                                                            $"{product_.CategoryID}," +
                                                            $"{product_.RatingStar}");
        }
        public static void Delete(Product_ product_)
        {
            MyConnection.ExecuteNonQuery($"sp_deleteProduct {product_.ProductId}");
        }
        public static IEnumerable<Product_> Select()
        {
            foreach( DataRow row in MyConnection.ExecuteDataTable("sp_selectProduct").Rows)
            {
                yield return new Product_()
                {
                    ProductId = row["ProductID"].ToString(),
                    ProductName = row["ProductName"].ToString(),
                    Description = row["Description_"].ToString(),
                    Price = row["Price"].ToString(),
                    CreatedDate = row["CreatedDate"].ToString(),
                    Quantity = row["Quantity"].ToString(),
                    AttributeList = row["AttributeList"].ToString().Split(','),
                    MainImage = row["MainImage"].ToString(),
                    ExtraImageList = row["ExtraImageList"].ToString().Split(','),
                    BannedState = row["BannedState"].ToString().ToBool(),
                    ReviewState = row["ReviewState"].ToString().ToBool(),
                    CategoryID = row["CategoryID"].ToString(),
                    ShopID = row["ShopID"].ToString(),
                    RatingStar = row["RatingStar"].ToString(),
                };
            }
        }
    }
}
