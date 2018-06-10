namespace Invoice
{
    partial class MyStore
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MyStore));
            this.storeNameLabel = new System.Windows.Forms.Label();
            this.storePhoneLabels = new System.Windows.Forms.Label();
            this.storeAddressLabel = new System.Windows.Forms.Label();
            this.storeDetailabel = new System.Windows.Forms.Label();
            this.storeNameTxt = new System.Windows.Forms.TextBox();
            this.storePhoneTxt = new System.Windows.Forms.TextBox();
            this.storeAddressTxt = new System.Windows.Forms.TextBox();
            this.storeDetailTxt = new System.Windows.Forms.TextBox();
            this.cancelBtn = new Invoice.ButtonModified();
            this.saveBtn = new Invoice.ButtonModified();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.storeFaxTxt = new System.Windows.Forms.TextBox();
            this.storeFaxLabel = new System.Windows.Forms.Label();
            this.titlePanel = new System.Windows.Forms.Panel();
            this.closeBtn = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Title = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.titlePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // storeNameLabel
            // 
            this.storeNameLabel.AutoSize = true;
            this.storeNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.storeNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.storeNameLabel.Location = new System.Drawing.Point(69, 126);
            this.storeNameLabel.Name = "storeNameLabel";
            this.storeNameLabel.Size = new System.Drawing.Size(127, 25);
            this.storeNameLabel.TabIndex = 0;
            this.storeNameLabel.Text = "Store Name: ";
            // 
            // storePhoneLabels
            // 
            this.storePhoneLabels.AutoSize = true;
            this.storePhoneLabels.BackColor = System.Drawing.Color.Transparent;
            this.storePhoneLabels.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.storePhoneLabels.Location = new System.Drawing.Point(64, 158);
            this.storePhoneLabels.Name = "storePhoneLabels";
            this.storePhoneLabels.Size = new System.Drawing.Size(132, 25);
            this.storePhoneLabels.TabIndex = 1;
            this.storePhoneLabels.Text = "Store Phone: ";
            // 
            // storeAddressLabel
            // 
            this.storeAddressLabel.AutoSize = true;
            this.storeAddressLabel.BackColor = System.Drawing.Color.Transparent;
            this.storeAddressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.storeAddressLabel.Location = new System.Drawing.Point(50, 224);
            this.storeAddressLabel.Name = "storeAddressLabel";
            this.storeAddressLabel.Size = new System.Drawing.Size(148, 25);
            this.storeAddressLabel.TabIndex = 2;
            this.storeAddressLabel.Text = "Store Address: ";
            // 
            // storeDetailabel
            // 
            this.storeDetailabel.AutoSize = true;
            this.storeDetailabel.BackColor = System.Drawing.Color.Transparent;
            this.storeDetailabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.storeDetailabel.Location = new System.Drawing.Point(25, 291);
            this.storeDetailabel.Name = "storeDetailabel";
            this.storeDetailabel.Size = new System.Drawing.Size(171, 25);
            this.storeDetailabel.TabIndex = 3;
            this.storeDetailabel.Text = "Store Detail/Note: ";
            // 
            // storeNameTxt
            // 
            this.storeNameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.storeNameTxt.Location = new System.Drawing.Point(202, 127);
            this.storeNameTxt.Name = "storeNameTxt";
            this.storeNameTxt.Size = new System.Drawing.Size(300, 26);
            this.storeNameTxt.TabIndex = 4;
            // 
            // storePhoneTxt
            // 
            this.storePhoneTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.storePhoneTxt.Location = new System.Drawing.Point(202, 159);
            this.storePhoneTxt.Name = "storePhoneTxt";
            this.storePhoneTxt.Size = new System.Drawing.Size(300, 26);
            this.storePhoneTxt.TabIndex = 6;
            // 
            // storeAddressTxt
            // 
            this.storeAddressTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.storeAddressTxt.Location = new System.Drawing.Point(202, 225);
            this.storeAddressTxt.Multiline = true;
            this.storeAddressTxt.Name = "storeAddressTxt";
            this.storeAddressTxt.Size = new System.Drawing.Size(300, 60);
            this.storeAddressTxt.TabIndex = 8;
            // 
            // storeDetailTxt
            // 
            this.storeDetailTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.storeDetailTxt.Location = new System.Drawing.Point(202, 292);
            this.storeDetailTxt.Multiline = true;
            this.storeDetailTxt.Name = "storeDetailTxt";
            this.storeDetailTxt.Size = new System.Drawing.Size(300, 141);
            this.storeDetailTxt.TabIndex = 11;
            // 
            // cancelBtn
            // 
            this.cancelBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.cancelBtn.Location = new System.Drawing.Point(202, 441);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(130, 34);
            this.cancelBtn.TabIndex = 13;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.saveBtn.Location = new System.Drawing.Point(372, 441);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(130, 34);
            this.saveBtn.TabIndex = 14;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // storeFaxTxt
            // 
            this.storeFaxTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.storeFaxTxt.Location = new System.Drawing.Point(202, 192);
            this.storeFaxTxt.Name = "storeFaxTxt";
            this.storeFaxTxt.Size = new System.Drawing.Size(300, 26);
            this.storeFaxTxt.TabIndex = 7;
            // 
            // storeFaxLabel
            // 
            this.storeFaxLabel.AutoSize = true;
            this.storeFaxLabel.BackColor = System.Drawing.Color.Transparent;
            this.storeFaxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.storeFaxLabel.Location = new System.Drawing.Point(88, 191);
            this.storeFaxLabel.Name = "storeFaxLabel";
            this.storeFaxLabel.Size = new System.Drawing.Size(108, 25);
            this.storeFaxLabel.TabIndex = 15;
            this.storeFaxLabel.Text = "Store Fax: ";
            // 
            // titlePanel
            // 
            this.titlePanel.BackColor = System.Drawing.Color.SteelBlue;
            this.titlePanel.Controls.Add(this.closeBtn);
            this.titlePanel.Controls.Add(this.pictureBox2);
            this.titlePanel.Controls.Add(this.pictureBox1);
            this.titlePanel.Controls.Add(this.Title);
            this.titlePanel.Location = new System.Drawing.Point(1, 1);
            this.titlePanel.Name = "titlePanel";
            this.titlePanel.Size = new System.Drawing.Size(582, 91);
            this.titlePanel.TabIndex = 19;
            this.titlePanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.DragTitlePanel);
            // 
            // closeBtn
            // 
            this.closeBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.closeBtn.Location = new System.Drawing.Point(561, 3);
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
            this.pictureBox2.Location = new System.Drawing.Point(162, 44);
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
            this.pictureBox1.Location = new System.Drawing.Point(127, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(57, 55);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.DragTitlePanel);
            // 
            // Title
            // 
            this.Title.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Title.Font = new System.Drawing.Font("Arial", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Title.Location = new System.Drawing.Point(128, 16);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(387, 60);
            this.Title.TabIndex = 1;
            this.Title.Text = "My Store";
            this.Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Title.MouseMove += new System.Windows.Forms.MouseEventHandler(this.DragTitlePanel);
            // 
            // MyStore
            // 
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(584, 489);
            this.Controls.Add(this.titlePanel);
            this.Controls.Add(this.storeFaxTxt);
            this.Controls.Add(this.storeFaxLabel);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.storeDetailTxt);
            this.Controls.Add(this.storeAddressTxt);
            this.Controls.Add(this.storePhoneTxt);
            this.Controls.Add(this.storeNameTxt);
            this.Controls.Add(this.storeDetailabel);
            this.Controls.Add(this.storeAddressLabel);
            this.Controls.Add(this.storePhoneLabels);
            this.Controls.Add(this.storeNameLabel);
            this.Name = "MyStore";
            this.Load += new System.EventHandler(this.MyStore_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.titlePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label storeNameLabel;
        private System.Windows.Forms.Label storePhoneLabels;
        private System.Windows.Forms.Label storeAddressLabel;
        private System.Windows.Forms.Label storeDetailabel;
        private System.Windows.Forms.TextBox storeNameTxt;
        private System.Windows.Forms.TextBox storePhoneTxt;
        private System.Windows.Forms.TextBox storeAddressTxt;
        private System.Windows.Forms.TextBox storeDetailTxt;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.TextBox storeFaxTxt;
        private System.Windows.Forms.Label storeFaxLabel;
        private System.Windows.Forms.Panel titlePanel;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Title;
        private ButtonModified cancelBtn;
        private ButtonModified saveBtn;
    }
}