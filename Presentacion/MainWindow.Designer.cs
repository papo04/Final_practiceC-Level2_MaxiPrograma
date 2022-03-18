namespace Presentacion
{
    partial class MainWindow
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvItems = new System.Windows.Forms.DataGridView();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.btnModify = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.pbxMainImage = new System.Windows.Forms.PictureBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxField = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxStandar = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtDescriptionReadOnly = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxMainImage)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvItems
            // 
            this.dgvItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItems.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvItems.Location = new System.Drawing.Point(12, 12);
            this.dgvItems.Name = "dgvItems";
            this.dgvItems.RowHeadersWidth = 62;
            this.dgvItems.RowTemplate.Height = 28;
            this.dgvItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvItems.Size = new System.Drawing.Size(741, 296);
            this.dgvItems.TabIndex = 0;
            this.dgvItems.SelectionChanged += new System.EventHandler(this.dgvItems_SelectionChanged);
            // 
            // btnAddItem
            // 
            this.btnAddItem.Location = new System.Drawing.Point(20, 326);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(106, 44);
            this.btnAddItem.TabIndex = 1;
            this.btnAddItem.Text = "Add Item";
            this.btnAddItem.UseVisualStyleBackColor = true;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // btnModify
            // 
            this.btnModify.Location = new System.Drawing.Point(149, 326);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(106, 44);
            this.btnModify.TabIndex = 2;
            this.btnModify.Text = "Modify Item";
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(276, 326);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(106, 44);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Delete Item";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // pbxMainImage
            // 
            this.pbxMainImage.Location = new System.Drawing.Point(770, 16);
            this.pbxMainImage.Name = "pbxMainImage";
            this.pbxMainImage.Size = new System.Drawing.Size(330, 296);
            this.pbxMainImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxMainImage.TabIndex = 4;
            this.pbxMainImage.TabStop = false;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(844, 315);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(0, 32);
            this.lblDescription.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 396);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Field";
            // 
            // cbxField
            // 
            this.cbxField.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxField.FormattingEnabled = true;
            this.cbxField.Location = new System.Drawing.Point(75, 393);
            this.cbxField.Name = "cbxField";
            this.cbxField.Size = new System.Drawing.Size(295, 28);
            this.cbxField.TabIndex = 4;
            this.cbxField.SelectedIndexChanged += new System.EventHandler(this.cbxField_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(376, 396);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Standar";
            // 
            // cbxStandar
            // 
            this.cbxStandar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxStandar.FormattingEnabled = true;
            this.cbxStandar.Location = new System.Drawing.Point(441, 393);
            this.cbxStandar.Name = "cbxStandar";
            this.cbxStandar.Size = new System.Drawing.Size(312, 28);
            this.cbxStandar.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 447);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Filter";
            // 
            // txtFilter
            // 
            this.txtFilter.Location = new System.Drawing.Point(76, 441);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(203, 26);
            this.txtFilter.TabIndex = 6;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(290, 435);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(92, 40);
            this.btnSearch.TabIndex = 7;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtDescriptionReadOnly
            // 
            this.txtDescriptionReadOnly.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescriptionReadOnly.Location = new System.Drawing.Point(770, 318);
            this.txtDescriptionReadOnly.Multiline = true;
            this.txtDescriptionReadOnly.Name = "txtDescriptionReadOnly";
            this.txtDescriptionReadOnly.ReadOnly = true;
            this.txtDescriptionReadOnly.Size = new System.Drawing.Size(330, 162);
            this.txtDescriptionReadOnly.TabIndex = 13;
            // 
            // MainWindow
            // 
            this.ClientSize = new System.Drawing.Size(1106, 500);
            this.Controls.Add(this.txtDescriptionReadOnly);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtFilter);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbxStandar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbxField);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.pbxMainImage);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnModify);
            this.Controls.Add(this.btnAddItem);
            this.Controls.Add(this.dgvItems);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.MainWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxMainImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

       
        private System.Windows.Forms.DataGridView dgvItems;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.PictureBox pbxMainImage;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxField;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxStandar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFilter;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtDescriptionReadOnly;
    }
}

