namespace Invoice
{
    partial class ProductList
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
            this.ProductListLabel = new System.Windows.Forms.Label();
            this.ProductDataView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.ProductDataView)).BeginInit();
            this.SuspendLayout();
            // 
            // ProductListLabel
            // 
            this.ProductListLabel.AutoSize = true;
            this.ProductListLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductListLabel.Location = new System.Drawing.Point(317, 34);
            this.ProductListLabel.Name = "ProductListLabel";
            this.ProductListLabel.Size = new System.Drawing.Size(196, 39);
            this.ProductListLabel.TabIndex = 0;
            this.ProductListLabel.Text = "Product List";
            // 
            // ProductDataView
            // 
            this.ProductDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductDataView.Location = new System.Drawing.Point(58, 98);
            this.ProductDataView.Name = "ProductDataView";
            this.ProductDataView.ReadOnly = true;
            this.ProductDataView.Size = new System.Drawing.Size(692, 310);
            this.ProductDataView.TabIndex = 1;
            // 
            // ProductList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ProductDataView);
            this.Controls.Add(this.ProductListLabel);
            this.Name = "ProductList";
            this.Text = "ItemList";
            ((System.ComponentModel.ISupportInitialize)(this.ProductDataView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ProductListLabel;
        private System.Windows.Forms.DataGridView ProductDataView;
    }
}