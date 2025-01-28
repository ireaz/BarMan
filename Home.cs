
using BarMan.Models;
using BarMan.sourc;

using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;



namespace BarMan
{
    public partial class Home : Form
    {
        string nameProduct;
        public Home()
        {
            InitializeComponent();
            DGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            EnabeldControl();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            ClassDesign.CustomizeDataGridView(DGV);
            DataGV();
            Availability();




        }
        public void Availability()
        {
            if (AdminControll.AdminRole == "Visitor")
            {
                PBProducts.Enabled = false;
                PBDrivers.Enabled = false;
                PBSuppliers.Enabled = false;
                PBTransactions.Enabled = false;
                PBAdmin.Enabled = false;


            }
            else
            {

                PBProducts.Enabled = true;
                PBDrivers.Enabled = true;
                PBSuppliers.Enabled = true;
                PBTransactions.Enabled = true;
                PBAdmin.Enabled = true;

            }
        }




        private void DataGV()
        {
            pictureBox1.BackColor = SystemColors.Control;
            PFilters.Visible = false;
            pictureBox1.Visible = false;
            pbBack.Visible = false;
            DGV.DataSource = ProductControll.ProductHome();
            if (DGV.Columns.Contains("ProductId"))
                DGV.Columns["ProductID"].Visible = false;
            panel11.Visible = true;

        }

        private void PBProducts_Click(object sender, EventArgs e)
        {
            FormProduct formproduct = new FormProduct();
            this.Hide();
            formproduct.ShowDialog();
            ProductControll.ProductData = null;

            this.Show();
            DataGV();
        }

        private void PBDrivers_Click(object sender, EventArgs e)
        {
            FormDriver formproduct = new FormDriver();
            this.Hide();
            formproduct.ShowDialog();
            DriverControll.DriverData = null;
            this.Show(); DataGV();
        }

        private void PBSuppliers_Click(object sender, EventArgs e)
        {
            FormSuppliers formSuppliers = new FormSuppliers();
            this.Hide();
            formSuppliers.ShowDialog();
            SuppliersControll.SuppliersData = null;

            this.Show(); DataGV();

        }

        private void PBTransactions_Click(object sender, EventArgs e)
        {
            FormTransactions formTransactions = new FormTransactions();
            this.Hide();
            formTransactions.ShowDialog();
            TransactionControll.TransactionData = null;
            this.Show();
            DataGV();

        }


        private void DGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                var row = DGV.Rows[e.RowIndex];


                if (pbBack.Visible == false)
                {


                    int id = Convert.ToInt32(row.Cells["ProductID"].Value);
                    TProduct.Text = nameProduct = row.Cells["ProductName"].Value.ToString();
                    DGV.DataSource = TransactionControll.GetTransactionsWith(id);
                    checkBox2.Checked = true;
                    TProduct.Enabled = false;
                    CBTime.Checked = false;
                    pbBack.Visible = true;
                    pictureBox1.Visible = true;
                    panel11.Visible = false;
                    heder();
                }
            }

        }

        private void pbBack_Click(object sender, EventArgs e)
        {
            DataGV();
            pbBack.Visible = false;
           
        }
        public void heder()
        {

            if (DGV.Columns.Contains("TransactionID"))
            {
                DGV.Columns["TransactionID"].Visible = false;
                DGV.Columns["Price"].DefaultCellStyle.Format = "0";


            }


        }



        private void backupDataBaesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "Backup Files (*.bak)|*.bak",
                Title = "Save Backup File"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string backupPath = saveFileDialog.FileName;
                DatabaseBackupUtility.BackupDatabase(backupPath);
            }
        }

        private void restoreDatabaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Backup Files (*.bak)|*.bak",
                Title = "Select Backup File"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string backupPath = openFileDialog.FileName;
                DatabaseRestoreUtility.RestoreDatabase(backupPath);
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void PBAdmin_Click(object sender, EventArgs e)
        {
            AdminForm adminForm = new AdminForm();
            this.Hide();
            adminForm.ShowDialog();
            this.Show();
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            logOut();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            logOut();

        }

        private void pbLogOut_Click(object sender, EventArgs e)
        {
            logOut();
        }

        public void logOut()
        {
            this.Hide();
            Login login = new Login();
            login.ShowDialog();
            Availability();
            this.Show();
        }





        private void Home_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Escape)
            {
                DataGV();
                pbBack.Visible = false;
            }

        }

        private void DGV_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void Home_MouseDown(object sender, MouseEventArgs e)
        {


        }

        private void DGV_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                DataGV();
                //  pbBack.Visible = false;
                // pictureBox1.Visible = false;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void TNumProduct_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if (PFilters.Visible == false)
            {
                PFilters.Visible = true;
                pictureBox1.BackColor = SystemColors.GradientActiveCaption;

            }
            else if (PFilters.Visible == true)
            {
                PFilters.Visible = false;
                pictureBox1.BackColor = SystemColors.Control;

            }


        }

        private void btnFilterApply_Click(object sender, EventArgs e)//اعمال فیلتر
        {
            string FProductName = TProduct.Text.ToString(),
                FDriverName = TDriver.Text.ToString(),
                FSuppliers = TSuppliers.Text.ToString();
            int numProductOpen = string.IsNullOrEmpty(TNumProduct.Text) ? 0 : Convert.ToInt32(TNumProduct.Text),
                numProductEnd = string.IsNullOrEmpty(numPEnd.Text) ? 0 : Convert.ToInt32(numPEnd.Text);
            DateTime OpanDate = DTP_Open.Value.Date,
                EndDate = DTP_End.Value.Date;
            TimeSpan timeF = TimeT.Value.TimeOfDay,
                TimeFEnd = TimeEnd.Value.TimeOfDay;
            bool buy = CBBuy.Checked,
                Sel = CBSel.Checked,
                DataEnable = checkBox1.Checked,
                TimeEnable = CBTime.Checked;


            if (buy == Sel)
            { buy = false; Sel = false; }

            DGV.DataSource = HomeControll.FilterT(FProductName, FDriverName, FSuppliers, numProductOpen, numProductEnd, OpanDate, EndDate, buy, Sel, DataEnable, timeF, TimeFEnd, TimeEnable);




        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)//فیلتر با تاریخ
        {
            DTP_End.Enabled = checkBox1.Checked;
            DTP_Open.Enabled = checkBox1.Checked;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)//اسم پروداکت برا فیلتر
        {
            TProduct.Enabled = !checkBox2.Checked;
            if (checkBox2.Checked == true) 
            TProduct.Text = nameProduct;
        }

        private void btnCansel_Click(object sender, EventArgs e)
        {
            DGV.DataSource = HomeControll.FilterT(nameProduct, null, null, 0, 0, DateTime.Now, DateTime.Now, false, false, false, TimeSpan.MinValue, TimeSpan.MaxValue, false);
        }
        private void numPEnd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void CBTime_CheckedChanged(object sender, EventArgs e)
        {

            TimeEnd.Enabled = CBTime.Checked;
            TimeT.Enabled = CBTime.Checked;

        }

        public void EnabeldControl()
        {
            TimeEnd.Enabled = false; TimeT.Enabled = false;

            DTP_End.Enabled = false;
            DTP_Open.Enabled = false;
           

        }

        private void DGV_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            var transactionList = DGV.DataSource as List<TransactionModel>;
            if (transactionList == null)
            {

                return;
            }


            string columnName = DGV.Columns[e.ColumnIndex].Name;

            // مرتب‌سازی بر اساس ستون انتخاب‌شده
            List<TransactionModel> sortedList;
            switch (columnName)
            {
                case "TransactionID":
                    sortedList = transactionList.OrderBy(x => x.TransactionID).ToList();
                    break;

                case "ProductName":
                    sortedList = transactionList.OrderBy(x => x.ProductName).ToList();
                    break;

                case "DriverName":
                    sortedList = transactionList.OrderBy(x => x.DriverName).ToList();
                    break;

                case "SupplierName":
                    sortedList = transactionList.OrderBy(x => x.SupplierName).ToList();
                    break;

                case "Quantity":
                    sortedList = transactionList.OrderBy(x => x.Quantity).ToList();
                    break;

                case "Price":
                    sortedList = transactionList.OrderBy(x => x.Price).ToList();
                    break;

                case "Type":
                    sortedList = transactionList.OrderBy(x => x.Type).ToList();
                    break;

                case "Date":
                    sortedList = transactionList.OrderBy(x => x.Date).ToList();
                    break;

                case "Time":
                    sortedList = transactionList.OrderBy(x => x.Time).ToList();
                    break;

                default:

                    return;
            }


            // DGV.DataSource = null;
            DGV.DataSource = sortedList;
            heder();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Excel Files|*.xlsx";
                saveFileDialog.Title = "ذخیره فایل Excel";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    Convert_To_Excel.ExportToExcel(DGV, saveFileDialog.FileName);
                }
            }
        }

        private void textSerchProduct_TextChanged(object sender, EventArgs e)
        {
            DGV.DataSource = ProductControll.FilterProductshome(textSerchProduct.Text.ToString());
        }
    }


}
