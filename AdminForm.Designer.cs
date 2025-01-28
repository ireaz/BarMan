namespace BarMan
{
    partial class AdminForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForm));
            panel1 = new System.Windows.Forms.Panel();
            panel4 = new System.Windows.Forms.Panel();
            pbAdd = new System.Windows.Forms.PictureBox();
            panel3 = new System.Windows.Forms.Panel();
            tbSerch = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            DGVAdmins = new System.Windows.Forms.DataGridView();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbAdd).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DGVAdmins).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Dock = System.Windows.Forms.DockStyle.Top;
            panel1.Location = new System.Drawing.Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(760, 100);
            panel1.TabIndex = 2;
            // 
            // panel4
            // 
            panel4.Controls.Add(pbAdd);
            panel4.Dock = System.Windows.Forms.DockStyle.Left;
            panel4.Location = new System.Drawing.Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new System.Drawing.Size(137, 100);
            panel4.TabIndex = 3;
            // 
            // pbAdd
            // 
            pbAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            pbAdd.Image = (System.Drawing.Image)resources.GetObject("pbAdd.Image");
            pbAdd.Location = new System.Drawing.Point(32, 26);
            pbAdd.Name = "pbAdd";
            pbAdd.Size = new System.Drawing.Size(61, 59);
            pbAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pbAdd.TabIndex = 0;
            pbAdd.TabStop = false;
            pbAdd.Click += pbAdd_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(tbSerch);
            panel3.Controls.Add(label1);
            panel3.Dock = System.Windows.Forms.DockStyle.Right;
            panel3.Location = new System.Drawing.Point(540, 0);
            panel3.Name = "panel3";
            panel3.Size = new System.Drawing.Size(220, 100);
            panel3.TabIndex = 2;
            // 
            // tbSerch
            // 
            tbSerch.Location = new System.Drawing.Point(0, 48);
            tbSerch.Name = "tbSerch";
            tbSerch.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            tbSerch.Size = new System.Drawing.Size(200, 23);
            tbSerch.TabIndex = 0;
            tbSerch.TextChanged += tbSerch_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(156, 30);
            label1.Name = "label1";
            label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            label1.Size = new System.Drawing.Size(41, 15);
            label1.TabIndex = 1;
            label1.Text = "جستجو";
            // 
            // DGVAdmins
            // 
            DGVAdmins.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGVAdmins.Dock = System.Windows.Forms.DockStyle.Fill;
            DGVAdmins.Location = new System.Drawing.Point(0, 100);
            DGVAdmins.Name = "DGVAdmins";
            DGVAdmins.RowTemplate.Height = 25;
            DGVAdmins.Size = new System.Drawing.Size(760, 532);
            DGVAdmins.TabIndex = 3;
            DGVAdmins.CellContentClick += DGVAdmins_CellContentClick;
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(760, 632);
            Controls.Add(DGVAdmins);
            Controls.Add(panel1);
            KeyPreview = true;
            Name = "AdminForm";
            Text = "AdminForm";
            Load += AdminForm_Load;
            KeyDown += AdminForm_KeyDown;
            panel1.ResumeLayout(false);
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbAdd).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DGVAdmins).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pbAdd;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox tbSerch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DGVAdmins;
    }
}