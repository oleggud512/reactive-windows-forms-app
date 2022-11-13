namespace PrOOPz3.src.features.customers.presentation
{
    partial class CustomersControl
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.addNewBtn = new System.Windows.Forms.Button();
            this.saveCurrentBtn = new System.Windows.Forms.Button();
            this.addressTb = new System.Windows.Forms.TextBox();
            this.phoneTb = new System.Windows.Forms.TextBox();
            this.nameTb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.todayCb = new System.Windows.Forms.CheckBox();
            this.customersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeleteBtnCol = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).BeginInit();
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
            this.splitContainer1.Panel2.Controls.Add(this.groupBox1);
            this.splitContainer1.Size = new System.Drawing.Size(782, 451);
            this.splitContainer1.SplitterDistance = 524;
            this.splitContainer1.TabIndex = 0;
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.DeleteBtnCol});
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
            // groupBox2
            // 
            this.groupBox2.AutoSize = true;
            this.groupBox2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox2.Controls.Add(this.addNewBtn);
            this.groupBox2.Controls.Add(this.saveCurrentBtn);
            this.groupBox2.Controls.Add(this.addressTb);
            this.groupBox2.Controls.Add(this.phoneTb);
            this.groupBox2.Controls.Add(this.nameTb);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(9, 86);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(176, 183);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Додати";
            // 
            // addNewBtn
            // 
            this.addNewBtn.Location = new System.Drawing.Point(70, 138);
            this.addNewBtn.Name = "addNewBtn";
            this.addNewBtn.Size = new System.Drawing.Size(100, 23);
            this.addNewBtn.TabIndex = 7;
            this.addNewBtn.Text = "Додати нового";
            this.addNewBtn.UseVisualStyleBackColor = true;
            this.addNewBtn.Click += new System.EventHandler(this.addNewBtn_Click);
            // 
            // saveCurrentBtn
            // 
            this.saveCurrentBtn.Location = new System.Drawing.Point(70, 109);
            this.saveCurrentBtn.Name = "saveCurrentBtn";
            this.saveCurrentBtn.Size = new System.Drawing.Size(100, 23);
            this.saveCurrentBtn.TabIndex = 6;
            this.saveCurrentBtn.Text = "Зберегти";
            this.saveCurrentBtn.UseVisualStyleBackColor = true;
            this.saveCurrentBtn.Click += new System.EventHandler(this.saveCurrentBtn_Click);
            // 
            // addressTb
            // 
            this.addressTb.Location = new System.Drawing.Point(70, 80);
            this.addressTb.Name = "addressTb";
            this.addressTb.Size = new System.Drawing.Size(100, 23);
            this.addressTb.TabIndex = 5;
            // 
            // phoneTb
            // 
            this.phoneTb.Location = new System.Drawing.Point(70, 51);
            this.phoneTb.Name = "phoneTb";
            this.phoneTb.Size = new System.Drawing.Size(100, 23);
            this.phoneTb.TabIndex = 4;
            // 
            // nameTb
            // 
            this.nameTb.Location = new System.Drawing.Point(70, 22);
            this.nameTb.Name = "nameTb";
            this.nameTb.Size = new System.Drawing.Size(100, 23);
            this.nameTb.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Адреса";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Телефон";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ім\'я";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.AutoSize = true;
            this.groupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox1.Controls.Add(this.todayCb);
            this.groupBox1.Location = new System.Drawing.Point(9, 10);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.groupBox1.Size = new System.Drawing.Size(204, 63);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Фільтр";
            // 
            // todayCb
            // 
            this.todayCb.AutoSize = true;
            this.todayCb.Location = new System.Drawing.Point(13, 22);
            this.todayCb.Name = "todayCb";
            this.todayCb.Size = new System.Drawing.Size(178, 19);
            this.todayCb.TabIndex = 0;
            this.todayCb.Text = "Тільки сьогоднішні покупці";
            this.todayCb.UseVisualStyleBackColor = true;
            this.todayCb.CheckedChanged += new System.EventHandler(this.todayCb_CheckedChanged);
            // 
            // customersBindingSource
            // 
            this.customersBindingSource.DataSource = typeof(PrOOPz3.src.features.customers.domain.Customer);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Ім\'я";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "Phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "Телефон";
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            this.phoneDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Адреса";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            this.addressDataGridViewTextBoxColumn.ReadOnly = true;
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
            // CustomersControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Name = "CustomersControl";
            this.Size = new System.Drawing.Size(782, 451);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private SplitContainer splitContainer1;
        private DataGridView dataGridView;
        private CheckBox todayCb;
        private GroupBox groupBox2;
        private Button saveCurrentBtn;
        private TextBox addressTb;
        private TextBox phoneTb;
        private TextBox nameTb;
        private Label label3;
        private Label label2;
        private Label label1;
        private GroupBox groupBox1;
        private BindingSource customersBindingSource;
        private Button addNewBtn;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private DataGridViewButtonColumn DeleteBtnCol;
    }
}
