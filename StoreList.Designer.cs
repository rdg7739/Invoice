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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StoreList));
            this.StoreDataView = new System.Windows.Forms.DataGridView();
            this.No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.storeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.storePhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.storeFax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.storeAddr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.storeDetail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isMarket = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ShowMarketCheckBox = new System.Windows.Forms.CheckBox();
            this.ShowCustomerCheckBox = new System.Windows.Forms.CheckBox();
            this.ListOptionLbl = new System.Windows.Forms.Label();
            this.storeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Title = new System.Windows.Forms.Label();
            this.titlePanel = new System.Windows.Forms.Panel();
            this.closeBtn = new System.Windows.Forms.Button();
            this.saveBtn = new Invoice.ButtonModified();
            this.cancelBtn = new Invoice.ButtonModified();
            ((System.ComponentModel.ISupportInitialize)(this.StoreDataView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.storeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.titlePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // StoreDataView
            // 
            this.StoreDataView.AllowUserToOrderColumns = true;
            this.StoreDataView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.StoreDataView.BackgroundColor = System.Drawing.SystemColors.Window;
            this.StoreDataView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.StoreDataView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.StoreDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StoreDataView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.No,
            this.storeName,
            this.storePhone,
            this.storeFax,
            this.storeAddr,
            this.contactName,
            this.contactPhone,
            this.storeDetail,
            this.isMarket});
            this.StoreDataView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.StoreDataView.Location = new System.Drawing.Point(32, 114);
            this.StoreDataView.Name = "StoreDataView";
            this.StoreDataView.RowHeadersVisible = false;
            this.StoreDataView.Size = new System.Drawing.Size(722, 393);
            this.StoreDataView.TabIndex = 1;
            this.StoreDataView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.StoreDataView_CellContentClick);
            // 
            // No
            // 
            this.No.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.No.HeaderText = "No";
            this.No.Name = "No";
            this.No.Width = 46;
            // 
            // storeName
            // 
            this.storeName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.storeName.HeaderText = "Store Name";
            this.storeName.Name = "storeName";
            this.storeName.Width = 81;
            // 
            // storePhone
            // 
            this.storePhone.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.storePhone.HeaderText = "Store Phone";
            this.storePhone.Name = "storePhone";
            this.storePhone.Width = 84;
            // 
            // storeFax
            // 
            this.storeFax.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.storeFax.HeaderText = "Store Fax";
            this.storeFax.Name = "storeFax";
            this.storeFax.Width = 71;
            // 
            // storeAddr
            // 
            this.storeAddr.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.storeAddr.HeaderText = "Store Address";
            this.storeAddr.Name = "storeAddr";
            this.storeAddr.Width = 90;
            // 
            // contactName
            // 
            this.contactName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.contactName.HeaderText = "Contact Name";
            this.contactName.Name = "contactName";
            this.contactName.Width = 92;
            // 
            // contactPhone
            // 
            this.contactPhone.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.contactPhone.HeaderText = "Contact Phone";
            this.contactPhone.Name = "contactPhone";
            this.contactPhone.Width = 95;
            // 
            // storeDetail
            // 
            this.storeDetail.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.storeDetail.HeaderText = "Store Detail";
            this.storeDetail.Name = "storeDetail";
            // 
            // isMarket
            // 
            this.isMarket.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.isMarket.FalseValue = "0";
            this.isMarket.HeaderText = "IsMarket";
            this.isMarket.Name = "isMarket";
            this.isMarket.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.isMarket.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.isMarket.TrueValue = "1";
            this.isMarket.Width = 73;
            // 
            // ShowMarketCheckBox
            // 
            this.ShowMarketCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ShowMarketCheckBox.AutoSize = true;
            this.ShowMarketCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ShowMarketCheckBox.ForeColor = System.Drawing.SystemColors.Window;
            this.ShowMarketCheckBox.Location = new System.Drawing.Point(439, 50);
            this.ShowMarketCheckBox.Name = "ShowMarketCheckBox";
            this.ShowMarketCheckBox.Size = new System.Drawing.Size(146, 29);
            this.ShowMarketCheckBox.TabIndex = 2;
            this.ShowMarketCheckBox.Text = "Show Market";
            this.ShowMarketCheckBox.UseVisualStyleBackColor = true;
            this.ShowMarketCheckBox.CheckedChanged += new System.EventHandler(this.ShowOptionCheckBox_CheckedChanged);
            // 
            // ShowCustomerCheckBox
            // 
            this.ShowCustomerCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ShowCustomerCheckBox.AutoSize = true;
            this.ShowCustomerCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ShowCustomerCheckBox.ForeColor = System.Drawing.SystemColors.Window;
            this.ShowCustomerCheckBox.Location = new System.Drawing.Point(591, 50);
            this.ShowCustomerCheckBox.Name = "ShowCustomerCheckBox";
            this.ShowCustomerCheckBox.Size = new System.Drawing.Size(171, 29);
            this.ShowCustomerCheckBox.TabIndex = 3;
            this.ShowCustomerCheckBox.Text = "Show Customer";
            this.ShowCustomerCheckBox.UseVisualStyleBackColor = true;
            this.ShowCustomerCheckBox.CheckedChanged += new System.EventHandler(this.ShowOptionCheckBox_CheckedChanged);
            // 
            // ListOptionLbl
            // 
            this.ListOptionLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ListOptionLbl.AutoSize = true;
            this.ListOptionLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ListOptionLbl.ForeColor = System.Drawing.SystemColors.Window;
            this.ListOptionLbl.Location = new System.Drawing.Point(317, 51);
            this.ListOptionLbl.Name = "ListOptionLbl";
            this.ListOptionLbl.Size = new System.Drawing.Size(116, 25);
            this.ListOptionLbl.TabIndex = 4;
            this.ListOptionLbl.Text = "List Option: ";
            this.ListOptionLbl.MouseMove += new System.Windows.Forms.MouseEventHandler(this.DragTitlePanel);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(66, 44);
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
            this.pictureBox1.Location = new System.Drawing.Point(31, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(57, 55);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.DragTitlePanel);
            // 
            // Title
            // 
            this.Title.Font = new System.Drawing.Font("Arial", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Title.Location = new System.Drawing.Point(73, 16);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(238, 60);
            this.Title.TabIndex = 1;
            this.Title.Text = "Store List";
            this.Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Title.MouseMove += new System.Windows.Forms.MouseEventHandler(this.DragTitlePanel);
            // 
            // titlePanel
            // 
            this.titlePanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.titlePanel.BackColor = System.Drawing.Color.SteelBlue;
            this.titlePanel.Controls.Add(this.closeBtn);
            this.titlePanel.Controls.Add(this.ListOptionLbl);
            this.titlePanel.Controls.Add(this.pictureBox2);
            this.titlePanel.Controls.Add(this.ShowCustomerCheckBox);
            this.titlePanel.Controls.Add(this.ShowMarketCheckBox);
            this.titlePanel.Controls.Add(this.pictureBox1);
            this.titlePanel.Controls.Add(this.Title);
            this.titlePanel.Location = new System.Drawing.Point(1, 1);
            this.titlePanel.Name = "titlePanel";
            this.titlePanel.Size = new System.Drawing.Size(782, 91);
            this.titlePanel.TabIndex = 22;
            this.titlePanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.DragTitlePanel);
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
            // saveBtn
            // 
            this.saveBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.saveBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.saveBtn.Location = new System.Drawing.Point(624, 519);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(130, 34);
            this.saveBtn.TabIndex = 27;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.cancelBtn.Location = new System.Drawing.Point(472, 519);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(130, 34);
            this.cancelBtn.TabIndex = 26;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // StoreList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.titlePanel);
            this.Controls.Add(this.StoreDataView);
            this.Name = "StoreList";
            this.Text = "CustomerList";
            ((System.ComponentModel.ISupportInitialize)(this.StoreDataView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.storeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.titlePanel.ResumeLayout(false);
            this.titlePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView StoreDataView;
        private System.Windows.Forms.CheckBox ShowMarketCheckBox;
        private System.Windows.Forms.CheckBox ShowCustomerCheckBox;
        private System.Windows.Forms.Label ListOptionLbl;
        private System.Windows.Forms.BindingSource storeBindingSource;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Panel titlePanel;
        private System.Windows.Forms.Button closeBtn;
        private ButtonModified saveBtn;
        private ButtonModified cancelBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn No;
        private System.Windows.Forms.DataGridViewTextBoxColumn storeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn storePhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn storeFax;
        private System.Windows.Forms.DataGridViewTextBoxColumn storeAddr;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactName;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn storeDetail;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isMarket;
    }
}