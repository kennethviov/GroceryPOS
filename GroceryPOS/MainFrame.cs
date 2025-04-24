using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Contexts;
using System.Windows.Forms;
using System.Xml.Serialization;
using GroceryPOS.Components;
using GroceryPOS.Screens;
using GroceryStroreDiscountGUI.Components;
using Microsoft.Data.SqlClient;
using System.Resources;
using System.Reflection;

namespace GroceryPOS
{
    public partial class MainFrame : Form
    {

        readonly List<ProductInCart> cartItems;
        readonly List<ProductCard> products = new List<ProductCard>();
        readonly ProductInfos productInfo;
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

            LoadItemsFromDatabase();
        }

        private void LoadItemsFromDatabase()
        {
            string connectionString = "Data Source = (LocalDB)\\MSSQLLocalDB; Database = protoDB; Integrated Security = True; Connect Timeout = 30; Encrypt = False; Trust Server Certificate = False; Application Intent = ReadWrite; Multi Subnet Failover = False";
            string query = "SELECT\r\n    I.item_id,\r\n    I.item_name,\r\n    I.item_price,\r\n    I.item_unit,\r\n    I.item_stocks,\r\n    C.category_name AS category_description,\r\n    I.item_description\r\nFROM Items I\r\nJOIN Inventory C ON I.category_id = C.category_id";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection)) 
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            ProductCard product = new ProductCard
                            {
                                ProductName = reader["item_name"].ToString(),
                                ProductPrice = Convert.ToDouble(reader["item_price"]),
                                SoldBy = reader["item_unit"].ToString(),
                                Stock = (int)reader["item_stocks"],
                                Category = reader["category_description"].ToString().ToLower(),
                                Description = reader["item_description"].ToString()
                            };

                            ProductLoadImage(product); // Load image for the product

                            products.Add(product);
                            flowLayoutPanel1.Controls.Add(product); // Ensure UI updates
                            product.Click += ClickHandler;
                            product.MouseEnter += ProductCard_MouseEnter;
                            product.MouseLeave += ProductCard_MouseLeave;

                            product.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, product.Width, product.Height, 15, 15));
                        }
                    }
                }
            }
        }

        private void DecrementFromStocks()
        {
            ConnectionInstance.Instance().getConn();
            foreach (var item in cartItems)
            {
                string query = ("exec decrement @productname = " + item.ProductName);

                int quantity = item.Quantity;

                
            }
        }
        
        private void ProductLoadImage(ProductCard product)
        {
            ResourceManager rm = GroceryPOS.Properties.Resources.ResourceManager;

            Image img = (Image)rm.GetObject(product.ProductName);

            if (img != null)
            {
                product.ProductImage = img;
            }
            else
            {
                product.ProductImage = GroceryPOS.Properties.Resources.broken_image;
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
            pictureBox1.BackColor = Color.FromArgb(114, 137, 218);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to clear your order?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                flowLayoutPanel2.Controls.Clear();
                cartItems.Clear();
                UpdateSummary();
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
            panel1.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, panel1.Width, panel1.Height, 11, 11));
            panel3.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, panel3.Width, panel3.Height, 11, 11));
            flowLayoutPanel2.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, flowLayoutPanel2.Width, flowLayoutPanel2.Height, 11, 11));
            pictureBox1.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, pictureBox1.Width, pictureBox1.Height, 10, 10));
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

                    rec.StartPosition = FormStartPosition.Manual;
                    //rec.Location = new Point(
                    //    this.Location.X + this.Width, 
                    //    this.Location.Y
                    //);

                    //rec.Show();
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