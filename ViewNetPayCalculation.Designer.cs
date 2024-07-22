namespace PayrollMngmentSystem
{
    partial class ViewNetPayCalculation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewNetPayCalculation));
            grdviewnetpay = new DataGridView();
            btnsearchemp = new Button();
            txtsearch = new TextBox();
            lblviewnetpay = new Label();
            ((System.ComponentModel.ISupportInitialize)grdviewnetpay).BeginInit();
            SuspendLayout();
            // 
            // grdviewnetpay
            // 
            grdviewnetpay.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grdviewnetpay.BackgroundColor = Color.Gray;
            grdviewnetpay.BorderStyle = BorderStyle.Fixed3D;
            grdviewnetpay.CellBorderStyle = DataGridViewCellBorderStyle.SingleVertical;
            grdviewnetpay.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdviewnetpay.Location = new Point(186, 281);
            grdviewnetpay.Name = "grdviewnetpay";
            grdviewnetpay.RowHeadersWidth = 51;
            grdviewnetpay.RowTemplate.Height = 29;
            grdviewnetpay.Size = new Size(943, 444);
            grdviewnetpay.TabIndex = 32;
            // 
            // btnsearchemp
            // 
            btnsearchemp.BackColor = Color.Silver;
            btnsearchemp.FlatAppearance.BorderSize = 0;
            btnsearchemp.FlatStyle = FlatStyle.Flat;
            btnsearchemp.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnsearchemp.Location = new Point(645, 160);
            btnsearchemp.Name = "btnsearchemp";
            btnsearchemp.Size = new Size(268, 41);
            btnsearchemp.TabIndex = 31;
            btnsearchemp.Text = "Search Employee";
            btnsearchemp.UseVisualStyleBackColor = false;
            btnsearchemp.Click += btnsearchemp_Click;
            // 
            // txtsearch
            // 
            txtsearch.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtsearch.Location = new Point(327, 160);
            txtsearch.Multiline = true;
            txtsearch.Name = "txtsearch";
            txtsearch.Size = new Size(231, 41);
            txtsearch.TabIndex = 30;
            txtsearch.Tag = "int";
            txtsearch.KeyPress += Control_KeyPress;
            // 
            // lblviewnetpay
            // 
            lblviewnetpay.AutoSize = true;
            lblviewnetpay.BackColor = Color.Transparent;
            lblviewnetpay.Font = new Font("Century Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblviewnetpay.Location = new Point(464, 48);
            lblviewnetpay.Name = "lblviewnetpay";
            lblviewnetpay.Size = new Size(360, 34);
            lblviewnetpay.TabIndex = 29;
            lblviewnetpay.Text = "View Net Pay Calculation";
            // 
            // ViewNetPayCalculation
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 122);
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1315, 780);
            Controls.Add(grdviewnetpay);
            Controls.Add(btnsearchemp);
            Controls.Add(txtsearch);
            Controls.Add(lblviewnetpay);
            DoubleBuffered = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ViewNetPayCalculation";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ViewNetPayCalculation";
            Load += ViewNetPayCalculation_Load;
            ((System.ComponentModel.ISupportInitialize)grdviewnetpay).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView grdviewnetpay;
        private Button btnsearchemp;
        private TextBox txtsearch;
        private Label lblviewnetpay;
    }
}