namespace GroceryPOS.Components
{
    partial class DBItem
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
            this.itemImage = new System.Windows.Forms.PictureBox();
            this.itemName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.itemCategory = new System.Windows.Forms.Label();
            this.itemPrice = new System.Windows.Forms.Label();
            this.PesoSign = new System.Windows.Forms.Label();
            this.itemStock = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.itemImage)).BeginInit();
            this.SuspendLayout();
            // 
            // itemImage
            // 
            this.itemImage.Image = global::GroceryPOS.Properties.Resources.broken_image;
            this.itemImage.Location = new System.Drawing.Point(3, 2);
            this.itemImage.Name = "itemImage";
            this.itemImage.Size = new System.Drawing.Size(24, 24);
            this.itemImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.itemImage.TabIndex = 0;
            this.itemImage.TabStop = false;
            // 
            // itemName
            // 
            this.itemName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemName.Location = new System.Drawing.Point(33, 6);
            this.itemName.Name = "itemName";
            this.itemName.Size = new System.Drawing.Size(178, 18);
            this.itemName.TabIndex = 1;
            this.itemName.Text = "ItemName";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(302, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "label2";
            // 
            // itemCategory
            // 
            this.itemCategory.AutoSize = true;
            this.itemCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemCategory.Location = new System.Drawing.Point(598, 6);
            this.itemCategory.Name = "itemCategory";
            this.itemCategory.Size = new System.Drawing.Size(55, 15);
            this.itemCategory.TabIndex = 20;
            this.itemCategory.Text = "Category";
            // 
            // itemPrice
            // 
            this.itemPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemPrice.Location = new System.Drawing.Point(302, 6);
            this.itemPrice.Name = "itemPrice";
            this.itemPrice.Size = new System.Drawing.Size(100, 18);
            this.itemPrice.TabIndex = 19;
            this.itemPrice.Text = "Price";
            // 
            // PesoSign
            // 
            this.PesoSign.AutoSize = true;
            this.PesoSign.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PesoSign.Location = new System.Drawing.Point(291, 6);
            this.PesoSign.Name = "PesoSign";
            this.PesoSign.Size = new System.Drawing.Size(15, 15);
            this.PesoSign.TabIndex = 22;
            this.PesoSign.Text = "₱";
            // 
            // itemStock
            // 
            this.itemStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemStock.Location = new System.Drawing.Point(859, 3);
            this.itemStock.MaxLength = 3;
            this.itemStock.Name = "itemStock";
            this.itemStock.ReadOnly = true;
            this.itemStock.Size = new System.Drawing.Size(41, 21);
            this.itemStock.TabIndex = 23;
            this.itemStock.Text = "1";
            this.itemStock.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // DBItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.itemStock);
            this.Controls.Add(this.PesoSign);
            this.Controls.Add(this.itemCategory);
            this.Controls.Add(this.itemPrice);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.itemName);
            this.Controls.Add(this.itemImage);
            this.Name = "DBItem";
            this.Size = new System.Drawing.Size(912, 28);
            ((System.ComponentModel.ISupportInitialize)(this.itemImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox itemImage;
        private System.Windows.Forms.Label itemName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label itemCategory;
        private System.Windows.Forms.Label itemPrice;
        private System.Windows.Forms.Label PesoSign;
        private System.Windows.Forms.TextBox itemStock;
    }
}
