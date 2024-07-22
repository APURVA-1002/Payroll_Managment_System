namespace PayrollMngmentSystem
{
    partial class PaymentMethod
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PaymentMethod));
            txtempname = new TextBox();
            lblempname = new Label();
            txtempid = new TextBox();
            lblempid = new Label();
            txtnetsal = new TextBox();
            lblnetsal = new Label();
            lblpaymeth = new Label();
            cmbpaymethod = new ComboBox();
            lblbkname = new Label();
            txtaccno = new TextBox();
            lblaccno = new Label();
            txtcity = new TextBox();
            lblcity = new Label();
            btnsearchemp = new Button();
            txtsearchemp = new TextBox();
            lblsearchemp = new Label();
            btnsave = new Button();
            cmbbankname = new ComboBox();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            btndelete = new Button();
            btncancel = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtempname
            // 
            txtempname.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtempname.Location = new Point(939, 213);
            txtempname.Multiline = true;
            txtempname.Name = "txtempname";
            txtempname.Size = new Size(351, 40);
            txtempname.TabIndex = 3;
            txtempname.Tag = "string";
            txtempname.KeyPress += Control_KeyPress;
            // 
            // lblempname
            // 
            lblempname.AutoSize = true;
            lblempname.BackColor = Color.Transparent;
            lblempname.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblempname.ForeColor = Color.White;
            lblempname.Location = new Point(702, 213);
            lblempname.Name = "lblempname";
            lblempname.Size = new Size(174, 23);
            lblempname.TabIndex = 25;
            lblempname.Text = "Employee Name";
            // 
            // txtempid
            // 
            txtempid.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtempid.Location = new Point(939, 130);
            txtempid.Multiline = true;
            txtempid.Name = "txtempid";
            txtempid.Size = new Size(351, 40);
            txtempid.TabIndex = 2;
            txtempid.Tag = "int";
            txtempid.KeyPress += Control_KeyPress;
            txtempid.Validating += txtempid_Validating;
            // 
            // lblempid
            // 
            lblempid.AutoSize = true;
            lblempid.BackColor = Color.Transparent;
            lblempid.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblempid.ForeColor = Color.White;
            lblempid.Location = new Point(702, 130);
            lblempid.Name = "lblempid";
            lblempid.Size = new Size(134, 23);
            lblempid.TabIndex = 23;
            lblempid.Text = "Employee ID";
            // 
            // txtnetsal
            // 
            txtnetsal.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtnetsal.Location = new Point(939, 294);
            txtnetsal.Multiline = true;
            txtnetsal.Name = "txtnetsal";
            txtnetsal.Size = new Size(351, 40);
            txtnetsal.TabIndex = 4;
            txtnetsal.Tag = "double";
            txtnetsal.KeyPress += Control_KeyPress;
            // 
            // lblnetsal
            // 
            lblnetsal.AutoSize = true;
            lblnetsal.BackColor = Color.Transparent;
            lblnetsal.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblnetsal.ForeColor = Color.White;
            lblnetsal.Location = new Point(702, 294);
            lblnetsal.Name = "lblnetsal";
            lblnetsal.Size = new Size(109, 23);
            lblnetsal.TabIndex = 47;
            lblnetsal.Text = "Net Salary";
            // 
            // lblpaymeth
            // 
            lblpaymeth.AutoSize = true;
            lblpaymeth.BackColor = Color.Transparent;
            lblpaymeth.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblpaymeth.ForeColor = Color.White;
            lblpaymeth.Location = new Point(702, 365);
            lblpaymeth.Name = "lblpaymeth";
            lblpaymeth.Size = new Size(177, 23);
            lblpaymeth.TabIndex = 49;
            lblpaymeth.Text = "Payment Method";
            // 
            // cmbpaymethod
            // 
            cmbpaymethod.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            cmbpaymethod.FormattingEnabled = true;
            cmbpaymethod.Items.AddRange(new object[] { "Deposite", "Check", "Cash", "Other" });
            cmbpaymethod.Location = new Point(939, 365);
            cmbpaymethod.Name = "cmbpaymethod";
            cmbpaymethod.Size = new Size(351, 31);
            cmbpaymethod.TabIndex = 5;
            cmbpaymethod.KeyPress += Control_KeyPress;
            // 
            // lblbkname
            // 
            lblbkname.AutoSize = true;
            lblbkname.BackColor = Color.Transparent;
            lblbkname.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblbkname.ForeColor = Color.White;
            lblbkname.Location = new Point(702, 441);
            lblbkname.Name = "lblbkname";
            lblbkname.Size = new Size(125, 23);
            lblbkname.TabIndex = 51;
            lblbkname.Text = "Bank Name";
            // 
            // txtaccno
            // 
            txtaccno.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtaccno.Location = new Point(939, 519);
            txtaccno.Multiline = true;
            txtaccno.Name = "txtaccno";
            txtaccno.Size = new Size(351, 40);
            txtaccno.TabIndex = 7;
            txtaccno.Tag = "int";
            txtaccno.KeyPress += Control_KeyPress;
            // 
            // lblaccno
            // 
            lblaccno.AutoSize = true;
            lblaccno.BackColor = Color.Transparent;
            lblaccno.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblaccno.ForeColor = Color.White;
            lblaccno.Location = new Point(702, 519);
            lblaccno.Name = "lblaccno";
            lblaccno.Size = new Size(178, 23);
            lblaccno.TabIndex = 53;
            lblaccno.Text = "Account Number";
            // 
            // txtcity
            // 
            txtcity.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtcity.Location = new Point(939, 604);
            txtcity.Multiline = true;
            txtcity.Name = "txtcity";
            txtcity.Size = new Size(351, 40);
            txtcity.TabIndex = 8;
            txtcity.Tag = "city";
            txtcity.KeyPress += Control_KeyPress;
            // 
            // lblcity
            // 
            lblcity.AutoSize = true;
            lblcity.BackColor = Color.Transparent;
            lblcity.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblcity.ForeColor = Color.White;
            lblcity.Location = new Point(702, 604);
            lblcity.Name = "lblcity";
            lblcity.Size = new Size(49, 23);
            lblcity.TabIndex = 55;
            lblcity.Text = "City";
            // 
            // btnsearchemp
            // 
            btnsearchemp.BackColor = Color.Silver;
            btnsearchemp.FlatAppearance.BorderSize = 0;
            btnsearchemp.FlatStyle = FlatStyle.Flat;
            btnsearchemp.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnsearchemp.Location = new Point(1120, 44);
            btnsearchemp.Name = "btnsearchemp";
            btnsearchemp.Size = new Size(172, 36);
            btnsearchemp.TabIndex = 59;
            btnsearchemp.Text = "Search Employee";
            btnsearchemp.UseVisualStyleBackColor = false;
            btnsearchemp.Click += btnsearchemp_Click;
            // 
            // txtsearchemp
            // 
            txtsearchemp.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtsearchemp.Location = new Point(903, 44);
            txtsearchemp.Name = "txtsearchemp";
            txtsearchemp.Size = new Size(151, 32);
            txtsearchemp.TabIndex = 1;
            txtsearchemp.Tag = "int";
            txtsearchemp.KeyPress += Control_KeyPress;
            // 
            // lblsearchemp
            // 
            lblsearchemp.AutoSize = true;
            lblsearchemp.BackColor = Color.Transparent;
            lblsearchemp.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblsearchemp.ForeColor = Color.White;
            lblsearchemp.Location = new Point(723, 51);
            lblsearchemp.Name = "lblsearchemp";
            lblsearchemp.Size = new Size(134, 23);
            lblsearchemp.TabIndex = 57;
            lblsearchemp.Text = "Employee ID";
            // 
            // btnsave
            // 
            btnsave.BackColor = Color.Silver;
            btnsave.FlatAppearance.BorderSize = 0;
            btnsave.FlatStyle = FlatStyle.Flat;
            btnsave.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnsave.Location = new Point(939, 681);
            btnsave.Name = "btnsave";
            btnsave.Size = new Size(101, 36);
            btnsave.TabIndex = 60;
            btnsave.Text = "Save";
            btnsave.UseVisualStyleBackColor = false;
            btnsave.Click += btnsave_Click;
            // 
            // cmbbankname
            // 
            cmbbankname.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            cmbbankname.FormattingEnabled = true;
            cmbbankname.Items.AddRange(new object[] { "SBI", "ICICI", "AXIS", "HDFC", "Other" });
            cmbbankname.Location = new Point(939, 441);
            cmbbankname.Name = "cmbbankname";
            cmbbankname.Size = new Size(351, 31);
            cmbbankname.TabIndex = 6;
            cmbbankname.KeyPress += Control_KeyPress;
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(665, 780);
            panel1.TabIndex = 61;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(665, 780);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // btndelete
            // 
            btndelete.BackColor = Color.Silver;
            btndelete.FlatAppearance.BorderSize = 0;
            btndelete.FlatStyle = FlatStyle.Flat;
            btndelete.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btndelete.Location = new Point(1180, 681);
            btndelete.Name = "btndelete";
            btndelete.Size = new Size(110, 34);
            btndelete.TabIndex = 63;
            btndelete.Text = "Delete";
            btndelete.UseVisualStyleBackColor = false;
            btndelete.Click += btndelete_Click;
            // 
            // btncancel
            // 
            btncancel.BackColor = Color.Silver;
            btncancel.FlatAppearance.BorderSize = 0;
            btncancel.FlatStyle = FlatStyle.Flat;
            btncancel.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btncancel.Location = new Point(1057, 681);
            btncancel.Name = "btncancel";
            btncancel.Size = new Size(108, 34);
            btncancel.TabIndex = 62;
            btncancel.Text = "Cancel";
            btncancel.UseVisualStyleBackColor = false;
            btncancel.Click += btncancel_Click;
            // 
            // PaymentMethod
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 122);
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1315, 780);
            Controls.Add(btndelete);
            Controls.Add(btncancel);
            Controls.Add(panel1);
            Controls.Add(cmbbankname);
            Controls.Add(btnsave);
            Controls.Add(btnsearchemp);
            Controls.Add(txtsearchemp);
            Controls.Add(lblsearchemp);
            Controls.Add(txtcity);
            Controls.Add(lblcity);
            Controls.Add(txtaccno);
            Controls.Add(lblaccno);
            Controls.Add(lblbkname);
            Controls.Add(cmbpaymethod);
            Controls.Add(lblpaymeth);
            Controls.Add(txtnetsal);
            Controls.Add(lblnetsal);
            Controls.Add(txtempname);
            Controls.Add(lblempname);
            Controls.Add(txtempid);
            Controls.Add(lblempid);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "PaymentMethod";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PaymentMethod";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtempname;
        private Label lblempname;
        private TextBox txtempid;
        private Label lblempid;
        private TextBox txtnetsal;
        private Label lblnetsal;
        private Label lblpaymeth;
        private ComboBox cmbpaymethod;
        private Label lblbkname;
        private TextBox txtaccno;
        private Label lblaccno;
        private TextBox txtcity;
        private Label lblcity;
        private Button btnsearchemp;
        private TextBox txtsearchemp;
        private Label lblsearchemp;
        private Button btnsave;
        private ComboBox cmbbankname;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Button btndelete;
        private Button btncancel;
    }
}