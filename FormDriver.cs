using BarMan.Models;
using BarMan.sourc;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BarMan
{
    public partial class FormDriver : Form
    {
        public FormDriver()
        {
            InitializeComponent();
        }

        private void FormDriver_Load(object sender, EventArgs e)
        {
            ClassDesign.CustomizeDataGridView(DGVDriver);
            ClassDesign.AddButtonsToGrid(DGVDriver);

            LodDriverData();
            cbSerch.SelectedIndex = 0;



        }




        public void LodDriverData()
        {
            if (tbSerchDriver.Text != "")
            {
                Serch();
            }
            else
            {
                DGVDriver.DataSource = DriverControll.GetDriver();

            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        public void Serch()
        {
            if (cbSerch.SelectedIndex == 0)
            { DGVDriver.DataSource = DriverControll.FilterDriverName(tbSerchDriver.Text); }
            else if (cbSerch.SelectedIndex == 1)
            { DGVDriver.DataSource = DriverControll.FilterDriverVehicleNumber(tbSerchDriver.Text); }
            else if (cbSerch.SelectedIndex == 2)
            { DGVDriver.DataSource = DriverControll.FilterDriverIdCod(tbSerchDriver.Text); }
        }

        private void tbSerchDriver_TextChanged(object sender, EventArgs e)
        {
            Serch();
        }

        private void pbAddDriver_Click(object sender, EventArgs e)
        {
            FormDriver_Add_Edit formDriver_Add = new FormDriver_Add_Edit();

            formDriver_Add.ShowDialog();
            LodDriverData();
        }



        private void DGVDriver_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string VehicleNumber = DGVDriver.Rows[e.RowIndex].Cells["VehicleNumber"].Value.ToString();
                string DriverName = DGVDriver.Rows[e.RowIndex].Cells["Name"].Value.ToString();
                if (e.ColumnIndex == DGVDriver.Columns["Delete"].Index)
                {    // گرفتن اطلاعات سطر انتخاب شده
                    var result = MessageBox.Show($"آیا از حذف {DriverName} اطمینان دارید؟ تمام رکورد های مربوت به این راننده حذف میشوند ", "حذف راننده", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (result == DialogResult.Yes)
                    {
                        DbContextHelper.Delete(DriverControll.FindDriverByVehicleNumber(VehicleNumber));
                        LodDriverData();
                        DatabaseManager.DeleteAll(DriverControll.GetDriverID_With_VehicleNumber(VehicleNumber), "Driver");

                    }
                }

                else if (e.ColumnIndex == DGVDriver.Columns["Edit"].Index)
                {
                    Driver driver = DriverControll.FindDriverByVehicleNumber(VehicleNumber);

                    FormDriver_Add_Edit formDriver_Edit = new FormDriver_Add_Edit(driver.DriverID,
                        driver.Name,
                        driver.DriverIDCode,
                        driver.Phone,
                        driver.VehicleType,
                        driver.VehicleNumber);


                    formDriver_Edit.ShowDialog();
                    LodDriverData();
                }
            }


        }

        private void DGVDriver_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {

            if (DGVDriver.Columns["VehicleNumber"] != null || DGVDriver.Columns["Name"] != null)
            {
                DGVDriver.Columns["Name"].HeaderText = "نام‌ راننده‌";
                DGVDriver.Columns["DriverIDCode"].HeaderText = "کدملی راننده";

                DGVDriver.Columns["Phone"].HeaderText = "تلفون راننده";

                DGVDriver.Columns["VehicleType"].HeaderText = "نوع ماشین";
                DGVDriver.Columns["VehicleNumber"].HeaderText = "شماره ماشین";


            }
        }

        private void FormDriver_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
