namespace Invoice
{
    partial class DeliverySchedule
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeliverySchedule));
            this.DeliveryScheduleView = new System.Windows.Forms.DataGridView();
            this.DeliveryScheduleDate = new System.Windows.Forms.DateTimePicker();
            this.Save = new Invoice.ButtonModified();
            this.CancelBtn = new Invoice.ButtonModified();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Title = new System.Windows.Forms.Label();
            this.titlePanel = new System.Windows.Forms.Panel();
            this.closeBtn = new System.Windows.Forms.Button();
            this.PrintBtn = new Invoice.ButtonModified();
            ((System.ComponentModel.ISupportInitialize)(this.DeliveryScheduleView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.titlePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // DeliveryScheduleView
            // 
            this.DeliveryScheduleView.AllowUserToAddRows = false;
            this.DeliveryScheduleView.AllowUserToDeleteRows = false;
            this.DeliveryScheduleView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DeliveryScheduleView.BackgroundColor = System.Drawing.SystemColors.Window;
            this.DeliveryScheduleView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DeliveryScheduleView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.DeliveryScheduleView.Location = new System.Drawing.Point(32, 108);
            this.DeliveryScheduleView.Name = "DeliveryScheduleView";
            this.DeliveryScheduleView.RowHeadersVisible = false;
            this.DeliveryScheduleView.Size = new System.Drawing.Size(722, 286);
            this.DeliveryScheduleView.TabIndex = 1;
            // 
            // DeliveryScheduleDate
            // 
            this.DeliveryScheduleDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DeliveryScheduleDate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeliveryScheduleDate.CustomFormat = "MMM/dd/yy dddd";
            this.DeliveryScheduleDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeliveryScheduleDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DeliveryScheduleDate.Location = new System.Drawing.Point(446, 35);
            this.DeliveryScheduleDate.Name = "DeliveryScheduleDate";
            this.DeliveryScheduleDate.Size = new System.Drawing.Size(307, 29);
            this.DeliveryScheduleDate.TabIndex = 2;
            this.DeliveryScheduleDate.ValueChanged += new System.EventHandler(this.DeliveryScheduleDate_ValueChanged);
            // 
            // Save
            // 
            this.Save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Save.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.Save.Location = new System.Drawing.Point(624, 404);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(130, 34);
            this.Save.TabIndex = 3;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // CancelBtn
            // 
            this.CancelBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CancelBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.CancelBtn.Location = new System.Drawing.Point(468, 404);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(137, 34);
            this.CancelBtn.TabIndex = 4;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = true;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
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
            this.Title.Size = new System.Drawing.Size(399, 60);
            this.Title.TabIndex = 1;
            this.Title.Text = "Delivery Schedule: ";
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
            this.titlePanel.Controls.Add(this.DeliveryScheduleDate);
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
            // PrintBtn
            // 
            this.PrintBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.PrintBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrintBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.PrintBtn.Location = new System.Drawing.Point(32, 404);
            this.PrintBtn.Name = "PrintBtn";
            this.PrintBtn.Size = new System.Drawing.Size(247, 34);
            this.PrintBtn.TabIndex = 27;
            this.PrintBtn.Text = "Print Delievery Schedule";
            this.PrintBtn.UseVisualStyleBackColor = true;
            this.PrintBtn.Click += new System.EventHandler(this.PrintBtn_Click);
            // 
            // DeliverySchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(784, 450);
            this.Controls.Add(this.PrintBtn);
            this.Controls.Add(this.titlePanel);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.DeliveryScheduleView);
            this.Name = "DeliverySchedule";
            this.Text = "DeliverySchedule";
            ((System.ComponentModel.ISupportInitialize)(this.DeliveryScheduleView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.titlePanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView DeliveryScheduleView;
        private System.Windows.Forms.DateTimePicker DeliveryScheduleDate;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Panel titlePanel;
        private System.Windows.Forms.Button closeBtn;
        private ButtonModified PrintBtn;
        private ButtonModified Save;
        private ButtonModified CancelBtn;
    }
}