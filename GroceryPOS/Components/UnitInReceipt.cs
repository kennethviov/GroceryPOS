using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GroceryPOS.Components
{
    public partial class UnitInReceipt: UserControl
    {
        public UnitInReceipt()
        {
            InitializeComponent();
        }

        public UnitInReceipt(string title, double price, int quantity)
        {
            InitializeComponent();
            Title = title;
            Price = price;
            Quantity = quantity;
        }

        public string Title
        {
            get => title.Text;
            set => title.Text = value;
        }

        public double Price
        {
            get => double.Parse(unitPrice.Text);
            set => unitPrice.Text = value.ToString("F2");
        }

        public int Quantity
        {
            get => int.Parse(quantity.Text);
            set => quantity.Text = value.ToString();
        }

        private void UnitInReceipt_Load(object sender, EventArgs e)
        {
            unitTotal.Text = ((double)(Quantity * Price)).ToString("F2");
        }
    }
}
