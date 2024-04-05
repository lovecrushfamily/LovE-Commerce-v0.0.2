using DLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class Product : Product_, Entity
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


        public Product(Product_ product_)
        {
            ProductId = product_.ProductId;
            ProductName = product_.ProductName;
            Description = product_.Description;
            Price = product_.Price;
            CreatedDate = product_.CreatedDate;
            Quantity = product_.Quantity;
            AttributeList = product_.AttributeList;
            MainImage = product_.MainImage;
            ExtraImageList = product_.ExtraImageList;
            BannedState = product_.BannedState;
            ReviewState = product_.ReviewState;
            CategoryID = product_.CategoryID;
            ShopID = product_.ShopID;
            RatingStar = product_.RatingStar;
        }

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
            return DAO.Product.Select().Select(c => new Product(c)).ToArray();
        }





    }
}
