using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BarMan.sourc
{
    internal class ClassDesign
    {

        internal static void CustomizeDataGridView(DataGridView DGV)
        {
            // رنگ پس‌زمینه برای DataGridView
            DGV.BackgroundColor = Color.WhiteSmoke;

            // تغییر رنگ سطرهای زوج و فرد برای نمایش بهتر
            DGV.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;

            // تغییر رنگ فونت سطرها
            DGV.DefaultCellStyle.Font = new Font("B Roya", 12);

            // تغییر رنگ سطر انتخاب شده
            DGV.DefaultCellStyle.SelectionBackColor = Color.CadetBlue;
            DGV.DefaultCellStyle.SelectionForeColor = Color.White;

            // تغییر حاشیه‌ها و گرید
            DGV.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            DGV.GridColor = Color.Gray;
            DGV.RightToLeft = RightToLeft.Yes;
            EnableSortingOnAllColumns(DGV);

            DGV.AllowUserToOrderColumns = true;




        }




        public static void AddButtonsToGrid(DataGridView dataGridView)
        {
            // افزودن دکمه حذف
            DataGridViewImageColumn deleteButtonColumn = new DataGridViewImageColumn();
            deleteButtonColumn.Name = "Delete";
            deleteButtonColumn.HeaderText = "حذف";
            deleteButtonColumn.Image = Properties.Resources.Delete;
            deleteButtonColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;
            deleteButtonColumn.Width = 50; 
            deleteButtonColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.None; 
            dataGridView.Columns.Add(deleteButtonColumn);

            // افزودن دکمه ویرایش
            DataGridViewImageColumn editButtonColumn = new DataGridViewImageColumn();
            editButtonColumn.Name = "Edit";
            editButtonColumn.HeaderText = "ویرایش";
            editButtonColumn.Image = Properties.Resources.Edit;
            editButtonColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;
            editButtonColumn.Width = 50; 
            editButtonColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.None; 
            dataGridView.Columns.Add(editButtonColumn);

           
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        public static void HindenTabPages(TabControl tabControl,TabPage TPHiden, TabPage TPShow)
        {

            tabControl.TabPages.Remove(TPHiden);
            tabControl.TabPages.Add(TPShow);


        }
        public static void EnableSortingOnAllColumns(DataGridView dataGridView)
        {
            foreach (DataGridViewColumn column in dataGridView.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.Automatic;
            }
        }


    }

   


}
