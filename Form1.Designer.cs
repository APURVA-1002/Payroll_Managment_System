namespace PayrollMngmentSystem
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            lblusername = new Label();
            lblpass = new Label();
            txtusername = new TextBox();
            txtpass = new TextBox();
            btnlogin = new Button();
            btnregister = new Button();
            lblnewuser = new Label();
            panel1 = new Panel();
            panel3 = new Panel();
            pictureBox5 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox2 = new PictureBox();
            panel4 = new Panel();
            pictureBox3 = new PictureBox();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblusername
            // 
            lblusername.AutoSize = true;
            lblusername.BackColor = Color.Transparent;
            lblusername.Font = new Font("Courier New", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblusername.ForeColor = Color.Gray;
            lblusername.Location = new Point(38, 157);
            lblusername.Name = "lblusername";
            lblusername.Size = new Size(106, 22);
            lblusername.TabIndex = 1;
            lblusername.Text = "Username";
            // 
            // lblpass
            // 
            lblpass.AutoSize = true;
            lblpass.BackColor = Color.Transparent;
            lblpass.Font = new Font("Courier New", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblpass.ForeColor = Color.Gray;
            lblpass.Location = new Point(38, 250);
            lblpass.Name = "lblpass";
            lblpass.Size = new Size(106, 22);
            lblpass.TabIndex = 2;
            lblpass.Text = "Password";
            // 
            // txtusername
            // 
            txtusername.BorderStyle = BorderStyle.FixedSingle;
            txtusername.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtusername.Location = new Point(38, 181);
            txtusername.Multiline = true;
            txtusername.Name = "txtusername";
            txtusername.Size = new Size(427, 43);
            txtusername.TabIndex = 1;
            txtusername.Tag = "username";
            txtusername.KeyPress += Control_KeyPress;
            // 
            // txtpass
            // 
            txtpass.BorderStyle = BorderStyle.FixedSingle;
            txtpass.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtpass.Location = new Point(38, 275);
            txtpass.Multiline = true;
            txtpass.Name = "txtpass";
            txtpass.PasswordChar = '*';
            txtpass.Size = new Size(427, 43);
            txtpass.TabIndex = 2;
            txtpass.Tag = "password";
            txtpass.KeyPress += Control_KeyPress;
            // 
            // btnlogin
            // 
            btnlogin.BackColor = Color.FromArgb(64, 64, 122);
            btnlogin.Cursor = Cursors.Hand;
            btnlogin.FlatAppearance.BorderSize = 0;
            btnlogin.FlatStyle = FlatStyle.Flat;
            btnlogin.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnlogin.ForeColor = Color.White;
            btnlogin.Location = new Point(38, 351);
            btnlogin.Name = "btnlogin";
            btnlogin.Size = new Size(428, 48);
            btnlogin.TabIndex = 5;
            btnlogin.Text = "LOGIN";
            btnlogin.UseVisualStyleBackColor = false;
            btnlogin.Click += btnlogin_Click;
            // 
            // btnregister
            // 
            btnregister.BackColor = Color.FromArgb(64, 64, 122);
            btnregister.Cursor = Cursors.Hand;
            btnregister.FlatAppearance.BorderSize = 0;
            btnregister.FlatStyle = FlatStyle.Flat;
            btnregister.Font = new Font("Courier New", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnregister.ForeColor = Color.White;
            btnregister.Location = new Point(275, 426);
            btnregister.Name = "btnregister";
            btnregister.Size = new Size(111, 43);
            btnregister.TabIndex = 6;
            btnregister.Text = "Sign Up";
            btnregister.UseVisualStyleBackColor = false;
            btnregister.Click += btnregister_Click;
            // 
            // lblnewuser
            // 
            lblnewuser.AutoSize = true;
            lblnewuser.BackColor = Color.Transparent;
            lblnewuser.Font = new Font("Courier New", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblnewuser.Location = new Point(50, 439);
            lblnewuser.Name = "lblnewuser";
            lblnewuser.Size = new Size(206, 17);
            lblnewuser.TabIndex = 7;
            lblnewuser.Text = "Don't have an account?";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(153, 134);
            panel1.Name = "panel1";
            panel1.Size = new Size(971, 504);
            panel1.TabIndex = 8;
            // 
            // panel3
            // 
            panel3.Controls.Add(pictureBox5);
            panel3.Controls.Add(btnregister);
            panel3.Controls.Add(lblnewuser);
            panel3.Controls.Add(pictureBox4);
            panel3.Controls.Add(pictureBox2);
            panel3.Controls.Add(btnlogin);
            panel3.Controls.Add(panel4);
            panel3.Controls.Add(lblusername);
            panel3.Controls.Add(txtusername);
            panel3.Controls.Add(lblpass);
            panel3.Controls.Add(txtpass);
            panel3.Dock = DockStyle.Right;
            panel3.Location = new Point(468, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(503, 504);
            panel3.TabIndex = 1;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(413, 280);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(48, 32);
            pictureBox5.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox5.TabIndex = 7;
            pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.icons8_name_24;
            pictureBox4.Location = new Point(413, 186);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(48, 32);
            pictureBox4.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox4.TabIndex = 6;
            pictureBox4.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(190, 74);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(118, 64);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // panel4
            // 
            panel4.Controls.Add(pictureBox3);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(503, 55);
            panel4.TabIndex = 0;
            // 
            // pictureBox3
            // 
            pictureBox3.Dock = DockStyle.Right;
            pictureBox3.Image = Properties.Resources.icons8_cross_50;
            pictureBox3.Location = new Point(443, 0);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(60, 55);
            pictureBox3.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox3.TabIndex = 0;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(pictureBox1);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(468, 504);
            panel2.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(468, 504);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 122);
            ClientSize = new Size(1315, 780);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(1333, 827);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Label lblusername;
        private Label lblpass;
        private TextBox txtusername;
        private TextBox txtpass;
        private Button btnlogin;
        private Button btnregister;
        private Label lblnewuser;
        private Panel panel1;
        private Panel panel3;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Panel panel4;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
    }
}
