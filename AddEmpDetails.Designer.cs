namespace PayrollMngmentSystem
{
    partial class AddEmpDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddEmpDetails));
            lblempid = new Label();
            txtempid = new TextBox();
            txtempname = new TextBox();
            lblempname = new Label();
            lblposition = new Label();
            lbldepartment = new Label();
            cmbdepartment = new ComboBox();
            cmbposition = new ComboBox();
            lblwklocation = new Label();
            cmbwklocation = new ComboBox();
            lbldob = new Label();
            dtmdateofbirth = new DateTimePicker();
            txtemail = new TextBox();
            lblemailid = new Label();
            btnaddemp = new Button();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            btncancel = new Button();
            btndelete = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblempid
            // 
            lblempid.AutoSize = true;
            lblempid.BackColor = Color.Transparent;
            lblempid.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblempid.ForeColor = Color.White;
            lblempid.Location = new Point(630, 68);
            lblempid.Name = "lblempid";
            lblempid.Size = new Size(134, 23);
            lblempid.TabIndex = 0;
            lblempid.Text = "Employee ID";
            // 
            // txtempid
            // 
            txtempid.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtempid.Location = new Point(882, 68);
            txtempid.Multiline = true;
            txtempid.Name = "txtempid";
            txtempid.Size = new Size(379, 41);
            txtempid.TabIndex = 1;
            txtempid.Tag = "int";
            txtempid.KeyPress += Control_KeyPress;
            txtempid.Validating += txtempid_Validating;
            // 
            // txtempname
            // 
            txtempname.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtempname.Location = new Point(882, 152);
            txtempname.Multiline = true;
            txtempname.Name = "txtempname";
            txtempname.Size = new Size(379, 41);
            txtempname.TabIndex = 2;
            txtempname.Tag = "string";
            txtempname.KeyPress += Control_KeyPress;
            // 
            // lblempname
            // 
            lblempname.AutoSize = true;
            lblempname.BackColor = Color.Transparent;
            lblempname.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblempname.ForeColor = Color.White;
            lblempname.Location = new Point(624, 152);
            lblempname.Name = "lblempname";
            lblempname.Size = new Size(174, 23);
            lblempname.TabIndex = 2;
            lblempname.Text = "Employee Name";
            // 
            // lblposition
            // 
            lblposition.AutoSize = true;
            lblposition.BackColor = Color.Transparent;
            lblposition.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblposition.ForeColor = Color.White;
            lblposition.Location = new Point(630, 342);
            lblposition.Name = "lblposition";
            lblposition.Size = new Size(84, 23);
            lblposition.TabIndex = 6;
            lblposition.Text = "Position";
            // 
            // lbldepartment
            // 
            lbldepartment.AutoSize = true;
            lbldepartment.BackColor = Color.Transparent;
            lbldepartment.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbldepartment.ForeColor = Color.White;
            lbldepartment.Location = new Point(624, 247);
            lbldepartment.Name = "lbldepartment";
            lbldepartment.Size = new Size(125, 23);
            lbldepartment.TabIndex = 4;
            lbldepartment.Text = "Department";
            // 
            // cmbdepartment
            // 
            cmbdepartment.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            cmbdepartment.FormattingEnabled = true;
            cmbdepartment.Items.AddRange(new object[] { "Sales", "Marketing", "Finance", "Human Resources", "Information Technology (IT)", "Customer Service", "Operations", "Research and Development", "Administration", "Production" });
            cmbdepartment.Location = new Point(882, 249);
            cmbdepartment.Name = "cmbdepartment";
            cmbdepartment.Size = new Size(379, 31);
            cmbdepartment.TabIndex = 3;
            // 
            // cmbposition
            // 
            cmbposition.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            cmbposition.FormattingEnabled = true;
            cmbposition.Items.AddRange(new object[] { "Sales Representative", "Sales Manager", "Account Executive", "Business Development Specialist", "Marketing Coordinator", "Marketing Manager", "Social Media Specialist", "Content Writer", "Financial Analyst", "Accounting Clerk", "Finance Manager", "Auditor", "HR Assistant", "HR Generalist", "Recruitment Specialist", "HR Manager", "IT Support Specialist", "Systems Administrator", "Software Developer", "IT Project Manager", "Customer Service Representative", "Customer Support Specialist", "Customer Success Manager", "Operations Coordinator", "Operations Manager", "Logistics Specialist", "Research Analyst", "Product Development Engineer", "Research Scientist", "Administration:", "Administrative Assistant", "Office Manager", "Executive Assistant", "Production Worker", "Manufacturing Engineer", "Production Manager" });
            cmbposition.Location = new Point(882, 341);
            cmbposition.Name = "cmbposition";
            cmbposition.Size = new Size(379, 31);
            cmbposition.TabIndex = 4;
            // 
            // lblwklocation
            // 
            lblwklocation.AutoSize = true;
            lblwklocation.BackColor = Color.Transparent;
            lblwklocation.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblwklocation.ForeColor = Color.White;
            lblwklocation.Location = new Point(630, 425);
            lblwklocation.Name = "lblwklocation";
            lblwklocation.Size = new Size(149, 23);
            lblwklocation.TabIndex = 9;
            lblwklocation.Text = "Work Location";
            // 
            // cmbwklocation
            // 
            cmbwklocation.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            cmbwklocation.FormattingEnabled = true;
            cmbwklocation.Items.AddRange(new object[] { "Mumbai", "Pune", "Banglore", "Indore", "Chennai" });
            cmbwklocation.Location = new Point(882, 423);
            cmbwklocation.Name = "cmbwklocation";
            cmbwklocation.Size = new Size(379, 31);
            cmbwklocation.TabIndex = 5;
            // 
            // lbldob
            // 
            lbldob.AutoSize = true;
            lbldob.BackColor = Color.Transparent;
            lbldob.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbldob.ForeColor = Color.White;
            lbldob.Location = new Point(630, 515);
            lbldob.Name = "lbldob";
            lbldob.Size = new Size(128, 23);
            lbldob.TabIndex = 11;
            lbldob.Text = "Date of Birth";
            // 
            // dtmdateofbirth
            // 
            dtmdateofbirth.CalendarFont = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dtmdateofbirth.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dtmdateofbirth.Location = new Point(882, 515);
            dtmdateofbirth.Name = "dtmdateofbirth";
            dtmdateofbirth.Size = new Size(379, 32);
            dtmdateofbirth.TabIndex = 6;
            // 
            // txtemail
            // 
            txtemail.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtemail.Location = new Point(882, 593);
            txtemail.Multiline = true;
            txtemail.Name = "txtemail";
            txtemail.Size = new Size(379, 41);
            txtemail.TabIndex = 7;
            txtemail.Tag = "email";
            txtemail.KeyPress += Control_KeyPress;
            // 
            // lblemailid
            // 
            lblemailid.AutoSize = true;
            lblemailid.BackColor = Color.Transparent;
            lblemailid.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblemailid.ForeColor = Color.White;
            lblemailid.Location = new Point(630, 604);
            lblemailid.Name = "lblemailid";
            lblemailid.Size = new Size(88, 23);
            lblemailid.TabIndex = 13;
            lblemailid.Text = "Email ID";
            // 
            // btnaddemp
            // 
            btnaddemp.BackColor = Color.Silver;
            btnaddemp.FlatAppearance.BorderSize = 0;
            btnaddemp.FlatStyle = FlatStyle.Flat;
            btnaddemp.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnaddemp.Location = new Point(882, 669);
            btnaddemp.Name = "btnaddemp";
            btnaddemp.Size = new Size(112, 38);
            btnaddemp.TabIndex = 8;
            btnaddemp.Text = "Add";
            btnaddemp.UseVisualStyleBackColor = false;
            btnaddemp.Click += btnaddemp_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(598, 780);
            panel1.TabIndex = 14;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(598, 780);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // btncancel
            // 
            btncancel.BackColor = Color.Silver;
            btncancel.FlatAppearance.BorderSize = 0;
            btncancel.FlatStyle = FlatStyle.Flat;
            btncancel.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btncancel.Location = new Point(1022, 669);
            btncancel.Name = "btncancel";
            btncancel.Size = new Size(112, 38);
            btncancel.TabIndex = 15;
            btncancel.Text = "Cancel";
            btncancel.UseVisualStyleBackColor = false;
            btncancel.Click += btncancel_Click;
            // 
            // btndelete
            // 
            btndelete.BackColor = Color.Silver;
            btndelete.FlatAppearance.BorderSize = 0;
            btndelete.FlatStyle = FlatStyle.Flat;
            btndelete.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btndelete.Location = new Point(1160, 669);
            btndelete.Name = "btndelete";
            btndelete.Size = new Size(112, 38);
            btndelete.TabIndex = 16;
            btndelete.Text = "Delete";
            btndelete.UseVisualStyleBackColor = false;
            btndelete.Click += btndelete_Click;
            // 
            // AddEmpDetails
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 122);
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1315, 780);
            Controls.Add(btndelete);
            Controls.Add(btncancel);
            Controls.Add(panel1);
            Controls.Add(btnaddemp);
            Controls.Add(txtemail);
            Controls.Add(lblemailid);
            Controls.Add(dtmdateofbirth);
            Controls.Add(lbldob);
            Controls.Add(cmbwklocation);
            Controls.Add(lblwklocation);
            Controls.Add(cmbposition);
            Controls.Add(cmbdepartment);
            Controls.Add(lblposition);
            Controls.Add(lbldepartment);
            Controls.Add(txtempname);
            Controls.Add(lblempname);
            Controls.Add(txtempid);
            Controls.Add(lblempid);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "AddEmpDetails";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddEmpDetails";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblempid;
        private TextBox txtempid;
        private TextBox txtempname;
        private Label lblempname;
        private Label lblposition;
        private Label lbldepartment;
        private ComboBox cmbdepartment;
        private ComboBox cmbposition;
        private Label lblwklocation;
        private ComboBox cmbwklocation;
        private Label lbldob;
        private DateTimePicker dtmdateofbirth;
        private TextBox txtemail;
        private Label lblemailid;
        private Button btnaddemp;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Button btncancel;
        private Button btndelete;
    }
}