namespace test_img
{
    partial class Form1
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
            this.pgImage = new System.Windows.Forms.PictureBox();
            this.imgname = new System.Windows.Forms.Label();
            this.imgID = new System.Windows.Forms.Label();
            this.pbImage3 = new System.Windows.Forms.PictureBox();
            this.pbImage2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pgImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage2)).BeginInit();
            this.SuspendLayout();
            // 
            // pgImage
            // 
            this.pgImage.Location = new System.Drawing.Point(625, 12);
            this.pgImage.Name = "pgImage";
            this.pgImage.Size = new System.Drawing.Size(163, 165);
            this.pgImage.TabIndex = 0;
            this.pgImage.TabStop = false;
            // 
            // imgname
            // 
            this.imgname.AutoSize = true;
            this.imgname.Location = new System.Drawing.Point(103, 89);
            this.imgname.Name = "imgname";
            this.imgname.Size = new System.Drawing.Size(44, 16);
            this.imgname.TabIndex = 1;
            this.imgname.Text = "label1";
            // 
            // imgID
            // 
            this.imgID.AutoSize = true;
            this.imgID.Location = new System.Drawing.Point(103, 135);
            this.imgID.Name = "imgID";
            this.imgID.Size = new System.Drawing.Size(44, 16);
            this.imgID.TabIndex = 1;
            this.imgID.Text = "label1";
            // 
            // pbImage3
            // 
            this.pbImage3.Location = new System.Drawing.Point(287, 12);
            this.pbImage3.Name = "pbImage3";
            this.pbImage3.Size = new System.Drawing.Size(163, 165);
            this.pbImage3.TabIndex = 2;
            this.pbImage3.TabStop = false;
            // 
            // pbImage2
            // 
            this.pbImage2.Location = new System.Drawing.Point(456, 12);
            this.pbImage2.Name = "pbImage2";
            this.pbImage2.Size = new System.Drawing.Size(163, 165);
            this.pbImage2.TabIndex = 3;
            this.pbImage2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pbImage2);
            this.Controls.Add(this.pbImage3);
            this.Controls.Add(this.imgID);
            this.Controls.Add(this.imgname);
            this.Controls.Add(this.pgImage);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pgImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pgImage;
        private System.Windows.Forms.Label imgname;
        private System.Windows.Forms.Label imgID;
        private System.Windows.Forms.PictureBox pbImage3;
        private System.Windows.Forms.PictureBox pbImage2;
    }
}

