namespace PayrollMngmentSystem
{
    partial class Register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            txtpass = new TextBox();
            txtusername = new TextBox();
            lblpass = new Label();
            lblusername = new Label();
            btnsave = new Button();
            panel1 = new Panel();
            panel3 = new Panel();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // txtpass
            // 
            txtpass.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtpass.Location = new Point(22, 288);
            txtpass.Multiline = true;
            txtpass.Name = "txtpass";
            txtpass.Size = new Size(427, 43);
            txtpass.TabIndex = 2;
            txtpass.Tag = "password";
            txtpass.KeyPress += Control_KeyPress;
            // 
            // txtusername
            // 
            txtusername.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtusername.Location = new Point(22, 188);
            txtusername.Multiline = true;
            txtusername.Name = "txtusername";
            txtusername.Size = new Size(427, 43);
            txtusername.TabIndex = 1;
            txtusername.Tag = "username";
            txtusername.KeyPress += Control_KeyPress;
            // 
            // lblpass
            // 
            lblpass.AutoSize = true;
            lblpass.BackColor = Color.Transparent;
            lblpass.Font = new Font("Courier New", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblpass.ForeColor = Color.Gray;
            lblpass.Location = new Point(22, 263);
            lblpass.Name = "lblpass";
            lblpass.Size = new Size(106, 22);
            lblpass.TabIndex = 6;
            lblpass.Text = "Password";
            // 
            // lblusername
            // 
            lblusername.AutoSize = true;
            lblusername.BackColor = Color.Transparent;
            lblusername.Font = new Font("Courier New", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblusername.ForeColor = Color.Gray;
            lblusername.Location = new Point(22, 163);
            lblusername.Name = "lblusername";
            lblusername.Size = new Size(106, 22);
            lblusername.TabIndex = 5;
            lblusername.Text = "Username";
            // 
            // btnsave
            // 
            btnsave.BackColor = Color.FromArgb(64, 64, 122);
            btnsave.FlatAppearance.BorderSize = 0;
            btnsave.FlatStyle = FlatStyle.Flat;
            btnsave.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnsave.ForeColor = Color.White;
            btnsave.Location = new Point(22, 370);
            btnsave.Name = "btnsave";
            btnsave.Size = new Size(428, 48);
            btnsave.TabIndex = 9;
            btnsave.Text = "SIGN UP";
            btnsave.UseVisualStyleBackColor = false;
            btnsave.Click += btnsave_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(174, 134);
            panel1.Name = "panel1";
            panel1.Size = new Size(971, 504);
            panel1.TabIndex = 10;
            // 
            // panel3
            // 
            panel3.Controls.Add(pictureBox1);
            panel3.Dock = DockStyle.Right;
            panel3.Location = new Point(468, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(503, 504);
            panel3.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(503, 504);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.Controls.Add(pictureBox4);
            panel2.Controls.Add(btnsave);
            panel2.Controls.Add(pictureBox3);
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(lblusername);
            panel2.Controls.Add(txtusername);
            panel2.Controls.Add(txtpass);
            panel2.Controls.Add(lblpass);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(468, 504);
            panel2.TabIndex = 0;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.icons8_lock_30;
            pictureBox4.Location = new Point(395, 294);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(48, 32);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 11;
            pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.icons8_name_24;
            pictureBox3.Location = new Point(395, 193);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(48, 32);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 10;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(148, 31);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(118, 64);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 122);
            ClientSize = new Size(1315, 780);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Register";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Register";
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private TextBox txtpass;
        private TextBox txtusername;
        private Label lblpass;
        private Label lblusername;
        private Button btnsave;
        private Panel panel1;
        private Panel panel3;
        private Panel panel2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
    }
}