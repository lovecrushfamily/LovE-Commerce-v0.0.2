using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
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
        public static void Delete(Voucher_ voucher_)
        {
            MyConnection.ExecuteNonQuery($"sp_deleteVoucher {voucher_.VoucherId}");
          
        }
        public static IEnumerable<Voucher_> Select()
        {
            foreach (DataRow row in MyConnection.ExecuteDataTable("sp_selectVoucher").Rows)
            {
                yield return new Voucher_()
                {
                    VoucherId = row["VoucherID"].ToString(),
                    VoucherName = row["VoucherName"].ToString(),
                    VoucherType = row["VoucherType"].ToString(),
                    FixedAmount = row["FixedAmount"].ToString(),
                    MinAmount = row["MinAmount"].ToString(),
                    Percentage = row["PercentageDiscount"].ToString(),
                    MaxAmount = row["MaxAmount"].ToString(),
                    Quantity = row["Quanity"].ToString(),
                    StartedDate = row["StartedDay"].ToString(),
                    ExpiredDate = row["EndedDay"].ToString(),
                    ShopId = row["ShopID"].ToString()
                };
            }
        }

    }
}
