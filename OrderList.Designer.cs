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
            this.closeBtn = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.OrderDate = new System.Windows.Forms.DateTimePicker();
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
            this.OrderListView.Size = new System.Drawing.Size(722, 406);
            this.OrderListView.TabIndex = 1;
            // 
            // BuyCheckBox
            // 
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
            // 
            // SellCheckBox
            // 
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
            // 
            // OptionLbl
            // 
            this.OptionLbl.AutoSize = true;
            this.OptionLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.OptionLbl.ForeColor = System.Drawing.SystemColors.Window;
            this.OptionLbl.Location = new System.Drawing.Point(296, 48);
            this.OptionLbl.Name = "OptionLbl";
            this.OptionLbl.Size = new System.Drawing.Size(136, 25);
            this.OptionLbl.TabIndex = 4;
            this.OptionLbl.Text = "Order Option: ";
            // 
            // Title
            // 
            this.Title.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Title.Font = new System.Drawing.Font("Arial", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Title.Location = new System.Drawing.Point(73, 13);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(238, 60);
            this.Title.TabIndex = 1;
            this.Title.Text = "Order List";
            this.Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // titlePanel
            // 
            this.titlePanel.BackColor = System.Drawing.Color.SteelBlue;
            this.titlePanel.Controls.Add(this.OrderDate);
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
            // closeBtn
            // 
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
            this.pictureBox2.Location = new System.Drawing.Point(66, 44);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(29, 32);
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
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
            // 
            // OrderDate
            // 
            this.OrderDate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderDate.Location = new System.Drawing.Point(446, 12);
            this.OrderDate.Name = "OrderDate";
            this.OrderDate.Size = new System.Drawing.Size(307, 29);
            this.OrderDate.TabIndex = 5;
            this.OrderDate.ValueChanged += new System.EventHandler(this.OrderDate_ValueChanged);
            // 
            // OrderList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.titlePanel);
            this.Controls.Add(this.OrderListView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
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
        private System.Windows.Forms.DateTimePicker OrderDate;
    }
}