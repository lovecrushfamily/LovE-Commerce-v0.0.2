using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DLL;

namespace BUS
{
    public class Category :  Category_  , Entity
    {
        public Category(Category_ parent)
        {
            CategoryId = parent.CategoryId;
            CategoryName = parent.CategoryName;
            AncestorId = parent.AncestorId;
            AttributeList = parent.AttributeList;
        }

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
            return DAO.Category.Select().Select(c => new Category(c)).ToArray();
        }
    }
}
