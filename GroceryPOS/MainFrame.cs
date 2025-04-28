using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Contexts;
using System.Windows.Forms;
using System.Xml.Serialization;
using GroceryPOS.Components;
using GroceryStroreDiscountGUI.Components;
using Microsoft.Data.SqlClient;
using System.Resources;
using System.Reflection;
using CuoreUI;

namespace GroceryPOS
{
    public partial class MainFrame : Form
    {


        readonly List<ProductInCart> cartItems;
        readonly List<ProductCard> products = new List<ProductCard>();
        readonly ProductInfos productInfo;
        readonly CalculatingFunctions cf;
        readonly DataHandler sdbh;

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

            cartItems = new List<ProductInCart>();
            productInfo = new ProductInfos();
            cf = new CalculatingFunctions();
            sdbh = new DataHandler();

            products = sdbh.LoadProductsFromDatabase();

            LoadToFlowLayoutPanel();

            walkingtext.Left = this.Width;
            timer1.Interval = 20;
            timer1.Tick += timer1_Tick;
            timer1.Start();

            RegionLoad();
        }

        private void LoadToFlowLayoutPanel()
        {
            foreach (var product in products)
            {
                flowLayoutPanel1.Controls.Add(product);
                product.Click += ClickHandler;
                product.MouseEnter += ProductCard_MouseEnter;
                product.MouseLeave += ProductCard_MouseLeave;

                product.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, product.Width, product.Height, 15, 15));
            }
        }


        //
        //
        // Product Card Events and other Mouse Events
        //
        //
        private void ClickHandler(object sender, EventArgs e)
        {
            if (sender is ProductCard productCard)
            {
                //Console.WriteLine($"Product clicked: {productCard.ProductName}");

                var existingItem = cartItems.FirstOrDefault(item => item.Title == productCard.ProductName);
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
                        Title = productCard.ProductName,
                        Price = productCard.ProductPrice,
                        ProductImage = productCard.ProductImage,
                        Quantity = 1
                    };

                    cartItem.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, cartItem.Width, cartItem.Height, 15, 15));

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
                productInfo.ProductTitle = productCard.ProductName;
                productInfo.ProductPrice = productCard.ProductPrice;
                productInfo.SoldBy = productCard.SoldBy;
                productInfo.Stock = productCard.Stock;
                productInfo.Description = productCard.Description;

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

        //
        // window dragging
        //
        private bool dragging = false;
        private Point startPoint = new Point(0, 0);

        private void mouse_Down(object sender, MouseEventArgs e)
        {
            dragging = true;
            startPoint = new Point(e.X, e.Y);
        }

        private void mouse_Move(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - startPoint.X, p.Y - startPoint.Y);
            }
        }

        private void dockertop_MouseUp(object sender, MouseEventArgs e) { dragging = false; }

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

            DisplayCategory("vegetables");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button3.Height;
            SidePanel.Top = button3.Top;

            DisplayCategory("meats");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button4.Height;
            SidePanel.Top = button4.Top;

            DisplayCategory("fruits");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button5.Height;
            SidePanel.Top = button5.Top;

            DisplayCategory("drinks");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button7.Height;
            SidePanel.Top = button7.Top;

            DisplayCategory("liquor");
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Color.FromArgb(189, 26, 26);
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBox1.BackColor = Color.FromArgb(138, 30, 30);
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Color.FromArgb(148, 168, 78);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            
            if (cartItems.Count == 0)
            {
                MessageBox.Show("Cart is Empty", "Cart Status", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                DialogResult result = MessageBox.Show("Are you sure you want to clear your order?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    flowLayoutPanel2.Controls.Clear();
                    cartItems.Clear();
                    UpdateSummary();
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to close the app?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }


        //
        //
        // UI
        //
        //
        private void RegionLoad()
        {
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));

            dockertop.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, dockertop.Width, dockertop.Height, 11, 11));
            button6.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, button6.Width, button6.Height, 11, 11));
            closeopensidebar.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, closeopensidebar.Width, closeopensidebar.Height, 11, 11));
            panel3.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, panel3.Width, panel3.Height, 11, 11));
            flowLayoutPanel1.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, flowLayoutPanel1.Width, flowLayoutPanel1.Height, 11, 11));
            flowLayoutPanel2.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, flowLayoutPanel2.Width, flowLayoutPanel2.Height, 11, 11));
            pictureBox1.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, pictureBox1.Width, pictureBox1.Height, 10, 10));
            productInfo.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, productInfo.Width, productInfo.Height, 15, 15));
            panel1.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, panel1.Width, panel1.Height, 15, 15));

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
            double subtotal = cf.CalculateSubtotal(cartItems);
            int discountP = cf.DetermineDiscountP(subtotal);
            double discount = cf.CalculateDiscount(subtotal, discountP);
            double total = cf.CalculateTotal(subtotal, discount);

            subtotalLabel.Text = "₱ " + subtotal.ToString("N2");
            discountpLabel.Text = $"{discountP}%";
            discountLabel.Text = "₱ " + discount.ToString("N2");
            totalLabel.Text = "₱ " + total.ToString("N2");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            walkingtext.Left -= 2;

            if(walkingtext.Right < 0)
            {
                walkingtext.Left = this.Width;

            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button8.Height;
            SidePanel.Top = button8.Top;

        }
    }
}