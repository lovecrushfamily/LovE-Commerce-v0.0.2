using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DLL;

namespace DAO
{
    public class Voucher
    {
        public static void Add(Voucher_ voucher_)
        {
            MyConnection.ExecuteNonQuery($"sp_insertVoucher '{voucher_.VoucherName}'," +
                                                            $"{voucher_.VoucherType}," +
                                                            $"'{voucher_.FixedAmount}'," +
                                                            $"'{voucher_.MinAmount}'," +
                                                            $"'{voucher_.Percentage}'," +
                                                            $"'{voucher_.MaxAmount}'," +
                                                            $"{voucher_.Quantity}," +
                                                            $"'{voucher_.StartedDate}'," +
                                                            $"'{voucher_.ExpiredDate}'," +
                                                            $"{voucher_.ShopId}");

        }
        public static void Update(Voucher_ voucher_)
        {

        }
        public static void Delete(Voucher_ voucher_)
        {

        }

    }
}
