namespace PayrollMngmentSystem
{
    partial class EarningSection
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EarningSection));
            cmbdepartment = new ComboBox();
            lbldepartment = new Label();
            txtempname = new TextBox();
            lblempname = new Label();
            txtempid = new TextBox();
            lblempid = new Label();
            txtbasicsal = new TextBox();
            lblbasicsal = new Label();
            txtincentive = new TextBox();
            lblincentiv = new Label();
            txtovertimeht = new TextBox();
            lblovertimehr = new Label();
            txtovertimepay = new TextBox();
            lblovertimepay = new Label();
            btnadd = new Button();
            txtsearchemp = new TextBox();
            label1 = new Label();
            btnsearchemp = new Button();
            txttotalearn = new TextBox();
            lbltotalearn = new Label();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            btndelete = new Button();
            btncancel = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // cmbdepartment
            // 
            cmbdepartment.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            cmbdepartment.FormattingEnabled = true;
            cmbdepartment.Items.AddRange(new object[] { "Sales", "Marketing", "Finance", "Human Resources", "Information Technology (IT)", "Customer Service", "Operations", "Research and Development", "Administration", "Production" });
            cmbdepartment.Location = new Point(918, 259);
            cmbdepartment.Name = "cmbdepartment";
            cmbdepartment.Size = new Size(375, 31);
            cmbdepartment.TabIndex = 4;
            cmbdepartment.KeyPress += Control_KeyPress;
            // 
            // lbldepartment
            // 
            lbldepartment.AutoSize = true;
            lbldepartment.BackColor = Color.Transparent;
            lbldepartment.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbldepartment.ForeColor = Color.White;
            lbldepartment.Location = new Point(633, 247);
            lbldepartment.Name = "lbldepartment";
            lbldepartment.Size = new Size(125, 23);
            lbldepartment.TabIndex = 12;
            lbldepartment.Text = "Department";
            // 
            // txtempname
            // 
            txtempname.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtempname.Location = new Point(918, 184);
            txtempname.Multiline = true;
            txtempname.Name = "txtempname";
            txtempname.Size = new Size(375, 43);
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
            lblempname.Location = new Point(633, 184);
            lblempname.Name = "lblempname";
            lblempname.Size = new Size(174, 23);
            lblempname.TabIndex = 10;
            lblempname.Text = "Employee Name";
            // 
            // txtempid
            // 
            txtempid.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtempid.Location = new Point(918, 108);
            txtempid.Multiline = true;
            txtempid.Name = "txtempid";
            txtempid.Size = new Size(375, 43);
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
            lblempid.Location = new Point(633, 108);
            lblempid.Name = "lblempid";
            lblempid.Size = new Size(134, 23);
            lblempid.TabIndex = 8;
            lblempid.Text = "Employee ID";
            // 
            // txtbasicsal
            // 
            txtbasicsal.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtbasicsal.Location = new Point(918, 323);
            txtbasicsal.Multiline = true;
            txtbasicsal.Name = "txtbasicsal";
            txtbasicsal.Size = new Size(375, 43);
            txtbasicsal.TabIndex = 5;
            txtbasicsal.Tag = "double";
            txtbasicsal.KeyPress += Control_KeyPress;
            // 
            // lblbasicsal
            // 
            lblbasicsal.AutoSize = true;
            lblbasicsal.BackColor = Color.Transparent;
            lblbasicsal.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblbasicsal.ForeColor = Color.White;
            lblbasicsal.Location = new Point(633, 323);
            lblbasicsal.Name = "lblbasicsal";
            lblbasicsal.Size = new Size(127, 23);
            lblbasicsal.TabIndex = 15;
            lblbasicsal.Text = "Basic Salary";
            // 
            // txtincentive
            // 
            txtincentive.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtincentive.Location = new Point(918, 394);
            txtincentive.Multiline = true;
            txtincentive.Name = "txtincentive";
            txtincentive.Size = new Size(375, 43);
            txtincentive.TabIndex = 6;
            txtincentive.Tag = "double";
            txtincentive.KeyPress += Control_KeyPress;
            // 
            // lblincentiv
            // 
            lblincentiv.AutoSize = true;
            lblincentiv.BackColor = Color.Transparent;
            lblincentiv.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblincentiv.ForeColor = Color.White;
            lblincentiv.Location = new Point(633, 394);
            lblincentiv.Name = "lblincentiv";
            lblincentiv.Size = new Size(110, 23);
            lblincentiv.TabIndex = 17;
            lblincentiv.Text = "Incentives";
            // 
            // txtovertimeht
            // 
            txtovertimeht.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtovertimeht.Location = new Point(918, 463);
            txtovertimeht.Multiline = true;
            txtovertimeht.Name = "txtovertimeht";
            txtovertimeht.Size = new Size(375, 43);
            txtovertimeht.TabIndex = 7;
            txtovertimeht.Tag = "int";
            txtovertimeht.KeyPress += Control_KeyPress;
            txtovertimeht.Validating += txtovertimeht_Validating;
            // 
            // lblovertimehr
            // 
            lblovertimehr.AutoSize = true;
            lblovertimehr.BackColor = Color.Transparent;
            lblovertimehr.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblovertimehr.ForeColor = Color.White;
            lblovertimehr.Location = new Point(633, 463);
            lblovertimehr.Name = "lblovertimehr";
            lblovertimehr.Size = new Size(151, 23);
            lblovertimehr.TabIndex = 19;
            lblovertimehr.Text = "Overtime Hour";
            // 
            // txtovertimepay
            // 
            txtovertimepay.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtovertimepay.Location = new Point(918, 533);
            txtovertimepay.Multiline = true;
            txtovertimepay.Name = "txtovertimepay";
            txtovertimepay.ReadOnly = true;
            txtovertimepay.Size = new Size(375, 43);
            txtovertimepay.TabIndex = 8;
            // 
            // lblovertimepay
            // 
            lblovertimepay.AutoSize = true;
            lblovertimepay.BackColor = Color.Transparent;
            lblovertimepay.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblovertimepay.ForeColor = Color.White;
            lblovertimepay.Location = new Point(633, 533);
            lblovertimepay.Name = "lblovertimepay";
            lblovertimepay.Size = new Size(142, 23);
            lblovertimepay.TabIndex = 21;
            lblovertimepay.Text = "Overtime Pay";
            // 
            // btnadd
            // 
            btnadd.BackColor = Color.Silver;
            btnadd.FlatAppearance.BorderSize = 0;
            btnadd.FlatStyle = FlatStyle.Flat;
            btnadd.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnadd.Location = new Point(918, 695);
            btnadd.Name = "btnadd";
            btnadd.Size = new Size(105, 34);
            btnadd.TabIndex = 23;
            btnadd.Text = "Add";
            btnadd.UseVisualStyleBackColor = false;
            btnadd.Click += btnadd_Click;
            // 
            // txtsearchemp
            // 
            txtsearchemp.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtsearchemp.Location = new Point(826, 18);
            txtsearchemp.Name = "txtsearchemp";
            txtsearchemp.Size = new Size(151, 32);
            txtsearchemp.TabIndex = 1;
            txtsearchemp.Tag = "int";
            txtsearchemp.KeyPress += Control_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(621, 25);
            label1.Name = "label1";
            label1.Size = new Size(134, 23);
            label1.TabIndex = 24;
            label1.Text = "Employee ID";
            // 
            // btnsearchemp
            // 
            btnsearchemp.BackColor = Color.Silver;
            btnsearchemp.FlatAppearance.BorderSize = 0;
            btnsearchemp.FlatStyle = FlatStyle.Flat;
            btnsearchemp.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnsearchemp.Location = new Point(1081, 20);
            btnsearchemp.Name = "btnsearchemp";
            btnsearchemp.Size = new Size(151, 32);
            btnsearchemp.TabIndex = 26;
            btnsearchemp.Text = "Search Employee";
            btnsearchemp.UseVisualStyleBackColor = false;
            btnsearchemp.Click += btnsearchemp_Click;
            // 
            // txttotalearn
            // 
            txttotalearn.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txttotalearn.Location = new Point(918, 609);
            txttotalearn.Multiline = true;
            txttotalearn.Name = "txttotalearn";
            txttotalearn.ReadOnly = true;
            txttotalearn.Size = new Size(375, 43);
            txttotalearn.TabIndex = 9;
            // 
            // lbltotalearn
            // 
            lbltotalearn.AutoSize = true;
            lbltotalearn.BackColor = Color.Transparent;
            lbltotalearn.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbltotalearn.ForeColor = Color.White;
            lbltotalearn.Location = new Point(633, 609);
            lbltotalearn.Name = "lbltotalearn";
            lbltotalearn.Size = new Size(132, 23);
            lbltotalearn.TabIndex = 27;
            lbltotalearn.Text = "Total Earning";
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(586, 780);
            panel1.TabIndex = 28;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(586, 780);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // btndelete
            // 
            btndelete.BackColor = Color.Silver;
            btndelete.FlatAppearance.BorderSize = 0;
            btndelete.FlatStyle = FlatStyle.Flat;
            btndelete.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btndelete.Location = new Point(1183, 695);
            btndelete.Name = "btndelete";
            btndelete.Size = new Size(110, 34);
            btndelete.TabIndex = 30;
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
            btncancel.Location = new Point(1049, 695);
            btncancel.Name = "btncancel";
            btncancel.Size = new Size(108, 34);
            btncancel.TabIndex = 29;
            btncancel.Text = "Cancel";
            btncancel.UseVisualStyleBackColor = false;
            btncancel.Click += btncancel_Click;
            // 
            // EarningSection
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 122);
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1315, 780);
            Controls.Add(btndelete);
            Controls.Add(btncancel);
            Controls.Add(panel1);
            Controls.Add(txttotalearn);
            Controls.Add(lbltotalearn);
            Controls.Add(btnsearchemp);
            Controls.Add(txtsearchemp);
            Controls.Add(label1);
            Controls.Add(btnadd);
            Controls.Add(txtovertimepay);
            Controls.Add(lblovertimepay);
            Controls.Add(txtovertimeht);
            Controls.Add(lblovertimehr);
            Controls.Add(txtincentive);
            Controls.Add(lblincentiv);
            Controls.Add(txtbasicsal);
            Controls.Add(lblbasicsal);
            Controls.Add(cmbdepartment);
            Controls.Add(lbldepartment);
            Controls.Add(txtempname);
            Controls.Add(lblempname);
            Controls.Add(txtempid);
            Controls.Add(lblempid);
            DoubleBuffered = true;
            ForeColor = Color.Black;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "EarningSection";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EarningSection";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbdepartment;
        private Label lbldepartment;
        private TextBox txtempname;
        private Label lblempname;
        private TextBox txtempid;
        private Label lblempid;
        private TextBox txtbasicsal;
        private Label lblbasicsal;
        private TextBox txtincentive;
        private Label lblincentiv;
        private TextBox txtovertimeht;
        private Label lblovertimehr;
        private TextBox txtovertimepay;
        private Label lblovertimepay;
        private Button btnadd;
        private TextBox txtsearchemp;
        private Label label1;
        private Button btnsearchemp;
        private TextBox txttotalearn;
        private Label lbltotalearn;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Button btndelete;
        private Button btncancel;
    }
}