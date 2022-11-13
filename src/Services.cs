using LiteDB;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using PrOOPz3.src.features.customers.application;
using PrOOPz3.src.features.customers.data;
using PrOOPz3.src.features.customers.presentation;
using PrOOPz3.src.features.customers.presentation.customer_picker;
using PrOOPz3.src.features.customers.presentation.customers;
using PrOOPz3.src.features.orders.data;
using PrOOPz3.src.features.orders.presentation.add_order;
using PrOOPz3.src.features.orders.presentation.orders;
using PrOOPz3.src.features.products.application;
using PrOOPz3.src.features.products.data;
using PrOOPz3.src.features.products.presentation;
using PrOOPz3.src.utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrOOPz3.src
{
    public static class Services
    {
        private static IServiceProvider? serviceProvider = null;

        private static void ConfigureServices()
        {
            var services = new ServiceCollection();
            // data
            services.AddSingleton((provider) =>
            {
                return new LiteDatabase(@"database.db");
            });
            services.AddSingleton<ICustomersRepository>((provider) => new CustomersRepository());
            services.AddSingleton<IProductsRepository>((provider) => 
                new ProductsRepository(provider.GetRequiredService<LiteDatabase>()));
            services.AddSingleton<IOrdersRepository>((provider) => 
                new OrdersRepository(provider.GetRequiredService<LiteDatabase>()));
            // application
            services.AddSingleton(
                (provider) => new FilterCustomersService(
                    customersRepository: provider.GetService<ICustomersRepository>()!,
                    ordersRepository: provider.GetService<IOrdersRepository>()!
                    )
                );
            services.AddSingleton((provider) => new ProductsToAddService(
                productsRepository: provider.GetRequiredService<IProductsRepository>()
                )
            );


            // presentation
            services.AddTransient((provider) =>
            {
                Utils.wl("Someone created CustomersControlController");
                return new CustomersControlController(
                    filterCustomersService: provider.GetRequiredService<FilterCustomersService>(),
                    customersRepository: provider.GetRequiredService<ICustomersRepository>()
                    );
            });
            services.AddTransient((provider) =>
            {
                return new OrdersControlController(provider.GetRequiredService<IOrdersRepository>());
            });
            services.AddTransient((provider) =>
            {
                return new ProductsControlController(provider.GetRequiredService<IProductsRepository>());
            });
            services.AddTransient((provider) =>
            {
                return new CustomerPickerFormController(provider.GetRequiredService<ICustomersRepository>());
            });
            services.AddSingleton((provider) =>
            {
                return new AddOrderFormParameters();
            });
            services.AddTransient((provider) =>
            {
                return new AddOrderFormController(
                    ordersRepository: provider.GetRequiredService<IOrdersRepository>(),
                    productsToAddService: provider.GetRequiredService<ProductsToAddService>(),
                    parameters: provider.GetRequiredService<AddOrderFormParameters>()
                    );
            });

            services.AddTransient((provider) =>
            {
                return new CustomersControl(provider.GetRequiredService<CustomersControlController>());
            });
            services.AddTransient((provider) =>
            {
                return new OrdersControl(provider.GetRequiredService<OrdersControlController>());
            });
            services.AddTransient((provider) =>
            {
                return new ProductsControl(provider.GetRequiredService<ProductsControlController>());
            });
            services.AddTransient((provider) =>
            {
                return new CustomerPickerForm(provider.GetRequiredService<CustomerPickerFormController>());
            });
            services.AddTransient((provider) =>
            {
                return new AddOrderForm(provider.GetRequiredService<AddOrderFormController>());
            });

            services.AddTransient((provider) => new MainForm());
            
            serviceProvider = services.BuildServiceProvider();
        }

        public static IServiceScope CreateScope()
        {
            if (serviceProvider == null) ConfigureServices();
            return serviceProvider!.CreateScope();
        }

        public static T? GetService<T>()
        {
            if (serviceProvider == null) ConfigureServices();
            return (T?)serviceProvider!.GetService<T>();
        }
    }
}
