using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Category
    {
        public string CategoryName { get; set; }
        public int CategoryId { get; set; }

        public bool CategoryStatus { get; set; } 

        public List<Product> Products { get; set; }



    }
}

//int x; // This is a field that is not used in this class.
//public int CategoryId { get; set; } //This is a property that represents the unique identifier for the category.

//void test()
//{
//    int y = 0; // This is a local variable that is not used in this method.
//}

////this 3 example shows the difference between field, property and local variable.