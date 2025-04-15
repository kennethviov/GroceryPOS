namespace GroceryPOS.Components
{
    partial class UnitInReceipt
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.title = new System.Windows.Forms.Label();
            this.quantity = new System.Windows.Forms.Label();
            this.unitPrice = new System.Windows.Forms.Label();
            this.unitTotal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.Location = new System.Drawing.Point(54, 0);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(214, 25);
            this.title.TabIndex = 5;
            this.title.Text = "Product";
            this.title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // quantity
            // 
            this.quantity.Location = new System.Drawing.Point(-3, 0);
            this.quantity.Name = "quantity";
            this.quantity.Size = new System.Drawing.Size(30, 25);
            this.quantity.TabIndex = 6;
            this.quantity.Text = "0";
            this.quantity.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // unitPrice
            // 
            this.unitPrice.Location = new System.Drawing.Point(274, 0);
            this.unitPrice.Name = "unitPrice";
            this.unitPrice.Size = new System.Drawing.Size(70, 25);
            this.unitPrice.TabIndex = 7;
            this.unitPrice.Text = "0.00";
            this.unitPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // unitTotal
            // 
            this.unitTotal.Location = new System.Drawing.Point(351, 0);
            this.unitTotal.Name = "unitTotal";
            this.unitTotal.Size = new System.Drawing.Size(75, 25);
            this.unitTotal.TabIndex = 8;
            this.unitTotal.Text = "0.00";
            this.unitTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // UnitInReceipt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.title);
            this.Controls.Add(this.quantity);
            this.Controls.Add(this.unitPrice);
            this.Controls.Add(this.unitTotal);
            this.Name = "UnitInReceipt";
            this.Size = new System.Drawing.Size(426, 25);
            this.Load += new System.EventHandler(this.UnitInReceipt_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label quantity;
        private System.Windows.Forms.Label unitPrice;
        private System.Windows.Forms.Label unitTotal;
    }
}
