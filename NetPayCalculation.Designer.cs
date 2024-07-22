namespace PayrollMngmentSystem
{
    partial class NetPayCalculation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NetPayCalculation));
            cmbdepartment = new ComboBox();
            lbldepartment = new Label();
            txtempname = new TextBox();
            lblempname = new Label();
            txtempid = new TextBox();
            lblempid = new Label();
            txttotalearn = new TextBox();
            lbltotalearn = new Label();
            txttotaldeduct = new TextBox();
            lbltotaldeduct = new Label();
            btnsearchemp = new Button();
            txtsearchemp = new TextBox();
            lblsearchemp = new Label();
            txtnetsal = new TextBox();
            lblnetsal = new Label();
            btnsave = new Button();
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
            cmbdepartment.Location = new Point(962, 343);
            cmbdepartment.Name = "cmbdepartment";
            cmbdepartment.Size = new Size(327, 31);
            cmbdepartment.TabIndex = 4;
            cmbdepartment.KeyPress += Control_KeyPress;
            // 
            // lbldepartment
            // 
            lbldepartment.AutoSize = true;
            lbldepartment.BackColor = Color.Transparent;
            lbldepartment.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbldepartment.ForeColor = Color.White;
            lbldepartment.Location = new Point(701, 341);
            lbldepartment.Name = "lbldepartment";
            lbldepartment.Size = new Size(125, 23);
            lbldepartment.TabIndex = 19;
            lbldepartment.Text = "Department";
            // 
            // txtempname
            // 
            txtempname.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtempname.Location = new Point(962, 261);
            txtempname.Multiline = true;
            txtempname.Name = "txtempname";
            txtempname.Size = new Size(327, 45);
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
            lblempname.Location = new Point(701, 261);
            lblempname.Name = "lblempname";
            lblempname.Size = new Size(174, 23);
            lblempname.TabIndex = 17;
            lblempname.Text = "Employee Name";
            // 
            // txtempid
            // 
            txtempid.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtempid.Location = new Point(962, 178);
            txtempid.Multiline = true;
            txtempid.Name = "txtempid";
            txtempid.Size = new Size(327, 45);
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
            lblempid.Location = new Point(701, 178);
            lblempid.Name = "lblempid";
            lblempid.Size = new Size(134, 23);
            lblempid.TabIndex = 15;
            lblempid.Text = "Employee ID";
            // 
            // txttotalearn
            // 
            txttotalearn.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txttotalearn.Location = new Point(962, 424);
            txttotalearn.Multiline = true;
            txttotalearn.Name = "txttotalearn";
            txttotalearn.Size = new Size(327, 45);
            txttotalearn.TabIndex = 5;
            txttotalearn.Tag = "double";
            txttotalearn.KeyPress += Control_KeyPress;
            // 
            // lbltotalearn
            // 
            lbltotalearn.AutoSize = true;
            lbltotalearn.BackColor = Color.Transparent;
            lbltotalearn.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbltotalearn.ForeColor = Color.White;
            lbltotalearn.Location = new Point(701, 424);
            lbltotalearn.Name = "lbltotalearn";
            lbltotalearn.Size = new Size(132, 23);
            lbltotalearn.TabIndex = 29;
            lbltotalearn.Text = "Total Earning";
            // 
            // txttotaldeduct
            // 
            txttotaldeduct.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txttotaldeduct.Location = new Point(962, 514);
            txttotaldeduct.Multiline = true;
            txttotaldeduct.Name = "txttotaldeduct";
            txttotaldeduct.Size = new Size(327, 45);
            txttotaldeduct.TabIndex = 6;
            txttotaldeduct.Tag = "double";
            txttotaldeduct.KeyPress += Control_KeyPress;
            txttotaldeduct.Validating += txttotaldeduct_Validating;
            // 
            // lbltotaldeduct
            // 
            lbltotaldeduct.AutoSize = true;
            lbltotaldeduct.BackColor = Color.Transparent;
            lbltotaldeduct.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbltotaldeduct.ForeColor = Color.White;
            lbltotaldeduct.Location = new Point(701, 514);
            lbltotaldeduct.Name = "lbltotaldeduct";
            lbltotaldeduct.Size = new Size(162, 23);
            lbltotaldeduct.TabIndex = 40;
            lbltotaldeduct.Text = "Total Deduction";
            // 
            // btnsearchemp
            // 
            btnsearchemp.BackColor = Color.Silver;
            btnsearchemp.FlatAppearance.BorderSize = 0;
            btnsearchemp.FlatStyle = FlatStyle.Flat;
            btnsearchemp.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnsearchemp.Location = new Point(1117, 52);
            btnsearchemp.Name = "btnsearchemp";
            btnsearchemp.Size = new Size(172, 36);
            btnsearchemp.TabIndex = 44;
            btnsearchemp.Text = "Search Employee";
            btnsearchemp.UseVisualStyleBackColor = false;
            btnsearchemp.Click += btnsearchemp_Click;
            // 
            // txtsearchemp
            // 
            txtsearchemp.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtsearchemp.Location = new Point(903, 53);
            txtsearchemp.Name = "txtsearchemp";
            txtsearchemp.Size = new Size(151, 32);
            txtsearchemp.TabIndex = 1;
            txtsearchemp.KeyPress += Control_KeyPress;
            // 
            // lblsearchemp
            // 
            lblsearchemp.AutoSize = true;
            lblsearchemp.BackColor = Color.Transparent;
            lblsearchemp.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblsearchemp.ForeColor = Color.White;
            lblsearchemp.Location = new Point(715, 60);
            lblsearchemp.Name = "lblsearchemp";
            lblsearchemp.Size = new Size(134, 23);
            lblsearchemp.TabIndex = 42;
            lblsearchemp.Text = "Employee ID";
            // 
            // txtnetsal
            // 
            txtnetsal.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtnetsal.Location = new Point(962, 601);
            txtnetsal.Multiline = true;
            txtnetsal.Name = "txtnetsal";
            txtnetsal.ReadOnly = true;
            txtnetsal.Size = new Size(327, 45);
            txtnetsal.TabIndex = 7;
            txtnetsal.KeyPress += Control_KeyPress;
            // 
            // lblnetsal
            // 
            lblnetsal.AutoSize = true;
            lblnetsal.BackColor = Color.Transparent;
            lblnetsal.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblnetsal.ForeColor = Color.White;
            lblnetsal.Location = new Point(701, 601);
            lblnetsal.Name = "lblnetsal";
            lblnetsal.Size = new Size(109, 23);
            lblnetsal.TabIndex = 45;
            lblnetsal.Text = "Net Salary";
            // 
            // btnsave
            // 
            btnsave.BackColor = Color.Silver;
            btnsave.FlatAppearance.BorderSize = 0;
            btnsave.FlatStyle = FlatStyle.Flat;
            btnsave.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnsave.Location = new Point(948, 695);
            btnsave.Name = "btnsave";
            btnsave.Size = new Size(101, 34);
            btnsave.TabIndex = 47;
            btnsave.Text = "Save";
            btnsave.UseVisualStyleBackColor = false;
            btnsave.Click += btnsave_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(647, 780);
            panel1.TabIndex = 48;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(647, 780);
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
            btndelete.Location = new Point(1186, 695);
            btndelete.Name = "btndelete";
            btndelete.Size = new Size(103, 34);
            btndelete.TabIndex = 50;
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
            btncancel.Location = new Point(1064, 695);
            btncancel.Name = "btncancel";
            btncancel.Size = new Size(108, 34);
            btncancel.TabIndex = 49;
            btncancel.Text = "Cancel";
            btncancel.UseVisualStyleBackColor = false;
            btncancel.Click += btncancel_Click;
            // 
            // NetPayCalculation
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 122);
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1315, 780);
            Controls.Add(btndelete);
            Controls.Add(btncancel);
            Controls.Add(panel1);
            Controls.Add(btnsave);
            Controls.Add(txtnetsal);
            Controls.Add(lblnetsal);
            Controls.Add(btnsearchemp);
            Controls.Add(txtsearchemp);
            Controls.Add(lblsearchemp);
            Controls.Add(txttotaldeduct);
            Controls.Add(lbltotaldeduct);
            Controls.Add(txttotalearn);
            Controls.Add(lbltotalearn);
            Controls.Add(cmbdepartment);
            Controls.Add(lbldepartment);
            Controls.Add(txtempname);
            Controls.Add(lblempname);
            Controls.Add(txtempid);
            Controls.Add(lblempid);
            DoubleBuffered = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "NetPayCalculation";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "NetPayCalculation";
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
        private TextBox txttotalearn;
        private Label lbltotalearn;
        private TextBox txttotaldeduct;
        private Label lbltotaldeduct;
        private Button btnsearchemp;
        private TextBox txtsearchemp;
        private Label lblsearchemp;
        private TextBox txtnetsal;
        private Label lblnetsal;
        private Button btnsave;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Button btndelete;
        private Button btncancel;
    }
}