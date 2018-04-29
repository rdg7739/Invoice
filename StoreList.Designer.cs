namespace Invoice
{
    partial class StoreList
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
            this.label1 = new System.Windows.Forms.Label();
            this.StoreDataView = new System.Windows.Forms.DataGridView();
            this.ShowMarketCheckBox = new System.Windows.Forms.CheckBox();
            this.ShowCustomerCheckBox = new System.Windows.Forms.CheckBox();
            this.ListOptionLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.StoreDataView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Store List";
            // 
            // StoreDataView
            // 
            this.StoreDataView.AllowUserToAddRows = false;
            this.StoreDataView.AllowUserToDeleteRows = false;
            this.StoreDataView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.StoreDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StoreDataView.Location = new System.Drawing.Point(39, 103);
            this.StoreDataView.Name = "StoreDataView";
            this.StoreDataView.ReadOnly = true;
            this.StoreDataView.Size = new System.Drawing.Size(718, 416);
            this.StoreDataView.TabIndex = 1;
            // 
            // ShowMarketCheckBox
            // 
            this.ShowMarketCheckBox.AutoSize = true;
            this.ShowMarketCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ShowMarketCheckBox.Location = new System.Drawing.Point(485, 63);
            this.ShowMarketCheckBox.Name = "ShowMarketCheckBox";
            this.ShowMarketCheckBox.Size = new System.Drawing.Size(121, 24);
            this.ShowMarketCheckBox.TabIndex = 2;
            this.ShowMarketCheckBox.Text = "Show Market";
            this.ShowMarketCheckBox.UseVisualStyleBackColor = true;
            this.ShowMarketCheckBox.CheckedChanged += new System.EventHandler(this.ShowOptionCheckBox_CheckedChanged);
            // 
            // ShowCustomerCheckBox
            // 
            this.ShowCustomerCheckBox.AutoSize = true;
            this.ShowCustomerCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ShowCustomerCheckBox.Location = new System.Drawing.Point(616, 63);
            this.ShowCustomerCheckBox.Name = "ShowCustomerCheckBox";
            this.ShowCustomerCheckBox.Size = new System.Drawing.Size(141, 24);
            this.ShowCustomerCheckBox.TabIndex = 3;
            this.ShowCustomerCheckBox.Text = "Show Customer";
            this.ShowCustomerCheckBox.UseVisualStyleBackColor = true;
            this.ShowCustomerCheckBox.CheckedChanged += new System.EventHandler(this.ShowOptionCheckBox_CheckedChanged);

            // 
            // ListOptionLbl
            // 
            this.ListOptionLbl.AutoSize = true;
            this.ListOptionLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ListOptionLbl.Location = new System.Drawing.Point(386, 64);
            this.ListOptionLbl.Name = "ListOptionLbl";
            this.ListOptionLbl.Size = new System.Drawing.Size(93, 20);
            this.ListOptionLbl.TabIndex = 4;
            this.ListOptionLbl.Text = "List Option: ";
            // 
            // StoreList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.ListOptionLbl);
            this.Controls.Add(this.ShowCustomerCheckBox);
            this.Controls.Add(this.ShowMarketCheckBox);
            this.Controls.Add(this.StoreDataView);
            this.Controls.Add(this.label1);
            this.Name = "StoreList";
            this.Text = "CustomerList";
            ((System.ComponentModel.ISupportInitialize)(this.StoreDataView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView StoreDataView;
        private System.Windows.Forms.CheckBox ShowMarketCheckBox;
        private System.Windows.Forms.CheckBox ShowCustomerCheckBox;
        private System.Windows.Forms.Label ListOptionLbl;
    }
}