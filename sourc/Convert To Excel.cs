using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using ClosedXML.Excel;
using System.Data;

namespace BarMan.sourc
{
    internal class Convert_To_Excel
    {

        public static void ExportToExcel(DataGridView dataGridView, string filePath)
        {
            try
            {
                using (var workbook = new XLWorkbook())
                {
                    var worksheet = workbook.Worksheets.Add("Data");

                  
                    for (int i = 1; i < dataGridView.Columns.Count; i++) 
                    {
                        worksheet.Cell(1, i).Value = dataGridView.Columns[i].HeaderText;
                    }

                    
                    for (int i = 0; i < dataGridView.Rows.Count; i++)
                    {
                        for (int j = 1; j < dataGridView.Columns.Count; j++)
                        {
                            worksheet.Cell(i + 2, j).Value = dataGridView.Rows[i].Cells[j].Value?.ToString() ?? string.Empty;
                        }
                    }

                    // ذخیره فایل
                    workbook.SaveAs(filePath);
                    MessageBox.Show("فایل Excel با موفقیت ذخیره شد!", "موفقیت", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"خطا در ذخیره فایل: {ex.Message}", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
