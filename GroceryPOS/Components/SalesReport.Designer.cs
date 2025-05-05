namespace GroceryPOS.Components
{
    partial class SalesReport
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
            this.salesID = new System.Windows.Forms.Label();
            this.dateAndTime = new System.Windows.Forms.Label();
            this.total = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // salesID
            // 
            this.salesID.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.salesID.Location = new System.Drawing.Point(3, 0);
            this.salesID.Name = "salesID";
            this.salesID.Size = new System.Drawing.Size(48, 25);
            this.salesID.TabIndex = 0;
            this.salesID.Text = "0";
            this.salesID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dateAndTime
            // 
            this.dateAndTime.Location = new System.Drawing.Point(57, 0);
            this.dateAndTime.Name = "dateAndTime";
            this.dateAndTime.Size = new System.Drawing.Size(165, 25);
            this.dateAndTime.TabIndex = 1;
            this.dateAndTime.Text = "DD-MM-YYYY HH:MM";
            this.dateAndTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // total
            // 
            this.total.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.total.Location = new System.Drawing.Point(329, -1);
            this.total.Name = "total";
            this.total.Size = new System.Drawing.Size(88, 25);
            this.total.TabIndex = 2;
            this.total.Text = "P0";
            this.total.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // SalesReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.total);
            this.Controls.Add(this.dateAndTime);
            this.Controls.Add(this.salesID);
            this.Name = "SalesReport";
            this.Size = new System.Drawing.Size(418, 25);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label salesID;
        private System.Windows.Forms.Label dateAndTime;
        private System.Windows.Forms.Label total;
    }
}
