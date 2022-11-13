using PrOOPz3.src.utils;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using PrOOPz3.src.features.products.data;
using PrOOPz3.src.features.customers.data;
using PrOOPz3.src.features.customers.application;
using PrOOPz3.src.features.orders.data;
using PrOOPz3.src;
using PrOOPz3.src.features.orders.presentation.add_order;
using LiteDB;
using PrOOPz3.src.features.orders.domain;

namespace PrOOPz3
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            //var db = new LiteDatabase("database.db");
            Application.Run(Services.GetService<MainForm>());
        }
    }
}