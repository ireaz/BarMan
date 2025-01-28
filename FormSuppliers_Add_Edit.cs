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
    public partial class FormSuppliers_Add_Edit : Form
    {
        public int SupplierId;
        public bool AE = false;
        public FormSuppliers_Add_Edit()
        {
            InitializeComponent();
            AE = false;
        }

        private void FormSuppliers_Add_Edit_Load(object sender, EventArgs e)
        {
            SetName(AE);
        }

        public FormSuppliers_Add_Edit(int id, string name, string idcod, string tell, string email, string description)
        {
            InitializeComponent();
            AE = true;

            SupplierId = id;
            tbName.Text = name;
            tbIDCod.Text = idcod;
            tbTell.Text = tell;
            tbVehicleType.Text = email;
            tbVehicleNumber.Text = description;


        }

        private void btnOK_Click(object sender, EventArgs e)
        {

            if (AE == true)
            {


                Edit();


            }
            else if (AE == false)
            {
                Add();
            }






        }

        private void btnCansel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void SetName(bool ae)
        {
            if (ae == false)
            {
                this.Text = "ثبت خریدار";
                btnOK.Text = "ثبت";
               
            }
            else if (ae == true)
            {
                this.Text = "ویرایش خریدار";
                btnOK.Text = "ویرایش";
              
            }

        }
        public void Add()
        {
            string name = tbName.Text;
            string IdCod = tbIDCod.Text;
            string tell = tbTell.Text;
            string Email = tbVehicleType.Text;
            string description = tbVehicleNumber.Text;


            if (!SuppliersControll.IsSupplier_ID_CodeAvailable(IdCod) && !SuppliersControll.IsSuppliersNameAvailable(name))
            {
                if (SuppliersControll.AddSupplier(name, IdCod, tell, Email, description))
                {
                    this.Close();
                }
                else
                {
                    MessageBox.Show("فرایند اضافه کردن خریدار با مشکل روبرو شد ", "هشدار");


                    this.Close();
                }

            }
            else
            {
                MessageBox.Show(" این رانندهبا نام " + name + " و با این شماره ماشین " + IdCod + " وجود دارد ", "هشدار");
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
                            string name = tbName.Text;
                            string IdCod = tbIDCod.Text;
                            string tell = tbTell.Text;
                            string Email = tbVehicleType.Text;
                            string description = tbVehicleNumber.Text;

                            if (!SuppliersControll.IsIdCodUnique(IdCod, SupplierId)
                                || !SuppliersControll.IsNameUnique(name, SupplierId)
                                )
                            {
                                if (!SuppliersControll.IsIdCodUnique(IdCod, SupplierId))
                                {
                                    if (SuppliersControll.UpdateSupplier(SupplierId, name, IdCod, tell, Email, description))
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

        private void FormSuppliers_Add_Edit_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                e.SuppressKeyPress = true;



                this.SelectNextControl((ActiveControl), true, true, true, true);
            }

          else  if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
