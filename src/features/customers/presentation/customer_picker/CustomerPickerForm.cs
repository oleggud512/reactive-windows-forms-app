using PrOOPz3.src.features.customers.domain;
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

namespace PrOOPz3.src.features.customers.presentation.customer_picker
{
    public partial class CustomerPickerForm : Form
    {
        public Customer? Result = null;

        CustomerPickerFormController cont;

        public CustomerPickerForm(CustomerPickerFormController cont)
        {
            InitializeComponent();
            Utils.wl("from form init");
            Utils.wl(Thread.CurrentThread.Name ?? "there is no thread name");
            this.cont = cont;
        }

        private void searchTb_TextChanged(object sender, EventArgs e)
        {
            cont.RefreshCustomers(searchTb.Text);
        }

        private void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Result = cont.State.Customers[listBox.SelectedIndex];
            DialogResult = DialogResult.OK;
            Close();
        }

        private void CustomerPickerForm_Load(object sender, EventArgs e)
        {
            cont.Subscribe((state) =>
            {
                Utils.wl("from subscribe");
                listBox.Items.Clear();
                foreach (var customer in state.Customers)
                {
                    listBox.Items.Add(customer.ToString());
                }
            });
        }

        private void listBox_DrawItem(object sender, DrawItemEventArgs e)
        {
            e.DrawBackground();
            var pen = new Pen(Brushes.Gray);
            pen.Width = 2;
            e.Graphics.DrawString(cont.State.Customers[e.Index].StringRepr, e.Font, Brushes.Black, e.Bounds);
            e.Graphics.DrawLine(
                pen,
                new Point(e.Bounds.Left, e.Bounds.Bottom),
                new Point(e.Bounds.Right, e.Bounds.Bottom)
                );
            e.DrawFocusRectangle();
        }
    }
}
