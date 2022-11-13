using PrOOPz3.src.features.customers.domain;
using PrOOPz3.src.features.orders.domain;
using PrOOPz3.src.features.products.domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrOOPz3.src.features.orders.presentation.add_order
{
    public class AddOrderFormState
    {
        public AddOrderFormState(
            AddOrderFormType formType, 
            Order? order = null, 
            List<Product>? products = null
            ) 
        {
            FormType = formType;
            Order = order ?? new Order();
            Products = products ?? new List<Product>();
        }

        public AddOrderFormType FormType { get; }
        public Order Order { get; }
        public List<Product> Products { get; set; }
        
        public string SubmitButtonText { get
            {
                switch (FormType)
                {
                    case AddOrderFormType.Add:
                        return "Додати";
                    case AddOrderFormType.Edit:
                        return "Зберегти зміни";
                    default:
                        throw new Exception("Incorrect FormType.");
                }
            }
        }

        public string TitleText
        {
            get
            {
                switch (FormType)
                {
                    case AddOrderFormType.Add:
                        return "Додати замовлення";
                    case AddOrderFormType.Edit:
                        return "Редагування замовлення";
                    default:
                        throw new Exception("Incorrect FormType.");
                }
            }
        }

        public bool CanDelete
        {
            get
            {
                return FormType == AddOrderFormType.Edit;
            }
        }

        public AddOrderFormState CopyWith(Order? order = null, List<Product>? products = null)
        {
            return new AddOrderFormState(
                FormType, 
                order: order ?? Order,
                products: products ?? Products
                );
        }
    }
}
