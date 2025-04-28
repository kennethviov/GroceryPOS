namespace GroceryPOS
{
    partial class MainFrame
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainFrame));
            this.dockertop = new System.Windows.Forms.Panel();
            this.closeBtn = new System.Windows.Forms.PictureBox();
            this.walkingtext = new System.Windows.Forms.Label();
            this.closeopensidebar = new System.Windows.Forms.Panel();
            this.SidePanel = new System.Windows.Forms.Panel();
            this.menuBtn = new System.Windows.Forms.Button();
            this.allitemsBtn = new System.Windows.Forms.Button();
            this.fruitsBtn = new System.Windows.Forms.Button();
            this.drinksBtn = new System.Windows.Forms.Button();
            this.meatsBtn = new System.Windows.Forms.Button();
            this.vegetablesBtn = new System.Windows.Forms.Button();
            this.liquorBtn = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.totalLabel = new System.Windows.Forms.Label();
            this.discountLabel = new System.Windows.Forms.Label();
            this.discountpLabel = new System.Windows.Forms.Label();
            this.subtotalLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.checkoutBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.userPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.clearCartBtn = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.dockertop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closeBtn)).BeginInit();
            this.closeopensidebar.SuspendLayout();
            this.panel3.SuspendLayout();
            this.userPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clearCartBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // dockertop
            // 
            this.dockertop.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dockertop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(168)))), ((int)(((byte)(78)))));
            this.dockertop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.dockertop.Controls.Add(this.closeBtn);
            this.dockertop.Controls.Add(this.walkingtext);
            this.dockertop.Location = new System.Drawing.Point(12, 12);
            this.dockertop.Name = "dockertop";
            this.dockertop.Size = new System.Drawing.Size(1154, 44);
            this.dockertop.TabIndex = 1;
            this.dockertop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Dockertop_MouseDown);
            this.dockertop.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Dockertop_MouseMove);
            this.dockertop.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Dockertop_MouseUp);
            // 
            // closeBtn
            // 
            this.closeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeBtn.Image = global::GroceryPOS.Properties.Resources.xclose;
            this.closeBtn.Location = new System.Drawing.Point(1120, 8);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(24, 24);
            this.closeBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.closeBtn.TabIndex = 1;
            this.closeBtn.TabStop = false;
            this.closeBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            this.closeBtn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CloseBtn_MouseDown);
            this.closeBtn.MouseEnter += new System.EventHandler(this.CloseBtn_MouseEnter);
            this.closeBtn.MouseLeave += new System.EventHandler(this.CLoseBtn_MouseLeave);
            // 
            // walkingtext
            // 
            this.walkingtext.AutoSize = true;
            this.walkingtext.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.walkingtext.ForeColor = System.Drawing.Color.Crimson;
            this.walkingtext.Location = new System.Drawing.Point(29, 12);
            this.walkingtext.Name = "walkingtext";
            this.walkingtext.Size = new System.Drawing.Size(1294, 22);
            this.walkingtext.TabIndex = 0;
            this.walkingtext.Text = "\"🛒 Welcome to  Barangay Basket - Your Budget-Friendly Grocery!\"     \"📢 Promo Al" +
    "ert: Up to 20% off!\"     \"\"🧺 Barangay Basket. Save More. Live Better.\"";
            // 
            // closeopensidebar
            // 
            this.closeopensidebar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.closeopensidebar.BackColor = System.Drawing.SystemColors.Control;
            this.closeopensidebar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.closeopensidebar.Controls.Add(this.SidePanel);
            this.closeopensidebar.Controls.Add(this.menuBtn);
            this.closeopensidebar.Controls.Add(this.allitemsBtn);
            this.closeopensidebar.Controls.Add(this.fruitsBtn);
            this.closeopensidebar.Controls.Add(this.drinksBtn);
            this.closeopensidebar.Controls.Add(this.meatsBtn);
            this.closeopensidebar.Controls.Add(this.vegetablesBtn);
            this.closeopensidebar.Controls.Add(this.liquorBtn);
            this.closeopensidebar.Location = new System.Drawing.Point(12, 62);
            this.closeopensidebar.Name = "closeopensidebar";
            this.closeopensidebar.Size = new System.Drawing.Size(194, 568);
            this.closeopensidebar.TabIndex = 0;
            // 
            // SidePanel
            // 
            this.SidePanel.BackColor = System.Drawing.Color.LightGray;
            this.SidePanel.Location = new System.Drawing.Point(0, 5);
            this.SidePanel.Name = "SidePanel";
            this.SidePanel.Size = new System.Drawing.Size(10, 46);
            this.SidePanel.TabIndex = 7;
            // 
            // menuBtn
            // 
            this.menuBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.menuBtn.FlatAppearance.BorderSize = 0;
            this.menuBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menuBtn.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuBtn.ForeColor = System.Drawing.Color.Gray;
            this.menuBtn.Image = global::GroceryPOS.Properties.Resources.menu;
            this.menuBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menuBtn.Location = new System.Drawing.Point(0, 3);
            this.menuBtn.Name = "menuBtn";
            this.menuBtn.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.menuBtn.Size = new System.Drawing.Size(193, 48);
            this.menuBtn.TabIndex = 9;
            this.menuBtn.Text = "         Menu";
            this.menuBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menuBtn.UseVisualStyleBackColor = true;
            this.menuBtn.Click += new System.EventHandler(this.CatBtns_Click);
            // 
            // allitemsBtn
            // 
            this.allitemsBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.allitemsBtn.FlatAppearance.BorderSize = 0;
            this.allitemsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.allitemsBtn.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.allitemsBtn.ForeColor = System.Drawing.Color.Gray;
            this.allitemsBtn.Image = ((System.Drawing.Image)(resources.GetObject("allitemsBtn.Image")));
            this.allitemsBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.allitemsBtn.Location = new System.Drawing.Point(0, 55);
            this.allitemsBtn.Name = "allitemsBtn";
            this.allitemsBtn.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.allitemsBtn.Size = new System.Drawing.Size(193, 48);
            this.allitemsBtn.TabIndex = 2;
            this.allitemsBtn.Text = "          All Items";
            this.allitemsBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.allitemsBtn.UseVisualStyleBackColor = true;
            this.allitemsBtn.Click += new System.EventHandler(this.CatBtns_Click);
            // 
            // fruitsBtn
            // 
            this.fruitsBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.fruitsBtn.FlatAppearance.BorderSize = 0;
            this.fruitsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fruitsBtn.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fruitsBtn.ForeColor = System.Drawing.Color.Gray;
            this.fruitsBtn.Image = ((System.Drawing.Image)(resources.GetObject("fruitsBtn.Image")));
            this.fruitsBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.fruitsBtn.Location = new System.Drawing.Point(0, 211);
            this.fruitsBtn.Name = "fruitsBtn";
            this.fruitsBtn.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.fruitsBtn.Size = new System.Drawing.Size(193, 48);
            this.fruitsBtn.TabIndex = 5;
            this.fruitsBtn.Text = "          Fruits";
            this.fruitsBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.fruitsBtn.UseVisualStyleBackColor = true;
            this.fruitsBtn.Click += new System.EventHandler(this.CatBtns_Click);
            // 
            // drinksBtn
            // 
            this.drinksBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.drinksBtn.FlatAppearance.BorderSize = 0;
            this.drinksBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.drinksBtn.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drinksBtn.ForeColor = System.Drawing.Color.Gray;
            this.drinksBtn.Image = ((System.Drawing.Image)(resources.GetObject("drinksBtn.Image")));
            this.drinksBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.drinksBtn.Location = new System.Drawing.Point(0, 263);
            this.drinksBtn.Name = "drinksBtn";
            this.drinksBtn.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.drinksBtn.Size = new System.Drawing.Size(193, 48);
            this.drinksBtn.TabIndex = 6;
            this.drinksBtn.Text = "          Drinks";
            this.drinksBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.drinksBtn.UseVisualStyleBackColor = true;
            this.drinksBtn.Click += new System.EventHandler(this.CatBtns_Click);
            // 
            // meatsBtn
            // 
            this.meatsBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.meatsBtn.FlatAppearance.BorderSize = 0;
            this.meatsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.meatsBtn.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.meatsBtn.ForeColor = System.Drawing.Color.Gray;
            this.meatsBtn.Image = ((System.Drawing.Image)(resources.GetObject("meatsBtn.Image")));
            this.meatsBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.meatsBtn.Location = new System.Drawing.Point(0, 159);
            this.meatsBtn.Name = "meatsBtn";
            this.meatsBtn.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.meatsBtn.Size = new System.Drawing.Size(193, 48);
            this.meatsBtn.TabIndex = 4;
            this.meatsBtn.Text = "          Meats";
            this.meatsBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.meatsBtn.UseVisualStyleBackColor = true;
            this.meatsBtn.Click += new System.EventHandler(this.CatBtns_Click);
            // 
            // vegetablesBtn
            // 
            this.vegetablesBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.vegetablesBtn.FlatAppearance.BorderSize = 0;
            this.vegetablesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.vegetablesBtn.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vegetablesBtn.ForeColor = System.Drawing.Color.Gray;
            this.vegetablesBtn.Image = ((System.Drawing.Image)(resources.GetObject("vegetablesBtn.Image")));
            this.vegetablesBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.vegetablesBtn.Location = new System.Drawing.Point(0, 107);
            this.vegetablesBtn.Name = "vegetablesBtn";
            this.vegetablesBtn.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.vegetablesBtn.Size = new System.Drawing.Size(193, 48);
            this.vegetablesBtn.TabIndex = 3;
            this.vegetablesBtn.Text = "          Vegetables";
            this.vegetablesBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.vegetablesBtn.UseVisualStyleBackColor = true;
            this.vegetablesBtn.Click += new System.EventHandler(this.CatBtns_Click);
            // 
            // liquorBtn
            // 
            this.liquorBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.liquorBtn.FlatAppearance.BorderSize = 0;
            this.liquorBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.liquorBtn.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.liquorBtn.ForeColor = System.Drawing.Color.Gray;
            this.liquorBtn.Image = global::GroceryPOS.Properties.Resources.bar;
            this.liquorBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.liquorBtn.Location = new System.Drawing.Point(0, 315);
            this.liquorBtn.Name = "liquorBtn";
            this.liquorBtn.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.liquorBtn.Size = new System.Drawing.Size(193, 48);
            this.liquorBtn.TabIndex = 8;
            this.liquorBtn.Text = "          Liquor";
            this.liquorBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.liquorBtn.UseVisualStyleBackColor = true;
            this.liquorBtn.Click += new System.EventHandler(this.CatBtns_Click);
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
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "  \r\n              Search\r\n\r\n";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.Control;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(212, 62);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(652, 566);
            this.flowLayoutPanel1.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.totalLabel);
            this.panel3.Controls.Add(this.discountLabel);
            this.panel3.Controls.Add(this.discountpLabel);
            this.panel3.Controls.Add(this.subtotalLabel);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.checkoutBtn);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Location = new System.Drawing.Point(869, 457);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(297, 174);
            this.panel3.TabIndex = 5;
            // 
            // totalLabel
            // 
            this.totalLabel.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalLabel.Location = new System.Drawing.Point(73, 72);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(204, 27);
            this.totalLabel.TabIndex = 19;
            this.totalLabel.Text = "₱ 0.00";
            this.totalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // discountLabel
            // 
            this.discountLabel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.discountLabel.Location = new System.Drawing.Point(177, 50);
            this.discountLabel.Name = "discountLabel";
            this.discountLabel.Size = new System.Drawing.Size(100, 16);
            this.discountLabel.TabIndex = 18;
            this.discountLabel.Text = "₱ 0.00";
            this.discountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // discountpLabel
            // 
            this.discountpLabel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.discountpLabel.Location = new System.Drawing.Point(177, 32);
            this.discountpLabel.Name = "discountpLabel";
            this.discountpLabel.Size = new System.Drawing.Size(100, 16);
            this.discountpLabel.TabIndex = 17;
            this.discountpLabel.Text = "0%";
            this.discountpLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // subtotalLabel
            // 
            this.subtotalLabel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subtotalLabel.Location = new System.Drawing.Point(177, 16);
            this.subtotalLabel.Name = "subtotalLabel";
            this.subtotalLabel.Size = new System.Drawing.Size(100, 16);
            this.subtotalLabel.TabIndex = 16;
            this.subtotalLabel.Text = "₱ 0.00";
            this.subtotalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(19, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 16);
            this.label6.TabIndex = 15;
            this.label6.Text = "Discount %";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(19, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "Subtotal";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(19, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 16);
            this.label5.TabIndex = 14;
            this.label5.Text = "Discount";
            // 
            // checkoutBtn
            // 
            this.checkoutBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkoutBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(168)))), ((int)(((byte)(78)))));
            this.checkoutBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkoutBtn.FlatAppearance.BorderSize = 0;
            this.checkoutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkoutBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkoutBtn.ForeColor = System.Drawing.Color.White;
            this.checkoutBtn.Location = new System.Drawing.Point(22, 111);
            this.checkoutBtn.Name = "checkoutBtn";
            this.checkoutBtn.Size = new System.Drawing.Size(257, 49);
            this.checkoutBtn.TabIndex = 11;
            this.checkoutBtn.Text = "Checkout";
            this.checkoutBtn.UseVisualStyleBackColor = false;
            this.checkoutBtn.Click += new System.EventHandler(this.CheckoutBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(17, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 27);
            this.label4.TabIndex = 13;
            this.label4.Text = "Total";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.AutoScroll = true;
            this.flowLayoutPanel2.BackColor = System.Drawing.SystemColors.Control;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(869, 93);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(2);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(297, 319);
            this.flowLayoutPanel2.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(3, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Current Order";
            // 
            // userPanel
            // 
            this.userPanel.Controls.Add(this.panel1);
            this.userPanel.Location = new System.Drawing.Point(211, 62);
            this.userPanel.Name = "userPanel";
            this.userPanel.Size = new System.Drawing.Size(955, 569);
            this.userPanel.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.clearCartBtn);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(658, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(297, 379);
            this.panel1.TabIndex = 3;
            // 
            // clearCartBtn
            // 
            this.clearCartBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clearCartBtn.Image = global::GroceryPOS.Properties.Resources.trashbin;
            this.clearCartBtn.Location = new System.Drawing.Point(263, 352);
            this.clearCartBtn.Name = "clearCartBtn";
            this.clearCartBtn.Size = new System.Drawing.Size(20, 20);
            this.clearCartBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.clearCartBtn.TabIndex = 2;
            this.clearCartBtn.TabStop = false;
            this.clearCartBtn.Click += new System.EventHandler(this.ClearCartBtn_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // MainFrame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1178, 642);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dockertop);
            this.Controls.Add(this.userPanel);
            this.Controls.Add(this.closeopensidebar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "MainFrame";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Frame";
            this.dockertop.ResumeLayout(false);
            this.dockertop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closeBtn)).EndInit();
            this.closeopensidebar.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.userPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clearCartBtn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel dockertop;
        private System.Windows.Forms.Panel closeopensidebar;
        private System.Windows.Forms.Button allitemsBtn;
        private System.Windows.Forms.Button vegetablesBtn;
        private System.Windows.Forms.Button meatsBtn;
        private System.Windows.Forms.Button drinksBtn;
        private System.Windows.Forms.Button fruitsBtn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label walkingtext;
        private System.Windows.Forms.Panel SidePanel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button checkoutBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Label discountLabel;
        private System.Windows.Forms.Label discountpLabel;
        private System.Windows.Forms.Label subtotalLabel;
        private System.Windows.Forms.PictureBox closeBtn;
        private System.Windows.Forms.Button liquorBtn;
        private System.Windows.Forms.Panel userPanel;
        private System.Windows.Forms.PictureBox clearCartBtn;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Button menuBtn;
        private System.Windows.Forms.Panel panel1;
    }
}

