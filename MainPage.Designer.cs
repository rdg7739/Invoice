namespace Invoice
{
    partial class MainPage
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
            this.createOrderBtn = new System.Windows.Forms.Button();
            this.Title = new System.Windows.Forms.Label();
            this.OrderListBtn = new System.Windows.Forms.Button();
            this.DeliveryScheduleBtn = new System.Windows.Forms.Button();
            this.ProductListBtn = new System.Windows.Forms.Button();
            this.StoreListBtn = new System.Windows.Forms.Button();
            this.CreateStoreBtn = new System.Windows.Forms.Button();
            this.MyStoreBtn = new System.Windows.Forms.Button();
            this.CreatProductBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // createOrderBtn
            // 
            this.createOrderBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.createOrderBtn.Location = new System.Drawing.Point(90, 116);
            this.createOrderBtn.Name = "createOrderBtn";
            this.createOrderBtn.Size = new System.Drawing.Size(200, 40);
            this.createOrderBtn.TabIndex = 0;
            this.createOrderBtn.Text = "Create Order";
            this.createOrderBtn.UseVisualStyleBackColor = true;
            this.createOrderBtn.Click += new System.EventHandler(this.CreateStore_Click);
            // 
            // Title
            // 
            this.Title.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.Location = new System.Drawing.Point(200, 50);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(200, 40);
            this.Title.TabIndex = 1;
            this.Title.Text = "Invoice";
            this.Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // OrderListBtn
            // 
            this.OrderListBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderListBtn.Location = new System.Drawing.Point(310, 116);
            this.OrderListBtn.Name = "OrderListBtn";
            this.OrderListBtn.Size = new System.Drawing.Size(200, 40);
            this.OrderListBtn.TabIndex = 2;
            this.OrderListBtn.Text = "Order List";
            this.OrderListBtn.UseVisualStyleBackColor = true;
            this.OrderListBtn.Click += new System.EventHandler(this.OrderListBtn_Click);
            // 
            // DeliveryScheduleBtn
            // 
            this.DeliveryScheduleBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeliveryScheduleBtn.Location = new System.Drawing.Point(90, 216);
            this.DeliveryScheduleBtn.Name = "DeliveryScheduleBtn";
            this.DeliveryScheduleBtn.Size = new System.Drawing.Size(200, 40);
            this.DeliveryScheduleBtn.TabIndex = 3;
            this.DeliveryScheduleBtn.Text = "Delivery Schedule";
            this.DeliveryScheduleBtn.UseVisualStyleBackColor = true;
            this.DeliveryScheduleBtn.Click += new System.EventHandler(this.DeliveryScheduleBtn_Click);
            // 
            // ProductListBtn
            // 
            this.ProductListBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductListBtn.Location = new System.Drawing.Point(90, 266);
            this.ProductListBtn.Name = "ProductListBtn";
            this.ProductListBtn.Size = new System.Drawing.Size(200, 40);
            this.ProductListBtn.TabIndex = 4;
            this.ProductListBtn.Text = "Product List";
            this.ProductListBtn.UseVisualStyleBackColor = true;
            this.ProductListBtn.Click += new System.EventHandler(this.ItemListBtn_Click);
            // 
            // StoreListBtn
            // 
            this.StoreListBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StoreListBtn.Location = new System.Drawing.Point(310, 166);
            this.StoreListBtn.Name = "StoreListBtn";
            this.StoreListBtn.Size = new System.Drawing.Size(200, 40);
            this.StoreListBtn.TabIndex = 5;
            this.StoreListBtn.Text = "Store List";
            this.StoreListBtn.UseVisualStyleBackColor = true;
            this.StoreListBtn.Click += new System.EventHandler(this.StoreListBtn_Click);
            // 
            // CreateStoreBtn
            // 
            this.CreateStoreBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateStoreBtn.Location = new System.Drawing.Point(90, 166);
            this.CreateStoreBtn.Name = "CreateStoreBtn";
            this.CreateStoreBtn.Size = new System.Drawing.Size(200, 40);
            this.CreateStoreBtn.TabIndex = 6;
            this.CreateStoreBtn.Text = "Create Store";
            this.CreateStoreBtn.UseVisualStyleBackColor = true;
            this.CreateStoreBtn.Click += new System.EventHandler(this.CreateStoreBtn_Click);
            // 
            // MyStoreBtn
            // 
            this.MyStoreBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MyStoreBtn.Location = new System.Drawing.Point(310, 216);
            this.MyStoreBtn.Name = "MyStoreBtn";
            this.MyStoreBtn.Size = new System.Drawing.Size(200, 40);
            this.MyStoreBtn.TabIndex = 7;
            this.MyStoreBtn.Text = "My Store";
            this.MyStoreBtn.UseVisualStyleBackColor = true;
            this.MyStoreBtn.Click += new System.EventHandler(this.MyStoreBtn_Click);
            // 
            // CreatProductBtn
            // 
            this.CreatProductBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreatProductBtn.Location = new System.Drawing.Point(310, 266);
            this.CreatProductBtn.Name = "CreatProductBtn";
            this.CreatProductBtn.Size = new System.Drawing.Size(200, 40);
            this.CreatProductBtn.TabIndex = 8;
            this.CreatProductBtn.Text = "Create Product";
            this.CreatProductBtn.UseVisualStyleBackColor = true;
            this.CreatProductBtn.Click += new System.EventHandler(this.CreatItemBtn_Click);
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.CreatProductBtn);
            this.Controls.Add(this.MyStoreBtn);
            this.Controls.Add(this.CreateStoreBtn);
            this.Controls.Add(this.StoreListBtn);
            this.Controls.Add(this.ProductListBtn);
            this.Controls.Add(this.DeliveryScheduleBtn);
            this.Controls.Add(this.OrderListBtn);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.createOrderBtn);
            this.Name = "MainPage";
            this.Text = "n";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button createOrderBtn;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Button OrderListBtn;
        private System.Windows.Forms.Button DeliveryScheduleBtn;
        private System.Windows.Forms.Button ProductListBtn;
        private System.Windows.Forms.Button StoreListBtn;
        private System.Windows.Forms.Button CreateStoreBtn;
        private System.Windows.Forms.Button MyStoreBtn;
        private System.Windows.Forms.Button CreatProductBtn;
    }
}

