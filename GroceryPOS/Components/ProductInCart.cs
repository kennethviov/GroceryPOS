using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using GroceryPOS;

namespace GroceryStroreDiscountGUI.Components
{
    public partial class ProductInCart: UserControl
    {

        private int _value = 1; // Default value
        private int _min = 0; // Allowed minimum value
        private int _max = 100; // Allowed maximum value

        MainFrame parent;

        public ProductInCart()
        {
            InitializeComponent();
        }

        public ProductInCart(MainFrame parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        public ProductInCart(string title, double price, int quantity)
        {
            InitializeComponent();
            Title = title;
            Price = price;
            Quantity = quantity;
        }

        public Image ProductImage
        {
            get => pictureBox1.Image;
            set => pictureBox1.Image = value;
        }

        public string Title
        {
            get => label1.Text;
            set => label1.Text = value;
        }

        public double Price
        {
            get => double.Parse(label2.Text);
            set => label2.Text = value.ToString("F2");
        }

        public int Quantity
        {
            get => _value;
            set
            {
                if (value >= _min && value <= _max)
                {
                    _value = value;
                    textBox1.Text = _value.ToString();
                }
            }
        }

        public void RemoveFromCart()
        {
            this.Parent?.Controls.Remove(this);
            Quantity = 0;
        }

        private void increaseBtn_Click(object sender, EventArgs e)
        {
            if (_value < _max)
            {
                _value++;
                textBox1.Text = _value.ToString();
            }

            parent.UpdateSummary();
        }

        private void decreaseBtn_Click(object sender, EventArgs e)
        {
            if (_value == 0) 
            {
                RemoveFromCart();
                parent.UpdateSummary();
                return;
            }

            if (_value > _min)
            {
                _value--;
                textBox1.Text = _value.ToString();
            }

            parent.UpdateSummary();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out int value))
            {
                if (_value == 0)
                {
                    RemoveFromCart();
                    parent.UpdateSummary();
                    return;
                }

                if (value >= _min && value <= _max)
                {
                    _value = value;
                }
                else
                {
                    textBox1.Text = _value.ToString();
                }
            }
            else
            {
                textBox1.Text = _value.ToString();
            }

            parent.UpdateSummary();
        }
    }
}
