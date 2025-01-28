using System;
using System.Windows.Forms;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            panel1 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            pbLogOut = new PictureBox();
            panel10 = new Panel();
            panel2 = new Panel();
            PBAdmin = new PictureBox();
            panel9 = new Panel();
            pbBack = new PictureBox();
            panel8 = new Panel();
            PBDrivers = new PictureBox();
            panel7 = new Panel();
            PBSuppliers = new PictureBox();
            panel6 = new Panel();
            PBTransactions = new PictureBox();
            panel5 = new Panel();
            PBProducts = new PictureBox();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            backupDataBaesToolStripMenuItem = new ToolStripMenuItem();
            restoreDatabaseToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            toolStripMenuItem1 = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            DGV = new DataGridView();
            openFileDialog1 = new OpenFileDialog();
            saveFileDialog1 = new SaveFileDialog();
            DTP_Open = new DateTimePicker();
            PFilters = new Panel();
            panel14 = new Panel();
            TNumProduct = new TextBox();
            label8 = new Label();
            numPEnd = new TextBox();
            TimeEnd = new DateTimePicker();
            btnCansel = new Button();
            TimeT = new DateTimePicker();
            checkBox2 = new CheckBox();
            CBTime = new CheckBox();
            checkBox1 = new CheckBox();
            panel13 = new Panel();
            CBSel = new CheckBox();
            label7 = new Label();
            CBBuy = new CheckBox();
            TSuppliers = new TextBox();
            TDriver = new TextBox();
            TProduct = new TextBox();
            btnFilterApply = new Button();
            label10 = new Label();
            label9 = new Label();
            label3 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            DTP_End = new DateTimePicker();
            panel12 = new Panel();
            pictureBox1 = new PictureBox();
            panel11 = new Panel();
            textSerchProduct = new TextBox();
            label11 = new Label();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbLogOut).BeginInit();
            panel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PBAdmin).BeginInit();
            panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbBack).BeginInit();
            panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PBDrivers).BeginInit();
            panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PBSuppliers).BeginInit();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PBTransactions).BeginInit();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PBProducts).BeginInit();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DGV).BeginInit();
            PFilters.SuspendLayout();
            panel14.SuspendLayout();
            panel13.SuspendLayout();
            panel12.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel11.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            panel1.Controls.Add(panel11);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel10);
            panel1.Controls.Add(panel9);
            panel1.Controls.Add(panel8);
            panel1.Controls.Add(panel7);
            panel1.Controls.Add(panel6);
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(menuStrip1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new System.Drawing.Point(0, 0);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(3);
            panel1.Size = new System.Drawing.Size(1413, 81);
            panel1.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Controls.Add(panel4);
            panel3.Controls.Add(pbLogOut);
            panel3.Dock = DockStyle.Left;
            panel3.Location = new System.Drawing.Point(133, 27);
            panel3.Name = "panel3";
            panel3.Size = new System.Drawing.Size(130, 51);
            panel3.TabIndex = 7;
            // 
            // panel4
            // 
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new System.Drawing.Point(93, 0);
            panel4.Name = "panel4";
            panel4.Size = new System.Drawing.Size(37, 51);
            panel4.TabIndex = 6;
            // 
            // pbLogOut
            // 
            pbLogOut.Cursor = Cursors.Hand;
            pbLogOut.Dock = DockStyle.Left;
            pbLogOut.Image = (System.Drawing.Image)resources.GetObject("pbLogOut.Image");
            pbLogOut.Location = new System.Drawing.Point(0, 0);
            pbLogOut.Name = "pbLogOut";
            pbLogOut.Size = new System.Drawing.Size(93, 51);
            pbLogOut.SizeMode = PictureBoxSizeMode.Zoom;
            pbLogOut.TabIndex = 1;
            pbLogOut.TabStop = false;
            pbLogOut.Click += pbLogOut_Click;
            // 
            // panel10
            // 
            panel10.Controls.Add(panel2);
            panel10.Controls.Add(PBAdmin);
            panel10.Dock = DockStyle.Left;
            panel10.Location = new System.Drawing.Point(3, 27);
            panel10.Name = "panel10";
            panel10.Size = new System.Drawing.Size(130, 51);
            panel10.TabIndex = 5;
            // 
            // panel2
            // 
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new System.Drawing.Point(93, 0);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(37, 51);
            panel2.TabIndex = 6;
            // 
            // PBAdmin
            // 
            PBAdmin.Cursor = Cursors.Hand;
            PBAdmin.Dock = DockStyle.Left;
            PBAdmin.Image = Properties.Resources.user_setting;
            PBAdmin.Location = new System.Drawing.Point(0, 0);
            PBAdmin.Name = "PBAdmin";
            PBAdmin.Size = new System.Drawing.Size(93, 51);
            PBAdmin.SizeMode = PictureBoxSizeMode.Zoom;
            PBAdmin.TabIndex = 1;
            PBAdmin.TabStop = false;
            PBAdmin.Click += PBAdmin_Click;
            // 
            // panel9
            // 
            panel9.Controls.Add(pbBack);
            panel9.Dock = DockStyle.Right;
            panel9.Location = new System.Drawing.Point(760, 27);
            panel9.Name = "panel9";
            panel9.Size = new System.Drawing.Size(130, 51);
            panel9.TabIndex = 4;
            // 
            // pbBack
            // 
            pbBack.Cursor = Cursors.Hand;
            pbBack.Dock = DockStyle.Right;
            pbBack.Image = (System.Drawing.Image)resources.GetObject("pbBack.Image");
            pbBack.Location = new System.Drawing.Point(37, 0);
            pbBack.Name = "pbBack";
            pbBack.Size = new System.Drawing.Size(93, 51);
            pbBack.SizeMode = PictureBoxSizeMode.Zoom;
            pbBack.TabIndex = 2;
            pbBack.TabStop = false;
            pbBack.Visible = false;
            pbBack.Click += pbBack_Click;
            // 
            // panel8
            // 
            panel8.Controls.Add(PBDrivers);
            panel8.Dock = DockStyle.Right;
            panel8.Location = new System.Drawing.Point(890, 27);
            panel8.Name = "panel8";
            panel8.Size = new System.Drawing.Size(130, 51);
            panel8.TabIndex = 3;
            // 
            // PBDrivers
            // 
            PBDrivers.Cursor = Cursors.Hand;
            PBDrivers.Dock = DockStyle.Right;
            PBDrivers.Image = Properties.Resources.delivery;
            PBDrivers.Location = new System.Drawing.Point(37, 0);
            PBDrivers.Name = "PBDrivers";
            PBDrivers.Size = new System.Drawing.Size(93, 51);
            PBDrivers.SizeMode = PictureBoxSizeMode.Zoom;
            PBDrivers.TabIndex = 1;
            PBDrivers.TabStop = false;
            PBDrivers.Click += PBDrivers_Click;
            // 
            // panel7
            // 
            panel7.Controls.Add(PBSuppliers);
            panel7.Dock = DockStyle.Right;
            panel7.Location = new System.Drawing.Point(1020, 27);
            panel7.Name = "panel7";
            panel7.Size = new System.Drawing.Size(130, 51);
            panel7.TabIndex = 2;
            // 
            // PBSuppliers
            // 
            PBSuppliers.Cursor = Cursors.Hand;
            PBSuppliers.Dock = DockStyle.Right;
            PBSuppliers.Image = Properties.Resources.supplier;
            PBSuppliers.Location = new System.Drawing.Point(37, 0);
            PBSuppliers.Name = "PBSuppliers";
            PBSuppliers.Size = new System.Drawing.Size(93, 51);
            PBSuppliers.SizeMode = PictureBoxSizeMode.Zoom;
            PBSuppliers.TabIndex = 1;
            PBSuppliers.TabStop = false;
            PBSuppliers.Click += PBSuppliers_Click;
            // 
            // panel6
            // 
            panel6.Controls.Add(PBTransactions);
            panel6.Dock = DockStyle.Right;
            panel6.Location = new System.Drawing.Point(1150, 27);
            panel6.Name = "panel6";
            panel6.Size = new System.Drawing.Size(130, 51);
            panel6.TabIndex = 1;
            // 
            // PBTransactions
            // 
            PBTransactions.Cursor = Cursors.Hand;
            PBTransactions.Dock = DockStyle.Right;
            PBTransactions.Image = Properties.Resources._3d_report;
            PBTransactions.Location = new System.Drawing.Point(37, 0);
            PBTransactions.Name = "PBTransactions";
            PBTransactions.Size = new System.Drawing.Size(93, 51);
            PBTransactions.SizeMode = PictureBoxSizeMode.Zoom;
            PBTransactions.TabIndex = 1;
            PBTransactions.TabStop = false;
            PBTransactions.Click += PBTransactions_Click;
            // 
            // panel5
            // 
            panel5.Controls.Add(PBProducts);
            panel5.Dock = DockStyle.Right;
            panel5.Location = new System.Drawing.Point(1280, 27);
            panel5.Name = "panel5";
            panel5.Size = new System.Drawing.Size(130, 51);
            panel5.TabIndex = 0;
            // 
            // PBProducts
            // 
            PBProducts.Cursor = Cursors.Hand;
            PBProducts.Dock = DockStyle.Right;
            PBProducts.Image = Properties.Resources.add_product;
            PBProducts.Location = new System.Drawing.Point(37, 0);
            PBProducts.Name = "PBProducts";
            PBProducts.Size = new System.Drawing.Size(93, 51);
            PBProducts.SizeMode = PictureBoxSizeMode.Zoom;
            PBProducts.TabIndex = 0;
            PBProducts.TabStop = false;
            PBProducts.Click += PBProducts_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem });
            menuStrip1.Location = new System.Drawing.Point(3, 3);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new System.Drawing.Size(1407, 24);
            menuStrip1.TabIndex = 6;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { backupDataBaesToolStripMenuItem, restoreDatabaseToolStripMenuItem, toolStripMenuItem2, toolStripSeparator1, toolStripMenuItem1, exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // backupDataBaesToolStripMenuItem
            // 
            backupDataBaesToolStripMenuItem.Name = "backupDataBaesToolStripMenuItem";
            backupDataBaesToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            backupDataBaesToolStripMenuItem.Text = "BackupDatabase";
            backupDataBaesToolStripMenuItem.Click += backupDataBaesToolStripMenuItem_Click;
            // 
            // restoreDatabaseToolStripMenuItem
            // 
            restoreDatabaseToolStripMenuItem.Name = "restoreDatabaseToolStripMenuItem";
            restoreDatabaseToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            restoreDatabaseToolStripMenuItem.Text = "RestoreDatabase";
            restoreDatabaseToolStripMenuItem.Click += restoreDatabaseToolStripMenuItem_Click;
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new System.Drawing.Size(161, 22);
            toolStripMenuItem2.Text = "Export to Excel";
            toolStripMenuItem2.Click += toolStripMenuItem2_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new System.Drawing.Size(158, 6);
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new System.Drawing.Size(161, 22);
            toolStripMenuItem1.Text = "Logout";
            toolStripMenuItem1.Click += toolStripMenuItem1_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // DGV
            // 
            DGV.AllowUserToAddRows = false;
            DGV.AllowUserToDeleteRows = false;
            DGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGV.Dock = DockStyle.Fill;
            DGV.Location = new System.Drawing.Point(0, 0);
            DGV.Name = "DGV";
            DGV.ReadOnly = true;
            DGV.RowTemplate.Height = 25;
            DGV.Size = new System.Drawing.Size(1142, 529);
            DGV.TabIndex = 0;
            DGV.CellClick += DGV_CellClick;
            DGV.ColumnHeaderMouseClick += DGV_ColumnHeaderMouseClick;
            DGV.KeyDown += DGV_KeyDown;
            DGV.MouseClick += DGV_MouseClick;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // DTP_Open
            // 
            DTP_Open.Location = new System.Drawing.Point(12, 284);
            DTP_Open.Name = "DTP_Open";
            DTP_Open.Size = new System.Drawing.Size(164, 23);
            DTP_Open.TabIndex = 9;
            // 
            // PFilters
            // 
            PFilters.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            PFilters.Controls.Add(panel14);
            PFilters.Controls.Add(TimeEnd);
            PFilters.Controls.Add(btnCansel);
            PFilters.Controls.Add(TimeT);
            PFilters.Controls.Add(checkBox2);
            PFilters.Controls.Add(CBTime);
            PFilters.Controls.Add(checkBox1);
            PFilters.Controls.Add(panel13);
            PFilters.Controls.Add(TSuppliers);
            PFilters.Controls.Add(TDriver);
            PFilters.Controls.Add(TProduct);
            PFilters.Controls.Add(btnFilterApply);
            PFilters.Controls.Add(label10);
            PFilters.Controls.Add(label9);
            PFilters.Controls.Add(label3);
            PFilters.Controls.Add(label6);
            PFilters.Controls.Add(label5);
            PFilters.Controls.Add(label4);
            PFilters.Controls.Add(label2);
            PFilters.Controls.Add(label1);
            PFilters.Controls.Add(DTP_End);
            PFilters.Controls.Add(DTP_Open);
            PFilters.Dock = DockStyle.Left;
            PFilters.Location = new System.Drawing.Point(0, 81);
            PFilters.Name = "PFilters";
            PFilters.Size = new System.Drawing.Size(271, 529);
            PFilters.TabIndex = 1;
            // 
            // panel14
            // 
            panel14.BorderStyle = BorderStyle.FixedSingle;
            panel14.Controls.Add(TNumProduct);
            panel14.Controls.Add(label8);
            panel14.Controls.Add(numPEnd);
            panel14.Location = new System.Drawing.Point(0, 148);
            panel14.Name = "panel14";
            panel14.Size = new System.Drawing.Size(271, 60);
            panel14.TabIndex = 20;
            // 
            // TNumProduct
            // 
            TNumProduct.Location = new System.Drawing.Point(12, 3);
            TNumProduct.Name = "TNumProduct";
            TNumProduct.PlaceholderText = "بیشتر از این";
            TNumProduct.Size = new System.Drawing.Size(164, 23);
            TNumProduct.TabIndex = 12;
            TNumProduct.KeyPress += TNumProduct_KeyPress;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label8.Location = new System.Drawing.Point(185, 18);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(73, 21);
            label8.TabIndex = 10;
            label8.Text = "تعداد کالا ";
            label8.Click += label1_Click;
            // 
            // numPEnd
            // 
            numPEnd.Location = new System.Drawing.Point(12, 32);
            numPEnd.Name = "numPEnd";
            numPEnd.PlaceholderText = "کمتر از این";
            numPEnd.Size = new System.Drawing.Size(164, 23);
            numPEnd.TabIndex = 12;
            numPEnd.KeyPress += numPEnd_KeyPress;
            // 
            // TimeEnd
            // 
            TimeEnd.CustomFormat = "mm,HH";
            TimeEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            TimeEnd.Format = DateTimePickerFormat.Custom;
            TimeEnd.Location = new System.Drawing.Point(12, 419);
            TimeEnd.Name = "TimeEnd";
            TimeEnd.ShowUpDown = true;
            TimeEnd.Size = new System.Drawing.Size(95, 22);
            TimeEnd.TabIndex = 19;
            TimeEnd.Value = new DateTime(2025, 1, 25, 23, 59, 0, 0);
            // 
            // btnCansel
            // 
            btnCansel.Location = new System.Drawing.Point(18, 473);
            btnCansel.Name = "btnCansel";
            btnCansel.Size = new System.Drawing.Size(78, 33);
            btnCansel.TabIndex = 18;
            btnCansel.Text = "انصراف";
            btnCansel.UseVisualStyleBackColor = true;
            btnCansel.Click += btnCansel_Click;
            // 
            // TimeT
            // 
            TimeT.CustomFormat = "mm,HH";
            TimeT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            TimeT.Format = DateTimePickerFormat.Custom;
            TimeT.Location = new System.Drawing.Point(12, 381);
            TimeT.Name = "TimeT";
            TimeT.ShowUpDown = true;
            TimeT.Size = new System.Drawing.Size(95, 22);
            TimeT.TabIndex = 17;
            TimeT.Value = new DateTime(2025, 1, 23, 0, 0, 0, 0);
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            checkBox2.Location = new System.Drawing.Point(86, 29);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new System.Drawing.Size(90, 25);
            checkBox2.TabIndex = 15;
            checkBox2.Text = "همین کالا";
            checkBox2.UseVisualStyleBackColor = true;
            checkBox2.CheckedChanged += checkBox2_CheckedChanged;
            // 
            // CBTime
            // 
            CBTime.AutoSize = true;
            CBTime.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            CBTime.Location = new System.Drawing.Point(102, 350);
            CBTime.Name = "CBTime";
            CBTime.Size = new System.Drawing.Size(121, 25);
            CBTime.TabIndex = 13;
            CBTime.Text = "فیلتر  با ساعت";
            CBTime.UseVisualStyleBackColor = true;
            CBTime.CheckedChanged += CBTime_CheckedChanged;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            checkBox1.Location = new System.Drawing.Point(106, 253);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new System.Drawing.Size(111, 25);
            checkBox1.TabIndex = 13;
            checkBox1.Text = "فیلتر  با تاریخ";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // panel13
            // 
            panel13.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            panel13.BorderStyle = BorderStyle.FixedSingle;
            panel13.Controls.Add(CBSel);
            panel13.Controls.Add(label7);
            panel13.Controls.Add(CBBuy);
            panel13.Location = new System.Drawing.Point(0, 214);
            panel13.Name = "panel13";
            panel13.Size = new System.Drawing.Size(274, 32);
            panel13.TabIndex = 14;
            // 
            // CBSel
            // 
            CBSel.AutoSize = true;
            CBSel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            CBSel.Location = new System.Drawing.Point(84, 3);
            CBSel.Name = "CBSel";
            CBSel.Size = new System.Drawing.Size(70, 25);
            CBSel.TabIndex = 13;
            CBSel.Text = "فروش";
            CBSel.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label7.Location = new System.Drawing.Point(182, 7);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(83, 21);
            label7.TabIndex = 10;
            label7.Text = "نوع تراکنش";
            label7.Click += label1_Click;
            // 
            // CBBuy
            // 
            CBBuy.AutoSize = true;
            CBBuy.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            CBBuy.Location = new System.Drawing.Point(3, 3);
            CBBuy.Name = "CBBuy";
            CBBuy.Size = new System.Drawing.Size(59, 25);
            CBBuy.TabIndex = 13;
            CBBuy.Text = "خرید";
            CBBuy.UseVisualStyleBackColor = true;
            // 
            // TSuppliers
            // 
            TSuppliers.Location = new System.Drawing.Point(12, 118);
            TSuppliers.Name = "TSuppliers";
            TSuppliers.Size = new System.Drawing.Size(164, 23);
            TSuppliers.TabIndex = 12;
            // 
            // TDriver
            // 
            TDriver.Location = new System.Drawing.Point(12, 89);
            TDriver.Name = "TDriver";
            TDriver.Size = new System.Drawing.Size(164, 23);
            TDriver.TabIndex = 12;
            // 
            // TProduct
            // 
            TProduct.Location = new System.Drawing.Point(12, 60);
            TProduct.Name = "TProduct";
            TProduct.Size = new System.Drawing.Size(164, 23);
            TProduct.TabIndex = 12;
            // 
            // btnFilterApply
            // 
            btnFilterApply.Location = new System.Drawing.Point(148, 473);
            btnFilterApply.Name = "btnFilterApply";
            btnFilterApply.Size = new System.Drawing.Size(78, 33);
            btnFilterApply.TabIndex = 11;
            btnFilterApply.Text = "اعمال کردن";
            btnFilterApply.UseVisualStyleBackColor = true;
            btnFilterApply.Click += btnFilterApply_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label10.Location = new System.Drawing.Point(125, 419);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(64, 21);
            label10.TabIndex = 10;
            label10.Text = "تا ساعت";
            label10.Click += label1_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label9.Location = new System.Drawing.Point(123, 382);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(66, 21);
            label9.TabIndex = 10;
            label9.Text = "از ساعت";
            label9.Click += label1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label3.Location = new System.Drawing.Point(195, 313);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(36, 21);
            label3.TabIndex = 10;
            label3.Text = "انتها";
            label3.Click += label1_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label6.Location = new System.Drawing.Point(185, 91);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(68, 21);
            label6.TabIndex = 10;
            label6.Text = "نام راننده";
            label6.Click += label1_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label5.Location = new System.Drawing.Point(185, 124);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(73, 21);
            label5.TabIndex = 10;
            label5.Text = "نام خریدار";
            label5.Click += label1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label4.Location = new System.Drawing.Point(185, 62);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(53, 21);
            label4.TabIndex = 10;
            label4.Text = "نام کالا";
            label4.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(195, 284);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(36, 21);
            label2.TabIndex = 10;
            label2.Text = "ابتدا";
            label2.Click += label1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(3, 3);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(45, 21);
            label1.TabIndex = 10;
            label1.Text = "Filter";
            label1.Click += label1_Click;
            // 
            // DTP_End
            // 
            DTP_End.Location = new System.Drawing.Point(12, 313);
            DTP_End.Name = "DTP_End";
            DTP_End.Size = new System.Drawing.Size(164, 23);
            DTP_End.TabIndex = 9;
            // 
            // panel12
            // 
            panel12.Controls.Add(pictureBox1);
            panel12.Controls.Add(DGV);
            panel12.Dock = DockStyle.Fill;
            panel12.Location = new System.Drawing.Point(271, 81);
            panel12.Name = "panel12";
            panel12.Size = new System.Drawing.Size(1142, 529);
            panel12.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = System.Drawing.SystemColors.Control;
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new System.Drawing.Point(-1, -1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(20, 59);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.MouseClick += pictureBox1_MouseClick;
            // 
            // panel11
            // 
            panel11.Controls.Add(textSerchProduct);
            panel11.Controls.Add(label11);
            panel11.Dock = DockStyle.Right;
            panel11.Location = new System.Drawing.Point(547, 27);
            panel11.Name = "panel11";
            panel11.Size = new System.Drawing.Size(213, 51);
            panel11.TabIndex = 8;
            // 
            // textSerchProduct
            // 
            textSerchProduct.Location = new System.Drawing.Point(0, 25);
            textSerchProduct.Name = "textSerchProduct";
            textSerchProduct.Size = new System.Drawing.Size(211, 23);
            textSerchProduct.TabIndex = 2;
            textSerchProduct.TextChanged += textSerchProduct_TextChanged;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new System.Drawing.Point(152, 7);
            label11.Name = "label11";
            label11.Size = new System.Drawing.Size(50, 15);
            label11.TabIndex = 3;
            label11.Text = "جستوجو ";
            // 
            // Home
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1413, 610);
            Controls.Add(panel12);
            Controls.Add(PFilters);
            Controls.Add(panel1);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            KeyPreview = true;
            MainMenuStrip = menuStrip1;
            Name = "Home";
            StartPosition = FormStartPosition.CenterScreen;
            Load += Form1_Load;
            KeyDown += Home_KeyDown;
            MouseDown += Home_MouseDown;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbLogOut).EndInit();
            panel10.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)PBAdmin).EndInit();
            panel9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbBack).EndInit();
            panel8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)PBDrivers).EndInit();
            panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)PBSuppliers).EndInit();
            panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)PBTransactions).EndInit();
            panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)PBProducts).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DGV).EndInit();
            PFilters.ResumeLayout(false);
            PFilters.PerformLayout();
            panel14.ResumeLayout(false);
            panel14.PerformLayout();
            panel13.ResumeLayout(false);
            panel13.PerformLayout();
            panel12.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel11.ResumeLayout(false);
            panel11.PerformLayout();
            ResumeLayout(false);
        }



        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView DGV;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.PictureBox PBAdmin;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.PictureBox PBDrivers;
        private System.Windows.Forms.PictureBox PBSuppliers;
        private System.Windows.Forms.PictureBox PBTransactions;
        private System.Windows.Forms.PictureBox PBProducts;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.PictureBox pbBack;
        private System.Windows.Forms.ToolStripMenuItem backupDataBaesToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem restoreDatabaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pbLogOut;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.DateTimePicker DTP_Open;
        private System.Windows.Forms.Panel PFilters;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Button btnFilterApply;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker DTP_End;
        private System.Windows.Forms.TextBox TSuppliers;
        private System.Windows.Forms.TextBox TDriver;
        private System.Windows.Forms.TextBox TProduct;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.CheckBox CBSel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox CBBuy;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TNumProduct;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Button btnCansel;
        private System.Windows.Forms.DateTimePicker TimeT;
        private System.Windows.Forms.CheckBox CBTime;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker TimeEnd;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox numPEnd;
        private System.Windows.Forms.Panel panel14;
        private ToolStripMenuItem toolStripMenuItem2;
        private Panel panel11;
        private TextBox textSerchProduct;
        private Label label11;
    }
}
