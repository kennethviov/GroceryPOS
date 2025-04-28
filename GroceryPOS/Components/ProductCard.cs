using System;
using System.Drawing;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace GroceryPOS
{
    public partial class ProductCard : UserControl
    {
        public ProductCard()
        {
            InitializeComponent();
            SetEventHandlers();
        }

        public Image Image
        {
            get => pictureBox1.Image;
            set => pictureBox1.Image = value;
        }

        public new string Name
        {
            get => label1.Text;
            set => label1.Text = value;
        }

        public double Price
        {
            get => double.Parse(label3.Text);
            set => label3.Text = value.ToString("N2");
        }

        public string Category { get; set; }

        public string SoldBy
        {
            get => label4.Text;
            set => label4.Text = value;
        }

        public string Description 
        { 
            get => description.Text; 
            set => description.Text = value;
        }

        public int Stock 
        {
            get => int.Parse(stock.Text);
            set => stock.Text = value.ToString();
        }

        private void SetEventHandlers()
        {
            foreach (Control control in this.Controls)
            {
                control.Click += (s, e) => this.OnClick(e); // Redirect click to UserControl
                control.MouseEnter += (s, e) => this.OnMouseEnter(e); // Redirect mouse enter to UserControl
                control.MouseMove += (s, e) => this.OnMouseMove(e); // Redirect mouse move to UserControl
                control.MouseLeave += (s, e) => this.OnMouseLeave(e); // Redirect mouse leave to UserControl
            }
        }
    }
}
