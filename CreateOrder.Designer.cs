namespace Invoice
{
    partial class CreateOrder
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateOrder));
            this.orderDataView = new System.Windows.Forms.DataGridView();
            this.ProductCol = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.box1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EachCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pound1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PriceCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AmountCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MarketCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RouteCol = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.NoteCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BillToLbl = new System.Windows.Forms.Label();
            this.StoreList = new System.Windows.Forms.ComboBox();
            this.DeliveryDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.TotalTxt = new System.Windows.Forms.TextBox();
            this.SaveBtn = new Invoice.ButtonModified();
            this.CancelBtn = new Invoice.ButtonModified();
            this.RouteLbl = new System.Windows.Forms.Label();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RouteComboBox = new System.Windows.Forms.ComboBox();
            this.titlePanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.closeBtn = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PrintBtn = new Invoice.ButtonModified();
            this.ProdListBtn = new Invoice.ButtonModified();
            ((System.ComponentModel.ISupportInitialize)(this.orderDataView)).BeginInit();
            this.titlePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // orderDataView
            // 
            this.orderDataView.AllowUserToAddRows = false;
            this.orderDataView.AllowUserToDeleteRows = false;
            this.orderDataView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.orderDataView.BackgroundColor = System.Drawing.SystemColors.Window;
            this.orderDataView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.orderDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.orderDataView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductCol,
            this.box1,
            this.EachCol,
            this.pound1,
            this.PriceCol,
            this.AmountCol,
            this.MarketCol,
            this.RouteCol,
            this.NoteCol});
            this.orderDataView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.orderDataView.Location = new System.Drawing.Point(29, 113);
            this.orderDataView.Name = "orderDataView";
            this.orderDataView.RowHeadersVisible = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.orderDataView.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.orderDataView.Size = new System.Drawing.Size(822, 386);
            this.orderDataView.TabIndex = 5;
            this.orderDataView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.OrderListView_CellValueChanged);
            this.orderDataView.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.Grid_EditingControlShowing);
            // 
            // ProductCol
            // 
            this.ProductCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.ProductCol.HeaderText = "Product";
            this.ProductCol.MinimumWidth = 150;
            this.ProductCol.Name = "ProductCol";
            this.ProductCol.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ProductCol.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ProductCol.Width = 150;
            // 
            // box1
            // 
            this.box1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.box1.FillWeight = 40F;
            this.box1.HeaderText = "Box";
            this.box1.MinimumWidth = 40;
            this.box1.Name = "box1";
            this.box1.Width = 50;
            // 
            // EachCol
            // 
            this.EachCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.EachCol.FillWeight = 40F;
            this.EachCol.HeaderText = "Each";
            this.EachCol.MinimumWidth = 40;
            this.EachCol.Name = "EachCol";
            this.EachCol.Width = 57;
            // 
            // pound1
            // 
            this.pound1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.pound1.FillWeight = 40F;
            this.pound1.HeaderText = "Pound";
            this.pound1.MinimumWidth = 40;
            this.pound1.Name = "pound1";
            this.pound1.Width = 63;
            // 
            // PriceCol
            // 
            this.PriceCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.PriceCol.HeaderText = "Unit Price";
            this.PriceCol.MinimumWidth = 50;
            this.PriceCol.Name = "PriceCol";
            this.PriceCol.Width = 78;
            // 
            // AmountCol
            // 
            this.AmountCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.AmountCol.HeaderText = "Amount";
            this.AmountCol.MinimumWidth = 50;
            this.AmountCol.Name = "AmountCol";
            this.AmountCol.Width = 68;
            // 
            // MarketCol
            // 
            this.MarketCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.MarketCol.HeaderText = "Market";
            this.MarketCol.MinimumWidth = 50;
            this.MarketCol.Name = "MarketCol";
            this.MarketCol.Width = 65;
            // 
            // RouteCol
            // 
            this.RouteCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.RouteCol.HeaderText = "Route";
            this.RouteCol.Items.AddRange(new object[] {
            "",
            "1",
            "2",
            "3"});
            this.RouteCol.MinimumWidth = 50;
            this.RouteCol.Name = "RouteCol";
            this.RouteCol.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.RouteCol.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.RouteCol.Width = 61;
            // 
            // NoteCol
            // 
            this.NoteCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NoteCol.HeaderText = "Note";
            this.NoteCol.MinimumWidth = 100;
            this.NoteCol.Name = "NoteCol";
            // 
            // BillToLbl
            // 
            this.BillToLbl.AutoSize = true;
            this.BillToLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BillToLbl.ForeColor = System.Drawing.SystemColors.Window;
            this.BillToLbl.Location = new System.Drawing.Point(77, 15);
            this.BillToLbl.Name = "BillToLbl";
            this.BillToLbl.Size = new System.Drawing.Size(181, 25);
            this.BillToLbl.TabIndex = 6;
            this.BillToLbl.Text = "Bill To (Customer): ";
            this.BillToLbl.MouseMove += new System.Windows.Forms.MouseEventHandler(this.DragTitlePanel);
            // 
            // StoreList
            // 
            this.StoreList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.StoreList.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StoreList.FormattingEnabled = true;
            this.StoreList.Location = new System.Drawing.Point(264, 11);
            this.StoreList.Name = "StoreList";
            this.StoreList.Size = new System.Drawing.Size(584, 33);
            this.StoreList.TabIndex = 1;
            this.StoreList.SelectedIndexChanged += new System.EventHandler(this.SelectedIndexChanged);
            // 
            // DeliveryDate
            // 
            this.DeliveryDate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeliveryDate.CustomFormat = "MMM/dd/yy dddd";
            this.DeliveryDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeliveryDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DeliveryDate.Location = new System.Drawing.Point(147, 53);
            this.DeliveryDate.Name = "DeliveryDate";
            this.DeliveryDate.Size = new System.Drawing.Size(243, 26);
            this.DeliveryDate.TabIndex = 2;
            this.DeliveryDate.Value = new System.DateTime(2018, 4, 14, 17, 57, 1, 0);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(645, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 25);
            this.label1.TabIndex = 12;
            this.label1.Text = "Total: $";
            this.label1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.DragTitlePanel);
            // 
            // TotalTxt
            // 
            this.TotalTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TotalTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalTxt.Location = new System.Drawing.Point(720, 51);
            this.TotalTxt.Name = "TotalTxt";
            this.TotalTxt.Size = new System.Drawing.Size(130, 30);
            this.TotalTxt.TabIndex = 4;
            // 
            // SaveBtn
            // 
            this.SaveBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SaveBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.SaveBtn.Location = new System.Drawing.Point(721, 509);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(130, 34);
            this.SaveBtn.TabIndex = 7;
            this.SaveBtn.Text = "Save";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // CancelBtn
            // 
            this.CancelBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CancelBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.CancelBtn.Location = new System.Drawing.Point(557, 509);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(130, 34);
            this.CancelBtn.TabIndex = 6;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = true;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // RouteLbl
            // 
            this.RouteLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RouteLbl.AutoSize = true;
            this.RouteLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RouteLbl.ForeColor = System.Drawing.SystemColors.Window;
            this.RouteLbl.Location = new System.Drawing.Point(429, 54);
            this.RouteLbl.Name = "RouteLbl";
            this.RouteLbl.Size = new System.Drawing.Size(74, 25);
            this.RouteLbl.TabIndex = 16;
            this.RouteLbl.Text = "Route: ";
            this.RouteLbl.MouseMove += new System.Windows.Forms.MouseEventHandler(this.DragTitlePanel);
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "QTY";
            this.Quantity.Name = "Quantity";
            this.Quantity.Width = 50;
            // 
            // RouteComboBox
            // 
            this.RouteComboBox.AllowDrop = true;
            this.RouteComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RouteComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.RouteComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RouteComboBox.FormattingEnabled = true;
            this.RouteComboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.RouteComboBox.Location = new System.Drawing.Point(509, 51);
            this.RouteComboBox.Name = "RouteComboBox";
            this.RouteComboBox.Size = new System.Drawing.Size(130, 33);
            this.RouteComboBox.TabIndex = 17;
            this.RouteComboBox.SelectedIndexChanged += new System.EventHandler(this.ComboBox_SelectedIndexChanged);
            // 
            // titlePanel
            // 
            this.titlePanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.titlePanel.BackColor = System.Drawing.Color.SteelBlue;
            this.titlePanel.Controls.Add(this.label2);
            this.titlePanel.Controls.Add(this.closeBtn);
            this.titlePanel.Controls.Add(this.RouteComboBox);
            this.titlePanel.Controls.Add(this.RouteLbl);
            this.titlePanel.Controls.Add(this.TotalTxt);
            this.titlePanel.Controls.Add(this.label1);
            this.titlePanel.Controls.Add(this.pictureBox2);
            this.titlePanel.Controls.Add(this.pictureBox1);
            this.titlePanel.Controls.Add(this.StoreList);
            this.titlePanel.Controls.Add(this.BillToLbl);
            this.titlePanel.Controls.Add(this.DeliveryDate);
            this.titlePanel.Location = new System.Drawing.Point(1, 1);
            this.titlePanel.Name = "titlePanel";
            this.titlePanel.Size = new System.Drawing.Size(882, 91);
            this.titlePanel.TabIndex = 23;
            this.titlePanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.DragTitlePanel);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(82, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 25);
            this.label2.TabIndex = 18;
            this.label2.Text = "Date:";
            this.label2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.DragTitlePanel);
            // 
            // closeBtn
            // 
            this.closeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.closeBtn.Location = new System.Drawing.Point(859, 3);
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
            this.pictureBox2.Location = new System.Drawing.Point(46, 41);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 32);
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.DragTitlePanel);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(11, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(58, 55);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.DragTitlePanel);
            // 
            // PrintBtn
            // 
            this.PrintBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.PrintBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrintBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.PrintBtn.Location = new System.Drawing.Point(289, 509);
            this.PrintBtn.Name = "PrintBtn";
            this.PrintBtn.Size = new System.Drawing.Size(160, 34);
            this.PrintBtn.TabIndex = 24;
            this.PrintBtn.Text = "Open Invoice";
            this.PrintBtn.UseVisualStyleBackColor = true;
            this.PrintBtn.Click += new System.EventHandler(this.PrintBtn_Click);
            // 
            // ProdListBtn
            // 
            this.ProdListBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ProdListBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProdListBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ProdListBtn.Location = new System.Drawing.Point(29, 509);
            this.ProdListBtn.Name = "ProdListBtn";
            this.ProdListBtn.Size = new System.Drawing.Size(160, 34);
            this.ProdListBtn.TabIndex = 25;
            this.ProdListBtn.Text = "Product List";
            this.ProdListBtn.UseVisualStyleBackColor = true;
            this.ProdListBtn.Click += new System.EventHandler(this.ProdListBtn_Click);
            // 
            // CreateOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.ProdListBtn);
            this.Controls.Add(this.PrintBtn);
            this.Controls.Add(this.titlePanel);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.orderDataView);
            this.MaximizeBox = false;
            this.Name = "CreateOrder";
            this.Text = "CreateOrder";
            ((System.ComponentModel.ISupportInitialize)(this.orderDataView)).EndInit();
            this.titlePanel.ResumeLayout(false);
            this.titlePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }
        private void Init_deleteBtn()
        {
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.DeleteBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteBtn.Location = new System.Drawing.Point(593, 357);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(90, 30);
            this.DeleteBtn.TabIndex = 13;
            this.DeleteBtn.Text = "Delete";
            this.DeleteBtn.UseVisualStyleBackColor = true;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            this.Controls.Add(this.DeleteBtn);
        }
        #endregion
        private System.Windows.Forms.DataGridView orderDataView;
        private System.Windows.Forms.Label BillToLbl;
        private System.Windows.Forms.ComboBox StoreList;
        private System.Windows.Forms.DateTimePicker DeliveryDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TotalTxt;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Label RouteLbl;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.Panel titlePanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private ButtonModified SaveBtn;
        private ButtonModified CancelBtn;
        private ButtonModified PrintBtn;
        private ButtonModified ProdListBtn;
        private System.Windows.Forms.DataGridViewComboBoxColumn ProductCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn box1;
        private System.Windows.Forms.DataGridViewTextBoxColumn EachCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn pound1;
        private System.Windows.Forms.DataGridViewTextBoxColumn PriceCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn AmountCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn MarketCol;
        private System.Windows.Forms.DataGridViewComboBoxColumn RouteCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn NoteCol;
        private System.Windows.Forms.ComboBox RouteComboBox;
    }
}