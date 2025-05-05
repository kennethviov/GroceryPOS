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
        public MainFrame()
        {
            InitializeComponent();

            dh = new DataHandler();
            items = dh.LoadItemsFromDatabase();

            cartItems = new List<ProductInCart>();
            productInfo = new ProductInfos();
            cf = new CalculatingFunctions();


            LoadToFlowLayoutPanel();

            walkingtext.Left = this.Width;
            timer1.Interval = 20;
            timer1.Tick += Timer1_Tick;
            timer1.Start();

            RegionLoad();
            admin = new Admin(this);
        }

        private void LoadToFlowLayoutPanel()
        {
            StoreToAComponent();

            foreach (var product in products)
            {
                flowLayoutPanel1.Controls.Add(product);
                product.Click += ProductCard_Click;
                product.MouseEnter += ProductCard_MouseEnter;
                product.MouseLeave += ProductCard_MouseLeave;
                product.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, product.Width, product.Height, 15, 15));
            }
        }

        private void StoreToAComponent()
        {
            foreach (var item in items)
            {
                ProductCard product = new ProductCard()
                {
                    Image = item.Image,
                    Name = item.Name,
                    Price = item.Price,
                    SoldBy = item.SoldBy,
                    Stock = item.Stock,
                    Description = item.Description,
                    Category = item.Category
                };
                products.Add(product);
            }
        }

        private void ProductCard_Click(object sender, EventArgs e)
        {
            if (sender is ProductCard productCard)
            {

                var existingItem = cartItems.FirstOrDefault(item => item.Title == productCard.Name);
                if (existingItem != null)
                {
                    existingItem.Quantity++;
                }
                else
                {
                    ProductInCart cartItem = new ProductInCart(this)
                    {
                        Title = productCard.Name,
                        Price = productCard.Price,
                        ProductImage = productCard.Image,
                        Quantity = 1
                    };

                    cartItem.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, cartItem.Width, cartItem.Height, 15, 15));

                    cartItems.Add(cartItem);
                    flowLayoutPanel2.Controls.Add(cartItem);
                }
                UpdateCartUI();
            }
        }

        private void ProductCard_MouseEnter(object sender, EventArgs e)
        {
            if (sender is ProductCard productCard)
            {

                productInfo.ProductImage = productCard.Image;
                productInfo.ProductTitle = productCard.Name;
                productInfo.ProductPrice = productCard.Price;
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

        private bool dragging = false;
        private Point startPoint = new Point(0, 0);

        private void Dockertop_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            startPoint = new Point(e.X, e.Y);
        }

        private void Dockertop_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - startPoint.X, p.Y - startPoint.Y);
            }
        }

        private void Dockertop_MouseUp(object sender, MouseEventArgs e) { dragging = false; }

        private string currCat = "allitemsBtn";

        private void CatBtns_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            if (currCat == btn.Name) return;

            currCat = btn.Name;
            SidePanel.Height = btn.Height;
            SidePanel.Top = btn.Top;

            if (btn.Name == "vegetablesBtn")
            {
                DisplayCategory("vegetables");
            }
            else if (btn.Name == "meatsBtn")
            {
                DisplayCategory("meats");
            }
            else if (btn.Name == "fruitsBtn")
            {
                DisplayCategory("fruits");
            }
            else if (btn.Name == "drinksBtn")
            {
                DisplayCategory("drinks");
            }
            else if (btn.Name == "liquorBtn")
            {
                DisplayCategory("liquor");
            }
            else if (btn.Name == "menuBtn")
            {
            }
            else if (btn.Name == "allitemsBtn")
            {
                DisplayCategory("all items");
            }
        }

        private void AdminBtn_Click(object sender, EventArgs e)
        {
            admin.Show();
            this.Hide();
        }

        private void DisplayCategory(string category)
        {
            if (category == "all items")
            {
                flowLayoutPanel1.Controls.Clear();
                foreach (var product in products)
                {
                    flowLayoutPanel1.Controls.Add(product);
                }

                return;
            }

            flowLayoutPanel1.Controls.Clear();
            foreach (var product in products)
            {
                if (product.Category == category)
                {
                    flowLayoutPanel1.Controls.Add(product);
                }
            }
        }

        private void CloseBtn_MouseEnter(object sender, EventArgs e) { closeBtn.BackColor = Color.FromArgb(189, 26, 26); }

        private void CloseBtn_MouseDown(object sender, MouseEventArgs e) { closeBtn.BackColor = Color.FromArgb(138, 30, 30); }

        private void CloseBtn_MouseLeave(object sender, EventArgs e) { closeBtn.BackColor = Color.FromArgb(114, 137, 218); }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to close the app?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void ClearCartBtn_Click(object sender, EventArgs e)
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

        private void CheckoutBtn_Click(object sender, EventArgs e)
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
                    foreach (var ci in cartItems)
                    {
                        foreach (var item in items)
                        {
                            if (item.Name == ci.Title)
                            {
                                item.Stock -= ci.Quantity;
                            }
                        }
                    }


                    dh.AddNewSale(double.Parse(totalLabel.Text.ToString().Substring(1).Replace(",", "")));
                    admin.RefreshSalesReportPanel();
                    admin.RefreshInventoryPanel();

                    Receipt rec = new Receipt(cartItems);
                    rec.ShowDialog();

                    flowLayoutPanel1.Controls.Clear();
                    flowLayoutPanel2.Controls.Clear();
                    cartItems.Clear();
                    products.Clear();
                    UpdateSummary();
                    LoadToFlowLayoutPanel();
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

        private void Timer1_Tick(object sender, EventArgs e)
        {

            walkingtext.Left -= 2;

            if(walkingtext.Right < 0)
            {
                walkingtext.Left = this.Width;
            }
        }

        private void RegionLoad()
        {
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));

            dockertop.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, dockertop.Width, dockertop.Height, 11, 11));
            checkoutBtn.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, checkoutBtn.Width, checkoutBtn.Height, 11, 11));
            closeopensidebar.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, closeopensidebar.Width, closeopensidebar.Height, 11, 11));
            panel3.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, panel3.Width, panel3.Height, 11, 11));
            flowLayoutPanel1.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, flowLayoutPanel1.Width, flowLayoutPanel1.Height, 11, 11));
            flowLayoutPanel2.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, flowLayoutPanel2.Width, flowLayoutPanel2.Height, 11, 11));
            closeBtn.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, closeBtn.Width, closeBtn.Height, 10, 10));
            productInfo.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, productInfo.Width, productInfo.Height, 15, 15));
            panel1.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, panel1.Width, panel1.Height, 15, 15));
        }

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

        readonly List<ProductInCart> cartItems;
        public List<Item> items;
        readonly List<ProductCard> products = new List<ProductCard>();
        readonly ProductInfos productInfo;
        readonly CalculatingFunctions cf;
        readonly DataHandler dh;
        readonly Admin admin;
    }
}