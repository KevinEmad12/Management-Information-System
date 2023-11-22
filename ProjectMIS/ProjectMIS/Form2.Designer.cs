
namespace ProjectMIS
{
    partial class Window2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Window2));
            this.Username = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.LOGINbutton1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Clearbutton1 = new System.Windows.Forms.Button();
            this.Exitbutton2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Username
            // 
            this.Username.AutoSize = true;
            this.Username.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Username.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Username.Location = new System.Drawing.Point(104, 123);
            this.Username.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(95, 18);
            this.Username.TabIndex = 0;
            this.Username.Text = "Username:";
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Password.Location = new System.Drawing.Point(104, 178);
            this.Password.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(92, 18);
            this.Password.TabIndex = 1;
            this.Password.Text = "Password:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(205, 123);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(193, 28);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(205, 178);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(193, 28);
            this.textBox2.TabIndex = 3;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // LOGINbutton1
            // 
            this.LOGINbutton1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LOGINbutton1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LOGINbutton1.Location = new System.Drawing.Point(306, 244);
            this.LOGINbutton1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.LOGINbutton1.Name = "LOGINbutton1";
            this.LOGINbutton1.Size = new System.Drawing.Size(92, 36);
            this.LOGINbutton1.TabIndex = 4;
            this.LOGINbutton1.Text = "Login";
            this.LOGINbutton1.UseVisualStyleBackColor = true;
            this.LOGINbutton1.Click += new System.EventHandler(this.LOGINbutton1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Red;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(480, 11);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(155, 161);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // Clearbutton1
            // 
            this.Clearbutton1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F);
            this.Clearbutton1.Location = new System.Drawing.Point(205, 244);
            this.Clearbutton1.Name = "Clearbutton1";
            this.Clearbutton1.Size = new System.Drawing.Size(92, 36);
            this.Clearbutton1.TabIndex = 6;
            this.Clearbutton1.Text = "Clear\r\n\r\n";
            this.Clearbutton1.UseVisualStyleBackColor = true;
            this.Clearbutton1.Click += new System.EventHandler(this.Clearbutton1_Click);
            // 
            // Exitbutton2
            // 
            this.Exitbutton2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exitbutton2.Location = new System.Drawing.Point(205, 286);
            this.Exitbutton2.Name = "Exitbutton2";
            this.Exitbutton2.Size = new System.Drawing.Size(193, 38);
            this.Exitbutton2.TabIndex = 7;
            this.Exitbutton2.Text = "Exit";
            this.Exitbutton2.UseVisualStyleBackColor = true;
            this.Exitbutton2.Click += new System.EventHandler(this.Exitbutton2_Click);
            // 
            // Window2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(24)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(646, 366);
            this.Controls.Add(this.Exitbutton2);
            this.Controls.Add(this.Clearbutton1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.LOGINbutton1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Username);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Window2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Window2";
            this.Load += new System.EventHandler(this.Window2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Username;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button LOGINbutton1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Clearbutton1;
        private System.Windows.Forms.Button Exitbutton2;
    }
}