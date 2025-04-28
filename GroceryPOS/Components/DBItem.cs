using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
            get => itemImage.Image;
            set => itemImage.Image = value;
        }

        public String ItemName
        {
            get => itemName.Text;
            set => itemName.Text = value;
        }

        public String ItemPrice
        {
            get => itemPrice.Text;
            set => itemPrice.Text = value;
        }

        public String ItemCategory
        {
            get => itemCategory.Text;
            set => itemCategory.Text = value;
        }

        public String ItemStock
        {
            get => itemStock.Text;
            set => itemStock.Text = value;
        }

        
        // KeyPress handler
        private void ItemStock_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

    }
}
