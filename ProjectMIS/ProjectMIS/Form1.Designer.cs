
namespace ProjectMIS
{
    partial class Window1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Window1));
            this.InitialLabel = new System.Windows.Forms.Label();
            this.Loginbutton1 = new System.Windows.Forms.Button();
            this.SignUpbutton2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.NavigateMenu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // InitialLabel
            // 
            this.InitialLabel.AutoSize = true;
            this.InitialLabel.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.InitialLabel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.InitialLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InitialLabel.ForeColor = System.Drawing.SystemColors.Desktop;
            this.InitialLabel.Location = new System.Drawing.Point(38, 193);
            this.InitialLabel.Name = "InitialLabel";
            this.InitialLabel.Size = new System.Drawing.Size(730, 55);
            this.InitialLabel.TabIndex = 1;
            this.InitialLabel.Text = "Welcome to Virigin MegaStore";
            this.InitialLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Loginbutton1
            // 
            this.Loginbutton1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Loginbutton1.Location = new System.Drawing.Point(118, 302);
            this.Loginbutton1.Name = "Loginbutton1";
            this.Loginbutton1.Size = new System.Drawing.Size(164, 48);
            this.Loginbutton1.TabIndex = 2;
            this.Loginbutton1.Text = "Login";
            this.Loginbutton1.UseVisualStyleBackColor = true;
            this.Loginbutton1.Click += new System.EventHandler(this.Loginbutton1_Click);
            // 
            // SignUpbutton2
            // 
            this.SignUpbutton2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignUpbutton2.Location = new System.Drawing.Point(487, 302);
            this.SignUpbutton2.Name = "SignUpbutton2";
            this.SignUpbutton2.Size = new System.Drawing.Size(164, 48);
            this.SignUpbutton2.TabIndex = 3;
            this.SignUpbutton2.Text = "SignUp";
            this.SignUpbutton2.UseVisualStyleBackColor = true;
            this.SignUpbutton2.Click += new System.EventHandler(this.SignUpbutton2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label1.Location = new System.Drawing.Point(522, 356);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 40);
            this.label1.TabIndex = 4;
            this.label1.Text = "New Here?\r\nSignUp";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Red;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(314, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(153, 160);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // NavigateMenu
            // 
            this.NavigateMenu.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NavigateMenu.Location = new System.Drawing.Point(289, 381);
            this.NavigateMenu.Name = "NavigateMenu";
            this.NavigateMenu.Size = new System.Drawing.Size(197, 57);
            this.NavigateMenu.TabIndex = 5;
            this.NavigateMenu.Text = "Navigate Menu";
            this.NavigateMenu.UseVisualStyleBackColor = true;
            this.NavigateMenu.Click += new System.EventHandler(this.button1_Click);
            // 
            // Window1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(24)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(802, 450);
            this.Controls.Add(this.NavigateMenu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SignUpbutton2);
            this.Controls.Add(this.Loginbutton1);
            this.Controls.Add(this.InitialLabel);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Window1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Window1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label InitialLabel;
        private System.Windows.Forms.Button Loginbutton1;
        private System.Windows.Forms.Button SignUpbutton2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button NavigateMenu;
    }
}

