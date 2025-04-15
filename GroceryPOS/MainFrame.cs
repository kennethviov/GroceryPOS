using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Xml.Serialization;
using GroceryPOS.Components;
using GroceryPOS.Screens;
using GroceryStroreDiscountGUI.Components;

namespace GroceryPOS
{
    public partial class MainFrame : Form
    {

        readonly List<ProductInCart> cartItems;
        readonly List<ProductCard> products = new List<ProductCard>();
        private ProductInfos productInfo;
        readonly Image productImage;

        Point mouseLocation;

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


        public MainFrame()
        {
            InitializeComponent();
            RegionLoad();

            cartItems = new List<ProductInCart>();
            productInfo = new ProductInfos();
            productImage = Image.FromFile("C:\\Users\\kenne\\source\\repos\\GroceryPOS1.1\\GroceryPOS1.1\\GroceryPOS1\\GroceryPOS\\GroceryPOS\\Resources\\broken-image.png");
            
            foreach (Control control in flowLayoutPanel1.Controls)
            {
                if (control is ProductCard product)
                {
                    products.Add(product);
                    product.Click += ClickHandler;
                    product.MouseEnter += ProductCard_MouseEnter;
                    product.MouseLeave += ProductCard_MouseLeave;

                    product.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, product.Width, product.Height, 15, 15));
                }
            } 
        }

        //
        //
        // Window Aesthetics
        //
        //
        private void RegionLoad()
        {
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));

            dockertop.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, dockertop.Width, dockertop.Height, 15, 15));
            button6.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, button6.Width, button6.Height, 15, 15));
            panel1.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, panel1.Width, panel1.Height, 15, 15));
            panel3.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, panel3.Width, panel3.Height, 15, 15));
            flowLayoutPanel2.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, flowLayoutPanel2.Width, flowLayoutPanel2.Height, 15, 15));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button1.Height;
            SidePanel.Top = button1.Top;

            flowLayoutPanel1.Controls.Clear();
            foreach (var product in products)
            {
                flowLayoutPanel1.Controls.Add(product);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button2.Height;
            SidePanel.Top = button2.Top;
            
            DisplayCategory("vegetable");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button3.Height;
            SidePanel.Top = button3.Top;

            DisplayCategory("meat");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button4.Height;
            SidePanel.Top = button4.Top;

            DisplayCategory("fruit");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button5.Height;
            SidePanel.Top = button5.Top;

            DisplayCategory("drink");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button7.Height;
            SidePanel.Top = button7.Top;

            DisplayCategory("liquor");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        //
        //
        // Product Card Events
        //
        //
        private void ClickHandler(object sender, EventArgs e)
        {
            if (sender is ProductCard productCard)
            {
                Console.WriteLine($"Product clicked: {productCard.ProducTitle}");

                var existingItem = cartItems.FirstOrDefault(item => item.Title == productCard.ProducTitle);
                if (existingItem != null)
                {
                    // Increase quantity if item already exists
                    existingItem.Quantity++;
                }
                else
                {
                    // Create a new cart item if it doesn't exist
                    ProductInCart cartItem = new ProductInCart(this)
                    {
                        Title = productCard.ProducTitle,
                        Price = productCard.ProductPrice,
                        ProductImage = productCard.ProductImage,
                        Quantity = 1
                    };

                    cartItems.Add(cartItem);
                    flowLayoutPanel2.Controls.Add(cartItem);
                }

                // Refresh UI to reflect changes
                UpdateCartUI();
            }
        }

        private void ProductCard_MouseEnter(object sender, EventArgs e)
        {
            if (sender is ProductCard productCard)
            {

                productInfo.ProductImage = productCard.ProductImage;
                productInfo.ProductTitle = productCard.ProducTitle;
                productInfo.ProductPrice = productCard.ProductPrice;
                productInfo.SoldBy = productCard.SoldBy;
                productInfo.Description = productCard.Descrition;
                productInfo.Stock = productCard.Stock;

                productInfo.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, productInfo.Width, productInfo.Height, 15, 15));
                productInfo.TopMost = true;
                productInfo.BringToFront();
                productInfo.Show();

                productCard.MouseMove += ProductCard_MouseMove;
            }
        }

        private void ProductCard_MouseMove(object sender, EventArgs e) 
        { 
            if (productInfo != null && !productInfo.IsDisposed)
            {
                Point mousePos = Cursor.Position;
                mousePos.Offset(15, 15);
                productInfo.Location = mousePos;
            }
        }

        private void ProductCard_MouseLeave(object sender, EventArgs e)
        {
            if (productInfo != null && !productInfo.IsDisposed)
            {
                productInfo.Hide();
            }

            if (sender is ProductCard productCard)
            {
                productCard.MouseMove -= ProductCard_MouseMove;
            }
        }

        private void mouse_Down(object sender, MouseEventArgs e)
        {
            mouseLocation = new Point(-e.X, -e.Y);
        }

        private void mouse_Move(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mousePose = Control.MousePosition;
                mousePose.Offset(mouseLocation.X, mouseLocation.Y);
                Location = mousePose;
            }
        }

        private void DisplayCategory(string category)
        {
            flowLayoutPanel1.Controls.Clear();
            foreach (var product in products)
            {
                if (product.Category == category)
                {
                    flowLayoutPanel1.Controls.Add(product);
                }
            }
        }

        private void UpdateCartUI()
        {
            flowLayoutPanel2.Controls.Clear(); // Clear current cart display

            var itemsToRemove = new List<ProductInCart>();

            for (int i = cartItems.Count - 1; i >= 0; i--)
            {
                if (cartItems[i].Quantity == 0)
                {
                    itemsToRemove.Add(cartItems[i]);
                    continue;
                }
                flowLayoutPanel2.Controls.Add(cartItems[i]);
            }

            foreach (var item in itemsToRemove)
            {
                cartItems.Remove(item);
            }

            UpdateSummary();
        }

        //
        //
        // Core Functions
        //
        //
        private void button6_Click(object sender, EventArgs e)
        {
            UpdateCartUI();

            if (cartItems.Count == 0)
            {
                MessageBox.Show("Cart is Empty", "Cart Status", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                DialogResult result = MessageBox.Show("Are you sure you want to checkout?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    Receipt rec = new Receipt(cartItems);
                    rec.ShowDialog();

                    flowLayoutPanel2.Controls.Clear();
                    cartItems.Clear();
                    UpdateSummary();
                }
            }
        }
       
        public void UpdateSummary()
        {
            double subtotal = CalculateSubtotal();
            int discountP = DetermineDiscountP(subtotal);
            double discount = CalculateDiscount(subtotal, discountP);
            double total = CalculateTotal(subtotal, discount);

            subtotalLabel.Text = "₱ " + subtotal.ToString("N2");
            discountpLabel.Text = $"{discountP}%";
            discountLabel.Text = "₱ " + discount.ToString("N2");
            totalLabel.Text = "₱ " + total.ToString("N2");
        }

        private double CalculateSubtotal()
        {
            double subtotal = 0;
            foreach (var item in cartItems)
            {
                subtotal += item.Price * item.Quantity;
            }

            return subtotal;
        }

        private int DetermineDiscountP(double subtotal)
        {
            if (subtotal >= 500)
                return 20;
            else if (subtotal >= 200)
                return 15;
            else if (subtotal >= 100)
                return 10;
            else
                return 0;
        }

        private double CalculateDiscount(double subtotal, int discountP)
        {
            return subtotal * discountP / 100;
        }

        private double CalculateTotal(double subtotal, double discount)
        {
            return subtotal - discount;
        }
    }
}