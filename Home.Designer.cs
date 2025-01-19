namespace BarMan
{
    partial class Home
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new System.Windows.Forms.Panel();
            panel10 = new System.Windows.Forms.Panel();
            PBAdmin = new System.Windows.Forms.PictureBox();
            panel9 = new System.Windows.Forms.Panel();
            pictureBox5 = new System.Windows.Forms.PictureBox();
            panel8 = new System.Windows.Forms.Panel();
            PBDrivers = new System.Windows.Forms.PictureBox();
            panel7 = new System.Windows.Forms.Panel();
            PBSuppliers = new System.Windows.Forms.PictureBox();
            panel6 = new System.Windows.Forms.Panel();
            PBTransactions = new System.Windows.Forms.PictureBox();
            panel5 = new System.Windows.Forms.Panel();
            PBProducts = new System.Windows.Forms.PictureBox();
            panel2 = new System.Windows.Forms.Panel();
            DGV = new System.Windows.Forms.DataGridView();
            Column1 = new System.Windows.Forms.DataGridViewImageColumn();
            panel3 = new System.Windows.Forms.Panel();
            panel4 = new System.Windows.Forms.Panel();
            panel1.SuspendLayout();
            panel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PBAdmin).BeginInit();
            panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PBDrivers).BeginInit();
            panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PBSuppliers).BeginInit();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PBTransactions).BeginInit();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PBProducts).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DGV).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(panel10);
            panel1.Controls.Add(panel9);
            panel1.Controls.Add(panel8);
            panel1.Controls.Add(panel7);
            panel1.Controls.Add(panel6);
            panel1.Controls.Add(panel5);
            panel1.Dock = System.Windows.Forms.DockStyle.Top;
            panel1.Location = new System.Drawing.Point(0, 0);
            panel1.Name = "panel1";
            panel1.Padding = new System.Windows.Forms.Padding(3);
            panel1.Size = new System.Drawing.Size(1413, 81);
            panel1.TabIndex = 0;
            // 
            // panel10
            // 
            panel10.Controls.Add(PBAdmin);
            panel10.Dock = System.Windows.Forms.DockStyle.Left;
            panel10.Location = new System.Drawing.Point(3, 3);
            panel10.Name = "panel10";
            panel10.Size = new System.Drawing.Size(130, 75);
            panel10.TabIndex = 5;
            // 
            // PBAdmin
            // 
            PBAdmin.Dock = System.Windows.Forms.DockStyle.Left;
            PBAdmin.Image = Properties.Resources.user_setting;
            PBAdmin.Location = new System.Drawing.Point(0, 0);
            PBAdmin.Name = "PBAdmin";
            PBAdmin.Size = new System.Drawing.Size(93, 75);
            PBAdmin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            PBAdmin.TabIndex = 1;
            PBAdmin.TabStop = false;
            // 
            // panel9
            // 
            panel9.Controls.Add(pictureBox5);
            panel9.Dock = System.Windows.Forms.DockStyle.Right;
            panel9.Location = new System.Drawing.Point(760, 3);
            panel9.Name = "panel9";
            panel9.Size = new System.Drawing.Size(130, 75);
            panel9.TabIndex = 4;
            // 
            // pictureBox5
            // 
            pictureBox5.Dock = System.Windows.Forms.DockStyle.Right;
            pictureBox5.Image = Properties.Resources.add_product;
            pictureBox5.Location = new System.Drawing.Point(37, 0);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new System.Drawing.Size(93, 75);
            pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 1;
            pictureBox5.TabStop = false;
            // 
            // panel8
            // 
            panel8.Controls.Add(PBDrivers);
            panel8.Dock = System.Windows.Forms.DockStyle.Right;
            panel8.Location = new System.Drawing.Point(890, 3);
            panel8.Name = "panel8";
            panel8.Size = new System.Drawing.Size(130, 75);
            panel8.TabIndex = 3;
            // 
            // PBDrivers
            // 
            PBDrivers.Dock = System.Windows.Forms.DockStyle.Right;
            PBDrivers.Image = Properties.Resources.delivery;
            PBDrivers.Location = new System.Drawing.Point(37, 0);
            PBDrivers.Name = "PBDrivers";
            PBDrivers.Size = new System.Drawing.Size(93, 75);
            PBDrivers.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            PBDrivers.TabIndex = 1;
            PBDrivers.TabStop = false;
            // 
            // panel7
            // 
            panel7.Controls.Add(PBSuppliers);
            panel7.Dock = System.Windows.Forms.DockStyle.Right;
            panel7.Location = new System.Drawing.Point(1020, 3);
            panel7.Name = "panel7";
            panel7.Size = new System.Drawing.Size(130, 75);
            panel7.TabIndex = 2;
            panel7.Paint += panel7_Paint;
            // 
            // PBSuppliers
            // 
            PBSuppliers.Dock = System.Windows.Forms.DockStyle.Right;
            PBSuppliers.Image = Properties.Resources.supplier;
            PBSuppliers.Location = new System.Drawing.Point(37, 0);
            PBSuppliers.Name = "PBSuppliers";
            PBSuppliers.Size = new System.Drawing.Size(93, 75);
            PBSuppliers.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            PBSuppliers.TabIndex = 1;
            PBSuppliers.TabStop = false;
            // 
            // panel6
            // 
            panel6.Controls.Add(PBTransactions);
            panel6.Dock = System.Windows.Forms.DockStyle.Right;
            panel6.Location = new System.Drawing.Point(1150, 3);
            panel6.Name = "panel6";
            panel6.Size = new System.Drawing.Size(130, 75);
            panel6.TabIndex = 1;
            // 
            // PBTransactions
            // 
            PBTransactions.Dock = System.Windows.Forms.DockStyle.Right;
            PBTransactions.Image = Properties.Resources._3d_report;
            PBTransactions.Location = new System.Drawing.Point(37, 0);
            PBTransactions.Name = "PBTransactions";
            PBTransactions.Size = new System.Drawing.Size(93, 75);
            PBTransactions.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            PBTransactions.TabIndex = 1;
            PBTransactions.TabStop = false;
            // 
            // panel5
            // 
            panel5.Controls.Add(PBProducts);
            panel5.Dock = System.Windows.Forms.DockStyle.Right;
            panel5.Location = new System.Drawing.Point(1280, 3);
            panel5.Name = "panel5";
            panel5.Size = new System.Drawing.Size(130, 75);
            panel5.TabIndex = 0;
            // 
            // PBProducts
            // 
            PBProducts.Dock = System.Windows.Forms.DockStyle.Right;
            PBProducts.Image = Properties.Resources.add_product;
            PBProducts.Location = new System.Drawing.Point(37, 0);
            PBProducts.Name = "PBProducts";
            PBProducts.Size = new System.Drawing.Size(93, 75);
            PBProducts.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            PBProducts.TabIndex = 0;
            PBProducts.TabStop = false;
            PBProducts.Click += PBProducts_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(DGV);
            panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            panel2.Location = new System.Drawing.Point(0, 81);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(1413, 529);
            panel2.TabIndex = 1;
            // 
            // DGV
            // 
            DGV.AllowUserToAddRows = false;
            DGV.AllowUserToDeleteRows = false;
            DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { Column1 });
            DGV.Dock = System.Windows.Forms.DockStyle.Fill;
            DGV.Location = new System.Drawing.Point(0, 0);
            DGV.Name = "DGV";
            DGV.ReadOnly = true;
            DGV.RowTemplate.Height = 25;
            DGV.Size = new System.Drawing.Size(1413, 529);
            DGV.TabIndex = 0;
            // 
            // Column1
            // 
            Column1.HeaderText = "Delete";
            Column1.Image = Properties.Resources.Delete;
            Column1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.ToolTipText = "حذف";
            // 
            // panel3
            // 
            panel3.Controls.Add(panel4);
            panel3.Dock = System.Windows.Forms.DockStyle.Left;
            panel3.Location = new System.Drawing.Point(0, 81);
            panel3.Name = "panel3";
            panel3.Size = new System.Drawing.Size(366, 529);
            panel3.TabIndex = 2;
            // 
            // panel4
            // 
            panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            panel4.Location = new System.Drawing.Point(0, 332);
            panel4.Name = "panel4";
            panel4.Size = new System.Drawing.Size(366, 197);
            panel4.TabIndex = 0;
            // 
            // Home
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1413, 610);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Home";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel10.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)PBAdmin).EndInit();
            panel9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            panel8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)PBDrivers).EndInit();
            panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)PBSuppliers).EndInit();
            panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)PBTransactions).EndInit();
            panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)PBProducts).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DGV).EndInit();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView DGV;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.PictureBox PBAdmin;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox PBDrivers;
        private System.Windows.Forms.PictureBox PBSuppliers;
        private System.Windows.Forms.PictureBox PBTransactions;
        private System.Windows.Forms.PictureBox PBProducts;
        private System.Windows.Forms.DataGridViewImageColumn Column1;
    }
}
