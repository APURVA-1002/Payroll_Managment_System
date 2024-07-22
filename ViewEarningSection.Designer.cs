namespace PayrollMngmentSystem
{
    partial class ViewEarningSection
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewEarningSection));
            grdviewearning = new DataGridView();
            btnsearchemp = new Button();
            txtsearch = new TextBox();
            lblviewearn = new Label();
            ((System.ComponentModel.ISupportInitialize)grdviewearning).BeginInit();
            SuspendLayout();
            // 
            // grdviewearning
            // 
            grdviewearning.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grdviewearning.BackgroundColor = Color.Gray;
            grdviewearning.BorderStyle = BorderStyle.Fixed3D;
            grdviewearning.CellBorderStyle = DataGridViewCellBorderStyle.SingleVertical;
            grdviewearning.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdviewearning.Location = new Point(199, 259);
            grdviewearning.Name = "grdviewearning";
            grdviewearning.RowHeadersWidth = 51;
            grdviewearning.RowTemplate.Height = 29;
            grdviewearning.Size = new Size(943, 444);
            grdviewearning.TabIndex = 24;
            // 
            // btnsearchemp
            // 
            btnsearchemp.BackColor = Color.Silver;
            btnsearchemp.FlatAppearance.BorderSize = 0;
            btnsearchemp.FlatStyle = FlatStyle.Flat;
            btnsearchemp.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnsearchemp.Location = new Point(683, 137);
            btnsearchemp.Name = "btnsearchemp";
            btnsearchemp.Size = new Size(268, 41);
            btnsearchemp.TabIndex = 23;
            btnsearchemp.Text = "Search Employee";
            btnsearchemp.UseVisualStyleBackColor = false;
            btnsearchemp.Click += btnsearchemp_Click;
            // 
            // txtsearch
            // 
            txtsearch.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtsearch.Location = new Point(376, 137);
            txtsearch.Multiline = true;
            txtsearch.Name = "txtsearch";
            txtsearch.Size = new Size(231, 41);
            txtsearch.TabIndex = 22;
            txtsearch.Tag = "int";
            txtsearch.KeyPress += Control_KeyPress;
            // 
            // lblviewearn
            // 
            lblviewearn.AutoSize = true;
            lblviewearn.BackColor = Color.Transparent;
            lblviewearn.Font = new Font("Century Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblviewearn.Location = new Point(510, 40);
            lblviewearn.Name = "lblviewearn";
            lblviewearn.Size = new Size(300, 34);
            lblviewearn.TabIndex = 21;
            lblviewearn.Text = "View Earning Section";
            // 
            // ViewEarningSection
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 122);
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1315, 780);
            Controls.Add(grdviewearning);
            Controls.Add(btnsearchemp);
            Controls.Add(txtsearch);
            Controls.Add(lblviewearn);
            DoubleBuffered = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ViewEarningSection";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ViewEarningSection";
            Load += ViewEarningSection_Load;
            ((System.ComponentModel.ISupportInitialize)grdviewearning).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView grdviewearning;
        private Button btnsearchemp;
        private TextBox txtsearch;
        private Label lblviewearn;
    }
}