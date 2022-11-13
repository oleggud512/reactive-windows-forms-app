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

namespace PrOOPz3.src.features.products.presentation
{
    [Designer("System.Windows.Forms.Design.ParentControlDesigner, System.Design", typeof(IDesigner))]
    public partial class ProductsControl : UserControl
    {
        ProductsControlController cont;

        public ProductsControl(ProductsControlController cont)
        {
            InitializeComponent();
            this.cont = cont;
            cont.Subscribe((state) =>
            {
                dataGridView.DataSource = state.Products;

                if (state.Products.Count > 0)
                {
                    Utils.wl(state.CurrentIndex);
                    nameTb.Text = state.CurrentProduct.Name;
                    priceTb.Text = state.CurrentProduct.Price.ToString();
                    weightTb.Text = state.CurrentProduct.Weight.ToString();
                }
                else
                {
                    nameTb.Text = "";
                    priceTb.Text = "";
                    weightTb.Text = "";
                }
                Utils.wl("ProductsControlState arrived");
            });
        }

        private void saveCurrentBtn_Click(object sender, EventArgs e)
        {
            cont.UpdateProduct(
                cont.State.CurrentProduct.Id, 
                nameTb.Text, 
                double.Parse(priceTb.Text), 
                double.Parse(weightTb.Text)
                );
        }

        private void addSaveBtn_Click(object sender, EventArgs e)
        {
            cont.AddProduct(
                nameTb.Text,
                double.Parse(priceTb.Text),
                double.Parse(weightTb.Text)
                );
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView.Columns["DeleteBtnCol"].Index)
            {
                cont.RemoveProduct(cont.State.Products[e.RowIndex].Id);
            }
            else
            {
                cont.CurrentIndex = e.RowIndex;
            }
        }

        private void dataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count > 0)
            {
                cont.CurrentIndex = dataGridView.SelectedRows[0].Index;
            }
        }
    }
}
