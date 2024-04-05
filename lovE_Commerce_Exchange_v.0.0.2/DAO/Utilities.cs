using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DLL;

namespace DAO
{
    internal class Utilities
    {


    }
    public static class StringExtensionMethod
    {
        public static int ToInt(this string Str)
        {
            return int.Parse(Str);
        }

        public static bool  ToBool(this string Str)
        {
            return Convert.ToBoolean(Str);
        }
    }

    public static class DataRowExtensionMethod
    {
        public static int ToInt(this DataColumn dataRow)
        {                                                              
            return int.Parse(dataRow.ToString());
        }

        public static bool ToBool(this DataColumn Str)
        {
            return Convert.ToBoolean(Str.ToString());
        }

    }
}
