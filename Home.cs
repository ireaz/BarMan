using BarMan.Models;
using BarMan.sourc;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BarMan
{
    public partial class Home : Form
    {
        private ServiceProvider _serviceProvider;
        public Home()
        {
            InitializeComponent();
            InitializeCalendarInPanel();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
            this.TopMost = false;

            DataGV();


        }


        private void DataGV()
        {

            var products = ProductControll.GetProductWithCategoryName();
          
                ClassDesign.CustomizeDataGridView(DGV);
                DGV.DataSource = products;
            DGVCName(DGV);
           /*
            DGV.Columns["ProductName"].HeaderText = "نام کالا";
            DGV.Columns["ProductStock"].HeaderText = "موجودی کالا";
            DGV.Columns["CategoryName"].HeaderText = "نام دسته‌بندی";*/



        }


        public void DGVCName(DataGridView DGV)
        {
            if (DGV.Columns["ProductName"] == null)
            {
                DGV.Columns.Add("ProductName", "نام کالا");
            }
            if (DGV.Columns["ProductStock"] == null)
            {
                DGV.Columns.Add("ProductStock", "موجودی کالا");
            }
            if (DGV.Columns["CategoryName"] == null)
            {
                DGV.Columns.Add("CategoryName", "نام دسته‌بندی");
            }

            // تنظیم نام ستون‌ها
            DGV.Columns["ProductName"].HeaderText = "نام کالا";
            DGV.Columns["ProductStock"].HeaderText = "موجودی کالا";
            DGV.Columns["CategoryName"].HeaderText = "نام دسته‌بندی";


        }






        private void pictureBox5_Click(object sender, EventArgs e)
        {
            AdminForm adminform = new AdminForm();
            this.Hide();
            adminform.ShowDialog();

            ProductControll.ProductData = null;
            this.Show();
        }



        private void InitializeCalendarInPanel()
        {
            // فرض بر این است که پنل p1 قبلاً در فرم ایجاد شده است
            MonthCalendar monthCalendar = new MonthCalendar();
            monthCalendar.MaxSelectionCount = 1;
            monthCalendar.DateSelected += new DateRangeEventHandler(MonthCalendar_DateSelected);

            panel4.BackColor = Color.LightSkyBlue;
            panel4.Padding = new Padding(5); // پدینگ 10 پیکسل از تمامی لبه‌ها

            monthCalendar.Dock = DockStyle.Bottom;

            panel4.Controls.Add(monthCalendar);
        }

        private void MonthCalendar_DateSelected(object sender, DateRangeEventArgs e)
        {
            DateTime selectedDate = e.Start;

            // تبدیل تاریخ میلادی به شمسی
            PersianCalendar persianCalendar = new PersianCalendar();
            int year = persianCalendar.GetYear(selectedDate);
            int month = persianCalendar.GetMonth(selectedDate);
            int day = persianCalendar.GetDayOfMonth(selectedDate);

            MessageBox.Show($"تاریخ انتخابی: {year}/{month}/{day}");
        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PBProducts_Click(object sender, EventArgs e)
        {
            FormProduct formproduct = new FormProduct();
            this.Hide();
            formproduct.ShowDialog();


            this.Show();
        }
    }
}
