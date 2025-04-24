using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GroceryPOS
{
    public partial class Inventory : Form
    {
        public Inventory()
        {
            InitializeComponent();
            RegionLoad();
        }

        private void RegionLoad()
        {

        }

        private void CloseButton_MouseEnter(object sender, EventArgs e) { closePictureBox.BackColor = Color.FromArgb(189, 26, 26); }

        private void CloseButton_MouseDown(object sender, MouseEventArgs e) { closePictureBox.BackColor = Color.FromArgb(138, 30, 30); }

        private void CloseButton_MouseLeave(object sender, EventArgs e) { closePictureBox.BackColor = Color.FromArgb(114, 137, 218); }

        private void BackButton_MouseEnter(object sender, EventArgs e) { backPictureBox.BackColor = Color.FromArgb(95, 117, 194); }

        private void BackButton_MouseDown(object sender, MouseEventArgs e) { backPictureBox.BackColor = Color.FromArgb(160, 179, 246); }

        private void BackButton_MouseLeave(object sender, EventArgs e) { backPictureBox.BackColor = Color.FromArgb(114, 137, 218); }
    }
}
