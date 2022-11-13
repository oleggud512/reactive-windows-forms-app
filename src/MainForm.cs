using PrOOPz3.src.features.customers.presentation;
using PrOOPz3.src.features.orders.presentation.orders;
using PrOOPz3.src.features.products.presentation;
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

namespace PrOOPz3.src
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            SwitchPage(Services.GetService<OrdersControl>()!);
        }

        private void pageRb_CheckedChanged(object sender, EventArgs e)
        {
            if (ordersRb.Checked)
            {
                Utils.wl("ordersRb.Checked");
                SwitchPage(Services.GetService<OrdersControl>()!);
            }
            else if (customersRb.Checked)
            {
                Utils.wl("customersRb.Checked");
                SwitchPage(Services.GetService<CustomersControl>()!);
            }
            else if (productsRb.Checked)
            {
                Utils.wl("productsRb.Checked");
                SwitchPage(Services.GetService<ProductsControl>()!);
            }
        }

        private void SwitchPage(UserControl newPage)
        {
            if (contentPanel.Controls.Count != 0)
            {
                UserControl? oldPage = contentPanel.Controls[0] as UserControl;
                contentPanel.Controls.Remove(oldPage);
                oldPage?.Dispose();
            }
            contentPanel.Controls.Add(newPage);
            newPage.Dock = DockStyle.Fill;
        }
    }
}
