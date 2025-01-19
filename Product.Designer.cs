namespace BarMan
{
    partial class EditProduct
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
            Lnew = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            btncCancel = new System.Windows.Forms.Button();
            btnSave = new System.Windows.Forms.Button();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            Tproductname = new System.Windows.Forms.TextBox();
            ProductNumber = new System.Windows.Forms.NumericUpDown();
            CBCategory = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)ProductNumber).BeginInit();
            SuspendLayout();
            // 
            // Lnew
            // 
            Lnew.AutoSize = true;
            Lnew.Location = new System.Drawing.Point(218, 51);
            Lnew.Name = "Lnew";
            Lnew.Size = new System.Drawing.Size(83, 15);
            Lnew.TabIndex = 15;
            Lnew.Text = "اضافه کردن کالا";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(357, 94);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(40, 15);
            label2.TabIndex = 16;
            label2.Text = "نام کالا";
            // 
            // btncCancel
            // 
            btncCancel.Location = new System.Drawing.Point(56, 313);
            btncCancel.Name = "btncCancel";
            btncCancel.Size = new System.Drawing.Size(99, 32);
            btncCancel.TabIndex = 21;
            btncCancel.Text = "انصراف";
            btncCancel.UseVisualStyleBackColor = true;
            btncCancel.Click += btncCancel_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new System.Drawing.Point(320, 313);
            btnSave.Name = "btnSave";
            btnSave.Size = new System.Drawing.Size(99, 32);
            btnSave.TabIndex = 22;
            btnSave.Text = "افزودن";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(361, 159);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(33, 15);
            label3.TabIndex = 14;
            label3.Text = "تعداد";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(356, 224);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(43, 15);
            label4.TabIndex = 20;
            label4.Text = "نوع کالا";
            // 
            // Tproductname
            // 
            Tproductname.Location = new System.Drawing.Point(56, 112);
            Tproductname.Name = "Tproductname";
            Tproductname.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            Tproductname.Size = new System.Drawing.Size(363, 23);
            Tproductname.TabIndex = 17;
            Tproductname.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // ProductNumber
            // 
            ProductNumber.Location = new System.Drawing.Point(56, 177);
            ProductNumber.Maximum = new decimal(new int[] { -727379969, 232, 0, 0 });
            ProductNumber.Name = "ProductNumber";
            ProductNumber.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            ProductNumber.Size = new System.Drawing.Size(363, 23);
            ProductNumber.TabIndex = 19;
            // 
            // CBCategory
            // 
            CBCategory.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            CBCategory.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            CBCategory.FormattingEnabled = true;
            CBCategory.Location = new System.Drawing.Point(56, 242);
            CBCategory.Name = "CBCategory";
            CBCategory.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            CBCategory.Size = new System.Drawing.Size(363, 23);
            CBCategory.TabIndex = 18;
            // 
            // EditProduct
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(516, 431);
            Controls.Add(Lnew);
            Controls.Add(label2);
            Controls.Add(btncCancel);
            Controls.Add(btnSave);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(Tproductname);
            Controls.Add(ProductNumber);
            Controls.Add(CBCategory);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            Name = "EditProduct";
            Text = "ویرایش کالا";
            Load += EditProduct_Load;
            ((System.ComponentModel.ISupportInitialize)ProductNumber).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label Lnew;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btncCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Tproductname;
        private System.Windows.Forms.NumericUpDown ProductNumber;
        private System.Windows.Forms.ComboBox CBCategory;
    }
}