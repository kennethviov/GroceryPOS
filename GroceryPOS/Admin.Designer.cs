using System.Drawing;

namespace GroceryPOS
{
    partial class Admin
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dockertop = new System.Windows.Forms.Panel();
            this.backPictureBox = new System.Windows.Forms.PictureBox();
            this.closePictureBox = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SidePanel = new System.Windows.Forms.Panel();
            this.InventoryBtn = new System.Windows.Forms.Button();
            this.SalesBtn = new System.Windows.Forms.Button();
            this.stockPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.InventoryPanel = new System.Windows.Forms.Panel();
            this.editBtn = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SalesPanel = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label7 = new System.Windows.Forms.Label();
            this.dockertop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.backPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closePictureBox)).BeginInit();
            this.panel1.SuspendLayout();
            this.InventoryPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.editBtn)).BeginInit();
            this.SalesPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.BackColor = System.Drawing.SystemColors.Control;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.Gray;
            this.textBox1.Location = new System.Drawing.Point(223, 62);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(674, 1);
            this.textBox1.TabIndex = 11;
            this.textBox1.Text = "  \r\n              Search\r\n\r\n";
            // 
            // dockertop
            // 
            this.dockertop.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dockertop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(137)))), ((int)(((byte)(218)))));
            this.dockertop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.dockertop.Controls.Add(this.backPictureBox);
            this.dockertop.Controls.Add(this.closePictureBox);
            this.dockertop.Location = new System.Drawing.Point(12, 12);
            this.dockertop.Name = "dockertop";
            this.dockertop.Size = new System.Drawing.Size(1154, 44);
            this.dockertop.TabIndex = 10;
            this.dockertop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Dockertop_MouseDown);
            this.dockertop.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Dockertop_MouseMove);
            this.dockertop.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Dockertop_MouseUp);
            // 
            // backPictureBox
            // 
            this.backPictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backPictureBox.Image = global::GroceryPOS.Properties.Resources.left;
            this.backPictureBox.Location = new System.Drawing.Point(13, 9);
            this.backPictureBox.Name = "backPictureBox";
            this.backPictureBox.Size = new System.Drawing.Size(24, 24);
            this.backPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.backPictureBox.TabIndex = 2;
            this.backPictureBox.TabStop = false;
            this.backPictureBox.Click += new System.EventHandler(this.backPictureBox_Click);
            this.backPictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BackButton_MouseDown);
            this.backPictureBox.MouseEnter += new System.EventHandler(this.BackButton_MouseEnter);
            this.backPictureBox.MouseLeave += new System.EventHandler(this.BackButton_MouseLeave);
            this.backPictureBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BackPictureBox_MouseUp);
            // 
            // closePictureBox
            // 
            this.closePictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closePictureBox.Image = global::GroceryPOS.Properties.Resources.xclose;
            this.closePictureBox.Location = new System.Drawing.Point(1120, 9);
            this.closePictureBox.Name = "closePictureBox";
            this.closePictureBox.Size = new System.Drawing.Size(24, 24);
            this.closePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.closePictureBox.TabIndex = 1;
            this.closePictureBox.TabStop = false;
            this.closePictureBox.Click += new System.EventHandler(this.ClosePictureBox_Click);
            this.closePictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CloseButton_MouseDown);
            this.closePictureBox.MouseEnter += new System.EventHandler(this.CloseButton_MouseEnter);
            this.closePictureBox.MouseLeave += new System.EventHandler(this.CloseButton_MouseLeave);
            this.closePictureBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ClosePictureBox_MouseUp);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.Controls.Add(this.SidePanel);
            this.panel1.Controls.Add(this.InventoryBtn);
            this.panel1.Controls.Add(this.SalesBtn);
            this.panel1.Location = new System.Drawing.Point(12, 62);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(194, 568);
            this.panel1.TabIndex = 8;
            // 
            // SidePanel
            // 
            this.SidePanel.BackColor = System.Drawing.Color.LightGray;
            this.SidePanel.Location = new System.Drawing.Point(0, 9);
            this.SidePanel.Name = "SidePanel";
            this.SidePanel.Size = new System.Drawing.Size(10, 46);
            this.SidePanel.TabIndex = 7;
            // 
            // InventoryBtn
            // 
            this.InventoryBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.InventoryBtn.FlatAppearance.BorderSize = 0;
            this.InventoryBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.InventoryBtn.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InventoryBtn.ForeColor = System.Drawing.Color.Gray;
            this.InventoryBtn.Image = global::GroceryPOS.Properties.Resources.inventory__2_;
            this.InventoryBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.InventoryBtn.Location = new System.Drawing.Point(0, 9);
            this.InventoryBtn.Name = "InventoryBtn";
            this.InventoryBtn.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.InventoryBtn.Size = new System.Drawing.Size(193, 48);
            this.InventoryBtn.TabIndex = 2;
            this.InventoryBtn.Text = "          Inventory";
            this.InventoryBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.InventoryBtn.UseVisualStyleBackColor = true;
            this.InventoryBtn.Click += new System.EventHandler(this.InvOrSlsBtn_Click);
            // 
            // SalesBtn
            // 
            this.SalesBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.SalesBtn.FlatAppearance.BorderSize = 0;
            this.SalesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SalesBtn.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalesBtn.ForeColor = System.Drawing.Color.Gray;
            this.SalesBtn.Image = global::GroceryPOS.Properties.Resources.bill__1_;
            this.SalesBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SalesBtn.Location = new System.Drawing.Point(0, 61);
            this.SalesBtn.Name = "SalesBtn";
            this.SalesBtn.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.SalesBtn.Size = new System.Drawing.Size(193, 48);
            this.SalesBtn.TabIndex = 3;
            this.SalesBtn.Text = "          Sales";
            this.SalesBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SalesBtn.UseVisualStyleBackColor = true;
            this.SalesBtn.Click += new System.EventHandler(this.InvOrSlsBtn_Click);
            // 
            // stockPanel
            // 
            this.stockPanel.AutoScroll = true;
            this.stockPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.stockPanel.Location = new System.Drawing.Point(0, 69);
            this.stockPanel.Name = "stockPanel";
            this.stockPanel.Size = new System.Drawing.Size(948, 499);
            this.stockPanel.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 37);
            this.label1.TabIndex = 13;
            this.label1.Text = "Inventory";
            // 
            // InventoryPanel
            // 
            this.InventoryPanel.Controls.Add(this.editBtn);
            this.InventoryPanel.Controls.Add(this.label5);
            this.InventoryPanel.Controls.Add(this.label4);
            this.InventoryPanel.Controls.Add(this.label3);
            this.InventoryPanel.Controls.Add(this.label2);
            this.InventoryPanel.Controls.Add(this.stockPanel);
            this.InventoryPanel.Controls.Add(this.label1);
            this.InventoryPanel.Location = new System.Drawing.Point(218, 62);
            this.InventoryPanel.Name = "InventoryPanel";
            this.InventoryPanel.Size = new System.Drawing.Size(948, 568);
            this.InventoryPanel.TabIndex = 14;
            // 
            // editBtn
            // 
            this.editBtn.Image = global::GroceryPOS.Properties.Resources.edit;
            this.editBtn.Location = new System.Drawing.Point(914, 9);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(24, 24);
            this.editBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.editBtn.TabIndex = 18;
            this.editBtn.TabStop = false;
            this.editBtn.Click += new System.EventHandler(this.EditBtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(849, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 18);
            this.label5.TabIndex = 17;
            this.label5.Text = "Stock";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(594, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 18);
            this.label4.TabIndex = 16;
            this.label4.Text = "Category";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(303, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 18);
            this.label3.TabIndex = 15;
            this.label3.Text = "Price";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 18);
            this.label2.TabIndex = 14;
            this.label2.Text = "Item";
            // 
            // SalesPanel
            // 
            this.SalesPanel.BackColor = System.Drawing.Color.White;
            this.SalesPanel.Controls.Add(this.panel2);
            this.SalesPanel.Location = new System.Drawing.Point(218, 62);
            this.SalesPanel.Name = "SalesPanel";
            this.SalesPanel.Size = new System.Drawing.Size(948, 568);
            this.SalesPanel.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(5, 2);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 31);
            this.label6.TabIndex = 0;
            this.label6.Text = "Sales ";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.flowLayoutPanel1);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Location = new System.Drawing.Point(488, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(460, 568);
            this.panel2.TabIndex = 1;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.Control;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(11, 69);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(437, 499);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(8, 48);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(429, 17);
            this.label7.TabIndex = 13;
            this.label7.Text = "Sales ID               Date                                                   Sal" +
    "es Total";
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1178, 642);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dockertop);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.SalesPanel);
            this.Controls.Add(this.InventoryPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventory";
            this.dockertop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.backPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closePictureBox)).EndInit();
            this.panel1.ResumeLayout(false);
            this.InventoryPanel.ResumeLayout(false);
            this.InventoryPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.editBtn)).EndInit();
            this.SalesPanel.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel dockertop;
        private System.Windows.Forms.PictureBox closePictureBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel SidePanel;
        private System.Windows.Forms.Button InventoryBtn;
        private System.Windows.Forms.Button SalesBtn;
        private System.Windows.Forms.FlowLayoutPanel stockPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox backPictureBox;
        private System.Windows.Forms.Panel InventoryPanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel SalesPanel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox editBtn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label7;
    }
}