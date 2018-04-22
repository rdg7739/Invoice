namespace Invoice
{
    partial class WeeklyExpense
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
            this.WeeklyExpenseLbl = new System.Windows.Forms.Label();
            this.WeeklyExpenseDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.WeeklyExpenseDataView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.WeeklyExpenseDataView)).BeginInit();
            this.SuspendLayout();
            // 
            // WeeklyExpenseLbl
            // 
            this.WeeklyExpenseLbl.AutoSize = true;
            this.WeeklyExpenseLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WeeklyExpenseLbl.Location = new System.Drawing.Point(45, 36);
            this.WeeklyExpenseLbl.Name = "WeeklyExpenseLbl";
            this.WeeklyExpenseLbl.Size = new System.Drawing.Size(271, 39);
            this.WeeklyExpenseLbl.TabIndex = 1;
            this.WeeklyExpenseLbl.Text = "Weekly Expense";
            // 
            // WeeklyExpenseDateTimePicker
            // 
            this.WeeklyExpenseDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WeeklyExpenseDateTimePicker.Location = new System.Drawing.Point(470, 49);
            this.WeeklyExpenseDateTimePicker.Name = "WeeklyExpenseDateTimePicker";
            this.WeeklyExpenseDateTimePicker.Size = new System.Drawing.Size(263, 26);
            this.WeeklyExpenseDateTimePicker.TabIndex = 2;
            this.WeeklyExpenseDateTimePicker.ValueChanged += new System.EventHandler(this.WeeklyExpenseDateTimePicker_ValueChanged);
            // 
            // WeeklyExpenseDataView
            // 
            this.WeeklyExpenseDataView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.WeeklyExpenseDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.WeeklyExpenseDataView.Location = new System.Drawing.Point(52, 101);
            this.WeeklyExpenseDataView.Name = "WeeklyExpenseDataView";
            this.WeeklyExpenseDataView.ReadOnly = true;
            this.WeeklyExpenseDataView.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.WeeklyExpenseDataView.Size = new System.Drawing.Size(681, 440);
            this.WeeklyExpenseDataView.TabIndex = 3;
            // 
            // WeeklyExpense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.WeeklyExpenseDataView);
            this.Controls.Add(this.WeeklyExpenseDateTimePicker);
            this.Controls.Add(this.WeeklyExpenseLbl);
            this.Name = "WeeklyExpense";
            this.Text = "WeeklyExpense";
            ((System.ComponentModel.ISupportInitialize)(this.WeeklyExpenseDataView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label WeeklyExpenseLbl;
        private System.Windows.Forms.DateTimePicker WeeklyExpenseDateTimePicker;
        private System.Windows.Forms.DataGridView WeeklyExpenseDataView;
    }
}