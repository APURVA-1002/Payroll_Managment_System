namespace PayrollMngmentSystem
{
    partial class DeductionSection
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeductionSection));
            cmbdepartment = new ComboBox();
            lbldepartment = new Label();
            txtempname = new TextBox();
            lblempname = new Label();
            txtempid = new TextBox();
            lblempid = new Label();
            btnsearchemp = new Button();
            txtsearchemp = new TextBox();
            lblsearchemp = new Label();
            txtitax = new TextBox();
            lblitax = new Label();
            txtsosecurity = new TextBox();
            lblsosecurity = new Label();
            txtretirement = new TextBox();
            lblretirement = new Label();
            txthealth = new TextBox();
            lblhealth = new Label();
            txttotaldeduct = new TextBox();
            lbltotaldeduct = new Label();
            btnadddeduct = new Button();
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
            cmbdepartment.Location = new Point(955, 268);
            cmbdepartment.Name = "cmbdepartment";
            cmbdepartment.Size = new Size(338, 31);
            cmbdepartment.TabIndex = 4;
            cmbdepartment.KeyPress += Control_KeyPress;
            // 
            // lbldepartment
            // 
            lbldepartment.AutoSize = true;
            lbldepartment.BackColor = Color.Transparent;
            lbldepartment.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbldepartment.ForeColor = Color.White;
            lbldepartment.Location = new Point(651, 259);
            lbldepartment.Name = "lbldepartment";
            lbldepartment.Size = new Size(125, 23);
            lbldepartment.TabIndex = 19;
            lbldepartment.Text = "Department";
            // 
            // txtempname
            // 
            txtempname.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtempname.Location = new Point(955, 182);
            txtempname.Multiline = true;
            txtempname.Name = "txtempname";
            txtempname.Size = new Size(338, 41);
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
            lblempname.Location = new Point(651, 185);
            lblempname.Name = "lblempname";
            lblempname.Size = new Size(174, 23);
            lblempname.TabIndex = 17;
            lblempname.Text = "Employee Name";
            // 
            // txtempid
            // 
            txtempid.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtempid.Location = new Point(955, 109);
            txtempid.Multiline = true;
            txtempid.Name = "txtempid";
            txtempid.Size = new Size(338, 41);
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
            lblempid.Location = new Point(651, 112);
            lblempid.Name = "lblempid";
            lblempid.Size = new Size(134, 23);
            lblempid.TabIndex = 15;
            lblempid.Text = "Employee ID";
            // 
            // btnsearchemp
            // 
            btnsearchemp.BackColor = Color.Silver;
            btnsearchemp.FlatAppearance.BorderSize = 0;
            btnsearchemp.FlatStyle = FlatStyle.Flat;
            btnsearchemp.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnsearchemp.Location = new Point(1086, 36);
            btnsearchemp.Name = "btnsearchemp";
            btnsearchemp.Size = new Size(172, 36);
            btnsearchemp.TabIndex = 29;
            btnsearchemp.Text = "Search Employee";
            btnsearchemp.UseVisualStyleBackColor = false;
            btnsearchemp.Click += btnsearchemp_Click;
            // 
            // txtsearchemp
            // 
            txtsearchemp.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtsearchemp.Location = new Point(869, 36);
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
            lblsearchemp.Location = new Point(671, 36);
            lblsearchemp.Name = "lblsearchemp";
            lblsearchemp.Size = new Size(134, 23);
            lblsearchemp.TabIndex = 27;
            lblsearchemp.Text = "Employee ID";
            // 
            // txtitax
            // 
            txtitax.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtitax.Location = new Point(955, 325);
            txtitax.Multiline = true;
            txtitax.Name = "txtitax";
            txtitax.Size = new Size(338, 41);
            txtitax.TabIndex = 5;
            txtitax.Tag = "double";
            txtitax.KeyPress += Control_KeyPress;
            // 
            // lblitax
            // 
            lblitax.AutoSize = true;
            lblitax.BackColor = Color.Transparent;
            lblitax.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblitax.ForeColor = Color.White;
            lblitax.Location = new Point(651, 328);
            lblitax.Name = "lblitax";
            lblitax.Size = new Size(124, 23);
            lblitax.TabIndex = 30;
            lblitax.Text = "Income Tax";
            // 
            // txtsosecurity
            // 
            txtsosecurity.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtsosecurity.Location = new Point(955, 396);
            txtsosecurity.Multiline = true;
            txtsosecurity.Name = "txtsosecurity";
            txtsosecurity.Size = new Size(338, 41);
            txtsosecurity.TabIndex = 6;
            txtsosecurity.Tag = "double";
            txtsosecurity.KeyPress += Control_KeyPress;
            // 
            // lblsosecurity
            // 
            lblsosecurity.AutoSize = true;
            lblsosecurity.BackColor = Color.Transparent;
            lblsosecurity.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblsosecurity.ForeColor = Color.White;
            lblsosecurity.Location = new Point(651, 399);
            lblsosecurity.Name = "lblsosecurity";
            lblsosecurity.Size = new Size(152, 23);
            lblsosecurity.TabIndex = 32;
            lblsosecurity.Text = "Social Security";
            // 
            // txtretirement
            // 
            txtretirement.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtretirement.Location = new Point(955, 534);
            txtretirement.Multiline = true;
            txtretirement.Name = "txtretirement";
            txtretirement.Size = new Size(338, 41);
            txtretirement.TabIndex = 8;
            txtretirement.Tag = "double";
            txtretirement.KeyPress += Control_KeyPress;
            txtretirement.Validating += txtretirement_Validating;
            // 
            // lblretirement
            // 
            lblretirement.AutoSize = true;
            lblretirement.BackColor = Color.Transparent;
            lblretirement.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblretirement.ForeColor = Color.White;
            lblretirement.Location = new Point(651, 537);
            lblretirement.Name = "lblretirement";
            lblretirement.Size = new Size(249, 23);
            lblretirement.TabIndex = 36;
            lblretirement.Text = "Retirement Contributions";
            // 
            // txthealth
            // 
            txthealth.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txthealth.Location = new Point(955, 467);
            txthealth.Multiline = true;
            txthealth.Name = "txthealth";
            txthealth.Size = new Size(338, 41);
            txthealth.TabIndex = 7;
            txthealth.Tag = "double";
            txthealth.KeyPress += Control_KeyPress;
            // 
            // lblhealth
            // 
            lblhealth.AutoSize = true;
            lblhealth.BackColor = Color.Transparent;
            lblhealth.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblhealth.ForeColor = Color.White;
            lblhealth.Location = new Point(651, 470);
            lblhealth.Name = "lblhealth";
            lblhealth.Size = new Size(175, 23);
            lblhealth.TabIndex = 34;
            lblhealth.Text = "Health Insurance";
            // 
            // txttotaldeduct
            // 
            txttotaldeduct.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txttotaldeduct.Location = new Point(955, 606);
            txttotaldeduct.Multiline = true;
            txttotaldeduct.Name = "txttotaldeduct";
            txttotaldeduct.ReadOnly = true;
            txttotaldeduct.Size = new Size(338, 41);
            txttotaldeduct.TabIndex = 9;
            txttotaldeduct.Tag = "double";
            txttotaldeduct.KeyPress += Control_KeyPress;
            // 
            // lbltotaldeduct
            // 
            lbltotaldeduct.AutoSize = true;
            lbltotaldeduct.BackColor = Color.Transparent;
            lbltotaldeduct.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbltotaldeduct.ForeColor = Color.White;
            lbltotaldeduct.Location = new Point(651, 609);
            lbltotaldeduct.Name = "lbltotaldeduct";
            lbltotaldeduct.Size = new Size(162, 23);
            lbltotaldeduct.TabIndex = 38;
            lbltotaldeduct.Text = "Total Deduction";
            // 
            // btnadddeduct
            // 
            btnadddeduct.BackColor = Color.Silver;
            btnadddeduct.FlatAppearance.BorderSize = 0;
            btnadddeduct.FlatStyle = FlatStyle.Flat;
            btnadddeduct.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnadddeduct.Location = new Point(955, 690);
            btnadddeduct.Name = "btnadddeduct";
            btnadddeduct.Size = new Size(94, 34);
            btnadddeduct.TabIndex = 40;
            btnadddeduct.Text = "Add";
            btnadddeduct.UseVisualStyleBackColor = false;
            btnadddeduct.Click += btnadddeduct_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(618, 780);
            panel1.TabIndex = 41;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(618, 780);
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
            btndelete.Location = new Point(1183, 690);
            btndelete.Name = "btndelete";
            btndelete.Size = new Size(110, 34);
            btndelete.TabIndex = 43;
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
            btncancel.Location = new Point(1063, 690);
            btncancel.Name = "btncancel";
            btncancel.Size = new Size(108, 34);
            btncancel.TabIndex = 42;
            btncancel.Text = "Cancel";
            btncancel.UseVisualStyleBackColor = false;
            btncancel.Click += btncancel_Click;
            // 
            // DeductionSection
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 122);
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1315, 780);
            Controls.Add(btndelete);
            Controls.Add(btncancel);
            Controls.Add(panel1);
            Controls.Add(btnadddeduct);
            Controls.Add(txttotaldeduct);
            Controls.Add(lbltotaldeduct);
            Controls.Add(txtretirement);
            Controls.Add(lblretirement);
            Controls.Add(txthealth);
            Controls.Add(lblhealth);
            Controls.Add(txtsosecurity);
            Controls.Add(lblsosecurity);
            Controls.Add(txtitax);
            Controls.Add(lblitax);
            Controls.Add(btnsearchemp);
            Controls.Add(txtsearchemp);
            Controls.Add(lblsearchemp);
            Controls.Add(cmbdepartment);
            Controls.Add(lbldepartment);
            Controls.Add(txtempname);
            Controls.Add(lblempname);
            Controls.Add(txtempid);
            Controls.Add(lblempid);
            DoubleBuffered = true;
            Name = "DeductionSection";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DeductionSection";
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
        private Button btnsearchemp;
        private TextBox txtsearchemp;
        private Label lblsearchemp;
        private TextBox txtitax;
        private Label lblitax;
        private TextBox txtsosecurity;
        private Label lblsosecurity;
        private TextBox txtretirement;
        private Label lblretirement;
        private TextBox txthealth;
        private Label lblhealth;
        private TextBox txttotaldeduct;
        private Label lbltotaldeduct;
        private Button btnadddeduct;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Button btndelete;
        private Button btncancel;
    }
}