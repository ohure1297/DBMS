namespace QL.Views
{
    partial class DetailProductView
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
            this.ucProductDetails = new QL.Views.UCProductDetails();
            this.SuspendLayout();
            // 
            // ucProductDetails
            // 
            this.ucProductDetails.Location = new System.Drawing.Point(-2, -1);
            this.ucProductDetails.Name = "ucProductDetails";
            this.ucProductDetails.Size = new System.Drawing.Size(1345, 505);
            this.ucProductDetails.TabIndex = 0;
            // 
            // DetailProductView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(243)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(1345, 505);
            this.Controls.Add(this.ucProductDetails);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DetailProductView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProductDetail";
            this.ResumeLayout(false);

        }

        #endregion

        private UCProductDetails ucProductDetails;
    }
}