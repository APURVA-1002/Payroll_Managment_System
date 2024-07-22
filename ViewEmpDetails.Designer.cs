namespace PayrollMngmentSystem
{
    partial class ViewEmpDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewEmpDetails));
            lblview = new Label();
            txtsearch = new TextBox();
            grdviewemp = new DataGridView();
            btnsearchemp = new Button();
            ((System.ComponentModel.ISupportInitialize)grdviewemp).BeginInit();
            SuspendLayout();
            // 
            // lblview
            // 
            lblview.AutoSize = true;
            lblview.BackColor = Color.Transparent;
            lblview.Font = new Font("Century Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblview.Location = new Point(501, 46);
            lblview.Name = "lblview";
            lblview.Size = new Size(324, 34);
            lblview.TabIndex = 2;
            lblview.Text = "View Employee Details";
            // 
            // txtsearch
            // 
            txtsearch.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtsearch.Location = new Point(375, 140);
            txtsearch.Multiline = true;
            txtsearch.Name = "txtsearch";
            txtsearch.Size = new Size(231, 41);
            txtsearch.TabIndex = 4;
            txtsearch.Tag = "int";
            txtsearch.KeyPress += Control_KeyPress;
            // 
            // grdviewemp
            // 
            grdviewemp.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grdviewemp.BorderStyle = BorderStyle.Fixed3D;
            grdviewemp.CellBorderStyle = DataGridViewCellBorderStyle.SingleVertical;
            grdviewemp.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdviewemp.Location = new Point(146, 263);
            grdviewemp.Name = "grdviewemp";
            grdviewemp.RowHeadersWidth = 51;
            grdviewemp.RowTemplate.Height = 29;
            grdviewemp.Size = new Size(1018, 444);
            grdviewemp.TabIndex = 5;
            // 
            // btnsearchemp
            // 
            btnsearchemp.BackColor = Color.Silver;
            btnsearchemp.FlatAppearance.BorderSize = 0;
            btnsearchemp.FlatStyle = FlatStyle.Flat;
            btnsearchemp.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnsearchemp.Location = new Point(682, 140);
            btnsearchemp.Name = "btnsearchemp";
            btnsearchemp.Size = new Size(268, 41);
            btnsearchemp.TabIndex = 16;
            btnsearchemp.Text = "Search Employee";
            btnsearchemp.UseVisualStyleBackColor = false;
            btnsearchemp.Click += btnsearchemp_Click;
            // 
            // ViewEmpDetails
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 122);
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(1315, 780);
            Controls.Add(btnsearchemp);
            Controls.Add(grdviewemp);
            Controls.Add(txtsearch);
            Controls.Add(lblview);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ViewEmpDetails";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ViewEmpDetails";
            Load += ViewEmpDetails_Load;
            ((System.ComponentModel.ISupportInitialize)grdviewemp).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblview;
        private TextBox txtsearch;
        private DataGridView grdviewemp;
        private Button btnsearchemp;
    }
}