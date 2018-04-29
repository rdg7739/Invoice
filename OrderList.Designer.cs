namespace Invoice
{
    partial class OrderList
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
            this.OrderListLbl = new System.Windows.Forms.Label();
            this.OrderListView = new System.Windows.Forms.DataGridView();
            this.BuyCheckBox = new System.Windows.Forms.CheckBox();
            this.SellCheckBox = new System.Windows.Forms.CheckBox();
            this.OptionLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.OrderListView)).BeginInit();
            this.SuspendLayout();
            // 
            // OrderListLbl
            // 
            this.OrderListLbl.AutoSize = true;
            this.OrderListLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderListLbl.Location = new System.Drawing.Point(53, 56);
            this.OrderListLbl.Name = "OrderListLbl";
            this.OrderListLbl.Size = new System.Drawing.Size(165, 39);
            this.OrderListLbl.TabIndex = 0;
            this.OrderListLbl.Text = "Order List";
            // 
            // OrderListView
            // 
            this.OrderListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OrderListView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrderListView.Location = new System.Drawing.Point(48, 113);
            this.OrderListView.Name = "OrderListView";
            this.OrderListView.ReadOnly = true;
            this.OrderListView.Size = new System.Drawing.Size(696, 406);
            this.OrderListView.TabIndex = 1;
            // 
            // BuyCheckBox
            // 
            this.BuyCheckBox.AutoSize = true;
            this.BuyCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.BuyCheckBox.Location = new System.Drawing.Point(461, 70);
            this.BuyCheckBox.Name = "BuyCheckBox";
            this.BuyCheckBox.Size = new System.Drawing.Size(128, 24);
            this.BuyCheckBox.TabIndex = 2;
            this.BuyCheckBox.Text = "Buy Order List";
            this.BuyCheckBox.UseVisualStyleBackColor = true;
            this.BuyCheckBox.CheckedChanged += new System.EventHandler(this.OptionCheckBox_CheckedChanged);
            // 
            // SellCheckBox
            // 
            this.SellCheckBox.AutoSize = true;
            this.SellCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.SellCheckBox.Location = new System.Drawing.Point(617, 70);
            this.SellCheckBox.Name = "SellCheckBox";
            this.SellCheckBox.Size = new System.Drawing.Size(127, 24);
            this.SellCheckBox.TabIndex = 3;
            this.SellCheckBox.Text = "Sell Order List";
            this.SellCheckBox.UseVisualStyleBackColor = true;
            this.SellCheckBox.CheckedChanged += new System.EventHandler(this.OptionCheckBox_CheckedChanged);

            // 
            // OptionLbl
            // 
            this.OptionLbl.AutoSize = true;
            this.OptionLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.OptionLbl.Location = new System.Drawing.Point(347, 70);
            this.OptionLbl.Name = "OptionLbl";
            this.OptionLbl.Size = new System.Drawing.Size(108, 20);
            this.OptionLbl.TabIndex = 4;
            this.OptionLbl.Text = "Order Option: ";
            // 
            // OrderList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.OptionLbl);
            this.Controls.Add(this.SellCheckBox);
            this.Controls.Add(this.BuyCheckBox);
            this.Controls.Add(this.OrderListView);
            this.Controls.Add(this.OrderListLbl);
            this.Name = "OrderList";
            this.Text = "OrderList";
            ((System.ComponentModel.ISupportInitialize)(this.OrderListView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label OrderListLbl;
        private System.Windows.Forms.DataGridView OrderListView;
        private System.Windows.Forms.CheckBox BuyCheckBox;
        private System.Windows.Forms.CheckBox SellCheckBox;
        private System.Windows.Forms.Label OptionLbl;
    }
}