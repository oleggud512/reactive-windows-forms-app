namespace PrOOPz3.src.features.products.presentation
{
    partial class ProductsControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.IdCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PriceCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WeightCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeleteBtnCol = new System.Windows.Forms.DataGridViewButtonColumn();
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.saveCurrentBtn = new System.Windows.Forms.Button();
            this.addSaveBtn = new System.Windows.Forms.Button();
            this.weightTb = new System.Windows.Forms.TextBox();
            this.priceTb = new System.Windows.Forms.TextBox();
            this.nameTb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dataGridView);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox2);
            this.splitContainer1.Size = new System.Drawing.Size(782, 451);
            this.splitContainer1.SplitterDistance = 524;
            this.splitContainer1.TabIndex = 0;
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AutoGenerateColumns = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdCol,
            this.NameCol,
            this.PriceCol,
            this.WeightCol,
            this.DeleteBtnCol});
            this.dataGridView.DataSource = this.productsBindingSource;
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView.Location = new System.Drawing.Point(0, 0);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowTemplate.Height = 25;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(524, 451);
            this.dataGridView.TabIndex = 0;
            this.dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellClick);
            this.dataGridView.SelectionChanged += new System.EventHandler(this.dataGridView_SelectionChanged);
            // 
            // IdCol
            // 
            this.IdCol.DataPropertyName = "Id";
            this.IdCol.HeaderText = "Id";
            this.IdCol.Name = "IdCol";
            this.IdCol.ReadOnly = true;
            // 
            // NameCol
            // 
            this.NameCol.DataPropertyName = "Name";
            this.NameCol.HeaderText = "Назава";
            this.NameCol.Name = "NameCol";
            this.NameCol.ReadOnly = true;
            // 
            // PriceCol
            // 
            this.PriceCol.DataPropertyName = "Price";
            this.PriceCol.HeaderText = "Ціна";
            this.PriceCol.Name = "PriceCol";
            this.PriceCol.ReadOnly = true;
            // 
            // WeightCol
            // 
            this.WeightCol.DataPropertyName = "Weight";
            this.WeightCol.HeaderText = "Вага";
            this.WeightCol.Name = "WeightCol";
            this.WeightCol.ReadOnly = true;
            // 
            // DeleteBtnCol
            // 
            this.DeleteBtnCol.HeaderText = "Видалити";
            this.DeleteBtnCol.Name = "DeleteBtnCol";
            this.DeleteBtnCol.ReadOnly = true;
            this.DeleteBtnCol.Text = "Видалити";
            this.DeleteBtnCol.ToolTipText = "Видалити";
            this.DeleteBtnCol.UseColumnTextForButtonValue = true;
            // 
            // productsBindingSource
            // 
            this.productsBindingSource.DataSource = typeof(PrOOPz3.src.features.products.domain.Product);
            // 
            // groupBox2
            // 
            this.groupBox2.AutoSize = true;
            this.groupBox2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox2.Controls.Add(this.saveCurrentBtn);
            this.groupBox2.Controls.Add(this.addSaveBtn);
            this.groupBox2.Controls.Add(this.weightTb);
            this.groupBox2.Controls.Add(this.priceTb);
            this.groupBox2.Controls.Add(this.nameTb);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(157, 181);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Додати";
            // 
            // saveCurrentBtn
            // 
            this.saveCurrentBtn.Location = new System.Drawing.Point(51, 109);
            this.saveCurrentBtn.Name = "saveCurrentBtn";
            this.saveCurrentBtn.Size = new System.Drawing.Size(100, 23);
            this.saveCurrentBtn.TabIndex = 7;
            this.saveCurrentBtn.Text = "Зберегти зміни";
            this.saveCurrentBtn.UseVisualStyleBackColor = true;
            this.saveCurrentBtn.Click += new System.EventHandler(this.saveCurrentBtn_Click);
            // 
            // addSaveBtn
            // 
            this.addSaveBtn.Location = new System.Drawing.Point(51, 136);
            this.addSaveBtn.Name = "addSaveBtn";
            this.addSaveBtn.Size = new System.Drawing.Size(100, 23);
            this.addSaveBtn.TabIndex = 6;
            this.addSaveBtn.Text = "Додати новий";
            this.addSaveBtn.UseVisualStyleBackColor = true;
            this.addSaveBtn.Click += new System.EventHandler(this.addSaveBtn_Click);
            // 
            // weightTb
            // 
            this.weightTb.Location = new System.Drawing.Point(51, 80);
            this.weightTb.Name = "weightTb";
            this.weightTb.Size = new System.Drawing.Size(100, 23);
            this.weightTb.TabIndex = 5;
            // 
            // priceTb
            // 
            this.priceTb.Location = new System.Drawing.Point(51, 51);
            this.priceTb.Name = "priceTb";
            this.priceTb.Size = new System.Drawing.Size(100, 23);
            this.priceTb.TabIndex = 4;
            // 
            // nameTb
            // 
            this.nameTb.Location = new System.Drawing.Point(51, 22);
            this.nameTb.Name = "nameTb";
            this.nameTb.Size = new System.Drawing.Size(100, 23);
            this.nameTb.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Вага";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ціна";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Назва";
            // 
            // ProductsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Name = "ProductsControl";
            this.Size = new System.Drawing.Size(782, 451);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private SplitContainer splitContainer1;
        private DataGridView dataGridView;
        private GroupBox groupBox2;
        private Button addSaveBtn;
        private TextBox weightTb;
        private TextBox priceTb;
        private TextBox nameTb;
        private Label label3;
        private Label label2;
        private Label label1;
        private BindingSource productsBindingSource;
        private Button saveCurrentBtn;
        private DataGridViewTextBoxColumn IdCol;
        private DataGridViewTextBoxColumn NameCol;
        private DataGridViewTextBoxColumn PriceCol;
        private DataGridViewTextBoxColumn WeightCol;
        private DataGridViewButtonColumn DeleteBtnCol;
    }
}
