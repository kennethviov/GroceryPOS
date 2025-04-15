using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GroceryPOS.Components
{
    public partial class ProductInfos : Form
    {

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
        );

        public ProductInfos()
        {
            InitializeComponent();
            pictureBox1.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, pictureBox1.Width, pictureBox1.Height, 15, 15));
        }

        private void PoductInfos_Load(object sender, EventArgs e)
        {

        }

        public Image ProductImage
        {
            get => pictureBox1.Image;
            set => pictureBox1.Image = value;
        }

        public string ProductTitle
        {
            get => productName.Text;
            set => productName.Text = value;
        }

        public double ProductPrice
        {
            get => double.Parse(price.Text);
            set => price.Text = value.ToString("N2");
        }

        public string SoldBy
        {
            get => soldBy.Text;
            set => soldBy.Text = value;
        }

        public int Stock
        {
            get => int.Parse(stock.Text);
            set => stock.Text = value.ToString();
        }

        public string Description
        {
            get => description.Text;
            set => description.Text = value;
        }
    }
}
