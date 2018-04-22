namespace Invoice
{
    partial class CreateStore
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
            this.storeNameLabel = new System.Windows.Forms.Label();
            this.storePhoneLabel = new System.Windows.Forms.Label();
            this.contactNameLabel = new System.Windows.Forms.Label();
            this.contactPhoneLabel = new System.Windows.Forms.Label();
            this.storeDetailLabel = new System.Windows.Forms.Label();
            this.storeNameTxt = new System.Windows.Forms.TextBox();
            this.storePhoneTxt = new System.Windows.Forms.TextBox();
            this.storeAddressTxt = new System.Windows.Forms.TextBox();
            this.contactNameTxt = new System.Windows.Forms.TextBox();
            this.storeDetailTxt = new System.Windows.Forms.TextBox();
            this.createStoreTitleLabel = new System.Windows.Forms.Label();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.contactPhoneTxt = new System.Windows.Forms.TextBox();
            this.storeAddressLabel = new System.Windows.Forms.Label();
            this.storeFaxTxt = new System.Windows.Forms.TextBox();
            this.storeFaxLabel = new System.Windows.Forms.Label();
            this.isMarket = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // storeNameLabel
            // 
            this.storeNameLabel.AutoSize = true;
            this.storeNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.storeNameLabel.Location = new System.Drawing.Point(157, 116);
            this.storeNameLabel.Name = "storeNameLabel";
            this.storeNameLabel.Size = new System.Drawing.Size(102, 20);
            this.storeNameLabel.TabIndex = 0;
            this.storeNameLabel.Text = "Store Name: ";
            // 
            // storePhoneLabel
            // 
            this.storePhoneLabel.AutoSize = true;
            this.storePhoneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.storePhoneLabel.Location = new System.Drawing.Point(153, 146);
            this.storePhoneLabel.Name = "storePhoneLabel";
            this.storePhoneLabel.Size = new System.Drawing.Size(106, 20);
            this.storePhoneLabel.TabIndex = 1;
            this.storePhoneLabel.Text = "Store Phone: ";
            // 
            // contactNameLabel
            // 
            this.contactNameLabel.AutoSize = true;
            this.contactNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contactNameLabel.Location = new System.Drawing.Point(140, 278);
            this.contactNameLabel.Name = "contactNameLabel";
            this.contactNameLabel.Size = new System.Drawing.Size(119, 20);
            this.contactNameLabel.TabIndex = 2;
            this.contactNameLabel.Text = "Contact Name: ";
            // 
            // contactPhoneLabel
            // 
            this.contactPhoneLabel.AutoSize = true;
            this.contactPhoneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contactPhoneLabel.Location = new System.Drawing.Point(136, 309);
            this.contactPhoneLabel.Name = "contactPhoneLabel";
            this.contactPhoneLabel.Size = new System.Drawing.Size(123, 20);
            this.contactPhoneLabel.TabIndex = 3;
            this.contactPhoneLabel.Text = "Contact Phone: ";
            // 
            // storeDetailLabel
            // 
            this.storeDetailLabel.AutoSize = true;
            this.storeDetailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.storeDetailLabel.Location = new System.Drawing.Point(120, 342);
            this.storeDetailLabel.Name = "storeDetailLabel";
            this.storeDetailLabel.Size = new System.Drawing.Size(139, 20);
            this.storeDetailLabel.TabIndex = 4;
            this.storeDetailLabel.Text = "Store Detail/Note: ";
            // 
            // storeNameTxt
            // 
            this.storeNameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.storeNameTxt.Location = new System.Drawing.Point(267, 113);
            this.storeNameTxt.Name = "storeNameTxt";
            this.storeNameTxt.Size = new System.Drawing.Size(288, 26);
            this.storeNameTxt.TabIndex = 5;
            // 
            // storePhoneTxt
            // 
            this.storePhoneTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.storePhoneTxt.Location = new System.Drawing.Point(267, 143);
            this.storePhoneTxt.Name = "storePhoneTxt";
            this.storePhoneTxt.Size = new System.Drawing.Size(288, 26);
            this.storePhoneTxt.TabIndex = 6;
            this.storePhoneTxt.TextChanged += new System.EventHandler(this.StorePhoneTxt_TextChanged);
            // 
            // storeAddressTxt
            // 
            this.storeAddressTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.storeAddressTxt.Location = new System.Drawing.Point(267, 209);
            this.storeAddressTxt.Multiline = true;
            this.storeAddressTxt.Name = "storeAddressTxt";
            this.storeAddressTxt.Size = new System.Drawing.Size(288, 60);
            this.storeAddressTxt.TabIndex = 8;
            this.storeAddressTxt.UseWaitCursor = true;
            // 
            // contactNameTxt
            // 
            this.contactNameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.contactNameTxt.Location = new System.Drawing.Point(267, 275);
            this.contactNameTxt.Name = "contactNameTxt";
            this.contactNameTxt.Size = new System.Drawing.Size(288, 26);
            this.contactNameTxt.TabIndex = 9;
            // 
            // storeDetailTxt
            // 
            this.storeDetailTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.storeDetailTxt.Location = new System.Drawing.Point(267, 339);
            this.storeDetailTxt.Multiline = true;
            this.storeDetailTxt.Name = "storeDetailTxt";
            this.storeDetailTxt.Size = new System.Drawing.Size(288, 141);
            this.storeDetailTxt.TabIndex = 11;
            // 
            // createStoreTitleLabel
            // 
            this.createStoreTitleLabel.AutoSize = true;
            this.createStoreTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createStoreTitleLabel.Location = new System.Drawing.Point(307, 54);
            this.createStoreTitleLabel.Name = "createStoreTitleLabel";
            this.createStoreTitleLabel.Size = new System.Drawing.Size(209, 39);
            this.createStoreTitleLabel.TabIndex = 12;
            this.createStoreTitleLabel.Text = "Create Store";
            // 
            // cancelBtn
            // 
            this.cancelBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelBtn.Location = new System.Drawing.Point(267, 517);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(90, 30);
            this.cancelBtn.TabIndex = 13;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveBtn.Location = new System.Drawing.Point(465, 517);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(90, 30);
            this.saveBtn.TabIndex = 14;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // contactPhoneTxt
            // 
            this.contactPhoneTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.contactPhoneTxt.Location = new System.Drawing.Point(267, 306);
            this.contactPhoneTxt.Name = "contactPhoneTxt";
            this.contactPhoneTxt.Size = new System.Drawing.Size(288, 26);
            this.contactPhoneTxt.TabIndex = 10;
            this.contactPhoneTxt.TextChanged += new System.EventHandler(this.ContactPhoneTxt_TextChanged);
            // 
            // storeAddressLabel
            // 
            this.storeAddressLabel.AutoSize = true;
            this.storeAddressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.storeAddressLabel.Location = new System.Drawing.Point(140, 212);
            this.storeAddressLabel.Name = "storeAddressLabel";
            this.storeAddressLabel.Size = new System.Drawing.Size(119, 20);
            this.storeAddressLabel.TabIndex = 15;
            this.storeAddressLabel.Text = "Store Address: ";
            // 
            // storeFaxTxt
            // 
            this.storeFaxTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.storeFaxTxt.Location = new System.Drawing.Point(267, 176);
            this.storeFaxTxt.Name = "storeFaxTxt";
            this.storeFaxTxt.Size = new System.Drawing.Size(288, 26);
            this.storeFaxTxt.TabIndex = 7;
            this.storeFaxTxt.TextChanged += new System.EventHandler(this.StoreFaxTxt_TextChanged);
            // 
            // storeFaxLabel
            // 
            this.storeFaxLabel.AutoSize = true;
            this.storeFaxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.storeFaxLabel.Location = new System.Drawing.Point(153, 179);
            this.storeFaxLabel.Name = "storeFaxLabel";
            this.storeFaxLabel.Size = new System.Drawing.Size(86, 20);
            this.storeFaxLabel.TabIndex = 16;
            this.storeFaxLabel.Text = "Store Fax: ";
            // 
            // isMarket
            // 
            this.isMarket.AutoSize = true;
            this.isMarket.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.isMarket.Location = new System.Drawing.Point(267, 486);
            this.isMarket.Name = "isMarket";
            this.isMarket.Size = new System.Drawing.Size(116, 24);
            this.isMarket.TabIndex = 17;
            this.isMarket.Text = "Is a market?";
            this.isMarket.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.isMarket.UseVisualStyleBackColor = true;
            // 
            // CreateStore
            // 
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.isMarket);
            this.Controls.Add(this.storeFaxTxt);
            this.Controls.Add(this.storeFaxLabel);
            this.Controls.Add(this.contactPhoneTxt);
            this.Controls.Add(this.storeAddressLabel);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.createStoreTitleLabel);
            this.Controls.Add(this.storeDetailTxt);
            this.Controls.Add(this.contactNameTxt);
            this.Controls.Add(this.storeAddressTxt);
            this.Controls.Add(this.storePhoneTxt);
            this.Controls.Add(this.storeNameTxt);
            this.Controls.Add(this.storeDetailLabel);
            this.Controls.Add(this.contactPhoneLabel);
            this.Controls.Add(this.contactNameLabel);
            this.Controls.Add(this.storePhoneLabel);
            this.Controls.Add(this.storeNameLabel);
            this.Name = "CreateStore";
            this.Load += new System.EventHandler(this.CreateStore_Load);
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
        private System.Windows.Forms.Label storeNameLabel;
        private System.Windows.Forms.Label storePhoneLabel;
        private System.Windows.Forms.Label contactNameLabel;
        private System.Windows.Forms.Label contactPhoneLabel;
        private System.Windows.Forms.Label storeDetailLabel;
        private System.Windows.Forms.TextBox storeNameTxt;
        private System.Windows.Forms.TextBox storePhoneTxt;
        private System.Windows.Forms.TextBox storeAddressTxt;
        private System.Windows.Forms.TextBox contactNameTxt;
        private System.Windows.Forms.TextBox storeDetailTxt;
        private System.Windows.Forms.Label createStoreTitleLabel;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.TextBox contactPhoneTxt;
        private System.Windows.Forms.Label storeAddressLabel;
        private System.Windows.Forms.TextBox storeFaxTxt;
        private System.Windows.Forms.Label storeFaxLabel;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.CheckBox isMarket;
    }
}