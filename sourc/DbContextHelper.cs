using BarMan.Models;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace BarMan.sourc
{
    public static class DbContextHelper
    {

       

        // عملیات عمومی بازگشتی
        public static T ExecuteInDbContext<T>(Func<InventoryContext, T> operation)
        {
            using (var scope = db_Connect.GetServiceScope())
            {
                var context = scope.ServiceProvider.GetRequiredService<InventoryContext>();
                return operation(context);
            }
        }

        // عملیات عمومی بدون بازگشت
        public static void ExecuteInDbContext(Action<InventoryContext> operation)
        {
            using (var scope = db_Connect.GetServiceScope())
            {
                var context = scope.ServiceProvider.GetRequiredService<InventoryContext>();
                operation(context);
            }
        }

       


        // افزودن یک موجودیت
        public static void Add<TEntity>(TEntity entity) where TEntity : class
        {
            ExecuteInDbContext(context =>
            {
                context.Set<TEntity>().Add(entity);
                context.SaveChanges();
            });
        }

        // به‌روزرسانی یک موجودیت
        public static void Update<TEntity>(TEntity entity) where TEntity : class
        {
            ExecuteInDbContext(context =>
            {
                context.Set<TEntity>().Update(entity);
                context.SaveChanges();
            });
        }

        // حذف یک موجودیت
        public static void Delete<TEntity>(TEntity entity) where TEntity : class
        {
            ExecuteInDbContext(context =>
            {
                context.Set<TEntity>().Remove(entity);
                context.SaveChanges();
            });
        }
    }

}
