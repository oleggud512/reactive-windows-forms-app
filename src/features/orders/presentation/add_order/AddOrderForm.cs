using LiteDB;
using PrOOPz3.src.features.customers.presentation.customer_picker;
using PrOOPz3.src.features.orders.domain;
using PrOOPz3.src.features.products.domain;
using PrOOPz3.src.utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrOOPz3.src.features.orders.presentation.add_order
{
    public partial class AddOrderForm : Form
    {
        AddOrderFormController cont;
        // нужен, потому что когда добавляются новые итемы в productsListBox то вызывается 
        // productsListBox_SelectedIndexChanged и я не хочу чтобы во время заполнения 
        // productsListBox данными сразу же Product добавлялся в чек. 
        bool couldSelectProduct = false;

        public AddOrderForm(AddOrderFormController cont)
        {
            InitializeComponent();
            this.cont = cont;

            cont.Subscribe((state) =>
            {
                submitBtn.Text = state.SubmitButtonText;
                Text = state.TitleText;

                deleteBtn.Visible = state.CanDelete;

                customerLbl.Text = state.Order.Customer?.ToString() ?? "Покупця не вибрано.";

                couldSelectProduct = false;
                productsListBox.DataSource = state.Products;
                couldSelectProduct = true;

                // TODO: валидация ввода в "Колличество". 
                productsDataGridView.DataSource = state.Order.OrderItems;
            });
        }

        private void chooseCustomerBtn_Click(object sender, EventArgs e)
        {
            var form = Services.GetService<CustomerPickerForm>()!;
            if (form.ShowDialog() == DialogResult.OK && form.Result != null)
            {
                cont.Customer = form.Result;
            }
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            cont.Submit();
            Close();
        }

        private void searchProductsTb_TextChanged(object sender, EventArgs e)
        {
            cont.RefreshProducts(searchProductsTb.Text);
        }

        #region AddProduct logic

        private void productsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (couldSelectProduct && productsListBox.SelectedItems.Count > 0)
            {
                cont.ProductSelected((Product)productsListBox.SelectedItems[0]);
            }
        }

        private void productsListBox_Leave(object sender, EventArgs e)
        {
            productsListBox.SelectedIndex = -1;
        }

        #endregion

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            cont.OrderDate = dateTimePicker1.Value.Date;
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            cont.RemoveThisOrder();
            Close();

        }

        private void productsListBox_DrawItem(object sender, DrawItemEventArgs e)
        {
            e.DrawBackground();
            Brush brush = Brushes.Black;

            var p = cont.State.Products[e.Index];

            var pen = new Pen(Brushes.Gray);
            pen.Width = 2;
            e.Graphics.DrawString($"{p.Id} | {p.Name}\nЦіна: {p.Price}\nВага: {p.Weight}", e.Font, brush, e.Bounds);
            e.Graphics.DrawLine(
                pen,
                new Point(e.Bounds.Left, e.Bounds.Bottom),
                new Point(e.Bounds.Right, e.Bounds.Bottom)
                );
            e.DrawFocusRectangle();
        }

        private void productsListBox_MeasureItem(object sender, MeasureItemEventArgs e)
        {
            e.ItemHeight = 48;
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cont.RemoveOrderItem((OrderItem)productsDataGridView.SelectedRows[0].DataBoundItem);
        }
    }
}
