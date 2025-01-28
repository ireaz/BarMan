namespace BarMan
{
    partial class FormTransactions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTransactions));
            panel1 = new System.Windows.Forms.Panel();
            panel2 = new System.Windows.Forms.Panel();
            checkBox1 = new System.Windows.Forms.CheckBox();
            dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            panel4 = new System.Windows.Forms.Panel();
            pbAddDriver = new System.Windows.Forms.PictureBox();
            panel3 = new System.Windows.Forms.Panel();
            label2 = new System.Windows.Forms.Label();
            cbSerch = new System.Windows.Forms.ComboBox();
            tbSerch = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            DGVTransaction = new System.Windows.Forms.DataGridView();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbAddDriver).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DGVTransaction).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Dock = System.Windows.Forms.DockStyle.Top;
            panel1.Location = new System.Drawing.Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(1004, 108);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(checkBox1);
            panel2.Controls.Add(dateTimePicker2);
            panel2.Controls.Add(dateTimePicker1);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Dock = System.Windows.Forms.DockStyle.Right;
            panel2.Location = new System.Drawing.Point(610, 0);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(175, 108);
            panel2.TabIndex = 7;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new System.Drawing.Point(2, 22);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new System.Drawing.Size(92, 19);
            checkBox1.TabIndex = 7;
            checkBox1.Text = "فیلتر  با تاریخ ";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            dateTimePicker2.Location = new System.Drawing.Point(3, 70);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new System.Drawing.Size(102, 23);
            dateTimePicker2.TabIndex = 6;
            dateTimePicker2.ValueChanged += dateTimePicker2_ValueChanged;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            dateTimePicker1.Location = new System.Drawing.Point(3, 44);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new System.Drawing.Size(102, 23);
            dateTimePicker1.TabIndex = 5;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // panel4
            // 
            panel4.Controls.Add(pbAddDriver);
            panel4.Dock = System.Windows.Forms.DockStyle.Left;
            panel4.Location = new System.Drawing.Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new System.Drawing.Size(137, 108);
            panel4.TabIndex = 4;
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
            panel3.Controls.Add(tbSerch);
            panel3.Controls.Add(label1);
            panel3.Dock = System.Windows.Forms.DockStyle.Right;
            panel3.Location = new System.Drawing.Point(785, 0);
            panel3.Name = "panel3";
            panel3.Size = new System.Drawing.Size(219, 108);
            panel3.TabIndex = 3;
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
            // tbSerch
            // 
            tbSerch.Location = new System.Drawing.Point(0, 70);
            tbSerch.Name = "tbSerch";
            tbSerch.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            tbSerch.Size = new System.Drawing.Size(200, 23);
            tbSerch.TabIndex = 0;
            tbSerch.TextChanged += tbSerch_TextChanged;
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
            // DGVTransaction
            // 
            DGVTransaction.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGVTransaction.Dock = System.Windows.Forms.DockStyle.Fill;
            DGVTransaction.Location = new System.Drawing.Point(0, 108);
            DGVTransaction.Name = "DGVTransaction";
            DGVTransaction.RowTemplate.Height = 25;
            DGVTransaction.Size = new System.Drawing.Size(1004, 514);
            DGVTransaction.TabIndex = 1;
            DGVTransaction.DataSourceChanged += DGVTransaction_DataSourceChanged;
            DGVTransaction.CellContentClick += DGVTransaction_CellContentClick;
            DGVTransaction.ColumnAdded += DGVTransaction_ColumnAdded;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(111, 76);
            label3.Name = "label3";
            label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            label3.Size = new System.Drawing.Size(29, 15);
            label3.TabIndex = 1;
            label3.Text = "پایان";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(111, 50);
            label4.Name = "label4";
            label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            label4.Size = new System.Drawing.Size(25, 15);
            label4.TabIndex = 1;
            label4.Text = "آغاز";
            // 
            // FormTransactions
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1004, 622);
            Controls.Add(DGVTransaction);
            Controls.Add(panel1);
            KeyPreview = true;
            Name = "FormTransactions";
            Text = "FormTransactions";
            Load += FormTransactions_Load;
            KeyDown += FormTransactions_KeyDown;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbAddDriver).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DGVTransaction).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView DGVTransaction;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbSerch;
        private System.Windows.Forms.TextBox tbSerch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pbAddDriver;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}