using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class Voucher : DLL.Voucher_
    {
        public Voucher() : base() { }

        public void Add()
        {

        }

        public void Delete()
        {

        }
        public static Voucher[] GetVouchers()
        {
            return DAO.Voucher.Select() as Voucher[];
        }
    }
}
