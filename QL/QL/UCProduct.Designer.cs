namespace GiaoDien
{
    partial class UCProduct
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
            this.ptbProductImg = new Guna.UI2.WinForms.Guna2PictureBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblCurrentPrice = new System.Windows.Forms.Label();
            this.lblDiscount = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ptbProductImg)).BeginInit();
            this.SuspendLayout();
            // 
            // ptbProductImg
            // 
            this.ptbProductImg.ImageRotate = 0F;
            this.ptbProductImg.Location = new System.Drawing.Point(3, 3);
            this.ptbProductImg.Name = "ptbProductImg";
            this.ptbProductImg.Size = new System.Drawing.Size(261, 225);
            this.ptbProductImg.TabIndex = 0;
            this.ptbProductImg.TabStop = false;
            this.ptbProductImg.Click += new System.EventHandler(this.ptbProductImg_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(4, 231);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(118, 23);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Tên Sản Phẩm";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Strikeout, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(5, 314);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(73, 23);
            this.lblPrice.TabIndex = 2;
            this.lblPrice.Text = "Giá gốc ";
            // 
            // lblCurrentPrice
            // 
            this.lblCurrentPrice.AutoSize = true;
            this.lblCurrentPrice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentPrice.Location = new System.Drawing.Point(3, 269);
            this.lblCurrentPrice.Name = "lblCurrentPrice";
            this.lblCurrentPrice.Size = new System.Drawing.Size(110, 28);
            this.lblCurrentPrice.TabIndex = 3;
            this.lblCurrentPrice.Text = "Giá hiện tại";
            // 
            // lblDiscount
            // 
            this.lblDiscount.AutoSize = true;
            this.lblDiscount.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiscount.ForeColor = System.Drawing.Color.Tomato;
            this.lblDiscount.Location = new System.Drawing.Point(68, 314);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(117, 23);
            this.lblDiscount.TabIndex = 4;
            this.lblDiscount.Text = "% khuyến mãi";
            // 
            // UCProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.lblDiscount);
            this.Controls.Add(this.lblCurrentPrice);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.ptbProductImg);
            this.Name = "UCProduct";
            this.Size = new System.Drawing.Size(263, 352);
            ((System.ComponentModel.ISupportInitialize)(this.ptbProductImg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public Guna.UI2.WinForms.Guna2PictureBox ptbProductImg;
        public System.Windows.Forms.Label lblName;
        public System.Windows.Forms.Label lblPrice;
        public System.Windows.Forms.Label lblCurrentPrice;
        public System.Windows.Forms.Label lblDiscount;
    }
}
