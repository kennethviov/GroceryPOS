using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GroceryStroreDiscountGUI.Components
{
    public partial class NumericStepper: UserControl
    {
        private int _value = 1; // Default value
        private int _min   = 0; // Allowed minimum value
        private int _max  = 100; // Allowed maximum value

        public NumericStepper()
        {
            InitializeComponent();
        }

        public int Value
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

        public int Minimum
        {
            get => _min;
            set => _min = value;
        }

        public int Maximum
        {
            get => _max;
            set => _max = value;
        }

        private void increaseBtn_Click(object sender, EventArgs e)
        {
            if (_value < _max)
            {
                _value++;
                textBox1.Text = _value.ToString();
            }
        }

        private void decreaseBtn_Click(object sender, EventArgs e)
        {
            if (_value > _min)
            {
                _value--;
                textBox1.Text = _value.ToString();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out int value))
            {
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
        }
    }
}
