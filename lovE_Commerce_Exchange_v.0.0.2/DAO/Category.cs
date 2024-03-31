using DLL;
using System;
using System.Collections.Generic;
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

        }
        public static void Delete(Category_ category_)
        {

        }
    }
}
