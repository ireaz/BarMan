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
    public partial class FormCategory : Form
    {
        
        public FormCategory()
        {
            InitializeComponent();
        }

        private void FormCategory_Load(object sender, EventArgs e)
        {
            ClassDesign.CustomizeDataGridView(DGVCategory);
            ClassDesign.ButtenDelet(DGVCategory);
            ClassDesign.ButtenEdit(DGVCategory);
            DGVCategory.DataSource = CategoryControll.GetAllCategory();
            tabPage2.Hide();
            tabControl1.TabPages.Remove(tabPage2);



        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
           
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Remove(tabPage2);
            tabControl1.TabPages.Add(tabPage1);
        }

        private void DGVCategory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (e.ColumnIndex == DGVCategory.Columns["Delete"].Index)
                {


                }

                if (e.ColumnIndex == DGVCategory.Columns["Edit"].Index)
                {if (tabControl1.TabPages.Contains(tabPage1))
                    {
                        tabControl1.TabPages.Remove(tabPage1);                      
                        tabControl1.TabPages.Add(tabPage2);                     
                    }
                // ادامه کار اضافه کردن لیست کتگوری ها به کمبو باکس و نام کتگوری برای ویرایش به تکس باکس

                }


            }
        }


     


    }
}
