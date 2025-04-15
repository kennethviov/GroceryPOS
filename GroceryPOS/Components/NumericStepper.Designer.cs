namespace GroceryStroreDiscountGUI.Components
{
    partial class NumericStepper
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.decreaseBtn = new System.Windows.Forms.Button();
            this.increaseBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBox1.Location = new System.Drawing.Point(23, 0);
            this.textBox1.MaxLength = 3;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(30, 23);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "1";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // decreaseBtn
            // 
            this.decreaseBtn.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.decreaseBtn.Location = new System.Drawing.Point(0, 0);
            this.decreaseBtn.Name = "decreaseBtn";
            this.decreaseBtn.Size = new System.Drawing.Size(23, 23);
            this.decreaseBtn.TabIndex = 1;
            this.decreaseBtn.Text = "-";
            this.decreaseBtn.UseVisualStyleBackColor = true;
            this.decreaseBtn.Click += new System.EventHandler(this.decreaseBtn_Click);
            // 
            // increaseBtn
            // 
            this.increaseBtn.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.increaseBtn.Location = new System.Drawing.Point(53, 0);
            this.increaseBtn.Name = "increaseBtn";
            this.increaseBtn.Size = new System.Drawing.Size(23, 23);
            this.increaseBtn.TabIndex = 2;
            this.increaseBtn.Text = "+";
            this.increaseBtn.UseVisualStyleBackColor = true;
            this.increaseBtn.Click += new System.EventHandler(this.increaseBtn_Click);
            // 
            // NumericStepper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.increaseBtn);
            this.Controls.Add(this.decreaseBtn);
            this.Controls.Add(this.textBox1);
            this.Name = "NumericStepper";
            this.Size = new System.Drawing.Size(76, 23);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button decreaseBtn;
        private System.Windows.Forms.Button increaseBtn;
    }
}
