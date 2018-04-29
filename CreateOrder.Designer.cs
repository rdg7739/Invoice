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
            this.orderDataView = new System.Windows.Forms.DataGridView();
            this.ProductCol = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.QTYCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PriceCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AmountCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MarketCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NoteCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RouteCol = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.BillToLbl = new System.Windows.Forms.Label();
            this.StoreList = new System.Windows.Forms.ComboBox();
            this.DeliveryDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.TotalTxt = new System.Windows.Forms.TextBox();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.RouteLbl = new System.Windows.Forms.Label();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RouteComboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.orderDataView)).BeginInit();
            this.SuspendLayout();
            // 
            // orderDataView
            // 
            this.orderDataView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.orderDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.orderDataView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductCol,
            this.QTYCol,
            this.PriceCol,
            this.AmountCol,
            this.MarketCol,
            this.NoteCol,
            this.RouteCol});
            this.orderDataView.Location = new System.Drawing.Point(29, 108);
            this.orderDataView.Name = "orderDataView";
            this.orderDataView.Size = new System.Drawing.Size(729, 386);
            this.orderDataView.TabIndex = 5;
            this.orderDataView.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.Grid_EditingControlShowing);
            // 
            // ProductCol
            // 
            this.ProductCol.HeaderText = "Product";
            this.ProductCol.Name = "ProductCol";
            this.ProductCol.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ProductCol.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // QTYCol
            // 
            this.QTYCol.HeaderText = "QTY";
            this.QTYCol.Name = "QTYCol";
            // 
            // PriceCol
            // 
            this.PriceCol.HeaderText = "Price";
            this.PriceCol.Name = "PriceCol";
            // 
            // AmountCol
            // 
            this.AmountCol.HeaderText = "Amount";
            this.AmountCol.Name = "AmountCol";
            // 
            // MarketCol
            // 
            this.MarketCol.HeaderText = "Market";
            this.MarketCol.Name = "MarketCol";
            // 
            // NoteCol
            // 
            this.NoteCol.HeaderText = "Note";
            this.NoteCol.Name = "NoteCol";
            // 
            // RouteCol
            // 
            this.RouteCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.RouteCol.HeaderText = "Route";
            this.RouteCol.Items.AddRange(new object[] {
            "",
            "1",
            "2",
            "3"});
            this.RouteCol.Name = "RouteCol";
            this.RouteCol.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.RouteCol.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.RouteCol.Width = 61;
            // 
            // BillToLbl
            // 
            this.BillToLbl.AutoSize = true;
            this.BillToLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BillToLbl.Location = new System.Drawing.Point(25, 33);
            this.BillToLbl.Name = "BillToLbl";
            this.BillToLbl.Size = new System.Drawing.Size(142, 20);
            this.BillToLbl.TabIndex = 6;
            this.BillToLbl.Text = "Bill To (Customer): ";
            // 
            // StoreList
            // 
            this.StoreList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StoreList.FormattingEnabled = true;
            this.StoreList.Location = new System.Drawing.Point(174, 30);
            this.StoreList.Name = "StoreList";
            this.StoreList.Size = new System.Drawing.Size(584, 28);
            this.StoreList.TabIndex = 1;
            this.StoreList.SelectedIndexChanged += new System.EventHandler(this.StoreList_SelectedIndexChanged);
            // 
            // DeliveryDate
            // 
            this.DeliveryDate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeliveryDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeliveryDate.Location = new System.Drawing.Point(29, 68);
            this.DeliveryDate.Name = "DeliveryDate";
            this.DeliveryDate.Size = new System.Drawing.Size(258, 26);
            this.DeliveryDate.TabIndex = 2;
            this.DeliveryDate.Value = new System.DateTime(2018, 4, 14, 17, 57, 1, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(604, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Total:";
            // 
            // TotalTxt
            // 
            this.TotalTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalTxt.Location = new System.Drawing.Point(658, 68);
            this.TotalTxt.Name = "TotalTxt";
            this.TotalTxt.Size = new System.Drawing.Size(100, 26);
            this.TotalTxt.TabIndex = 4;
            // 
            // SaveBtn
            // 
            this.SaveBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveBtn.Location = new System.Drawing.Point(674, 501);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(84, 34);
            this.SaveBtn.TabIndex = 7;
            this.SaveBtn.Text = "Save";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // CancelBtn
            // 
            this.CancelBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelBtn.Location = new System.Drawing.Point(568, 501);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(84, 34);
            this.CancelBtn.TabIndex = 6;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = true;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // RouteLbl
            // 
            this.RouteLbl.AutoSize = true;
            this.RouteLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RouteLbl.Location = new System.Drawing.Point(314, 71);
            this.RouteLbl.Name = "RouteLbl";
            this.RouteLbl.Size = new System.Drawing.Size(61, 20);
            this.RouteLbl.TabIndex = 16;
            this.RouteLbl.Text = "Route: ";
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
            this.RouteComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.RouteComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RouteComboBox.FormattingEnabled = true;
            this.RouteComboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.RouteComboBox.Location = new System.Drawing.Point(381, 68);
            this.RouteComboBox.Name = "RouteComboBox";
            this.RouteComboBox.Size = new System.Drawing.Size(100, 28);
            this.RouteComboBox.TabIndex = 17;
            this.RouteComboBox.SelectedIndexChanged += new System.EventHandler(this.RouteComboBox_SelectedIndexChanged);
            // 
            // CreateOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.RouteComboBox);
            this.Controls.Add(this.RouteLbl);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.TotalTxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DeliveryDate);
            this.Controls.Add(this.StoreList);
            this.Controls.Add(this.BillToLbl);
            this.Controls.Add(this.orderDataView);
            this.Name = "CreateOrder";
            this.Text = "CreateOrder";
            ((System.ComponentModel.ISupportInitialize)(this.orderDataView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Label RouteLbl;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.ComboBox RouteComboBox;
        private System.Windows.Forms.DataGridViewComboBoxColumn ProductCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn QTYCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn PriceCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn AmountCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn MarketCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn NoteCol;
        private System.Windows.Forms.DataGridViewComboBoxColumn RouteCol;
    }
}