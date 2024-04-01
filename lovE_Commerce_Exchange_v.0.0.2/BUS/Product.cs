using DLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class Product : Product_
    {
        //public string ProductId;
        //public string ProductName;
        //public string Description;
        //public string Price;
        //public string CreatedDate;
        //public int Quantity;
        //public string[] AttributeList;
        //public string MainImage;
        //public string[] ExtraImageList;
        //public bool BannedState;
        //public bool ReviewState;
        //public bool CategoryID;
        //public string ShopID;


        public Product() : base() { }

        public void Add()
        {

        }

        public void Update()
        {

        }


        public void Delete()
        {

        }

        public void UpdateReviewState()
        {

        }


        public void UpdateBanState()
        {

        }

        public static Product[] GetProducts()
        {
            return DAO.Product.Select() as Product[];
        }





    }
}
