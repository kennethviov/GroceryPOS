using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroceryPOS
{
    internal class Item
    {
        public Image Image { get; set; }

        public string Name { get; set; }

        public double Price { get; set; }

        public string Category { get; set; }

        public string SoldBy { get; set; }

        public string Description { get; set; }

        public int Stock { get; set; }
    }
}
