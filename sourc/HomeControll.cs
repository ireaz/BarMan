using BarMan.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BarMan.sourc
{
    internal class HomeControll
    {
      
     //  public static List<TransactionModel> DataTrans()
        // فیلتر 
        public static List<TransactionModel> FilterT(string FProductName, string FDriverName, string FSuppliers, int numProductO, int numProductE, DateTime OpanDate, DateTime EndDate, bool buy, bool Sel,bool FDEnable, TimeSpan TimeO, TimeSpan TimeE, bool TimeEnable)
        {

            return DbContextHelper.ExecuteInDbContext(context =>
            {
                var query = context.Transactions
                    .Include(t => t.Product)
                    .Include(t => t.Driver)
                    .Include(t => t.Supplier)
                    .AsQueryable();

                // فیلتر بر اساس نام محصول
                if (!string.IsNullOrEmpty(FProductName))
                {
                    query = query.Where(t => t.Product.ProductName.Contains(FProductName));
                }

                // فیلتر بر اساس نام راننده
                if (!string.IsNullOrEmpty(FDriverName))
                {
                    query = query.Where(t => t.Driver != null && t.Driver.Name.Contains(FDriverName));
                }

                // فیلتر بر اساس نام تأمین‌کننده
                if (!string.IsNullOrEmpty(FSuppliers))
                {
                    query = query.Where(t => t.Supplier.SupplierName.Contains(FSuppliers));
                }

                // فیلتر بر اساس تعداد محصول
                if (numProductO > 0)
                {
                    query = query.Where(t => t.Quantity >= numProductO);
                }
                if (numProductE > 0)
                {
                    query = query.Where(t => t.Quantity <= numProductE);
                }

                // فیلتر بر اساس تاریخ شروع
                if (FDEnable == true)
                {
                    query = query.Where(t => t.Date >= OpanDate);
                }

                // فیلتر بر اساس تاریخ پایان
                if ( FDEnable == true)
                {
                    query = query.Where(t => t.Date <= EndDate);
                }

                // فیلتر بر اساس خرید
                if (buy)
                {
                    query = query.Where(t => t.Type == "خرید");
                }

                // فیلتر بر اساس فروش
                if (Sel)
                {
                    query = query.Where(t => t.Type == "فروش");
                }
                if (TimeEnable)
                {
                    query = query.Where(t => t.TimeT >= TimeO);
                }
                if (TimeEnable)
                {
                    query = query.Where(t => t.TimeT <= TimeE);
                }

                // بازگشت نتایج
                return query.Select(t => new TransactionModel
                {
                    TransactionID = t.TransactionID,
                    ProductName = t.Product.ProductName,
                    DriverName = t.Driver != null ? t.Driver.Name : "بدون راننده",
                    SupplierName = t.Supplier.SupplierName,
                    Quantity = t.Quantity,
                    Price = t.Price,
                    Type = t.Type,
                    Date = t.Date,
                    Time = t.TimeT
                }).ToList();
            });


        }

        public static List<TransactionModel> SortTransactionsByDate(List<TransactionModel> transactions, bool ascending)
        {
            return ascending
                ? transactions.OrderBy(t => t.Date).ToList()  // ترتیب صعودی
                : transactions.OrderByDescending(t => t.Date).ToList();  // ترتیب نزولی
        }
       
    }
}
