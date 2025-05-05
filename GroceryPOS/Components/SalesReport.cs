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
    public partial class SalesReport : UserControl
    {
        public SalesReport()
        {
            InitializeComponent();
        }

        public string SalesID
        {
            get => salesID.Text;
            set => salesID.Text = value;
        }

        public string DateAndTime
        {
            get => dateAndTime.Text;
            set => dateAndTime.Text = value;
        }

        public string Total
        {
            get => total.Text;
            set => total.Text = value;
        }
    }
}
