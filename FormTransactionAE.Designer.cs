namespace BarMan
{
    partial class FormTransactionAE
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
            dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            cbProduct = new System.Windows.Forms.ComboBox();
            label5 = new System.Windows.Forms.Label();
            CBDriver = new System.Windows.Forms.ComboBox();
            label6 = new System.Windows.Forms.Label();
            cbSupplisers = new System.Windows.Forms.ComboBox();
            CBType = new System.Windows.Forms.ComboBox();
            label7 = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            btnOK = new System.Windows.Forms.Button();
            btnCansell = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            label9 = new System.Windows.Forms.Label();
            Price = new System.Windows.Forms.TextBox();
            ProductNum = new System.Windows.Forms.NumericUpDown();
            TimeT = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)ProductNum).BeginInit();
            SuspendLayout();
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            dateTimePicker1.Location = new System.Drawing.Point(291, 386);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new System.Drawing.Size(138, 22);
            dateTimePicker1.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(209, 60);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(120, 31);
            label2.TabIndex = 0;
            label2.Text = "ثبت تراکنش";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label3.Location = new System.Drawing.Point(234, 281);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(55, 16);
            label3.TabIndex = 0;
            label3.Text = "قیمت کالا";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label4.Location = new System.Drawing.Point(452, 281);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(53, 16);
            label4.TabIndex = 0;
            label4.Text = "تعداد کالا";
            // 
            // cbProduct
            // 
            cbProduct.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            cbProduct.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            cbProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            cbProduct.FormattingEnabled = true;
            cbProduct.Location = new System.Drawing.Point(92, 126);
            cbProduct.Name = "cbProduct";
            cbProduct.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            cbProduct.Size = new System.Drawing.Size(337, 24);
            cbProduct.TabIndex = 0;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label5.Location = new System.Drawing.Point(451, 181);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(35, 16);
            label5.TabIndex = 0;
            label5.Text = "راننده";
            // 
            // CBDriver
            // 
            CBDriver.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            CBDriver.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            CBDriver.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            CBDriver.FormattingEnabled = true;
            CBDriver.Location = new System.Drawing.Point(92, 173);
            CBDriver.Name = "CBDriver";
            CBDriver.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            CBDriver.Size = new System.Drawing.Size(337, 24);
            CBDriver.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label6.Location = new System.Drawing.Point(452, 233);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(39, 16);
            label6.TabIndex = 0;
            label6.Text = "خریدار";
            // 
            // cbSupplisers
            // 
            cbSupplisers.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            cbSupplisers.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            cbSupplisers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            cbSupplisers.FormattingEnabled = true;
            cbSupplisers.Location = new System.Drawing.Point(92, 225);
            cbSupplisers.Name = "cbSupplisers";
            cbSupplisers.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            cbSupplisers.Size = new System.Drawing.Size(337, 24);
            cbSupplisers.TabIndex = 2;
            // 
            // CBType
            // 
            CBType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            CBType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            CBType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            CBType.FormattingEnabled = true;
            CBType.Items.AddRange(new object[] { "خرید", "فروش" });
            CBType.Location = new System.Drawing.Point(92, 336);
            CBType.Name = "CBType";
            CBType.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            CBType.Size = new System.Drawing.Size(337, 24);
            CBType.TabIndex = 6;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label7.Location = new System.Drawing.Point(452, 336);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(67, 16);
            label7.TabIndex = 0;
            label7.Text = "نوع تراکنش";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label8.Location = new System.Drawing.Point(452, 394);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(77, 16);
            label8.TabIndex = 0;
            label8.Text = "تاریخ تراکنش";
            // 
            // btnOK
            // 
            btnOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnOK.Location = new System.Drawing.Point(363, 463);
            btnOK.Name = "btnOK";
            btnOK.Size = new System.Drawing.Size(66, 36);
            btnOK.TabIndex = 9;
            btnOK.Text = "ثبت";
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += btnOK_Click;
            // 
            // btnCansell
            // 
            btnCansell.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnCansell.Location = new System.Drawing.Point(92, 463);
            btnCansell.Name = "btnCansell";
            btnCansell.Size = new System.Drawing.Size(86, 36);
            btnCansell.TabIndex = 10;
            btnCansell.Text = "انصراف";
            btnCansell.UseVisualStyleBackColor = true;
            btnCansell.Click += btnCansell_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(451, 134);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(48, 16);
            label1.TabIndex = 0;
            label1.Text = "نوع کالا";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label9.Location = new System.Drawing.Point(193, 391);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(79, 16);
            label9.TabIndex = 0;
            label9.Text = "ساعت تراکنش";
            // 
            // Price
            // 
            Price.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            Price.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            Price.Location = new System.Drawing.Point(94, 278);
            Price.MaxLength = 9;
            Price.Name = "Price";
            Price.Size = new System.Drawing.Size(134, 22);
            Price.TabIndex = 5;
            Price.TextChanged += textBox2_TextChanged;
            Price.KeyPress += textBox2_KeyPress;
            // 
            // ProductNum
            // 
            ProductNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            ProductNum.Location = new System.Drawing.Point(309, 279);
            ProductNum.Maximum = new decimal(new int[] { 999999999, 0, 0, 0 });
            ProductNum.Name = "ProductNum";
            ProductNum.Size = new System.Drawing.Size(120, 22);
            ProductNum.TabIndex = 4;
            // 
            // TimeT
            // 
            TimeT.CustomFormat = "mm,HH";
            TimeT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            TimeT.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            TimeT.Location = new System.Drawing.Point(92, 388);
            TimeT.Name = "TimeT";
            TimeT.ShowUpDown = true;
            TimeT.Size = new System.Drawing.Size(95, 22);
            TimeT.TabIndex = 8;
            TimeT.Value = new System.DateTime(2025, 1, 23, 0, 58, 0, 0);
            // 
            // FormTransactionAE
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(567, 546);
            Controls.Add(ProductNum);
            Controls.Add(Price);
            Controls.Add(btnCansell);
            Controls.Add(btnOK);
            Controls.Add(CBType);
            Controls.Add(cbSupplisers);
            Controls.Add(CBDriver);
            Controls.Add(cbProduct);
            Controls.Add(TimeT);
            Controls.Add(dateTimePicker1);
            Controls.Add(label6);
            Controls.Add(label1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label3);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            KeyPreview = true;
            Name = "FormTransactionAE";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "FormTransactionAE";
            Load += FormTransactionAE_Load;
            KeyDown += FormTransactionAE_KeyDown;
            ((System.ComponentModel.ISupportInitialize)ProductNum).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbProduct;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox CBDriver;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbSupplisers;
        private System.Windows.Forms.ComboBox CBType;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCansell;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox time;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox Price;
        private System.Windows.Forms.NumericUpDown ProductNum;
        private System.Windows.Forms.DateTimePicker TimeT;
    }
}