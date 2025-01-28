using BarMan.Models;
using BarMan.sourc;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BarMan
{
    public partial class FormTransactionAE : Form
    {
        int TransactionId;
        string typeEdit;
        int numericProduct;
        public FormTransactionAE()
        {
            InitializeComponent();
            LodCB();
            label2.Text = "صفحه ثبت";
            this.Text = "صفحه ثبت";
            btnOK.Text = "ثبت";
            TimeT.Value = DateTime.Now;

        }
        public FormTransactionAE(Transaction transaction)
        {
            InitializeComponent();
            LodCB();
            TransactionId = transaction.TransactionID;
            cbProduct.SelectedValue = Convert.ToInt32(transaction.ProductID);
            CBDriver.SelectedValue = transaction.DriverID;
            cbSupplisers.SelectedValue = transaction.SupplierID;
            ProductNum.Text = transaction.Quantity.ToString();
            Price.Text = Math.Round(transaction.Price, 0).ToString();
            dateTimePicker1.Value = transaction.Date;
            CBType.Text = typeEdit = transaction.Type;
            TimeT.Value = DateTime.Today.Add(transaction.TimeT);
            label2.Text = "صفحه ویرایش";
            this.Text = "صفحه ویرایش";
            btnOK.Text = "ویرایش";

            numericProduct = transaction.Quantity;




        }


        private void btnCansell_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (ProductNum.Value != 0)
            {
                if (btnOK.Text == "ثبت")
                    Add();
                else if (btnOK.Text == "ویرایش")
                    Edit();
            }
            else
            {
                MessageBox.Show("تعداد کالا نباید صفر باشد.", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void FormTransactionAE_Load(object sender, EventArgs e)
        {


        }

        public void LodCB()
        {


            cbProduct.DataSource = ProductControll.GetProduct_ID_Name();
            cbProduct.DisplayMember = "ProductName";
            cbProduct.ValueMember = "ProductID";

            /////////////////////////////////////////
            ///

            cbSupplisers.DataSource = SuppliersControll.GetSupplier_ID_Name();
            cbSupplisers.DisplayMember = "SupplierName";
            cbSupplisers.ValueMember = "SupplierID";

            /////////////////////////////////////////
            ///
            CBDriver.DataSource = DriverControll.GetDriver_ID_name();
            CBDriver.DisplayMember = "Name";
            CBDriver.ValueMember = "DriverID";

            /////////////////////////////////////////
            ///
            CBType.SelectedIndex = 0;

        }

        public void Add()
        {
            int Productid = Convert.ToInt32(cbProduct.SelectedValue),
                Driverid = Convert.ToInt32(CBDriver.SelectedValue),
                Supplisersid = Convert.ToInt32(cbSupplisers.SelectedValue),
                numProduct = Convert.ToInt32(ProductNum.Text);
            int price;
            if (Price.Text == "")
            { price = 0; }
            else
            { price = Convert.ToInt32(Price.Text); }
            string type = CBType.Text;
            DateTime date = dateTimePicker1.Value.Date;
            TimeSpan Time = TimeT.Value.TimeOfDay;

            int num = ProductControll.FindStockByID(Productid);
            if ((num - numProduct) < 0 && type == "فروش")
            {
                MessageBox.Show($"تعداد کالا برای فروش کم میباشد    تعداد کالا {num}");
            }
            else
            {

                if (type == "خرید")
                {
                    num = num + numProduct;

                }
                else if (type == "فروش")
                { num = num - numProduct; }

                TransactionControll.AddTransaction(Productid, Driverid, Supplisersid, numProduct, price, type, date, Time);
                ProductControll.UpdateProudactNUM(Productid, numProduct);
                this.Close();
            }

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        public void Edit()
        {

            int Productid = Convert.ToInt32(cbProduct.SelectedValue),
                    Driverid = Convert.ToInt32(CBDriver.SelectedValue),
                    Supplisersid = Convert.ToInt32(cbSupplisers.SelectedValue),
                    numProduct = Convert.ToInt32(ProductNum.Text),
                    price = Convert.ToInt32(Price.Text);
            string type = CBType.Text;
            DateTime date = dateTimePicker1.Value.Date;
            TimeSpan Time = TimeT.Value.TimeOfDay;
            int num = ProductControll.FindStockByID(Productid);
            if (typeEdit == "خرید")
            {
                num = num - numericProduct;

            }
            else if (typeEdit == "فروش")
            { num = num + numericProduct; }



            if ((num - numProduct) < 0 && type == "فروش")
            {
                MessageBox.Show($"تعداد کالا برای فروش کم میباشد    تعداد کالا {num}");
            }
            else
            {
                if (type == "خرید")
                {
                    num = num + numProduct;

                }
                else if (type == "فروش")
                { num = num - numProduct; }
                TransactionControll.UpdateTransaction(TransactionId, Productid, Driverid, Supplisersid, numProduct, price, type, date, Time);
                ProductControll.UpdateProudactNUM(Productid, num);
                this.Close();
            }


        }

        private void FormTransactionAE_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
