using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GroceryPOS.Components
{
    public partial class DBItem : UserControl
    {
        public DBItem()
        {
            InitializeComponent();
        }

        public Image ItemImage
        {
            get { return itemImage.Image; }
            set { itemImage.Image = value; }
        }

        public String ItemName
        {
            get { return itemName.Text; }
            set { itemName.Text = value; }
        }

        public String ItemPrice
        {
            get { return itemPrice.Text; }
            set { itemPrice.Text = value; }
        }

        public String ItemCategory
        {
            get { return itemCategory.Text; }
            set { itemCategory.Text = value; }
        }

        public String ItemStock
        {
            get { return itemStock.Text; }
            set { itemStock.Text = value; }
        }
        
    }
}
