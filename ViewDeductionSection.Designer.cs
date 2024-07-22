namespace PayrollMngmentSystem
{
    partial class ViewDeductionSection
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewDeductionSection));
            grdviewdeduct = new DataGridView();
            btnsearchemp = new Button();
            txtsearch = new TextBox();
            lblviewdeduct = new Label();
            ((System.ComponentModel.ISupportInitialize)grdviewdeduct).BeginInit();
            SuspendLayout();
            // 
            // grdviewdeduct
            // 
            grdviewdeduct.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grdviewdeduct.BackgroundColor = Color.Gray;
            grdviewdeduct.BorderStyle = BorderStyle.Fixed3D;
            grdviewdeduct.CellBorderStyle = DataGridViewCellBorderStyle.SingleVertical;
            grdviewdeduct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdviewdeduct.Location = new Point(181, 274);
            grdviewdeduct.Name = "grdviewdeduct";
            grdviewdeduct.RowHeadersWidth = 51;
            grdviewdeduct.RowTemplate.Height = 29;
            grdviewdeduct.Size = new Size(943, 444);
            grdviewdeduct.TabIndex = 28;
            // 
            // btnsearchemp
            // 
            btnsearchemp.BackColor = Color.Silver;
            btnsearchemp.FlatAppearance.BorderSize = 0;
            btnsearchemp.FlatStyle = FlatStyle.Flat;
            btnsearchemp.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnsearchemp.Location = new Point(648, 153);
            btnsearchemp.Name = "btnsearchemp";
            btnsearchemp.Size = new Size(268, 41);
            btnsearchemp.TabIndex = 27;
            btnsearchemp.Text = "Search Employee";
            btnsearchemp.UseVisualStyleBackColor = false;
            btnsearchemp.Click += btnsearchemp_Click;
            // 
            // txtsearch
            // 
            txtsearch.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtsearch.Location = new Point(330, 153);
            txtsearch.Multiline = true;
            txtsearch.Name = "txtsearch";
            txtsearch.Size = new Size(231, 41);
            txtsearch.TabIndex = 26;
            txtsearch.Tag = "int";
            txtsearch.KeyPress += Control_KeyPress;
            // 
            // lblviewdeduct
            // 
            lblviewdeduct.AutoSize = true;
            lblviewdeduct.BackColor = Color.Transparent;
            lblviewdeduct.Font = new Font("Century Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblviewdeduct.Location = new Point(451, 48);
            lblviewdeduct.Name = "lblviewdeduct";
            lblviewdeduct.Size = new Size(340, 34);
            lblviewdeduct.TabIndex = 25;
            lblviewdeduct.Text = "View Deduction Section";
            // 
            // ViewDeductionSection
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 122);
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1315, 780);
            Controls.Add(grdviewdeduct);
            Controls.Add(btnsearchemp);
            Controls.Add(txtsearch);
            Controls.Add(lblviewdeduct);
            DoubleBuffered = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ViewDeductionSection";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ViewDeductionSection";
            Load += ViewDeductionSection_Load;
            ((System.ComponentModel.ISupportInitialize)grdviewdeduct).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView grdviewdeduct;
        private Button btnsearchemp;
        private TextBox txtsearch;
        private Label lblviewdeduct;
    }
}