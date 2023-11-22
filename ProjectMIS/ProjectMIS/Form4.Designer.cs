
namespace ProjectMIS
{
    partial class Window4
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
            this.Sportsbutton1 = new System.Windows.Forms.Button();
            this.Techbutton1 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Sportsbutton1
            // 
            this.Sportsbutton1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sportsbutton1.Location = new System.Drawing.Point(518, 347);
            this.Sportsbutton1.Name = "Sportsbutton1";
            this.Sportsbutton1.Size = new System.Drawing.Size(315, 49);
            this.Sportsbutton1.TabIndex = 2;
            this.Sportsbutton1.Text = "Sports";
            this.Sportsbutton1.UseVisualStyleBackColor = true;
            this.Sportsbutton1.Click += new System.EventHandler(this.Sportsbutton1_Click);
            // 
            // Techbutton1
            // 
            this.Techbutton1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Techbutton1.Location = new System.Drawing.Point(51, 347);
            this.Techbutton1.Name = "Techbutton1";
            this.Techbutton1.Size = new System.Drawing.Size(308, 49);
            this.Techbutton1.TabIndex = 5;
            this.Techbutton1.Text = "Technology";
            this.Techbutton1.UseVisualStyleBackColor = true;
            this.Techbutton1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::ProjectMIS.Properties.Resources.PNGPIX_COM_Dumbbells_PNG_Transparent_Image1;
            this.pictureBox2.Location = new System.Drawing.Point(514, 68);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(304, 205);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProjectMIS.Properties.Resources.lovepik_laptop_png_image_401595062_wh1200_removebg_preview1;
            this.pictureBox1.Location = new System.Drawing.Point(51, 68);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(308, 205);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Window4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(24)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(862, 450);
            this.Controls.Add(this.Techbutton1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.Sportsbutton1);
            this.Controls.Add(this.pictureBox1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "Window4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Window4";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Sportsbutton1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button Techbutton1;
    }
}