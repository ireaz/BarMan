namespace BarMan
{
    partial class FormSuppliers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSuppliers));
            pbAddSuppliers = new System.Windows.Forms.PictureBox();
            panel4 = new System.Windows.Forms.Panel();
            panel1 = new System.Windows.Forms.Panel();
            panel3 = new System.Windows.Forms.Panel();
            label2 = new System.Windows.Forms.Label();
            cbSerch = new System.Windows.Forms.ComboBox();
            tbSerchSuppliers = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            DGVSuppliers = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)pbAddSuppliers).BeginInit();
            panel4.SuspendLayout();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DGVSuppliers).BeginInit();
            SuspendLayout();
            // 
            // pbAddSuppliers
            // 
            pbAddSuppliers.Cursor = System.Windows.Forms.Cursors.Hand;
            pbAddSuppliers.Image = (System.Drawing.Image)resources.GetObject("pbAddSuppliers.Image");
            pbAddSuppliers.Location = new System.Drawing.Point(32, 26);
            pbAddSuppliers.Name = "pbAddSuppliers";
            pbAddSuppliers.Size = new System.Drawing.Size(61, 59);
            pbAddSuppliers.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pbAddSuppliers.TabIndex = 0;
            pbAddSuppliers.TabStop = false;
            pbAddSuppliers.Click += pbAddSuppliers_Click;
            // 
            // panel4
            // 
            panel4.Controls.Add(pbAddSuppliers);
            panel4.Dock = System.Windows.Forms.DockStyle.Left;
            panel4.Location = new System.Drawing.Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new System.Drawing.Size(137, 100);
            panel4.TabIndex = 3;
            // 
            // panel1
            // 
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Dock = System.Windows.Forms.DockStyle.Top;
            panel1.Location = new System.Drawing.Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(762, 100);
            panel1.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.Controls.Add(label2);
            panel3.Controls.Add(cbSerch);
            panel3.Controls.Add(tbSerchSuppliers);
            panel3.Controls.Add(label1);
            panel3.Dock = System.Windows.Forms.DockStyle.Right;
            panel3.Location = new System.Drawing.Point(542, 0);
            panel3.Name = "panel3";
            panel3.Size = new System.Drawing.Size(220, 100);
            panel3.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(67, 8);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(130, 15);
            label2.TabIndex = 3;
            label2.Text = "انتخاب ستون برای جستجو";
            // 
            // cbSerch
            // 
            cbSerch.FormattingEnabled = true;
            cbSerch.Items.AddRange(new object[] { "نام خریدار", "شماره تلفن", "کدملی", "ایمیل" });
            cbSerch.Location = new System.Drawing.Point(0, 26);
            cbSerch.Name = "cbSerch";
            cbSerch.Size = new System.Drawing.Size(200, 23);
            cbSerch.TabIndex = 2;
            // 
            // tbSerchSuppliers
            // 
            tbSerchSuppliers.Location = new System.Drawing.Point(0, 70);
            tbSerchSuppliers.Name = "tbSerchSuppliers";
            tbSerchSuppliers.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            tbSerchSuppliers.Size = new System.Drawing.Size(200, 23);
            tbSerchSuppliers.TabIndex = 0;
            tbSerchSuppliers.TextChanged += tbSerchSuppliers_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(156, 52);
            label1.Name = "label1";
            label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            label1.Size = new System.Drawing.Size(41, 15);
            label1.TabIndex = 1;
            label1.Text = "جستجو";
            // 
            // DGVSuppliers
            // 
            DGVSuppliers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGVSuppliers.Dock = System.Windows.Forms.DockStyle.Fill;
            DGVSuppliers.Location = new System.Drawing.Point(0, 100);
            DGVSuppliers.Name = "DGVSuppliers";
            DGVSuppliers.RowTemplate.Height = 25;
            DGVSuppliers.Size = new System.Drawing.Size(762, 452);
            DGVSuppliers.TabIndex = 2;
            DGVSuppliers.CellContentClick += DGVSuppliers_CellContentClick_1;
            DGVSuppliers.DataBindingComplete += DGVSuppliers_DataBindingComplete;
            // 
            // FormSuppliers
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(762, 552);
            Controls.Add(DGVSuppliers);
            Controls.Add(panel1);
            KeyPreview = true;
            Name = "FormSuppliers";
            Text = "FormSuppliers";
            Load += FormSuppliers_Load;
            KeyDown += FormSuppliers_KeyDown;
            ((System.ComponentModel.ISupportInitialize)pbAddSuppliers).EndInit();
            panel4.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DGVSuppliers).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.PictureBox pbAddSuppliers;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbSerch;
        private System.Windows.Forms.TextBox tbSerchSuppliers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DGVSuppliers;
    }
}