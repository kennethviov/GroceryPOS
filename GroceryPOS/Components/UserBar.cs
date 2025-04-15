using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GroceryPOS.Components
{
    public partial class UserBar : UserControl
    {
        public UserBar()
        {
            InitializeComponent();

            foreach (Control control in this.Controls)
            {
                control.Click += (s, e) => this.OnClick(e); // Redirect click to UserControl
            }
        }

        public string Username
        {
            get => label1.Text;
            set => label1.Text = value;
        }

        private const int MaxWidth = 160;
        private const int MaxHeight = 43;
        private const int MinWidth = 160;
        private const int MinHeight = 43;

        protected override void SetBoundsCore(int x, int y, int width, int height, BoundsSpecified specified)
        {
            width = Math.Max(MinWidth, Math.Min(MaxWidth, width));
            height = Math.Max(MinHeight, Math.Min(MaxHeight, height));

            base.SetBoundsCore(x, y, width, height, specified);
        }
    }
}
