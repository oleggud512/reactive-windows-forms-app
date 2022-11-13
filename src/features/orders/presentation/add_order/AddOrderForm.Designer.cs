namespace PrOOPz3.src.features.orders.presentation.add_order
{
    partial class AddOrderForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.ordersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productsDataGridView = new System.Windows.Forms.DataGridView();
            this.ProductCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AmountCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productOptionsMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchProductsTb = new System.Windows.Forms.TextBox();
            this.productsListBox = new System.Windows.Forms.ListBox();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.chooseCustomerBtn = new System.Windows.Forms.Button();
            this.productsPickerSplitCont = new System.Windows.Forms.SplitContainer();
            this.lbl = new System.Windows.Forms.Label();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.customerLbl = new System.Windows.Forms.Label();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.submitBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsDataGridView)).BeginInit();
            this.productOptionsMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsPickerSplitCont)).BeginInit();
            this.productsPickerSplitCont.Panel1.SuspendLayout();
            this.productsPickerSplitCont.Panel2.SuspendLayout();
            this.productsPickerSplitCont.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // ordersBindingSource
            // 
            this.ordersBindingSource.DataSource = typeof(PrOOPz3.src.features.orders.domain.Order);
            // 
            // productsDataGridView
            // 
            this.productsDataGridView.AllowUserToAddRows = false;
            this.productsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductCol,
            this.AmountCol});
            this.productsDataGridView.ContextMenuStrip = this.productOptionsMenuStrip;
            this.productsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.productsDataGridView.Location = new System.Drawing.Point(0, 0);
            this.productsDataGridView.Margin = new System.Windows.Forms.Padding(0);
            this.productsDataGridView.MultiSelect = false;
            this.productsDataGridView.Name = "productsDataGridView";
            this.productsDataGridView.RowTemplate.Height = 25;
            this.productsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.productsDataGridView.Size = new System.Drawing.Size(247, 241);
            this.productsDataGridView.TabIndex = 0;
            // 
            // ProductCol
            // 
            this.ProductCol.DataPropertyName = "ProductName";
            this.ProductCol.HeaderText = "Товар";
            this.ProductCol.Name = "ProductCol";
            this.ProductCol.ReadOnly = true;
            // 
            // AmountCol
            // 
            this.AmountCol.DataPropertyName = "Amount";
            this.AmountCol.HeaderText = "Кількість";
            this.AmountCol.Name = "AmountCol";
            // 
            // productOptionsMenuStrip
            // 
            this.productOptionsMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteToolStripMenuItem});
            this.productOptionsMenuStrip.Name = "productOptionsMenuStrip";
            this.productOptionsMenuStrip.Size = new System.Drawing.Size(108, 26);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // searchProductsTb
            // 
            this.searchProductsTb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchProductsTb.Location = new System.Drawing.Point(0, 0);
            this.searchProductsTb.Margin = new System.Windows.Forms.Padding(0);
            this.searchProductsTb.Name = "searchProductsTb";
            this.searchProductsTb.Size = new System.Drawing.Size(236, 23);
            this.searchProductsTb.TabIndex = 1;
            this.searchProductsTb.TextChanged += new System.EventHandler(this.searchProductsTb_TextChanged);
            // 
            // productsListBox
            // 
            this.productsListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.productsListBox.DataSource = this.productBindingSource;
            this.productsListBox.DisplayMember = "Name";
            this.productsListBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.productsListBox.FormattingEnabled = true;
            this.productsListBox.IntegralHeight = false;
            this.productsListBox.ItemHeight = 30;
            this.productsListBox.Location = new System.Drawing.Point(0, 33);
            this.productsListBox.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.productsListBox.Name = "productsListBox";
            this.productsListBox.Size = new System.Drawing.Size(236, 192);
            this.productsListBox.TabIndex = 2;
            this.productsListBox.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.productsListBox_DrawItem);
            this.productsListBox.MeasureItem += new System.Windows.Forms.MeasureItemEventHandler(this.productsListBox_MeasureItem);
            this.productsListBox.SelectedIndexChanged += new System.EventHandler(this.productsListBox_SelectedIndexChanged);
            this.productsListBox.Leave += new System.EventHandler(this.productsListBox_Leave);
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataSource = typeof(PrOOPz3.src.features.products.domain.Product);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Дата";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePicker1.Location = new System.Drawing.Point(56, 35);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(290, 23);
            this.dateTimePicker1.TabIndex = 5;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // chooseCustomerBtn
            // 
            this.chooseCustomerBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chooseCustomerBtn.Location = new System.Drawing.Point(352, 64);
            this.chooseCustomerBtn.Name = "chooseCustomerBtn";
            this.chooseCustomerBtn.Size = new System.Drawing.Size(132, 23);
            this.chooseCustomerBtn.TabIndex = 6;
            this.chooseCustomerBtn.Text = "Обрати клієнта";
            this.chooseCustomerBtn.UseVisualStyleBackColor = true;
            this.chooseCustomerBtn.Click += new System.EventHandler(this.chooseCustomerBtn_Click);
            // 
            // productsPickerSplitCont
            // 
            this.productsPickerSplitCont.Dock = System.Windows.Forms.DockStyle.Fill;
            this.productsPickerSplitCont.Location = new System.Drawing.Point(0, 0);
            this.productsPickerSplitCont.Name = "productsPickerSplitCont";
            // 
            // productsPickerSplitCont.Panel1
            // 
            this.productsPickerSplitCont.Panel1.Controls.Add(this.productsDataGridView);
            // 
            // productsPickerSplitCont.Panel2
            // 
            this.productsPickerSplitCont.Panel2.Controls.Add(this.searchProductsTb);
            this.productsPickerSplitCont.Panel2.Controls.Add(this.productsListBox);
            this.productsPickerSplitCont.Size = new System.Drawing.Size(487, 241);
            this.productsPickerSplitCont.SplitterDistance = 247;
            this.productsPickerSplitCont.TabIndex = 7;
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(8, 67);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(42, 15);
            this.lbl.TabIndex = 8;
            this.lbl.Text = "Клієнт";
            // 
            // splitContainer
            // 
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.Location = new System.Drawing.Point(10, 10);
            this.splitContainer.Name = "splitContainer";
            this.splitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.customerLbl);
            this.splitContainer.Panel1.Controls.Add(this.deleteBtn);
            this.splitContainer.Panel1.Controls.Add(this.submitBtn);
            this.splitContainer.Panel1.Controls.Add(this.dateTimePicker1);
            this.splitContainer.Panel1.Controls.Add(this.chooseCustomerBtn);
            this.splitContainer.Panel1.Controls.Add(this.label1);
            this.splitContainer.Panel1.Controls.Add(this.lbl);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.productsPickerSplitCont);
            this.splitContainer.Size = new System.Drawing.Size(487, 361);
            this.splitContainer.SplitterDistance = 116;
            this.splitContainer.TabIndex = 10;
            // 
            // customerLbl
            // 
            this.customerLbl.AutoSize = true;
            this.customerLbl.Location = new System.Drawing.Point(56, 67);
            this.customerLbl.Name = "customerLbl";
            this.customerLbl.Size = new System.Drawing.Size(0, 15);
            this.customerLbl.TabIndex = 12;
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(352, 6);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(132, 23);
            this.deleteBtn.TabIndex = 11;
            this.deleteBtn.Text = "Видалити";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // submitBtn
            // 
            this.submitBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.submitBtn.Location = new System.Drawing.Point(56, 6);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(290, 23);
            this.submitBtn.TabIndex = 10;
            this.submitBtn.Text = "Зберегти зміни/Готово";
            this.submitBtn.UseVisualStyleBackColor = true;
            this.submitBtn.Click += new System.EventHandler(this.submitBtn_Click);
            // 
            // AddOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 381);
            this.Controls.Add(this.splitContainer);
            this.MinimumSize = new System.Drawing.Size(460, 420);
            this.Name = "AddOrderForm";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AddOrderForm";
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsDataGridView)).EndInit();
            this.productOptionsMenuStrip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            this.productsPickerSplitCont.Panel1.ResumeLayout(false);
            this.productsPickerSplitCont.Panel2.ResumeLayout(false);
            this.productsPickerSplitCont.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productsPickerSplitCont)).EndInit();
            this.productsPickerSplitCont.ResumeLayout(false);
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel1.PerformLayout();
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private BindingSource ordersBindingSource;
        private DataGridView productsDataGridView;
        private TextBox searchProductsTb;
        private ListBox productsListBox;
        private Label label1;
        private DateTimePicker dateTimePicker1;
        private Button chooseCustomerBtn;
        private SplitContainer productsPickerSplitCont;
        private Label lbl;
        private SplitContainer splitContainer;
        private Button submitBtn;
        private DataGridViewTextBoxColumn ProductCol;
        private DataGridViewTextBoxColumn AmountCol;
        private BindingSource productBindingSource;
        private Button deleteBtn;
        private ContextMenuStrip productOptionsMenuStrip;
        private ToolStripMenuItem deleteToolStripMenuItem;
        private Label customerLbl;
    }
}