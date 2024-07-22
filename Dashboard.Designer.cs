namespace PayrollMngmentSystem
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            btnaddemp = new Button();
            btnviewemp = new Button();
            btnearn = new Button();
            btndeduct = new Button();
            btnnetpay = new Button();
            btnpaymethod = new Button();
            button1 = new Button();
            btnviewearn = new Button();
            btnviewdeduct = new Button();
            btnviewnetpay = new Button();
            panel1 = new Panel();
            panel4 = new Panel();
            panel3 = new Panel();
            panel2 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel5 = new Panel();
            pictureBox2 = new PictureBox();
            pictureBox12 = new PictureBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox12).BeginInit();
            SuspendLayout();
            // 
            // btnaddemp
            // 
            btnaddemp.BackColor = Color.Transparent;
            btnaddemp.FlatAppearance.BorderSize = 0;
            btnaddemp.FlatStyle = FlatStyle.Flat;
            btnaddemp.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnaddemp.ForeColor = Color.White;
            btnaddemp.Image = (Image)resources.GetObject("btnaddemp.Image");
            btnaddemp.ImageAlign = ContentAlignment.MiddleLeft;
            btnaddemp.Location = new Point(12, 99);
            btnaddemp.Name = "btnaddemp";
            btnaddemp.Size = new Size(355, 40);
            btnaddemp.TabIndex = 0;
            btnaddemp.Text = "Add Emp Details";
            btnaddemp.UseVisualStyleBackColor = false;
            btnaddemp.Click += btnaddemp_Click;
            // 
            // btnviewemp
            // 
            btnviewemp.BackColor = Color.Transparent;
            btnviewemp.FlatAppearance.BorderSize = 0;
            btnviewemp.FlatStyle = FlatStyle.Flat;
            btnviewemp.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnviewemp.ForeColor = Color.White;
            btnviewemp.Image = (Image)resources.GetObject("btnviewemp.Image");
            btnviewemp.ImageAlign = ContentAlignment.MiddleLeft;
            btnviewemp.Location = new Point(12, 171);
            btnviewemp.Name = "btnviewemp";
            btnviewemp.Size = new Size(355, 40);
            btnviewemp.TabIndex = 2;
            btnviewemp.Text = "View Emp Details";
            btnviewemp.UseVisualStyleBackColor = false;
            btnviewemp.Click += btnviewemp_Click;
            // 
            // btnearn
            // 
            btnearn.BackColor = Color.Transparent;
            btnearn.FlatAppearance.BorderSize = 0;
            btnearn.FlatStyle = FlatStyle.Flat;
            btnearn.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnearn.ForeColor = Color.White;
            btnearn.Image = (Image)resources.GetObject("btnearn.Image");
            btnearn.ImageAlign = ContentAlignment.MiddleLeft;
            btnearn.Location = new Point(12, 243);
            btnearn.Name = "btnearn";
            btnearn.Size = new Size(355, 40);
            btnearn.TabIndex = 3;
            btnearn.Text = "Earning Section";
            btnearn.UseVisualStyleBackColor = false;
            btnearn.Click += btnearn_Click;
            // 
            // btndeduct
            // 
            btndeduct.BackColor = Color.Transparent;
            btndeduct.FlatAppearance.BorderSize = 0;
            btndeduct.FlatStyle = FlatStyle.Flat;
            btndeduct.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btndeduct.ForeColor = Color.White;
            btndeduct.Image = (Image)resources.GetObject("btndeduct.Image");
            btndeduct.ImageAlign = ContentAlignment.MiddleLeft;
            btndeduct.Location = new Point(12, 375);
            btndeduct.Name = "btndeduct";
            btndeduct.Size = new Size(355, 40);
            btndeduct.TabIndex = 4;
            btndeduct.Text = "Deduction Section";
            btndeduct.UseVisualStyleBackColor = false;
            btndeduct.Click += btndeduct_Click;
            // 
            // btnnetpay
            // 
            btnnetpay.BackColor = Color.Transparent;
            btnnetpay.FlatAppearance.BorderSize = 0;
            btnnetpay.FlatStyle = FlatStyle.Flat;
            btnnetpay.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnnetpay.ForeColor = Color.White;
            btnnetpay.Image = (Image)resources.GetObject("btnnetpay.Image");
            btnnetpay.ImageAlign = ContentAlignment.MiddleLeft;
            btnnetpay.Location = new Point(12, 516);
            btnnetpay.Name = "btnnetpay";
            btnnetpay.Size = new Size(355, 40);
            btnnetpay.TabIndex = 5;
            btnnetpay.Text = "Net Pay Calculation";
            btnnetpay.UseVisualStyleBackColor = false;
            btnnetpay.Click += btnnetpay_Click;
            // 
            // btnpaymethod
            // 
            btnpaymethod.BackColor = Color.Transparent;
            btnpaymethod.FlatAppearance.BorderSize = 0;
            btnpaymethod.FlatStyle = FlatStyle.Flat;
            btnpaymethod.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnpaymethod.ForeColor = Color.White;
            btnpaymethod.Image = (Image)resources.GetObject("btnpaymethod.Image");
            btnpaymethod.ImageAlign = ContentAlignment.MiddleLeft;
            btnpaymethod.Location = new Point(12, 668);
            btnpaymethod.Name = "btnpaymethod";
            btnpaymethod.Size = new Size(355, 40);
            btnpaymethod.TabIndex = 6;
            btnpaymethod.Text = "Payment Method";
            btnpaymethod.UseVisualStyleBackColor = false;
            btnpaymethod.Click += btnpaymethod_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(12, 735);
            button1.Name = "button1";
            button1.Size = new Size(355, 40);
            button1.TabIndex = 7;
            button1.Text = "View Emp Income Details";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // btnviewearn
            // 
            btnviewearn.BackColor = Color.Transparent;
            btnviewearn.FlatAppearance.BorderSize = 0;
            btnviewearn.FlatStyle = FlatStyle.Flat;
            btnviewearn.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnviewearn.ForeColor = Color.White;
            btnviewearn.Image = (Image)resources.GetObject("btnviewearn.Image");
            btnviewearn.ImageAlign = ContentAlignment.MiddleLeft;
            btnviewearn.Location = new Point(12, 312);
            btnviewearn.Name = "btnviewearn";
            btnviewearn.Size = new Size(355, 40);
            btnviewearn.TabIndex = 8;
            btnviewearn.Text = "View Earning Section";
            btnviewearn.UseVisualStyleBackColor = false;
            btnviewearn.Click += btnviewearn_Click;
            // 
            // btnviewdeduct
            // 
            btnviewdeduct.BackColor = Color.Transparent;
            btnviewdeduct.FlatAppearance.BorderSize = 0;
            btnviewdeduct.FlatStyle = FlatStyle.Flat;
            btnviewdeduct.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnviewdeduct.ForeColor = Color.White;
            btnviewdeduct.Image = (Image)resources.GetObject("btnviewdeduct.Image");
            btnviewdeduct.ImageAlign = ContentAlignment.MiddleLeft;
            btnviewdeduct.Location = new Point(12, 447);
            btnviewdeduct.Name = "btnviewdeduct";
            btnviewdeduct.Size = new Size(355, 40);
            btnviewdeduct.TabIndex = 9;
            btnviewdeduct.Text = "View Deduction Section";
            btnviewdeduct.UseVisualStyleBackColor = false;
            btnviewdeduct.Click += btnviewdeduct_Click;
            // 
            // btnviewnetpay
            // 
            btnviewnetpay.BackColor = Color.Transparent;
            btnviewnetpay.FlatAppearance.BorderSize = 0;
            btnviewnetpay.FlatStyle = FlatStyle.Flat;
            btnviewnetpay.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnviewnetpay.ForeColor = Color.White;
            btnviewnetpay.Image = (Image)resources.GetObject("btnviewnetpay.Image");
            btnviewnetpay.ImageAlign = ContentAlignment.MiddleLeft;
            btnviewnetpay.Location = new Point(12, 592);
            btnviewnetpay.Name = "btnviewnetpay";
            btnviewnetpay.Size = new Size(355, 40);
            btnviewnetpay.TabIndex = 10;
            btnviewnetpay.Text = "View Net Pay Calculation";
            btnviewnetpay.UseVisualStyleBackColor = false;
            btnviewnetpay.Click += btnviewnetpay_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(64, 64, 122);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(btnviewemp);
            panel1.Controls.Add(btnearn);
            panel1.Controls.Add(btnaddemp);
            panel1.Controls.Add(btnviewearn);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(btndeduct);
            panel1.Controls.Add(btnpaymethod);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(btnnetpay);
            panel1.Controls.Add(btnviewdeduct);
            panel1.Controls.Add(btnviewnetpay);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(383, 780);
            panel1.TabIndex = 11;
            // 
            // panel4
            // 
            panel4.Dock = DockStyle.Right;
            panel4.Location = new Point(368, 99);
            panel4.Name = "panel4";
            panel4.Size = new Size(15, 681);
            panel4.TabIndex = 2;
            // 
            // panel3
            // 
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(0, 99);
            panel3.Name = "panel3";
            panel3.Size = new Size(15, 681);
            panel3.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.Controls.Add(label1);
            panel2.Controls.Add(pictureBox1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(383, 99);
            panel2.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(68, 36);
            label1.Name = "label1";
            label1.Size = new Size(277, 23);
            label1.TabIndex = 1;
            label1.Text = "Payroll Managment System";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 21);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(50, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel5
            // 
            panel5.BackColor = Color.White;
            panel5.Controls.Add(pictureBox2);
            panel5.Controls.Add(pictureBox12);
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(383, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(932, 56);
            panel5.TabIndex = 12;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(887, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(33, 33);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // pictureBox12
            // 
            pictureBox12.Image = (Image)resources.GetObject("pictureBox12.Image");
            pictureBox12.Location = new Point(8, 12);
            pictureBox12.Name = "pictureBox12";
            pictureBox12.Size = new Size(33, 33);
            pictureBox12.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox12.TabIndex = 2;
            pictureBox12.TabStop = false;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1315, 780);
            ControlBox = false;
            Controls.Add(panel5);
            Controls.Add(panel1);
            Cursor = Cursors.Hand;
            DoubleBuffered = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Dashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dashboard";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox12).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnaddemp;
        private Button btnviewemp;
        private Button btnearn;
        private Button btndeduct;
        private Button btnnetpay;
        private Button btnpaymethod;
        private Button button1;
        private Button btnviewearn;
        private Button btnviewdeduct;
        private Button btnviewnetpay;
        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Label label1;
        private Panel panel4;
        private Panel panel3;
        private Panel panel5;
        private PictureBox pictureBox12;
        private PictureBox pictureBox2;
    }
}