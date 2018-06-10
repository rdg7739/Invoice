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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPage));
            this.Title = new System.Windows.Forms.Label();
            this.titlePanel = new System.Windows.Forms.Panel();
            this.closeBtn = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.WeeklyExpenseBtn = new Invoice.ButtonModified();
            this.WeeklySaleBtn = new Invoice.ButtonModified();
            this.MyStoreBtn = new Invoice.ButtonModified();
            this.StoreListBtn = new Invoice.ButtonModified();
            this.ProductListBtn = new Invoice.ButtonModified();
            this.DeliveryScheduleBtn = new Invoice.ButtonModified();
            this.OrderListBtn = new Invoice.ButtonModified();
            this.createOrderBtn = new Invoice.ButtonModified();
            this.CatagoryBtn = new Invoice.ButtonModified();
            this.titlePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Title.Font = new System.Drawing.Font("Arial", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Title.Location = new System.Drawing.Point(201, 18);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(203, 60);
            this.Title.TabIndex = 1;
            this.Title.Text = "Invoice";
            this.Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Title.MouseMove += new System.Windows.Forms.MouseEventHandler(this.DragTitlePanel);
            // 
            // titlePanel
            // 
            this.titlePanel.BackColor = System.Drawing.Color.SteelBlue;
            this.titlePanel.Controls.Add(this.closeBtn);
            this.titlePanel.Controls.Add(this.pictureBox2);
            this.titlePanel.Controls.Add(this.pictureBox1);
            this.titlePanel.Controls.Add(this.Title);
            this.titlePanel.Location = new System.Drawing.Point(1, 1);
            this.titlePanel.Name = "titlePanel";
            this.titlePanel.Size = new System.Drawing.Size(582, 91);
            this.titlePanel.TabIndex = 11;
            this.titlePanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.DragTitlePanel);
            
            // 
            // closeBtn
            // 
            this.closeBtn.Location = new System.Drawing.Point(561, 3);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(20, 20);
            this.closeBtn.TabIndex = 4;
            this.closeBtn.Text = "X";
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(182, 39);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(29, 32);
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.DragTitlePanel);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(147, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(57, 55);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.DragTitlePanel);
            // 
            // WeeklyExpenseBtn
            // 
            this.WeeklyExpenseBtn.BackColor = System.Drawing.Color.White;
            this.WeeklyExpenseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.WeeklyExpenseBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WeeklyExpenseBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.WeeklyExpenseBtn.Location = new System.Drawing.Point(318, 265);
            this.WeeklyExpenseBtn.Name = "WeeklyExpenseBtn";
            this.WeeklyExpenseBtn.Size = new System.Drawing.Size(200, 40);
            this.WeeklyExpenseBtn.TabIndex = 10;
            this.WeeklyExpenseBtn.Text = "Weekly Expense";
            this.WeeklyExpenseBtn.UseVisualStyleBackColor = true;
            this.WeeklyExpenseBtn.Click += new System.EventHandler(this.WeeklyExpenseBtn_Click);
            // 
            // WeeklySaleBtn
            // 
            this.WeeklySaleBtn.BackColor = System.Drawing.Color.White;
            this.WeeklySaleBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.WeeklySaleBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WeeklySaleBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.WeeklySaleBtn.Location = new System.Drawing.Point(80, 265);
            this.WeeklySaleBtn.Name = "WeeklySaleBtn";
            this.WeeklySaleBtn.Size = new System.Drawing.Size(200, 40);
            this.WeeklySaleBtn.TabIndex = 9;
            this.WeeklySaleBtn.Text = "Weekly Sale";
            this.WeeklySaleBtn.UseVisualStyleBackColor = true;
            this.WeeklySaleBtn.Click += new System.EventHandler(this.WeeklySaleBtn_Click);
            // 
            // MyStoreBtn
            // 
            this.MyStoreBtn.BackColor = System.Drawing.Color.White;
            this.MyStoreBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MyStoreBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MyStoreBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.MyStoreBtn.Location = new System.Drawing.Point(318, 216);
            this.MyStoreBtn.Name = "MyStoreBtn";
            this.MyStoreBtn.Size = new System.Drawing.Size(200, 40);
            this.MyStoreBtn.TabIndex = 7;
            this.MyStoreBtn.Text = "My Store";
            this.MyStoreBtn.UseVisualStyleBackColor = true;
            this.MyStoreBtn.Click += new System.EventHandler(this.MyStoreBtn_Click);
            // 
            // StoreListBtn
            // 
            this.StoreListBtn.BackColor = System.Drawing.Color.White;
            this.StoreListBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StoreListBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StoreListBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.StoreListBtn.Location = new System.Drawing.Point(318, 166);
            this.StoreListBtn.Name = "StoreListBtn";
            this.StoreListBtn.Size = new System.Drawing.Size(200, 40);
            this.StoreListBtn.TabIndex = 5;
            this.StoreListBtn.Text = "Store List";
            this.StoreListBtn.UseVisualStyleBackColor = true;
            this.StoreListBtn.Click += new System.EventHandler(this.StoreListBtn_Click);
            // 
            // ProductListBtn
            // 
            this.ProductListBtn.BackColor = System.Drawing.Color.White;
            this.ProductListBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ProductListBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductListBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ProductListBtn.Location = new System.Drawing.Point(80, 166);
            this.ProductListBtn.Name = "ProductListBtn";
            this.ProductListBtn.Size = new System.Drawing.Size(200, 40);
            this.ProductListBtn.TabIndex = 4;
            this.ProductListBtn.Text = "Product List";
            this.ProductListBtn.UseVisualStyleBackColor = true;
            this.ProductListBtn.Click += new System.EventHandler(this.ItemListBtn_Click);
            // 
            // DeliveryScheduleBtn
            // 
            this.DeliveryScheduleBtn.BackColor = System.Drawing.Color.White;
            this.DeliveryScheduleBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeliveryScheduleBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeliveryScheduleBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.DeliveryScheduleBtn.Location = new System.Drawing.Point(80, 216);
            this.DeliveryScheduleBtn.Name = "DeliveryScheduleBtn";
            this.DeliveryScheduleBtn.Size = new System.Drawing.Size(200, 40);
            this.DeliveryScheduleBtn.TabIndex = 3;
            this.DeliveryScheduleBtn.Text = "Delivery Schedule";
            this.DeliveryScheduleBtn.UseVisualStyleBackColor = true;
            this.DeliveryScheduleBtn.Click += new System.EventHandler(this.DeliveryScheduleBtn_Click);
            // 
            // OrderListBtn
            // 
            this.OrderListBtn.BackColor = System.Drawing.Color.White;
            this.OrderListBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OrderListBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderListBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.OrderListBtn.Location = new System.Drawing.Point(318, 116);
            this.OrderListBtn.Name = "OrderListBtn";
            this.OrderListBtn.Size = new System.Drawing.Size(200, 40);
            this.OrderListBtn.TabIndex = 2;
            this.OrderListBtn.Text = "Order List";
            this.OrderListBtn.UseVisualStyleBackColor = true;
            this.OrderListBtn.Click += new System.EventHandler(this.OrderListBtn_Click);
            // 
            // createOrderBtn
            // 
            this.createOrderBtn.BackColor = System.Drawing.SystemColors.Window;
            this.createOrderBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.createOrderBtn.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.createOrderBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createOrderBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.createOrderBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.createOrderBtn.Location = new System.Drawing.Point(80, 116);
            this.createOrderBtn.Name = "createOrderBtn";
            this.createOrderBtn.Size = new System.Drawing.Size(200, 40);
            this.createOrderBtn.TabIndex = 0;
            this.createOrderBtn.Text = "Create Order";
            this.createOrderBtn.UseVisualStyleBackColor = false;
            this.createOrderBtn.Click += new System.EventHandler(this.CreateStore_Click);
            // 
            // CatagoryBtn
            // 
            this.CatagoryBtn.BackColor = System.Drawing.Color.White;
            this.CatagoryBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CatagoryBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CatagoryBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.CatagoryBtn.Location = new System.Drawing.Point(80, 314);
            this.CatagoryBtn.Name = "CatagoryBtn";
            this.CatagoryBtn.Size = new System.Drawing.Size(200, 40);
            this.CatagoryBtn.TabIndex = 12;
            this.CatagoryBtn.Text = "Catagory List";
            this.CatagoryBtn.UseVisualStyleBackColor = true;
            this.CatagoryBtn.Click += new System.EventHandler(this.CatagoryBtn_Click);
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(584, 373);
            this.Controls.Add(this.CatagoryBtn);
            this.Controls.Add(this.titlePanel);
            this.Controls.Add(this.WeeklyExpenseBtn);
            this.Controls.Add(this.WeeklySaleBtn);
            this.Controls.Add(this.MyStoreBtn);
            this.Controls.Add(this.StoreListBtn);
            this.Controls.Add(this.ProductListBtn);
            this.Controls.Add(this.DeliveryScheduleBtn);
            this.Controls.Add(this.OrderListBtn);
            this.Controls.Add(this.createOrderBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainPage";
            this.titlePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Panel titlePanel;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private ButtonModified createOrderBtn;
        private ButtonModified OrderListBtn;
        private ButtonModified DeliveryScheduleBtn;
        private ButtonModified ProductListBtn;
        private ButtonModified StoreListBtn;
        private ButtonModified MyStoreBtn;
        private ButtonModified WeeklySaleBtn;
        private ButtonModified WeeklyExpenseBtn;
        private System.Windows.Forms.Button closeBtn;
        private ButtonModified CatagoryBtn;
    }
}

