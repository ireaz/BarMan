using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BarMan.sourc
{
    internal class CategoryControll
    {


        public static void CategoryComboBox(ComboBox CB)
        {

            var LCategory = CategoryControll.GetAllCategory(); 
            if (LCategory != null && LCategory.Any()) // بررسی اینکه آیا لیست حاوی داده است
            {
                CB.DataSource = LCategory;
                CB.DisplayMember = "CategoryName"; 
                CB.ValueMember = "CategoryID"; 
            }
            else
            {
                
                MessageBox.Show("No categories available.");
            }

        }

        public static List<object> GetCategor_ID_Name()
        {
            return DbContextHelper.ExecuteInDbContext(context =>
            {
                return context.Categories
                .Select(P => new { P.CategoryID, P.CategoryName })
                .ToList<object>();

            });

        }
        public static List<object> GetAllCategory()
        {
            return DbContextHelper.ExecuteInDbContext(context =>
            {
                return context.Categories
                .Select(P => new
                {
                    P.CategoryID,
                    P.CategoryName,
                    ParentCategoryName = P.ParentCategoryID != null
                ? context.Categories
                    .Where(parent => parent.CategoryID == P.ParentCategoryID)
                    .Select(parent => parent.CategoryName)
                    .FirstOrDefault()
                : null // در صورت نبود ParentCategoryID، مقدار null می‌گذاریم
                })
                .ToList<object>();

            });

        }




    }
}
