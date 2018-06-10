namespace Invoice
{
    partial class ProductCollection
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductCollection));
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Title = new System.Windows.Forms.Label();
            this.titlePanel = new System.Windows.Forms.Panel();
            this.closeBtn = new System.Windows.Forms.Button();
            this.MeatLbl = new System.Windows.Forms.Label();
            this.FrozenLbl = new System.Windows.Forms.Label();
            this.GroceryBtn = new System.Windows.Forms.Label();
            this.ProduceBtn = new System.Windows.Forms.Label();
            this.EtcLbl = new System.Windows.Forms.Label();
            this.MeatListBox = new System.Windows.Forms.CheckedListBox();
            this.FrozenListBox = new System.Windows.Forms.CheckedListBox();
            this.GroceryListBox = new System.Windows.Forms.CheckedListBox();
            this.ProduceListBox = new System.Windows.Forms.CheckedListBox();
            this.EtcListBox = new System.Windows.Forms.CheckedListBox();
            this.cancelBtn = new Invoice.ButtonModified();
            this.saveBtn = new Invoice.ButtonModified();
            this.tableLayoutPanel1 = new Invoice.DBLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.titlePanel.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(293, 41);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(29, 32);
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.DragTitlePanel);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(258, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(57, 55);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.DragTitlePanel);
            // 
            // Title
            // 
            this.Title.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Title.Font = new System.Drawing.Font("Arial", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Title.Location = new System.Drawing.Point(311, 16);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(382, 60);
            this.Title.TabIndex = 1;
            this.Title.Text = "Select Product";
            this.Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Title.MouseMove += new System.Windows.Forms.MouseEventHandler(this.DragTitlePanel);
            // 
            // titlePanel
            // 
            this.titlePanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.titlePanel.BackColor = System.Drawing.Color.SteelBlue;
            this.titlePanel.Controls.Add(this.closeBtn);
            this.titlePanel.Controls.Add(this.pictureBox2);
            this.titlePanel.Controls.Add(this.pictureBox1);
            this.titlePanel.Controls.Add(this.Title);
            this.titlePanel.Location = new System.Drawing.Point(1, 1);
            this.titlePanel.Name = "titlePanel";
            this.titlePanel.Size = new System.Drawing.Size(998, 91);
            this.titlePanel.TabIndex = 14;
            this.titlePanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.DragTitlePanel);
            // 
            // closeBtn
            // 
            this.closeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.closeBtn.Location = new System.Drawing.Point(975, 3);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(20, 20);
            this.closeBtn.TabIndex = 4;
            this.closeBtn.Text = "X";
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // MeatLbl
            // 
            this.MeatLbl.BackColor = System.Drawing.Color.Transparent;
            this.MeatLbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MeatLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.MeatLbl.Location = new System.Drawing.Point(3, 0);
            this.MeatLbl.Name = "MeatLbl";
            this.MeatLbl.Size = new System.Drawing.Size(189, 40);
            this.MeatLbl.TabIndex = 15;
            this.MeatLbl.Text = "Meat";
            this.MeatLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrozenLbl
            // 
            this.FrozenLbl.BackColor = System.Drawing.Color.Transparent;
            this.FrozenLbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FrozenLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.FrozenLbl.Location = new System.Drawing.Point(198, 0);
            this.FrozenLbl.Name = "FrozenLbl";
            this.FrozenLbl.Size = new System.Drawing.Size(189, 40);
            this.FrozenLbl.TabIndex = 16;
            this.FrozenLbl.Text = "Frozen";
            this.FrozenLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GroceryBtn
            // 
            this.GroceryBtn.BackColor = System.Drawing.Color.Transparent;
            this.GroceryBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GroceryBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.GroceryBtn.Location = new System.Drawing.Point(393, 0);
            this.GroceryBtn.Name = "GroceryBtn";
            this.GroceryBtn.Size = new System.Drawing.Size(189, 40);
            this.GroceryBtn.TabIndex = 17;
            this.GroceryBtn.Text = "Grocery";
            this.GroceryBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ProduceBtn
            // 
            this.ProduceBtn.BackColor = System.Drawing.Color.Transparent;
            this.ProduceBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProduceBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ProduceBtn.Location = new System.Drawing.Point(588, 0);
            this.ProduceBtn.Name = "ProduceBtn";
            this.ProduceBtn.Size = new System.Drawing.Size(189, 40);
            this.ProduceBtn.TabIndex = 18;
            this.ProduceBtn.Text = "Produce";
            this.ProduceBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EtcLbl
            // 
            this.EtcLbl.BackColor = System.Drawing.Color.Transparent;
            this.EtcLbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EtcLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.EtcLbl.Location = new System.Drawing.Point(783, 0);
            this.EtcLbl.Name = "EtcLbl";
            this.EtcLbl.Size = new System.Drawing.Size(190, 40);
            this.EtcLbl.TabIndex = 19;
            this.EtcLbl.Text = "Etc";
            this.EtcLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MeatListBox
            // 
            this.MeatListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MeatListBox.CheckOnClick = true;
            this.MeatListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.MeatListBox.FormattingEnabled = true;
            this.MeatListBox.Location = new System.Drawing.Point(3, 43);
            this.MeatListBox.Name = "MeatListBox";
            this.MeatListBox.Size = new System.Drawing.Size(189, 445);
            this.MeatListBox.TabIndex = 20;
            // 
            // FrozenListBox
            // 
            this.FrozenListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FrozenListBox.CheckOnClick = true;
            this.FrozenListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.FrozenListBox.FormattingEnabled = true;
            this.FrozenListBox.Location = new System.Drawing.Point(198, 43);
            this.FrozenListBox.Name = "FrozenListBox";
            this.FrozenListBox.Size = new System.Drawing.Size(189, 445);
            this.FrozenListBox.TabIndex = 21;
            // 
            // GroceryListBox
            // 
            this.GroceryListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GroceryListBox.CheckOnClick = true;
            this.GroceryListBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.GroceryListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.GroceryListBox.FormattingEnabled = true;
            this.GroceryListBox.Location = new System.Drawing.Point(393, 43);
            this.GroceryListBox.Name = "GroceryListBox";
            this.GroceryListBox.Size = new System.Drawing.Size(189, 445);
            this.GroceryListBox.TabIndex = 22;
            // 
            // ProduceListBox
            // 
            this.ProduceListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ProduceListBox.CheckOnClick = true;
            this.ProduceListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ProduceListBox.FormattingEnabled = true;
            this.ProduceListBox.Location = new System.Drawing.Point(588, 43);
            this.ProduceListBox.Name = "ProduceListBox";
            this.ProduceListBox.Size = new System.Drawing.Size(189, 445);
            this.ProduceListBox.TabIndex = 23;
            // 
            // EtcListBox
            // 
            this.EtcListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EtcListBox.CheckOnClick = true;
            this.EtcListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.EtcListBox.FormattingEnabled = true;
            this.EtcListBox.Location = new System.Drawing.Point(783, 43);
            this.EtcListBox.Name = "EtcListBox";
            this.EtcListBox.Size = new System.Drawing.Size(190, 445);
            this.EtcListBox.TabIndex = 24;
            // 
            // cancelBtn
            // 
            this.cancelBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cancelBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.cancelBtn.Location = new System.Drawing.Point(712, 603);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(130, 34);
            this.cancelBtn.TabIndex = 25;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.saveBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.saveBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.saveBtn.Location = new System.Drawing.Point(848, 603);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(130, 34);
            this.saveBtn.TabIndex = 26;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.MeatListBox, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.FrozenListBox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.GroceryListBox, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.ProduceListBox, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.ProduceBtn, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.EtcListBox, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.GroceryBtn, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.MeatLbl, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.FrozenLbl, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.EtcLbl, 4, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 98);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(976, 499);
            this.tableLayoutPanel1.TabIndex = 27;
            // 
            // ProductCollection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1000, 650);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.titlePanel);
            this.Name = "ProductCollection";
            this.Text = "ProductCollection";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.titlePanel.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Panel titlePanel;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.Label MeatLbl;
        private System.Windows.Forms.Label FrozenLbl;
        private System.Windows.Forms.Label GroceryBtn;
        private System.Windows.Forms.Label ProduceBtn;
        private System.Windows.Forms.Label EtcLbl;
        private System.Windows.Forms.CheckedListBox MeatListBox;
        private System.Windows.Forms.CheckedListBox FrozenListBox;
        private System.Windows.Forms.CheckedListBox GroceryListBox;
        private System.Windows.Forms.CheckedListBox ProduceListBox;
        private System.Windows.Forms.CheckedListBox EtcListBox;
        private ButtonModified cancelBtn;
        private ButtonModified saveBtn;
        private DBLayoutPanel tableLayoutPanel1;
    }
}