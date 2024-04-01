using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DLL;

namespace BUS
{
    public class Category :  Category_
    {
        public Category() { }

        //public string CategoryId;
        //public string CategoryName;
        //public string AncestorId;
        //public string AttributeList;


        public void Add()
        {
            DAO.Category.Add(this);
        }

        public void Update()
        {
             DAO.Category.Update(this);
        }

        public void Delete()
        {
            DAO.Category.Delete(this);

        }
        public static Category[] GetCategories()
        {
            return DAO.Category.Select() as Category[];
        }
    }
}
