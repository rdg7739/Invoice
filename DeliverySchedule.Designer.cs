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
            this.DeliveryScheduleLbl = new System.Windows.Forms.Label();
            this.DeliveryScheduleView = new System.Windows.Forms.DataGridView();
            this.DeliveryScheduleDate = new System.Windows.Forms.DateTimePicker();
            this.Save = new System.Windows.Forms.Button();
            this.CancelBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DeliveryScheduleView)).BeginInit();
            this.SuspendLayout();
            // 
            // DeliveryScheduleLbl
            // 
            this.DeliveryScheduleLbl.AutoSize = true;
            this.DeliveryScheduleLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeliveryScheduleLbl.Location = new System.Drawing.Point(80, 46);
            this.DeliveryScheduleLbl.Name = "DeliveryScheduleLbl";
            this.DeliveryScheduleLbl.Size = new System.Drawing.Size(311, 39);
            this.DeliveryScheduleLbl.TabIndex = 0;
            this.DeliveryScheduleLbl.Text = "Delivery Schedule: ";
            // 
            // DeliveryScheduleView
            // 
            this.DeliveryScheduleView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DeliveryScheduleView.Location = new System.Drawing.Point(87, 116);
            this.DeliveryScheduleView.Name = "DeliveryScheduleView";
            this.DeliveryScheduleView.Size = new System.Drawing.Size(643, 271);
            this.DeliveryScheduleView.TabIndex = 1;
            // 
            // DeliveryScheduleDate
            // 
            this.DeliveryScheduleDate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeliveryScheduleDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeliveryScheduleDate.Location = new System.Drawing.Point(397, 52);
            this.DeliveryScheduleDate.Name = "DeliveryScheduleDate";
            this.DeliveryScheduleDate.Size = new System.Drawing.Size(333, 30);
            this.DeliveryScheduleDate.TabIndex = 2;
            this.DeliveryScheduleDate.ValueChanged += new System.EventHandler(this.DeliveryScheduleDate_ValueChanged);
            // 
            // Save
            // 
            this.Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Save.Location = new System.Drawing.Point(630, 400);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(100, 30);
            this.Save.TabIndex = 3;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // CancelBtn
            // 
            this.CancelBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelBtn.Location = new System.Drawing.Point(524, 400);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(100, 30);
            this.CancelBtn.TabIndex = 4;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = true;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // DeliverySchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.DeliveryScheduleDate);
            this.Controls.Add(this.DeliveryScheduleView);
            this.Controls.Add(this.DeliveryScheduleLbl);
            this.Name = "DeliverySchedule";
            this.Text = "DeliverySchedule";
            ((System.ComponentModel.ISupportInitialize)(this.DeliveryScheduleView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label DeliveryScheduleLbl;
        private System.Windows.Forms.DataGridView DeliveryScheduleView;
        private System.Windows.Forms.DateTimePicker DeliveryScheduleDate;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Button CancelBtn;
    }
}