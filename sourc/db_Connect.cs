using BarMan.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace BarMan.sourc
{
    public static class db_Connect
    {
        private static IServiceProvider _serviceProvider;

        public static void Initialize()
        {
            if (_serviceProvider == null)
            {
                _serviceProvider = new ServiceCollection()
                    .AddDbContext<InventoryContext>(options =>
                        options.UseSqlServer("Server=localhost;Database=DbBarMan;Trusted_Connection=True;"))
                    .BuildServiceProvider();
            }
        }


    

        public static IServiceScope GetServiceScope()//حذف
        {
            if (_serviceProvider == null)
            {
                throw new InvalidOperationException("Service provider is not initialized. Call Initialize() first.");
            }

            return _serviceProvider.CreateScope();
        }

    public static InventoryContext GetDbContext()
        {
            if (_serviceProvider == null)
            {
                throw new InvalidOperationException("Service provider is not initialized. Call Initialize() first.");
            }

            using var scope = _serviceProvider.CreateScope();
            return scope.ServiceProvider.GetRequiredService<InventoryContext>();
        }

      


    }


}
