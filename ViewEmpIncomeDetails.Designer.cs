namespace PayrollMngmentSystem
{
    partial class ViewEmpIncomeDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewEmpIncomeDetails));
            btnsearchemp = new Button();
            txtsearch = new TextBox();
            lblview = new Label();
            grdviewempinc = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)grdviewempinc).BeginInit();
            SuspendLayout();
            // 
            // btnsearchemp
            // 
            btnsearchemp.BackColor = Color.Silver;
            btnsearchemp.FlatAppearance.BorderSize = 0;
            btnsearchemp.FlatStyle = FlatStyle.Flat;
            btnsearchemp.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnsearchemp.Location = new Point(656, 124);
            btnsearchemp.Name = "btnsearchemp";
            btnsearchemp.Size = new Size(268, 41);
            btnsearchemp.TabIndex = 19;
            btnsearchemp.Text = "Search Employee";
            btnsearchemp.UseVisualStyleBackColor = false;
            btnsearchemp.Click += btnsearchemp_Click;
            // 
            // txtsearch
            // 
            txtsearch.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtsearch.Location = new Point(349, 124);
            txtsearch.Multiline = true;
            txtsearch.Name = "txtsearch";
            txtsearch.Size = new Size(231, 41);
            txtsearch.TabIndex = 18;
            txtsearch.Tag = "int";
            txtsearch.KeyPress += Control_KeyPress;
            // 
            // lblview
            // 
            lblview.AutoSize = true;
            lblview.BackColor = Color.Transparent;
            lblview.Font = new Font("Century Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblview.Location = new Point(439, 37);
            lblview.Name = "lblview";
            lblview.Size = new Size(437, 34);
            lblview.TabIndex = 17;
            lblview.Text = "View Employee Income Details";
            // 
            // grdviewempinc
            // 
            grdviewempinc.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grdviewempinc.BackgroundColor = Color.Gray;
            grdviewempinc.BorderStyle = BorderStyle.Fixed3D;
            grdviewempinc.CellBorderStyle = DataGridViewCellBorderStyle.SingleVertical;
            grdviewempinc.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdviewempinc.Location = new Point(223, 246);
            grdviewempinc.Name = "grdviewempinc";
            grdviewempinc.RowHeadersWidth = 51;
            grdviewempinc.RowTemplate.Height = 29;
            grdviewempinc.Size = new Size(943, 444);
            grdviewempinc.TabIndex = 20;
            // 
            // ViewEmpIncomeDetails
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 122);
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1315, 780);
            Controls.Add(grdviewempinc);
            Controls.Add(btnsearchemp);
            Controls.Add(txtsearch);
            Controls.Add(lblview);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ViewEmpIncomeDetails";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ViewEmpIncomeDetails";
            Load += ViewEmpIncomeDetails_Load;
            ((System.ComponentModel.ISupportInitialize)grdviewempinc).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnsearchemp;
        private TextBox txtsearch;
        private Label lblview;
        private DataGridView grdviewempinc;
    }
}