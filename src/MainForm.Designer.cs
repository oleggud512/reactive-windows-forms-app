namespace PrOOPz3.src
{
    partial class MainForm
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel2 = new System.Windows.Forms.Panel();
            this.navigationGroup = new System.Windows.Forms.GroupBox();
            this.ordersRb = new System.Windows.Forms.RadioButton();
            this.productsRb = new System.Windows.Forms.RadioButton();
            this.customersRb = new System.Windows.Forms.RadioButton();
            this.contentPanel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.navigationGroup.SuspendLayout();
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
            this.splitContainer1.Panel1.Controls.Add(this.panel2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.contentPanel);
            this.splitContainer1.Size = new System.Drawing.Size(961, 450);
            this.splitContainer1.SplitterDistance = 169;
            this.splitContainer1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.Controls.Add(this.navigationGroup);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(169, 450);
            this.panel2.TabIndex = 0;
            // 
            // navigationGroup
            // 
            this.navigationGroup.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.navigationGroup.Controls.Add(this.ordersRb);
            this.navigationGroup.Controls.Add(this.productsRb);
            this.navigationGroup.Controls.Add(this.customersRb);
            this.navigationGroup.Location = new System.Drawing.Point(12, 12);
            this.navigationGroup.Name = "navigationGroup";
            this.navigationGroup.Size = new System.Drawing.Size(154, 129);
            this.navigationGroup.TabIndex = 0;
            this.navigationGroup.TabStop = false;
            this.navigationGroup.Text = "Сторінки";
            // 
            // ordersRb
            // 
            this.ordersRb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ordersRb.Appearance = System.Windows.Forms.Appearance.Button;
            this.ordersRb.Checked = true;
            this.ordersRb.Location = new System.Drawing.Point(6, 22);
            this.ordersRb.Name = "ordersRb";
            this.ordersRb.Size = new System.Drawing.Size(142, 25);
            this.ordersRb.TabIndex = 3;
            this.ordersRb.TabStop = true;
            this.ordersRb.Text = "Замовлення";
            this.ordersRb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ordersRb.UseVisualStyleBackColor = true;
            this.ordersRb.CheckedChanged += new System.EventHandler(this.pageRb_CheckedChanged);
            // 
            // productsRb
            // 
            this.productsRb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.productsRb.Appearance = System.Windows.Forms.Appearance.Button;
            this.productsRb.Location = new System.Drawing.Point(6, 84);
            this.productsRb.Name = "productsRb";
            this.productsRb.Size = new System.Drawing.Size(142, 25);
            this.productsRb.TabIndex = 2;
            this.productsRb.Text = "Товари";
            this.productsRb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.productsRb.UseVisualStyleBackColor = true;
            this.productsRb.CheckedChanged += new System.EventHandler(this.pageRb_CheckedChanged);
            // 
            // customersRb
            // 
            this.customersRb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.customersRb.Appearance = System.Windows.Forms.Appearance.Button;
            this.customersRb.Location = new System.Drawing.Point(6, 53);
            this.customersRb.Name = "customersRb";
            this.customersRb.Size = new System.Drawing.Size(142, 25);
            this.customersRb.TabIndex = 1;
            this.customersRb.Text = "Клієнти";
            this.customersRb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.customersRb.UseVisualStyleBackColor = true;
            this.customersRb.CheckedChanged += new System.EventHandler(this.pageRb_CheckedChanged);
            // 
            // contentPanel
            // 
            this.contentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contentPanel.Location = new System.Drawing.Point(0, 0);
            this.contentPanel.Name = "contentPanel";
            this.contentPanel.Size = new System.Drawing.Size(788, 450);
            this.contentPanel.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(961, 450);
            this.Controls.Add(this.splitContainer1);
            this.Name = "MainForm";
            this.Text = "Практика. Завдання 3";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.navigationGroup.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private SplitContainer splitContainer1;
        private Panel panel2;
        private GroupBox navigationGroup;
        private RadioButton ordersRb;
        private RadioButton productsRb;
        private RadioButton customersRb;
        private Panel contentPanel;
    }
}