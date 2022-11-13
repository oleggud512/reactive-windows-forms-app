using PrOOPz3.src.features.customers.domain;
using PrOOPz3.src.features.orders.data;
using PrOOPz3.src.features.orders.domain;
using PrOOPz3.src.features.products.application;
using PrOOPz3.src.features.products.domain;
using PrOOPz3.src.utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrOOPz3.src.features.orders.presentation.add_order
{
    public class AddOrderFormController : StateObservable<AddOrderFormState>
    {
        IOrdersRepository ordersRepository;
        ProductsToAddService productsToAddService;
        AddOrderFormParameters parameters;
        readonly AddOrderFormType FormType;

        public AddOrderFormController(
            IOrdersRepository ordersRepository, 
            ProductsToAddService productsToAddService,
            AddOrderFormParameters parameters
            ) : base(new AddOrderFormState(parameters.FormType, parameters.OrderToEdit))
        {
            this.ordersRepository = ordersRepository;
            this.productsToAddService = productsToAddService;
            FormType = parameters.FormType;
            this.parameters = parameters;
            RefreshProducts();
        }

        public void Submit()
        {
            switch (FormType)
            {
                case AddOrderFormType.Add:
                    AddOrder();
                    break;
                case AddOrderFormType.Edit:
                    EditOrder();
                    break;
            }
        }

        private void AddOrder()
        {
            if (State.Order.CanAdd()) ordersRepository.AddOrder(State.Order);
        }

        private void EditOrder()
        {
            ordersRepository.UpdateOrder(State.Order);
        }

        public void RemoveThisOrder()
        {
            if (State.Order.Exists())
            {
                ordersRepository.RemoveOrder(State.Order.Id);
                parameters.OrderToEdit = null;
            }
        }

        public Customer Customer { 
            //get => State.Order.Customer; 
            set 
            { 
                State = State.CopyWith(
                    order: State.Order.SetCustomer(value)
                    );
            } 
        }

        public DateTime OrderDate
        {
            set
            {
                State = State.CopyWith(
                    order: State.Order.SetDate(value)
                    );
            }
        }

        public void RemoveOrderItem(OrderItem item)
        {
            State = State.CopyWith(
                order: State.Order.RemoveProduct(item.Product) // TODO: 
                );
        }

        public void ProductSelected(Product product)
        {
            State = State.CopyWith(
                order: State.Order.AddProduct(product)
                );
        }

        public void RefreshProducts(string query = "")
        {
            State = State.CopyWith(
                products: productsToAddService.GetProducts(query)
                );
        }
        
    }
}
