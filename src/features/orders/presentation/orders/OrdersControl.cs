using PrOOPz3.src.features.orders.data;
using PrOOPz3.src.features.orders.domain;
using PrOOPz3.src.features.orders.presentation.add_order;
using PrOOPz3.src.utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrOOPz3.src.features.orders.presentation.orders
{
    [Designer("System.Windows.Forms.Design.ParentControlDesigner, System.Design", typeof(IDesigner))]
    public partial class OrdersControl : UserControl
    {
        OrdersControlController cont;

        public OrdersControl(OrdersControlController ordersControlController)
        {
            cont = ordersControlController;
            InitializeComponent();
            cont.Subscribe((state) =>
            {
                listBox.DataSource = state.Orders;
                Utils.wl("new OrdersControlState()");
            });
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            var parameters = Services.GetService<AddOrderFormParameters>()!;
            parameters.FormType = AddOrderFormType.Edit;
            parameters.OrderToEdit = cont.State.Orders[listBox.SelectedIndex];
            Services.GetService<AddOrderForm>()!.ShowDialog();
            cont.RefreshOrders();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            var parameters = Services.GetService<AddOrderFormParameters>()!;
            parameters.FormType = AddOrderFormType.Add;
            Services.GetService<AddOrderForm>()!.ShowDialog();
            cont.RefreshOrders();
        }

        private void listBox_MeasureItem(object sender, MeasureItemEventArgs e)
        {
            e.ItemHeight = 48;
        }

        private void listBox_DrawItem(object sender, DrawItemEventArgs e)
        {
            e.DrawBackground();
            var brush = Brushes.Black;
            var pen = new Pen(Brushes.Gray);
            pen.Width = 2;
            e.Graphics.DrawString(cont.State.Orders[e.Index].StringRepr, e.Font, brush, e.Bounds);
            e.Graphics.DrawLine(
                pen, 
                new Point(e.Bounds.Left, e.Bounds.Bottom), 
                new Point(e.Bounds.Right, e.Bounds.Bottom)
                );
            e.DrawFocusRectangle();
        }



        // protected void Dispose(bool disposing) {
    }
}
