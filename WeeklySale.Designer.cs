namespace Invoice
{
    partial class WeeklySale
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
            this.WeeklySaleLbl = new System.Windows.Forms.Label();
            this.WeeklySaleDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.WeeklySaleDataView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.WeeklySaleDataView)).BeginInit();
            this.SuspendLayout();
            // 
            // WeeklySaleLbl
            // 
            this.WeeklySaleLbl.AutoSize = true;
            this.WeeklySaleLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WeeklySaleLbl.Location = new System.Drawing.Point(85, 43);
            this.WeeklySaleLbl.Name = "WeeklySaleLbl";
            this.WeeklySaleLbl.Size = new System.Drawing.Size(207, 39);
            this.WeeklySaleLbl.TabIndex = 0;
            this.WeeklySaleLbl.Text = "Weekly Sale";
            // 
            // WeeklySaleDateTimePicker
            // 
            this.WeeklySaleDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WeeklySaleDateTimePicker.Location = new System.Drawing.Point(456, 53);
            this.WeeklySaleDateTimePicker.Name = "WeeklySaleDateTimePicker";
            this.WeeklySaleDateTimePicker.Size = new System.Drawing.Size(263, 26);
            this.WeeklySaleDateTimePicker.TabIndex = 1;
            this.WeeklySaleDateTimePicker.ValueChanged += new System.EventHandler(this.DateTimePicker1_ValueChanged);
            // 
            // WeeklySaleDataView
            // 
            this.WeeklySaleDataView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.WeeklySaleDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.WeeklySaleDataView.Location = new System.Drawing.Point(43, 108);
            this.WeeklySaleDataView.Name = "WeeklySaleDataView";
            this.WeeklySaleDataView.ReadOnly = true;
            this.WeeklySaleDataView.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.WeeklySaleDataView.Size = new System.Drawing.Size(697, 409);
            this.WeeklySaleDataView.TabIndex = 2;
            // 
            // WeeklySale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.WeeklySaleDataView);
            this.Controls.Add(this.WeeklySaleDateTimePicker);
            this.Controls.Add(this.WeeklySaleLbl);
            this.Name = "WeeklySale";
            this.Text = "WeeklySale";
            ((System.ComponentModel.ISupportInitialize)(this.WeeklySaleDataView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label WeeklySaleLbl;
        private System.Windows.Forms.DateTimePicker WeeklySaleDateTimePicker;
        private System.Windows.Forms.DataGridView WeeklySaleDataView;
    }
}