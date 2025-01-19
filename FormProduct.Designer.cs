namespace BarMan
{
    partial class FormProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProduct));
            label1 = new System.Windows.Forms.Label();
            textS = new System.Windows.Forms.TextBox();
            Lnew = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            btncCancel = new System.Windows.Forms.Button();
            btnSave = new System.Windows.Forms.Button();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            Tproductname = new System.Windows.Forms.TextBox();
            ProductNumber = new System.Windows.Forms.NumericUpDown();
            CBCategory = new System.Windows.Forms.ComboBox();
            panel3 = new System.Windows.Forms.Panel();
            panel2 = new System.Windows.Forms.Panel();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            label10 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            textSerchProduct = new System.Windows.Forms.TextBox();
            panel5 = new System.Windows.Forms.Panel();
            label6 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            button2 = new System.Windows.Forms.Button();
            label8 = new System.Windows.Forms.Label();
            label9 = new System.Windows.Forms.Label();
            TBName = new System.Windows.Forms.TextBox();
            NumberProduct = new System.Windows.Forms.NumericUpDown();
            CBCtegories = new System.Windows.Forms.ComboBox();
            panel1 = new System.Windows.Forms.Panel();
            DGVProduct = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)ProductNumber).BeginInit();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)NumberProduct).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DGVProduct).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(199, 31);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(50, 15);
            label1.TabIndex = 1;
            label1.Text = "جستوجو ";
            // 
            // textS
            // 
            textS.Location = new System.Drawing.Point(54, 60);
            textS.Name = "textS";
            textS.Size = new System.Drawing.Size(211, 23);
            textS.TabIndex = 0;
            // 
            // Lnew
            // 
            Lnew.AutoSize = true;
            Lnew.Location = new System.Drawing.Point(215, 45);
            Lnew.Name = "Lnew";
            Lnew.Size = new System.Drawing.Size(83, 15);
            Lnew.TabIndex = 8;
            Lnew.Text = "اضافه کردن کالا";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(354, 88);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(40, 15);
            label2.TabIndex = 8;
            label2.Text = "نام کالا";
            // 
            // btncCancel
            // 
            btncCancel.Location = new System.Drawing.Point(53, 307);
            btncCancel.Name = "btncCancel";
            btncCancel.Size = new System.Drawing.Size(99, 32);
            btncCancel.TabIndex = 13;
            btncCancel.Text = "انصراف";
            btncCancel.UseVisualStyleBackColor = true;
            btncCancel.Visible = false;
            // 
            // btnSave
            // 
            btnSave.Location = new System.Drawing.Point(317, 307);
            btnSave.Name = "btnSave";
            btnSave.Size = new System.Drawing.Size(99, 32);
            btnSave.TabIndex = 13;
            btnSave.Text = "افزودن";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(358, 153);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(33, 15);
            label3.TabIndex = 7;
            label3.Text = "تعداد";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(353, 218);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(43, 15);
            label4.TabIndex = 12;
            label4.Text = "نوع کالا";
            // 
            // Tproductname
            // 
            Tproductname.Location = new System.Drawing.Point(53, 106);
            Tproductname.Name = "Tproductname";
            Tproductname.Size = new System.Drawing.Size(363, 23);
            Tproductname.TabIndex = 9;
            Tproductname.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // ProductNumber
            // 
            ProductNumber.Location = new System.Drawing.Point(53, 171);
            ProductNumber.Name = "ProductNumber";
            ProductNumber.Size = new System.Drawing.Size(363, 23);
            ProductNumber.TabIndex = 11;
            // 
            // CBCategory
            // 
            CBCategory.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            CBCategory.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            CBCategory.FormattingEnabled = true;
            CBCategory.Location = new System.Drawing.Point(53, 236);
            CBCategory.Name = "CBCategory";
            CBCategory.Size = new System.Drawing.Size(363, 23);
            CBCategory.TabIndex = 10;
            // 
            // panel3
            // 
            panel3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            panel3.Controls.Add(panel2);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(textSerchProduct);
            panel3.Dock = System.Windows.Forms.DockStyle.Top;
            panel3.Location = new System.Drawing.Point(487, 0);
            panel3.Name = "panel3";
            panel3.Size = new System.Drawing.Size(575, 113);
            panel3.TabIndex = 16;
            // 
            // panel2
            // 
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(label10);
            panel2.Dock = System.Windows.Forms.DockStyle.Left;
            panel2.Location = new System.Drawing.Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(200, 113);
            panel2.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new System.Drawing.Point(27, 42);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(78, 65);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new System.Drawing.Point(16, 24);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(110, 15);
            label10.TabIndex = 0;
            label10.Text = "اضافه کردن دستبندی";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(465, 38);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(50, 15);
            label5.TabIndex = 1;
            label5.Text = "جستوجو ";
            // 
            // textSerchProduct
            // 
            textSerchProduct.Location = new System.Drawing.Point(320, 67);
            textSerchProduct.Name = "textSerchProduct";
            textSerchProduct.Size = new System.Drawing.Size(211, 23);
            textSerchProduct.TabIndex = 0;
            textSerchProduct.TextChanged += textSerchProduct_TextChanged;
            // 
            // panel5
            // 
            panel5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            panel5.Controls.Add(label6);
            panel5.Controls.Add(label7);
            panel5.Controls.Add(button2);
            panel5.Controls.Add(label8);
            panel5.Controls.Add(label9);
            panel5.Controls.Add(TBName);
            panel5.Controls.Add(NumberProduct);
            panel5.Controls.Add(CBCtegories);
            panel5.Dock = System.Windows.Forms.DockStyle.Left;
            panel5.Location = new System.Drawing.Point(0, 0);
            panel5.Name = "panel5";
            panel5.Size = new System.Drawing.Size(487, 656);
            panel5.TabIndex = 17;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(214, 228);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(83, 15);
            label6.TabIndex = 8;
            label6.Text = "اضافه کردن کالا";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(353, 271);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(40, 15);
            label7.TabIndex = 8;
            label7.Text = "نام کالا";
            // 
            // button2
            // 
            button2.Location = new System.Drawing.Point(189, 487);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(99, 32);
            button2.TabIndex = 13;
            button2.Text = "افزودن";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new System.Drawing.Point(357, 336);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(33, 15);
            label8.TabIndex = 7;
            label8.Text = "تعداد";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new System.Drawing.Point(352, 401);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(43, 15);
            label9.TabIndex = 12;
            label9.Text = "نوع کالا";
            // 
            // TBName
            // 
            TBName.Location = new System.Drawing.Point(52, 289);
            TBName.Name = "TBName";
            TBName.Size = new System.Drawing.Size(363, 23);
            TBName.TabIndex = 9;
            TBName.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // NumberProduct
            // 
            NumberProduct.Location = new System.Drawing.Point(52, 354);
            NumberProduct.Maximum = new decimal(new int[] { -727379969, 232, 0, 0 });
            NumberProduct.Name = "NumberProduct";
            NumberProduct.Size = new System.Drawing.Size(363, 23);
            NumberProduct.TabIndex = 11;
            // 
            // CBCtegories
            // 
            CBCtegories.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            CBCtegories.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            CBCtegories.FormattingEnabled = true;
            CBCtegories.Location = new System.Drawing.Point(52, 419);
            CBCtegories.Name = "CBCtegories";
            CBCtegories.Size = new System.Drawing.Size(363, 23);
            CBCtegories.TabIndex = 10;
            // 
            // panel1
            // 
            panel1.Controls.Add(DGVProduct);
            panel1.Dock = System.Windows.Forms.DockStyle.Right;
            panel1.Location = new System.Drawing.Point(487, 113);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(575, 543);
            panel1.TabIndex = 18;
            // 
            // DGVProduct
            // 
            DGVProduct.AllowUserToAddRows = false;
            DGVProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGVProduct.Dock = System.Windows.Forms.DockStyle.Right;
            DGVProduct.Location = new System.Drawing.Point(0, 0);
            DGVProduct.Name = "DGVProduct";
            DGVProduct.ReadOnly = true;
            DGVProduct.RowTemplate.Height = 25;
            DGVProduct.Size = new System.Drawing.Size(575, 543);
            DGVProduct.TabIndex = 16;
            DGVProduct.CellContentClick += DGVProduct_CellContentClick_1;
            // 
            // FormProduct
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1062, 656);
            Controls.Add(panel1);
            Controls.Add(panel3);
            Controls.Add(panel5);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            Name = "FormProduct";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "FormProduct";
            TopMost = true;
            Load += FormProduct_Load;
            ((System.ComponentModel.ISupportInitialize)ProductNumber).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)NumberProduct).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DGVProduct).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textS;
        private System.Windows.Forms.Label Lnew;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btncCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Tproductname;
        private System.Windows.Forms.NumericUpDown ProductNumber;
        private System.Windows.Forms.ComboBox CBCategory;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textSerchProduct;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TBName;
        private System.Windows.Forms.NumericUpDown NumberProduct;
        private System.Windows.Forms.ComboBox CBCtegories;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView DGVProduct;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label10;
    }
}