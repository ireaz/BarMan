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

    public partial class FormDriver_Add_Edit : Form
    {
        public int DriverId;
        public bool AE = false;

        public FormDriver_Add_Edit()
        {
            InitializeComponent();
            AE = false;

        }
        public void SetName(bool ae)
        {
            if (ae == false)
            {
                this.Text = "ثبت راننده";
                btnOK.Text = "ثبت";
                lbtext.Text = "صفحه ثبت راننده";
            }
            else if (ae == true)
            {
                this.Text = "ویرایش راننده";
                btnOK.Text = "ویرایش";
                lbtext.Text = "صفحه ویرایش راننده";
            }

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormDriver_Add_Edit_Load(object sender, EventArgs e)
        {
            //  btnOK.Text = "ثبت";
            SetName(AE);

        }

        public FormDriver_Add_Edit(int driverid, string drivername, string DriverIdCod, string tell, string VehicleType, string VehicleNumber)
        {
            InitializeComponent();
            AE = true;

            DriverId = driverid;
            tbName.Text = drivername;
            tbIDCod.Text = DriverIdCod;
            tbTell.Text = tell;
            tbVehicleType.Text = VehicleType;
            tbVehicleNumber.Text = VehicleNumber;




        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (AE == true)
            {


                Edit();


            }
            else if (AE == false)
            {
                string Drivername = tbName.Text;
                string IdCod = tbIDCod.Text;
                string tell = tbTell.Text;
                string VehicleType = tbVehicleType.Text;
                string VehicleNumber = tbVehicleNumber.Text;


                if (DriverControll.IsDriverNameAvailable(IdCod) && DriverControll.IsDriverVehicleNumberAvailable(VehicleNumber))
                {
                    if (DriverControll.AddDriver(Drivername, IdCod, tell, VehicleType, VehicleNumber))
                    {
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("فرایند اضافه کردن دریاور با مشکل روبرو شد ", "هشدار");


                        this.Close();
                    }

                }
                else
                {
                    MessageBox.Show(" این رانندهبا نام " + Drivername + " و با این شماره ماشین " + VehicleNumber + " وجود دارد ", "هشدار");
                }
            }






        }

        public void Edit()
        {
            if (tbName.Text != "")
            {

                if (tbTell.Text != "")
                {

                    if (tbVehicleType.Text != "")
                    {

                        if (tbVehicleNumber.Text != "")
                        {
                            string Drivername = tbName.Text;
                            string IdCod = tbIDCod.Text;
                            string VehicleType = tbVehicleType.Text;
                            string DriverTell = tbTell.Text;
                            string VehicleNumber = tbVehicleNumber.Text;

                            if (!DriverControll.IsIdCodUnique(IdCod, DriverId)
                                || !DriverControll.IsVehicleNumberUnique(VehicleNumber, DriverId)
                                )
                            {
                                if (!DriverControll.IsVehicleNumberUnique(VehicleNumber, DriverId))
                                {
                                    if (DriverControll.UpdateDriver(DriverId, Drivername, IdCod, DriverTell, VehicleType, VehicleNumber))
                                        this.Close();
                                    else
                                        MessageBox.Show("فراینده ویرایش با مشکل روبرو شد  ");
                                }
                                else { MessageBox.Show("این  شماره ماشین وجود دارد "); }
                            }
                            else { MessageBox.Show("این کدملی با ابن شماره ماشین وجود دارد "); }


                        }
                        else
                        { MessageBox.Show("شماره ماشین را وارد کنید "); }
                    }
                    else
                    { MessageBox.Show("نوع ماشین را وارد کنید  "); }
                }
                else
                { MessageBox.Show("شماره تلفن راننده را وارد کنید  "); }


            }
            else
            {
                MessageBox.Show("نام راننده را وارد کنید ");
            }


        }

        private void btnCansel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormDriver_Add_Edit_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;

                panel1.SelectNextControl((ActiveControl), true, true, true, true);
            }


           else if (e.KeyCode == Keys.Escape)
            {

                this.Close();
            }
        }
    }
}
