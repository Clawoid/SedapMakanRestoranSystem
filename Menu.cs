using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Assignment_Customer_
{
    public class MenuItems
    {
        public int MenuItemID { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public decimal Price { get; set; }
        public bool Availability { get; set; }

        public static implicit operator MenuItems(System.Windows.Forms.MenuItem v)
        {
            throw new NotImplementedException();
        }
    }
}
