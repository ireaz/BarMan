using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BarMan
{
    public partial class LoadingForm : Form
    {
        private Label statusLabel;

        public LoadingForm()
        {
            InitializeComponent();

            // تنظیمات فرم
            this.FormBorderStyle = FormBorderStyle.None; // بدون نوار عنوان
            this.StartPosition = FormStartPosition.CenterScreen; // نمایش در مرکز صفحه
            this.BackColor = System.Drawing.Color.Lime; // رنگ پس‌زمینه (برای شفاف‌سازی)
            this.TransparencyKey = System.Drawing.Color.Lime; // شفاف کردن رنگ پس‌زمینه
            this.TopMost = true; // همیشه در بالای سایر پنجره‌ها باشد
            this.Width = 200; // تنظیم عرض فرم
            this.Height = 250; // تنظیم ارتفاع فرم (افزایش برای نمایش لیبل)

            // افزودن PictureBox برای نمایش گیف
            PictureBox pictureBox = new PictureBox
            {
                Dock = DockStyle.Top,
                Height = 200,
                Image = Properties.Resources.Loading4, // استفاده از گیف در Resources
                SizeMode = PictureBoxSizeMode.Normal // تطبیق اندازه گیف
            };
            this.Controls.Add(pictureBox);

            // افزودن Label برای نمایش وضعیت
            statusLabel = new Label
            {
                Height = 50, // ارتفاع لیبل (می‌توانید اندازه دلخواه تنظیم کنید)
                Text = "در حال بارگذاری...",
                TextAlign = ContentAlignment.MiddleCenter,
                Font = new Font("B Nazanin", 14, FontStyle.Bold),
                ForeColor = System.Drawing.Color.Black,
                BackColor = System.Drawing.Color.FromArgb(169, 169, 169)
            };

            // قرار دادن لیبل دقیقاً زیر پیکچر باکس
            statusLabel.Location = new Point(0, pictureBox.Bottom); // قرار گرفتن در زیر پیکچر باکس
            statusLabel.Width = this.ClientSize.Width; // تنظیم عرض مطابق با عرض فرم
            this.Controls.Add(statusLabel);
        }

        // متد برای تغییر متن لیبل از سایر کلاس‌ها
        public void UpdateStatus(string message)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new Action(() => UpdateStatus(message)));
            }
            else
            {
                statusLabel.Text = message;
            }
        }


    }
}
