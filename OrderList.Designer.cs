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
            ((System.ComponentModel.ISupportInitialize)(this.OrderListView)).BeginInit();
            this.SuspendLayout();
            // 
            // OrderListLbl
            // 
            this.OrderListLbl.AutoSize = true;
            this.OrderListLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderListLbl.Location = new System.Drawing.Point(299, 54);
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
            this.OrderListView.Location = new System.Drawing.Point(48, 119);
            this.OrderListView.Name = "OrderListView";
            this.OrderListView.ReadOnly = true;
            this.OrderListView.Size = new System.Drawing.Size(696, 400);
            this.OrderListView.TabIndex = 1;
            // 
            // OrderList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
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
    }
}