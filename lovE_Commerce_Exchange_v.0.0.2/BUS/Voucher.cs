using DLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class Voucher : DLL.Voucher_, Entity
    {
        public Voucher(Voucher_ voucher)
        {
            VoucherId = voucher.VoucherId;
            VoucherName = voucher.VoucherName;
            VoucherType = voucher.VoucherType;
            FixedAmount = voucher.FixedAmount;
            MinAmount = voucher.MinAmount;
            Percentage = voucher.Percentage;
            MaxAmount = voucher.MaxAmount;
            Quantity = voucher.Quantity;
            StartedDate = voucher.StartedDate;
            ExpiredDate = voucher.ExpiredDate;
            ShopId = voucher.ShopId;
        }

        public void Add()
        {

        }

        public void Delete()
        {

        }
        public static Voucher[] GetVouchers()
        {
            return DAO.Voucher.Select().Select(v => new Voucher(v)).ToArray();
        }
    }
}
