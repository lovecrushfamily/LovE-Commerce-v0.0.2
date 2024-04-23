using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DLL;

namespace BUS
{
    public class Shop : Shop_, Entity
    {

        public Shop(Shop_ shop_)
        {
            ShopId = shop_.ShopId;
            ShopName = shop_.ShopName;
            Description = shop_.Description;
            Address = shop_.Address;
            PhoneNumber = shop_.PhoneNumber;
            Date = shop_.Date;
            Image = shop_.Image;
            ShopOwner = shop_.ShopOwner;
        }

        public void Add()
        {
            DAO.Shop.Add(this);

        }

        public void Update()
        {
            DAO.Shop.Update(this);


        }

        public void Delete()
        {
            DAO.Shop.Delete(this);

        }

        public static Shop[] GetShops()
        {
            return DAO.Shop.Select().Select(c => new Shop(c)).ToArray();
        }

    }
}
