using DLL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class Category
    {
        public static void Add(Category_ category_)
        {
            MyConnection.ExecuteNonQuery($"sp_insertCategory '{category_.CategoryName}'," +
                                                            $"{category_.AncestorId},  " +
                                                            $"'{category_.AttributeList}'");

        }
        public static void Update(Category_ category_)
        {
            MyConnection.ExecuteNonQuery($"sp_updateCategory {category_.CategoryId}," +
                                                            $"'{category_.CategoryName}'," +
                                                            $"{category_.AncestorId}," +
                                                            $"'{category_.AttributeList}'");

        }
        public static void Delete(Category_ category_)
        {
            MyConnection.ExecuteNonQuery($"sp_deleteCategory {category_.CategoryId}");

        }

        public static IEnumerable<Category_> Select()
        {
            foreach(DataRow row in MyConnection.ExecuteDataTable("sp_selectCategory").Rows)
            {
                yield return new Category_()
                {
                    CategoryId = row["CategoryID"].ToString(),
                    CategoryName = row["CategoryName"].ToString(),
                    AncestorId = row["AncestorID"].ToString(),
                    AttributeList = row["AttributeList"].ToString()
                };
            }
        }
    }
}
