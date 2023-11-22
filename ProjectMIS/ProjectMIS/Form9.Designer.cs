
namespace ProjectMIS
{
    partial class Window9
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Window9));
            this.button1 = new System.Windows.Forms.Button();
            this.UserAdmin = new System.Windows.Forms.Label();
            this.PassAdmin = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.CausesValidation = false;
            this.button1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F);
            this.button1.Location = new System.Drawing.Point(193, 199);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 36);
            this.button1.TabIndex = 0;
            this.button1.Text = "Login";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // UserAdmin
            // 
            this.UserAdmin.AutoSize = true;
            this.UserAdmin.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F);
            this.UserAdmin.Location = new System.Drawing.Point(102, 117);
            this.UserAdmin.Name = "UserAdmin";
            this.UserAdmin.Size = new System.Drawing.Size(85, 16);
            this.UserAdmin.TabIndex = 1;
            this.UserAdmin.Text = "Username :";
            // 
            // PassAdmin
            // 
            this.PassAdmin.AutoSize = true;
            this.PassAdmin.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F);
            this.PassAdmin.Location = new System.Drawing.Point(103, 145);
            this.PassAdmin.Name = "PassAdmin";
            this.PassAdmin.Size = new System.Drawing.Size(83, 16);
            this.PassAdmin.TabIndex = 2;
            this.PassAdmin.Text = "Password :";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(193, 117);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(149, 20);
            this.textBox1.TabIndex = 3;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(192, 145);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(150, 20);
            this.textBox2.TabIndex = 4;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Red;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(476, 11);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(115, 130);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // Window9
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(24)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(602, 366);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.PassAdmin);
            this.Controls.Add(this.UserAdmin);
            this.Controls.Add(this.button1);
            this.Name = "Window9";
            this.Text = "Admin Login";
            this.Load += new System.EventHandler(this.Form9_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label UserAdmin;
        private System.Windows.Forms.Label PassAdmin;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        internal System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}