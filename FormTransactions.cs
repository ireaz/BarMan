using BarMan.Models;
using BarMan.sourc;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace BarMan
{
    public partial class FormTransactions : Form
    {
        public FormTransactions()
        {
            InitializeComponent();
            listCBSerch();
            dateTimePicker1.Enabled = checkBox1.Checked;
            dateTimePicker2.Enabled = checkBox1.Checked;

        }

        private void FormTransactions_Load(object sender, EventArgs e)
        {
            ClassDesign.CustomizeDataGridView(DGVTransaction);
            ClassDesign.AddButtonsToGrid(DGVTransaction);

            LodDataTransaction();
        }
        public void listCBSerch()
        {
            List<string> filterOptions = new List<string>
            {

            "نام محصول",
             "نام راننده",
             "نام تامین‌کننده",
              "تعداد کالا",
             "قیمت کالا",
              "نوع تراکنش"
            };
            cbSerch.DataSource = filterOptions;
        }

        private void pbAddDriver_Click(object sender, EventArgs e)
        {
            var product = ProductControll.GetProduct_ID_Name();
            var Driver = DriverControll.GetDriver_ID_name();
            var Supp = SuppliersControll.GetSupplier_ID_Name();
            if (product.Count > 0 && Driver.Count > 0 && Supp.Count > 0)
            {
                FormTransactionAE formTransactionAE = new FormTransactionAE();
                formTransactionAE.ShowDialog();
                LodDataTransaction();
            }
            else
            {
                MessageBox.Show("جدول‌های کالا، راننده و تأمین‌کننده خالی هستند.");
            }

        }
        public void LodDataTransaction()
        {
            if (tbSerch.Text != "")
            {
                Serch();
            }
            else
            {
                DGVTransaction.DataSource = TransactionControll.GetTransactionsWith();


            }
            FormatDataGridViewHeaders();
        }

        public void Serch()
        {
            switch (cbSerch.SelectedIndex)
            {
                case 0: // فیلتر بر اساس نام محصول
                    DGVTransaction.DataSource = TransactionControll.FilterTransaction_By_ProductName(tbSerch.Text);
                    break;

                case 1: // فیلتر بر اساس نام راننده
                    DGVTransaction.DataSource = TransactionControll.FilterTransaction_By_DriverName(tbSerch.Text);
                    break;

                case 2: // فیلتر بر اساس نام تامین‌کننده
                    DGVTransaction.DataSource = TransactionControll.FilterTransaction_By_SuppliersName(tbSerch.Text);
                    break;

                case 3: // فیلتر بر اساس تعداد کالا
                    if (int.TryParse(tbSerch.Text, out int quantity))
                    {
                        DGVTransaction.DataSource = TransactionControll.FilterTransaction_By_Quantity(quantity);
                    }
                    else
                    {
                        MessageBox.Show("لطفاً یک عدد معتبر وارد کنید.");
                        LodDataTransaction();
                    }
                    break;

                case 4: // فیلتر بر اساس قیمت
                    if (decimal.TryParse(tbSerch.Text, out decimal price))
                    {
                        DGVTransaction.DataSource = TransactionControll.FilterTransaction_By_Price(price);
                    }
                    else
                    {
                        MessageBox.Show("لطفاً یک قیمت معتبر وارد کنید.");
                        LodDataTransaction();
                    }
                    break;

                case 5: // فیلتر بر اساس نوع تراکنش (خرید/فروش)
                    DGVTransaction.DataSource = TransactionControll.FilterTransaction_By_Type(tbSerch.Text);
                    break;

                default:
                    MessageBox.Show("لطفاً یک گزینه معتبر انتخاب کنید.");
                    break;
            }


        }


        private void tbSerch_TextChanged(object sender, EventArgs e)
        {
            Serch();
        }

        private void FormatDataGridViewHeaders()
        {
            heder();

        }

        private void DGVTransaction_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int id = Convert.ToInt32(DGVTransaction.Rows[e.RowIndex].Cells["TransactionID"].Value),
                    Quantity = Convert.ToInt32(DGVTransaction.Rows[e.RowIndex].Cells["Quantity"].Value);

                string ProductName = DGVTransaction.Rows[e.RowIndex].Cells["ProductName"].Value.ToString(),
                    Suppliername = DGVTransaction.Rows[e.RowIndex].Cells["SupplierName"].Value.ToString();
                DateTime dateTime = Convert.ToDateTime(DGVTransaction.Rows[e.RowIndex].Cells["Date"].Value);


                /////////////////////////

                if (e.ColumnIndex == DGVTransaction.Columns["Delete"].Index)
                {
                    var result = MessageBox.Show($"آیا از حذف کالا {ProductName} با تأمین‌کننده {Suppliername} و تاریخ ثبت {dateTime} اطمینان دارید؟", "حذف تراکنش", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (result == DialogResult.Yes)
                    {
                        var transaction = TransactionControll.FindTransactionByID(id);
                        DbContextHelper.Delete(transaction);
                        LodDataTransaction();




                    }
                }

                else if (e.ColumnIndex == DGVTransaction.Columns["Edit"].Index)
                {
                    Transaction transaction = TransactionControll.FindTransactionByID(id);

                    FormTransactionAE transactionAE = new FormTransactionAE(transaction);


                    transactionAE.ShowDialog();
                    LodDataTransaction();

                }
            }
        }

        private void DGVTransaction_ColumnAdded(object sender, DataGridViewColumnEventArgs e)
        {

        }

        private void DGVTransaction_DataSourceChanged(object sender, EventArgs e)
        {
            heder();
        }

        public void heder()
        {
            if (DGVTransaction.Columns.Contains("TransactionID"))
            {
                DGVTransaction.Columns["TransactionID"].Visible = false;
                DGVTransaction.Columns["Price"].DefaultCellStyle.Format = "0";
            }


        }

        private void FormTransactions_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DGVTransaction.DataSource = TransactionControll.FilterDateTime(dateTimePicker1.Value.Date, dateTimePicker2.Value.Date);


        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            DGVTransaction.DataSource = TransactionControll.FilterDateTime(dateTimePicker1.Value.Date, dateTimePicker2.Value.Date);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            dateTimePicker1.Enabled = checkBox1.Checked;
            dateTimePicker2.Enabled = checkBox1.Checked;
        }
    }
}
