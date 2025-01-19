namespace BarMan
{
    partial class FormCategory
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
            panel1 = new System.Windows.Forms.Panel();
            panel3 = new System.Windows.Forms.Panel();
            textBox1 = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            panel2 = new System.Windows.Forms.Panel();
            DGVCategory = new System.Windows.Forms.DataGridView();
            tabControl1 = new System.Windows.Forms.TabControl();
            tabPage1 = new System.Windows.Forms.TabPage();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            btnAdd = new System.Windows.Forms.Button();
            cbParent = new System.Windows.Forms.ComboBox();
            Cname = new System.Windows.Forms.TextBox();
            tabPage2 = new System.Windows.Forms.TabPage();
            label3 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            btnEdit = new System.Windows.Forms.Button();
            cbParentEdit = new System.Windows.Forms.ComboBox();
            textEdit = new System.Windows.Forms.TextBox();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DGVCategory).BeginInit();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(panel3);
            panel1.Dock = System.Windows.Forms.DockStyle.Top;
            panel1.Location = new System.Drawing.Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(905, 100);
            panel1.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Controls.Add(textBox1);
            panel3.Controls.Add(label1);
            panel3.Dock = System.Windows.Forms.DockStyle.Right;
            panel3.Location = new System.Drawing.Point(570, 0);
            panel3.Name = "panel3";
            panel3.Size = new System.Drawing.Size(335, 100);
            panel3.TabIndex = 3;
            // 
            // textBox1
            // 
            textBox1.Location = new System.Drawing.Point(103, 55);
            textBox1.Name = "textBox1";
            textBox1.Size = new System.Drawing.Size(220, 23);
            textBox1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(282, 37);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(41, 15);
            label1.TabIndex = 1;
            label1.Text = "جستجو";
            // 
            // panel2
            // 
            panel2.Controls.Add(DGVCategory);
            panel2.Dock = System.Windows.Forms.DockStyle.Right;
            panel2.Location = new System.Drawing.Point(466, 100);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(439, 600);
            panel2.TabIndex = 1;
            // 
            // DGVCategory
            // 
            DGVCategory.AllowUserToOrderColumns = true;
            DGVCategory.AllowUserToResizeColumns = false;
            DGVCategory.AllowUserToResizeRows = false;
            DGVCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGVCategory.Dock = System.Windows.Forms.DockStyle.Fill;
            DGVCategory.Location = new System.Drawing.Point(0, 0);
            DGVCategory.Name = "DGVCategory";
            DGVCategory.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            DGVCategory.RowTemplate.Height = 25;
            DGVCategory.Size = new System.Drawing.Size(439, 600);
            DGVCategory.TabIndex = 0;
            DGVCategory.CellContentClick += DGVCategory_CellContentClick;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            tabControl1.Location = new System.Drawing.Point(0, 100);
            tabControl1.Name = "tabControl1";
            tabControl1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            tabControl1.RightToLeftLayout = true;
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new System.Drawing.Size(466, 600);
            tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(btnAdd);
            tabPage1.Controls.Add(cbParent);
            tabPage1.Controls.Add(Cname);
            tabPage1.Location = new System.Drawing.Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new System.Windows.Forms.Padding(3);
            tabPage1.Size = new System.Drawing.Size(458, 572);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "افزودن";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(273, 240);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(55, 15);
            label4.TabIndex = 7;
            label4.Text = "زیرمجموع";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(272, 114);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(56, 15);
            label5.TabIndex = 8;
            label5.Text = "نام ویژگی";
            // 
            // btnAdd
            // 
            btnAdd.Location = new System.Drawing.Point(169, 355);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new System.Drawing.Size(75, 32);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "ثبت";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // cbParent
            // 
            cbParent.FormattingEnabled = true;
            cbParent.Location = new System.Drawing.Point(75, 258);
            cbParent.Name = "cbParent";
            cbParent.Size = new System.Drawing.Size(253, 23);
            cbParent.TabIndex = 1;
            // 
            // Cname
            // 
            Cname.Location = new System.Drawing.Point(75, 132);
            Cname.Name = "Cname";
            Cname.Size = new System.Drawing.Size(253, 23);
            Cname.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(label3);
            tabPage2.Controls.Add(label2);
            tabPage2.Controls.Add(btnEdit);
            tabPage2.Controls.Add(cbParentEdit);
            tabPage2.Controls.Add(textEdit);
            tabPage2.Location = new System.Drawing.Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new System.Windows.Forms.Padding(3);
            tabPage2.Size = new System.Drawing.Size(458, 572);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "ویرایش";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(274, 265);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(55, 15);
            label3.TabIndex = 6;
            label3.Text = "زیرمجموع";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(273, 139);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(56, 15);
            label2.TabIndex = 6;
            label2.Text = "نام ویژگی";
            // 
            // btnEdit
            // 
            btnEdit.Location = new System.Drawing.Point(158, 382);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new System.Drawing.Size(75, 32);
            btnEdit.TabIndex = 5;
            btnEdit.Text = "ثبت";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // cbParentEdit
            // 
            cbParentEdit.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            cbParentEdit.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            cbParentEdit.FormattingEnabled = true;
            cbParentEdit.Location = new System.Drawing.Point(76, 283);
            cbParentEdit.Name = "cbParentEdit";
            cbParentEdit.Size = new System.Drawing.Size(253, 23);
            cbParentEdit.TabIndex = 4;
            // 
            // textEdit
            // 
            textEdit.Location = new System.Drawing.Point(76, 157);
            textEdit.Name = "textEdit";
            textEdit.Size = new System.Drawing.Size(253, 23);
            textEdit.TabIndex = 3;
            // 
            // FormCategory
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(905, 700);
            Controls.Add(tabControl1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "FormCategory";
            Text = "FormCategory";
            Load += FormCategory_Load;
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DGVCategory).EndInit();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView DGVCategory;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ComboBox cbParent;
        private System.Windows.Forms.TextBox Cname;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.ComboBox cbParentEdit;
        private System.Windows.Forms.TextBox textEdit;
    }
}