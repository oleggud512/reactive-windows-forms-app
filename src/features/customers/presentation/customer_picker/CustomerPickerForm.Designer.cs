using PrOOPz3.src.utils;

namespace PrOOPz3.src.features.customers.presentation.customer_picker
{
    partial class CustomerPickerForm
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
            Utils.wl("Dispose()");
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBox = new System.Windows.Forms.ListBox();
            this.searchTb = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // listBox
            // 
            this.listBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox.DisplayMember = "StringRepr";
            this.listBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.listBox.FormattingEnabled = true;
            this.listBox.IntegralHeight = false;
            this.listBox.ItemHeight = 48;
            this.listBox.Location = new System.Drawing.Point(12, 41);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(328, 238);
            this.listBox.TabIndex = 0;
            this.listBox.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.listBox_DrawItem);
            this.listBox.SelectedIndexChanged += new System.EventHandler(this.listBox_SelectedIndexChanged);
            // 
            // searchTb
            // 
            this.searchTb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchTb.Location = new System.Drawing.Point(12, 12);
            this.searchTb.Name = "searchTb";
            this.searchTb.Size = new System.Drawing.Size(328, 23);
            this.searchTb.TabIndex = 1;
            this.searchTb.TextChanged += new System.EventHandler(this.searchTb_TextChanged);
            // 
            // CustomerPickerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 291);
            this.Controls.Add(this.searchTb);
            this.Controls.Add(this.listBox);
            this.Name = "CustomerPickerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Вибір клієнта";
            this.Load += new System.EventHandler(this.CustomerPickerForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox listBox;
        private TextBox searchTb;
    }
}