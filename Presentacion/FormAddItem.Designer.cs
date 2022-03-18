namespace Presentacion
{
    partial class FormAddItem
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
            this.lblItemName = new System.Windows.Forms.Label();
            this.lvlItemCode = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblUrlImage = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblBrand = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtUrlImage = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.cbxTrademark = new System.Windows.Forms.ComboBox();
            this.cbxCategory = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.pbxAddImage = new System.Windows.Forms.PictureBox();
            this.errorProviderCode = new System.Windows.Forms.ErrorProvider(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddImage = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAddImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderCode)).BeginInit();
            this.SuspendLayout();
            // 
            // lblItemName
            // 
            this.lblItemName.AutoSize = true;
            this.lblItemName.Location = new System.Drawing.Point(45, 95);
            this.lblItemName.Name = "lblItemName";
            this.lblItemName.Size = new System.Drawing.Size(87, 20);
            this.lblItemName.TabIndex = 2;
            this.lblItemName.Text = "Item Name";
            // 
            // lvlItemCode
            // 
            this.lvlItemCode.AutoSize = true;
            this.lvlItemCode.Location = new System.Drawing.Point(45, 55);
            this.lvlItemCode.Name = "lvlItemCode";
            this.lvlItemCode.Size = new System.Drawing.Size(83, 20);
            this.lvlItemCode.TabIndex = 1;
            this.lvlItemCode.Text = "Item Code";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(45, 135);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(125, 20);
            this.lblDescription.TabIndex = 0;
            this.lblDescription.Text = "Item Description";
            // 
            // lblUrlImage
            // 
            this.lblUrlImage.AutoSize = true;
            this.lblUrlImage.Location = new System.Drawing.Point(45, 175);
            this.lblUrlImage.Name = "lblUrlImage";
            this.lblUrlImage.Size = new System.Drawing.Size(78, 20);
            this.lblUrlImage.TabIndex = 3;
            this.lblUrlImage.Text = "Url Image";
            // 
            // lblPrice
            // 
            this.lblPrice.Location = new System.Drawing.Point(0, 0);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(100, 23);
            this.lblPrice.TabIndex = 0;
            // 
            // lblBrand
            // 
            this.lblBrand.AutoSize = true;
            this.lblBrand.Location = new System.Drawing.Point(45, 255);
            this.lblBrand.Name = "lblBrand";
            this.lblBrand.Size = new System.Drawing.Size(85, 20);
            this.lblBrand.TabIndex = 5;
            this.lblBrand.Text = "Trademark";
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(45, 295);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(73, 20);
            this.lblCategory.TabIndex = 6;
            this.lblCategory.Text = "Category";
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(219, 55);
            this.txtCode.MaxLength = 3;
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(159, 26);
            this.txtCode.TabIndex = 1;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(219, 95);
            this.txtName.MaxLength = 20;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(159, 26);
            this.txtName.TabIndex = 2;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(219, 135);
            this.txtDescription.MaxLength = 50;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(159, 26);
            this.txtDescription.TabIndex = 3;
            // 
            // txtUrlImage
            // 
            this.txtUrlImage.Location = new System.Drawing.Point(219, 175);
            this.txtUrlImage.MaxLength = 300;
            this.txtUrlImage.Name = "txtUrlImage";
            this.txtUrlImage.Size = new System.Drawing.Size(159, 26);
            this.txtUrlImage.TabIndex = 4;
            this.txtUrlImage.Leave += new System.EventHandler(this.txtUrlImage_Leave);
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(219, 215);
            this.txtPrice.MaxLength = 200;
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(159, 26);
            this.txtPrice.TabIndex = 5;
            // 
            // cbxTrademark
            // 
            this.cbxTrademark.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTrademark.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.cbxTrademark.FormattingEnabled = true;
            this.cbxTrademark.Location = new System.Drawing.Point(219, 255);
            this.cbxTrademark.Name = "cbxTrademark";
            this.cbxTrademark.Size = new System.Drawing.Size(159, 28);
            this.cbxTrademark.TabIndex = 6;
            // 
            // cbxCategory
            // 
            this.cbxCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCategory.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.cbxCategory.FormattingEnabled = true;
            this.cbxCategory.Location = new System.Drawing.Point(219, 295);
            this.cbxCategory.Name = "cbxCategory";
            this.cbxCategory.Size = new System.Drawing.Size(159, 28);
            this.cbxCategory.TabIndex = 7;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(45, 361);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(142, 41);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Acept";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(219, 361);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(159, 41);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // pbxAddImage
            // 
            this.pbxAddImage.Location = new System.Drawing.Point(451, 55);
            this.pbxAddImage.Name = "pbxAddImage";
            this.pbxAddImage.Size = new System.Drawing.Size(281, 279);
            this.pbxAddImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxAddImage.TabIndex = 16;
            this.pbxAddImage.TabStop = false;
            // 
            // errorProviderCode
            // 
            this.errorProviderCode.ContainerControl = this;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 215);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 20);
            this.label1.TabIndex = 18;
            this.label1.Text = "Item Price";
            // 
            // btnAddImage
            // 
            this.btnAddImage.Location = new System.Drawing.Point(189, 176);
            this.btnAddImage.Name = "btnAddImage";
            this.btnAddImage.Size = new System.Drawing.Size(24, 26);
            this.btnAddImage.TabIndex = 19;
            this.btnAddImage.Text = "+";
            this.btnAddImage.UseVisualStyleBackColor = true;
            this.btnAddImage.Click += new System.EventHandler(this.btnAddImage_Click_1);
            // 
            // FormAddItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 414);
            this.Controls.Add(this.btnAddImage);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbxAddImage);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.cbxCategory);
            this.Controls.Add(this.cbxTrademark);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtUrlImage);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.lblBrand);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblUrlImage);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lvlItemCode);
            this.Controls.Add(this.lblItemName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FormAddItem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FormAddItem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxAddImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderCode)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblItemName;
        private System.Windows.Forms.Label lvlItemCode;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblUrlImage;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblBrand;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtUrlImage;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.ComboBox cbxTrademark;
        private System.Windows.Forms.ComboBox cbxCategory;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.PictureBox pbxAddImage;
        private System.Windows.Forms.ErrorProvider errorProviderCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddImage;
    }
}