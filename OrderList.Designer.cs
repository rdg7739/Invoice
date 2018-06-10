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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderList));
            this.OrderListView = new System.Windows.Forms.DataGridView();
            this.BuyCheckBox = new System.Windows.Forms.CheckBox();
            this.SellCheckBox = new System.Windows.Forms.CheckBox();
            this.OptionLbl = new System.Windows.Forms.Label();
            this.Title = new System.Windows.Forms.Label();
            this.titlePanel = new System.Windows.Forms.Panel();
            this.showAllOrderCheckBox = new System.Windows.Forms.CheckBox();
            this.StoreList = new System.Windows.Forms.ComboBox();
            this.DeliveryDate = new System.Windows.Forms.DateTimePicker();
            this.closeBtn = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.reportAction1 = new Microsoft.AnalysisServices.ReportAction();
            this.CancelBtn = new Invoice.ButtonModified();
            ((System.ComponentModel.ISupportInitialize)(this.OrderListView)).BeginInit();
            this.titlePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // OrderListView
            // 
            this.OrderListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OrderListView.BackgroundColor = System.Drawing.SystemColors.Window;
            this.OrderListView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.OrderListView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrderListView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.OrderListView.Location = new System.Drawing.Point(32, 118);
            this.OrderListView.Name = "OrderListView";
            this.OrderListView.ReadOnly = true;
            this.OrderListView.RowHeadersVisible = false;
            this.OrderListView.Size = new System.Drawing.Size(722, 391);
            this.OrderListView.TabIndex = 1;
            // 
            // BuyCheckBox
            // 
            this.BuyCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BuyCheckBox.AutoSize = true;
            this.BuyCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.BuyCheckBox.ForeColor = System.Drawing.SystemColors.Window;
            this.BuyCheckBox.Location = new System.Drawing.Point(438, 47);
            this.BuyCheckBox.Name = "BuyCheckBox";
            this.BuyCheckBox.Size = new System.Drawing.Size(155, 29);
            this.BuyCheckBox.TabIndex = 2;
            this.BuyCheckBox.Text = "Buy Order List";
            this.BuyCheckBox.UseVisualStyleBackColor = true;
            this.BuyCheckBox.CheckedChanged += new System.EventHandler(this.OptionCheckBox_CheckedChanged);
            this.BuyCheckBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.DragTitlePanel);
            // 
            // SellCheckBox
            // 
            this.SellCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SellCheckBox.AutoSize = true;
            this.SellCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.SellCheckBox.ForeColor = System.Drawing.SystemColors.Window;
            this.SellCheckBox.Location = new System.Drawing.Point(599, 47);
            this.SellCheckBox.Name = "SellCheckBox";
            this.SellCheckBox.Size = new System.Drawing.Size(154, 29);
            this.SellCheckBox.TabIndex = 3;
            this.SellCheckBox.Text = "Sell Order List";
            this.SellCheckBox.UseVisualStyleBackColor = true;
            this.SellCheckBox.CheckedChanged += new System.EventHandler(this.OptionCheckBox_CheckedChanged);
            this.SellCheckBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.DragTitlePanel);
            // 
            // OptionLbl
            // 
            this.OptionLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.OptionLbl.AutoSize = true;
            this.OptionLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.OptionLbl.ForeColor = System.Drawing.SystemColors.Window;
            this.OptionLbl.Location = new System.Drawing.Point(127, 48);
            this.OptionLbl.Name = "OptionLbl";
            this.OptionLbl.Size = new System.Drawing.Size(136, 25);
            this.OptionLbl.TabIndex = 4;
            this.OptionLbl.Text = "Order Option: ";
            this.OptionLbl.MouseMove += new System.Windows.Forms.MouseEventHandler(this.DragTitlePanel);
            // 
            // Title
            // 
            this.Title.Font = new System.Drawing.Font("Arial", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Title.Location = new System.Drawing.Point(93, 12);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(202, 37);
            this.Title.TabIndex = 1;
            this.Title.Text = "Order List";
            this.Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Title.MouseMove += new System.Windows.Forms.MouseEventHandler(this.DragTitlePanel);
            // 
            // titlePanel
            // 
            this.titlePanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.titlePanel.BackColor = System.Drawing.Color.SteelBlue;
            this.titlePanel.Controls.Add(this.showAllOrderCheckBox);
            this.titlePanel.Controls.Add(this.StoreList);
            this.titlePanel.Controls.Add(this.DeliveryDate);
            this.titlePanel.Controls.Add(this.closeBtn);
            this.titlePanel.Controls.Add(this.OptionLbl);
            this.titlePanel.Controls.Add(this.SellCheckBox);
            this.titlePanel.Controls.Add(this.BuyCheckBox);
            this.titlePanel.Controls.Add(this.pictureBox2);
            this.titlePanel.Controls.Add(this.pictureBox1);
            this.titlePanel.Controls.Add(this.Title);
            this.titlePanel.Location = new System.Drawing.Point(1, 1);
            this.titlePanel.Name = "titlePanel";
            this.titlePanel.Size = new System.Drawing.Size(782, 91);
            this.titlePanel.TabIndex = 23;
            this.titlePanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.DragTitlePanel);
            // 
            // showAllOrderCheckBox
            // 
            this.showAllOrderCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.showAllOrderCheckBox.AutoSize = true;
            this.showAllOrderCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.showAllOrderCheckBox.ForeColor = System.Drawing.SystemColors.Window;
            this.showAllOrderCheckBox.Location = new System.Drawing.Point(269, 47);
            this.showAllOrderCheckBox.Name = "showAllOrderCheckBox";
            this.showAllOrderCheckBox.Size = new System.Drawing.Size(163, 29);
            this.showAllOrderCheckBox.TabIndex = 7;
            this.showAllOrderCheckBox.Text = "Show All Order";
            this.showAllOrderCheckBox.UseVisualStyleBackColor = true;
            this.showAllOrderCheckBox.CheckedChanged += new System.EventHandler(this.ShowAllOrderCheckBox_CheckedChanged);
            // 
            // StoreList
            // 
            this.StoreList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.StoreList.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StoreList.FormattingEnabled = true;
            this.StoreList.Location = new System.Drawing.Point(301, 11);
            this.StoreList.Name = "StoreList";
            this.StoreList.Size = new System.Drawing.Size(292, 33);
            this.StoreList.TabIndex = 6;
            this.StoreList.SelectedIndexChanged += new System.EventHandler(this.StoreList_SelectedIndexChanged);
            // 
            // DeliveryDate
            // 
            this.DeliveryDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DeliveryDate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeliveryDate.CustomFormat = " ";
            this.DeliveryDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeliveryDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DeliveryDate.Location = new System.Drawing.Point(599, 12);
            this.DeliveryDate.Name = "DeliveryDate";
            this.DeliveryDate.Size = new System.Drawing.Size(154, 29);
            this.DeliveryDate.TabIndex = 5;
            this.DeliveryDate.ValueChanged += new System.EventHandler(this.OrderDate_ValueChanged);
            // 
            // closeBtn
            // 
            this.closeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.closeBtn.Location = new System.Drawing.Point(761, 3);
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
            this.pictureBox2.Location = new System.Drawing.Point(66, 35);
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
            this.pictureBox1.Location = new System.Drawing.Point(31, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(57, 55);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.DragTitlePanel);
            // 
            // reportAction1
            // 
            this.reportAction1.Application = null;
            this.reportAction1.Description = null;
            this.reportAction1.Name = null;
            this.reportAction1.OwningCollection = null;
            this.reportAction1.Path = null;
            this.reportAction1.ReportServer = null;
            // 
            // CancelBtn
            // 
            this.CancelBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CancelBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.CancelBtn.Location = new System.Drawing.Point(624, 515);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(130, 34);
            this.CancelBtn.TabIndex = 24;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = true;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // OrderList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.titlePanel);
            this.Controls.Add(this.OrderListView);
            this.Name = "OrderList";
            this.Text = "OrderList";
            ((System.ComponentModel.ISupportInitialize)(this.OrderListView)).EndInit();
            this.titlePanel.ResumeLayout(false);
            this.titlePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView OrderListView;
        private System.Windows.Forms.CheckBox BuyCheckBox;
        private System.Windows.Forms.CheckBox SellCheckBox;
        private System.Windows.Forms.Label OptionLbl;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Panel titlePanel;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DateTimePicker DeliveryDate;
        private Microsoft.AnalysisServices.ReportAction reportAction1;
        private System.Windows.Forms.ComboBox StoreList;
        private System.Windows.Forms.CheckBox showAllOrderCheckBox;
        private ButtonModified CancelBtn;
    }
}