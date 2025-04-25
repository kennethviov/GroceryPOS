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
    public partial class Inventory : Form
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

        public Inventory()
        {
            InitializeComponent();
            RegionLoad();
        }

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

        private void CloseButton_MouseEnter(object sender, EventArgs e) { closePictureBox.BackColor = Color.FromArgb(189, 26, 26); }

        private void CloseButton_MouseDown(object sender, MouseEventArgs e) { closePictureBox.BackColor = Color.FromArgb(138, 30, 30); }

        private void ClosePictureBox_MouseUp(object sender, MouseEventArgs e) { closePictureBox.BackColor = Color.FromArgb(189, 26, 26); }

        private void CloseButton_MouseLeave(object sender, EventArgs e) { closePictureBox.BackColor = Color.FromArgb(114, 137, 218); }

        private void BackButton_MouseEnter(object sender, EventArgs e) { backPictureBox.BackColor = Color.FromArgb(95, 117, 194); }

        private void BackButton_MouseDown(object sender, MouseEventArgs e) { backPictureBox.BackColor = Color.FromArgb(160, 179, 246); }

        private void BackButton_MouseLeave(object sender, EventArgs e) { backPictureBox.BackColor = Color.FromArgb(114, 137, 218); }

        private void BackPictureBox_MouseUp(object sender, MouseEventArgs e) { backPictureBox.BackColor = Color.FromArgb(95, 117, 194); }

        private bool dragging = false;
        private Point startPoint = new Point(0, 0);

        private void Dockertop_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            startPoint = new Point(e.X, e.Y);
        }

        private void Dockertop_MouseUp(object sender, MouseEventArgs e) { dragging = false; }

        private void closePictureBox_Click(object sender, EventArgs e)
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

        private void backPictureBox_MouseUp(object sender, MouseEventArgs e)
        {

        }

        private void Dockertop_MouseMove(object sender, MouseEventArgs e)
        {

        }
    }
}
