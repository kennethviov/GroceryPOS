using GroceryPOS.Components;
using GroceryStroreDiscountGUI.Components;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace GroceryPOS
{
    public partial class Receipt: Form
    {
        readonly List<ProductInCart> cartItems;

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

        public Receipt(List<ProductInCart> cartItems)
        {
            InitializeComponent();

            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));

            this.cartItems = cartItems;
        }

        private void UpdateSummary()
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

        private void Receipt_Load(object sender, EventArgs e)
        {
            foreach (var item in cartItems)
            {

                if (item.Quantity == 0) continue;

                flowLayoutPanel1.Controls.Add(new UnitInReceipt()
                {
                    Title = item.Title,
                    Price = item.Price,
                    Quantity = item.Quantity
                });
            }

            UpdateSummary();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape)
            {
                this.Dispose();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}
