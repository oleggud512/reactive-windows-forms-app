using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Extensions.Logging;
using PrOOPz3.src.features.customers.presentation.customers;
using PrOOPz3.src.utils;

namespace PrOOPz3.src.features.customers.presentation
{
    [Designer("System.Windows.Forms.Design.ParentControlDesigner, System.Design", typeof(IDesigner))]
    public partial class CustomersControl : UserControl
    {
        CustomersControlController cont;
        public CustomersControl(CustomersControlController customersControlController)
        {
            this.cont = customersControlController;
            InitializeComponent();
            cont.Subscribe((state) =>
            {
                // display customers in dataGridView
                dataGridView.DataSource = state.Customers;
                // display current customer by state.CurrentIndex in "Form"
                if (state.Customers.Count > 0)
                {
                    Utils.wl(state.CurrentIndex);
                    nameTb.Text = state.CurrentCustomer.Name;
                    phoneTb.Text = state.CurrentCustomer.Phone;
                    addressTb.Text = state.CurrentCustomer.Address;
                } else
                {
                    nameTb.Text = "";
                    phoneTb.Text = "";
                    addressTb.Text = "";
                }
                Utils.wl("new CustomersControlState()");
            });
        }

        private void todayCb_CheckedChanged(object sender, EventArgs e)
        {
            cont.ToggleTodayFilter(todayCb.Checked);
        }

        private void dataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count > 0)
            {
                Utils.wl($"dataGridView_SelectionChanged - dataGridView.SelectedRows[0].Index = {dataGridView.SelectedRows[0].Index}");
                cont.CurrentIndex = dataGridView.SelectedRows[0].Index;
            }
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // on delete button
            if (e.ColumnIndex == dataGridView.Columns["DeleteBtnCol"].Index)
            {
                cont.RemoveCustomer(cont.State.Customers[e.RowIndex].Id);
            } else
            {
                cont.CurrentIndex = e.RowIndex;
            }
        }

        private void saveCurrentBtn_Click(object sender, EventArgs e)
        {
            cont.UpdateCustomer(
                cont.State.CurrentCustomer.Id, 
                nameTb.Text, 
                phoneTb.Text, 
                addressTb.Text
                );
        }

        private void addNewBtn_Click(object sender, EventArgs e)
        {
            cont.AddCustomer(nameTb.Text, phoneTb.Text, addressTb.Text);
        }
    }
}
