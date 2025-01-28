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
            DGVCategory = new System.Windows.Forms.DataGridView();
            panel4 = new System.Windows.Forms.Panel();
            tabControl1 = new System.Windows.Forms.TabControl();
            tabPage1 = new System.Windows.Forms.TabPage();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            btnAdd = new System.Windows.Forms.Button();
            cbParent = new System.Windows.Forms.ComboBox();
            Cname = new System.Windows.Forms.TextBox();
            tabPage2 = new System.Windows.Forms.TabPage();
            button1 = new System.Windows.Forms.Button();
            label3 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            btnEdit = new System.Windows.Forms.Button();
            cbParentEdit = new System.Windows.Forms.ComboBox();
            textEdit = new System.Windows.Forms.TextBox();
            splitContainer1 = new System.Windows.Forms.SplitContainer();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DGVCategory).BeginInit();
            panel4.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(panel3);
            panel1.Dock = System.Windows.Forms.DockStyle.Top;
            panel1.Location = new System.Drawing.Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(973, 100);
            panel1.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Controls.Add(textBox1);
            panel3.Controls.Add(label1);
            panel3.Dock = System.Windows.Forms.DockStyle.Right;
            panel3.Location = new System.Drawing.Point(638, 0);
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
            textBox1.TextChanged += textBox1_TextChanged;
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
            // DGVCategory
            // 
            DGVCategory.AllowUserToResizeColumns = false;
            DGVCategory.AllowUserToResizeRows = false;
            DGVCategory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            DGVCategory.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            DGVCategory.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            DGVCategory.Dock = System.Windows.Forms.DockStyle.Fill;
            DGVCategory.Location = new System.Drawing.Point(0, 0);
            DGVCategory.Name = "DGVCategory";
            DGVCategory.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            DGVCategory.RowTemplate.Height = 25;
            DGVCategory.Size = new System.Drawing.Size(560, 600);
            DGVCategory.TabIndex = 0;
            DGVCategory.CellContentClick += DGVCategory_CellContentClick;
            DGVCategory.DataBindingComplete += DGVCategory_DataBindingComplete;
            DGVCategory.RowsAdded += DGVCategory_RowsAdded;
            // 
            // panel4
            // 
            panel4.Controls.Add(tabControl1);
            panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            panel4.Location = new System.Drawing.Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new System.Drawing.Size(409, 600);
            panel4.TabIndex = 2;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            tabControl1.Location = new System.Drawing.Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            tabControl1.RightToLeftLayout = true;
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new System.Drawing.Size(409, 600);
            tabControl1.TabIndex = 3;
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
            tabPage1.Size = new System.Drawing.Size(401, 572);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "افزودن";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(276, 243);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(55, 15);
            label4.TabIndex = 7;
            label4.Text = "زیرمجموع";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(275, 117);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(56, 15);
            label5.TabIndex = 8;
            label5.Text = "نام ویژگی";
            // 
            // btnAdd
            // 
            btnAdd.Location = new System.Drawing.Point(155, 353);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new System.Drawing.Size(75, 32);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "ثبت";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click_1;
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
            tabPage2.Controls.Add(button1);
            tabPage2.Controls.Add(label3);
            tabPage2.Controls.Add(label2);
            tabPage2.Controls.Add(btnEdit);
            tabPage2.Controls.Add(cbParentEdit);
            tabPage2.Controls.Add(textEdit);
            tabPage2.Location = new System.Drawing.Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new System.Windows.Forms.Padding(3);
            tabPage2.Size = new System.Drawing.Size(401, 572);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "ویرایش";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(76, 386);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(74, 32);
            button1.TabIndex = 7;
            button1.Text = "انصراف";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(277, 268);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(55, 15);
            label3.TabIndex = 6;
            label3.Text = "زیرمجموع";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(276, 142);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(56, 15);
            label2.TabIndex = 6;
            label2.Text = "نام ویژگی";
            // 
            // btnEdit
            // 
            btnEdit.Location = new System.Drawing.Point(254, 386);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new System.Drawing.Size(75, 32);
            btnEdit.TabIndex = 5;
            btnEdit.Text = "ویرایش";
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
            // splitContainer1
            // 
            splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            splitContainer1.Location = new System.Drawing.Point(0, 100);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(panel4);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(DGVCategory);
            splitContainer1.Size = new System.Drawing.Size(973, 600);
            splitContainer1.SplitterDistance = 409;
            splitContainer1.TabIndex = 2;
            // 
            // FormCategory
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(973, 700);
            Controls.Add(splitContainer1);
            Controls.Add(panel1);
            KeyPreview = true;
            Name = "FormCategory";
            Text = "FormCategory";
            Load += FormCategory_Load;
            KeyDown += FormCategory_KeyDown;
            Resize += FormCategory_Resize;
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DGVCategory).EndInit();
            panel4.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView DGVCategory;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
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
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button button1;
    }
}