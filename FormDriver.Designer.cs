namespace BarMan
{
    partial class FormDriver
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDriver));
            panel1 = new System.Windows.Forms.Panel();
            panel4 = new System.Windows.Forms.Panel();
            pbAddDriver = new System.Windows.Forms.PictureBox();
            panel3 = new System.Windows.Forms.Panel();
            label2 = new System.Windows.Forms.Label();
            cbSerch = new System.Windows.Forms.ComboBox();
            tbSerchDriver = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            panel2 = new System.Windows.Forms.Panel();
            DGVDriver = new System.Windows.Forms.DataGridView();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbAddDriver).BeginInit();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DGVDriver).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Dock = System.Windows.Forms.DockStyle.Top;
            panel1.Location = new System.Drawing.Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(689, 100);
            panel1.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.Controls.Add(pbAddDriver);
            panel4.Dock = System.Windows.Forms.DockStyle.Left;
            panel4.Location = new System.Drawing.Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new System.Drawing.Size(137, 100);
            panel4.TabIndex = 3;
            // 
            // pbAddDriver
            // 
            pbAddDriver.Cursor = System.Windows.Forms.Cursors.Hand;
            pbAddDriver.Image = (System.Drawing.Image)resources.GetObject("pbAddDriver.Image");
            pbAddDriver.Location = new System.Drawing.Point(32, 26);
            pbAddDriver.Name = "pbAddDriver";
            pbAddDriver.Size = new System.Drawing.Size(61, 59);
            pbAddDriver.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pbAddDriver.TabIndex = 0;
            pbAddDriver.TabStop = false;
            pbAddDriver.Click += pbAddDriver_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(label2);
            panel3.Controls.Add(cbSerch);
            panel3.Controls.Add(tbSerchDriver);
            panel3.Controls.Add(label1);
            panel3.Dock = System.Windows.Forms.DockStyle.Right;
            panel3.Location = new System.Drawing.Point(469, 0);
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
            cbSerch.Items.AddRange(new object[] { "نام راننده", "شماره ماشین", "کدملی" });
            cbSerch.Location = new System.Drawing.Point(0, 26);
            cbSerch.Name = "cbSerch";
            cbSerch.Size = new System.Drawing.Size(200, 23);
            cbSerch.TabIndex = 2;
            // 
            // tbSerchDriver
            // 
            tbSerchDriver.Location = new System.Drawing.Point(0, 70);
            tbSerchDriver.Name = "tbSerchDriver";
            tbSerchDriver.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            tbSerchDriver.Size = new System.Drawing.Size(200, 23);
            tbSerchDriver.TabIndex = 0;
            tbSerchDriver.TextChanged += tbSerchDriver_TextChanged;
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
            label1.Click += label1_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(DGVDriver);
            panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            panel2.Location = new System.Drawing.Point(0, 100);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(689, 502);
            panel2.TabIndex = 1;
            // 
            // DGVDriver
            // 
            DGVDriver.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            DGVDriver.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGVDriver.Dock = System.Windows.Forms.DockStyle.Fill;
            DGVDriver.Location = new System.Drawing.Point(0, 0);
            DGVDriver.Name = "DGVDriver";
            DGVDriver.RowTemplate.Height = 25;
            DGVDriver.Size = new System.Drawing.Size(689, 502);
            DGVDriver.TabIndex = 0;
            DGVDriver.CellContentClick += DGVDriver_CellContentClick;
            DGVDriver.DataBindingComplete += DGVDriver_DataBindingComplete;
            // 
            // FormDriver
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(689, 602);
            Controls.Add(panel2);
            Controls.Add(panel1);
            KeyPreview = true;
            Name = "FormDriver";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "FormDriver";
            Load += FormDriver_Load;
            KeyDown += FormDriver_KeyDown;
            panel1.ResumeLayout(false);
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbAddDriver).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DGVDriver).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox tbSerchDriver;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView DGVDriver;
        private System.Windows.Forms.PictureBox pbAddDriver;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbSerch;
    }
}