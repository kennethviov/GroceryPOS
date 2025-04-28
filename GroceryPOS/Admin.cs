using GroceryPOS.Components;
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

namespace GroceryPOS
{
    public partial class Admin : Form
    {

        readonly List<Item> items;
        readonly List<DBItem> dbItems = new List<DBItem>();
        readonly DataHandler dh;

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

        public Admin()
        {
            InitializeComponent();
            RegionLoad();

            dh = new DataHandler();
            items = dh.LoadItemsFromDatabase();
            LoadToInventoryPanel();
        }

        private void LoadToInventoryPanel()
        {
            StoreToAComponent();

            foreach (var dbItem in dbItems)
            {
                stockPanel.Controls.Add(dbItem);

                dbItem.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, dbItem.Width, dbItem.Height, 15, 15));
            }
        }

        private void StoreToAComponent()
        {
            foreach (var item in items) 
            {
                DBItem dbItem = new DBItem()
                {
                    ItemImage = item.Image,
                    ItemName = item.Name,
                    ItemPrice = item.Price.ToString("N2"),
                    ItemCategory = item.Category,
                    ItemStock = item.Stock.ToString()
                };

                dbItems.Add(dbItem);
            }
        }




        // / This method is used to create rounded corners for the form and its controls
        private void RegionLoad()
        {
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, this.Width, this.Height, 20, 20));
            dockertop.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, dockertop.Width, dockertop.Height, 11, 11));
            closePictureBox.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, closePictureBox.Width, closePictureBox.Height, 4, 4));
            backPictureBox.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, backPictureBox.Width, backPictureBox.Height, 4, 4));
            panel1.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, panel1.Width, panel1.Height, 11, 11));
            InventoryPanel.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, InventoryPanel.Width, InventoryPanel.Height, 11, 11));
            stockPanel.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, stockPanel.Width, stockPanel.Height, 11, 11));
        }


        //
        //
        // Methods below this are used to handle the mouse events for the buttons and others
        //
        //
        private void CloseButton_MouseEnter(object sender, EventArgs e) { closePictureBox.BackColor = Color.FromArgb(189, 26, 26); }

        private void CloseButton_MouseDown(object sender, MouseEventArgs e) { closePictureBox.BackColor = Color.FromArgb(138, 30, 30); }

        private void ClosePictureBox_MouseUp(object sender, MouseEventArgs e) { closePictureBox.BackColor = Color.FromArgb(189, 26, 26); }

        private void CloseButton_MouseLeave(object sender, EventArgs e) { closePictureBox.BackColor = Color.FromArgb(148, 168, 78); }

        private void BackButton_MouseEnter(object sender, EventArgs e) { backPictureBox.BackColor = Color.FromArgb(129, 148, 61); }

        private void BackButton_MouseDown(object sender, MouseEventArgs e) { backPictureBox.BackColor = Color.FromArgb(167, 190, 89); }

        private void BackPictureBox_MouseUp(object sender, MouseEventArgs e) { backPictureBox.BackColor = Color.FromArgb(129, 148, 61); }

        private void BackButton_MouseLeave(object sender, EventArgs e) { backPictureBox.BackColor = Color.FromArgb(148, 168, 78); }


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

        private void ClosePictureBox_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void InventoryBtn_Click(object sender, EventArgs e)
        {
            SidePanel.Height = InventoryBtn.Height;
            SidePanel.Top = InventoryBtn.Top;
            InventoryBtn.BackColor = Color.FromArgb(229, 229, 229);
            SalesBtn.BackColor = Color.FromArgb(255, 255, 255);
            InventoryPanel.Visible = true;
            SalesPanel.Visible = false;
        }

        private void SalesBtn_Click(object sender, EventArgs e)
        {
            SidePanel.Height = SalesBtn.Height;
            SidePanel.Top = SalesBtn.Top;
            SalesBtn.BackColor = Color.FromArgb(229, 229, 229);
            InventoryBtn.BackColor = Color.FromArgb(255, 255, 255);
            SalesPanel.Visible= true;
            InventoryPanel.Visible = false;
        }

        
    }
}
