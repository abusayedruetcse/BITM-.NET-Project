namespace StockManagementSystem.Screens
{
    partial class StockInForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxCompanyName = new System.Windows.Forms.ComboBox();
            this.companyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.companiesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.textBoxReorderLevel = new System.Windows.Forms.TextBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.dataGridViewStockInAllRecord = new System.Windows.Forms.DataGridView();
            this.stockInsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.stockManagementDBDataSet = new StockManagementSystem.StockManagementDBDataSet();
            this.stockOutBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stockInsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxCategoryName = new System.Windows.Forms.ComboBox();
            this.categoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.categoriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxItemName = new System.Windows.Forms.ComboBox();
            this.itemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.itemsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxAvailableQuantity = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxStockInQuantity = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dateTimePickerUserDefineDate = new System.Windows.Forms.DateTimePicker();
            this.stockInsTableAdapter = new StockManagementSystem.StockManagementDBDataSetTableAdapters.StockInsTableAdapter();
            this.SL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Action = new System.Windows.Forms.DataGridViewButtonColumn();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.companyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.companiesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStockInAllRecord)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockInsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockManagementDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockOutBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockInsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(120, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Company Name :";
            // 
            // comboBoxCompanyName
            // 
            this.comboBoxCompanyName.DataSource = this.companyBindingSource;
            this.comboBoxCompanyName.DisplayMember = "Name";
            this.comboBoxCompanyName.FormattingEnabled = true;
            this.comboBoxCompanyName.Location = new System.Drawing.Point(264, 60);
            this.comboBoxCompanyName.Name = "comboBoxCompanyName";
            this.comboBoxCompanyName.Size = new System.Drawing.Size(311, 24);
            this.comboBoxCompanyName.TabIndex = 1;
            this.comboBoxCompanyName.ValueMember = "ID";
            this.comboBoxCompanyName.Click += new System.EventHandler(this.comboBoxCompanyName_Click);
            // 
            // companyBindingSource
            // 
            this.companyBindingSource.DataSource = typeof(StockManagementSystem.Models.Company);
            // 
            // companiesBindingSource
            // 
            this.companiesBindingSource.DataMember = "Companies";
            // 
            // textBoxReorderLevel
            // 
            this.textBoxReorderLevel.Location = new System.Drawing.Point(264, 246);
            this.textBoxReorderLevel.Name = "textBoxReorderLevel";
            this.textBoxReorderLevel.Size = new System.Drawing.Size(156, 23);
            this.textBoxReorderLevel.TabIndex = 2;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(411, 397);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(164, 37);
            this.buttonSave.TabIndex = 3;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // dataGridViewStockInAllRecord
            // 
            this.dataGridViewStockInAllRecord.AllowUserToAddRows = false;
            this.dataGridViewStockInAllRecord.AllowUserToDeleteRows = false;
            this.dataGridViewStockInAllRecord.AutoGenerateColumns = false;
            this.dataGridViewStockInAllRecord.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewStockInAllRecord.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStockInAllRecord.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SL,
            this.ItemName,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.Action,
            this.iDDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn3});
            this.dataGridViewStockInAllRecord.DataSource = this.stockInsBindingSource1;
            this.dataGridViewStockInAllRecord.Location = new System.Drawing.Point(641, 60);
            this.dataGridViewStockInAllRecord.Name = "dataGridViewStockInAllRecord";
            this.dataGridViewStockInAllRecord.ReadOnly = true;
            this.dataGridViewStockInAllRecord.Size = new System.Drawing.Size(631, 403);
            this.dataGridViewStockInAllRecord.TabIndex = 4;
            this.dataGridViewStockInAllRecord.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewStockInAllRecord_CellContentClick);
            // 
            // stockInsBindingSource1
            // 
            this.stockInsBindingSource1.DataMember = "StockIns";
            this.stockInsBindingSource1.DataSource = this.stockManagementDBDataSet;
            // 
            // stockManagementDBDataSet
            // 
            this.stockManagementDBDataSet.DataSetName = "StockManagementDBDataSet";
            this.stockManagementDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // stockOutBindingSource
            // 
            this.stockOutBindingSource.DataSource = typeof(StockManagementSystem.Models.StockOut);
            // 
            // stockInsBindingSource
            // 
            this.stockInsBindingSource.DataMember = "StockIns";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(122, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Category Name :";
            // 
            // comboBoxCategoryName
            // 
            this.comboBoxCategoryName.DataSource = this.categoryBindingSource;
            this.comboBoxCategoryName.DisplayMember = "Name";
            this.comboBoxCategoryName.FormattingEnabled = true;
            this.comboBoxCategoryName.Location = new System.Drawing.Point(264, 125);
            this.comboBoxCategoryName.Name = "comboBoxCategoryName";
            this.comboBoxCategoryName.Size = new System.Drawing.Size(311, 24);
            this.comboBoxCategoryName.TabIndex = 1;
            this.comboBoxCategoryName.ValueMember = "ID";
            this.comboBoxCategoryName.Click += new System.EventHandler(this.comboBoxCategoryName_Click);
            // 
            // categoryBindingSource
            // 
            this.categoryBindingSource.DataSource = typeof(StockManagementSystem.Models.Category);
            // 
            // categoriesBindingSource
            // 
            this.categoriesBindingSource.DataMember = "Categories";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(153, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Item Name :";
            // 
            // comboBoxItemName
            // 
            this.comboBoxItemName.DataSource = this.itemBindingSource;
            this.comboBoxItemName.DisplayMember = "Name";
            this.comboBoxItemName.FormattingEnabled = true;
            this.comboBoxItemName.Location = new System.Drawing.Point(264, 186);
            this.comboBoxItemName.Name = "comboBoxItemName";
            this.comboBoxItemName.Size = new System.Drawing.Size(311, 24);
            this.comboBoxItemName.TabIndex = 1;
            this.comboBoxItemName.ValueMember = "ID";
            this.comboBoxItemName.SelectedIndexChanged += new System.EventHandler(this.comboBoxItemName_SelectedIndexChanged);
            this.comboBoxItemName.Click += new System.EventHandler(this.comboBoxItemName_Click);
            // 
            // itemBindingSource
            // 
            this.itemBindingSource.DataSource = typeof(StockManagementSystem.Models.Item);
            // 
            // itemsBindingSource
            // 
            this.itemsBindingSource.DataMember = "Items";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(129, 249);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Reorder Lebel :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(106, 286);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Available Quantity :";
            // 
            // textBoxAvailableQuantity
            // 
            this.textBoxAvailableQuantity.Location = new System.Drawing.Point(264, 283);
            this.textBoxAvailableQuantity.Name = "textBoxAvailableQuantity";
            this.textBoxAvailableQuantity.Size = new System.Drawing.Size(156, 23);
            this.textBoxAvailableQuantity.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(113, 347);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Stock In Quantity :";
            // 
            // textBoxStockInQuantity
            // 
            this.textBoxStockInQuantity.Location = new System.Drawing.Point(264, 345);
            this.textBoxStockInQuantity.Name = "textBoxStockInQuantity";
            this.textBoxStockInQuantity.Size = new System.Drawing.Size(156, 23);
            this.textBoxStockInQuantity.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(493, 246);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "Date :";
            // 
            // dateTimePickerUserDefineDate
            // 
            this.dateTimePickerUserDefineDate.CustomFormat = "dd/MM/yyyy";
            this.dateTimePickerUserDefineDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerUserDefineDate.Location = new System.Drawing.Point(444, 283);
            this.dateTimePickerUserDefineDate.Name = "dateTimePickerUserDefineDate";
            this.dateTimePickerUserDefineDate.Size = new System.Drawing.Size(131, 23);
            this.dateTimePickerUserDefineDate.TabIndex = 5;
            // 
            // stockInsTableAdapter
            // 
            this.stockInsTableAdapter.ClearBeforeFill = true;
            // 
            // SL
            // 
            this.SL.DataPropertyName = "SL";
            this.SL.FillWeight = 59.09711F;
            this.SL.HeaderText = "SL";
            this.SL.Name = "SL";
            this.SL.ReadOnly = true;
            // 
            // ItemName
            // 
            this.ItemName.DataPropertyName = "ItemName";
            this.ItemName.FillWeight = 111.7548F;
            this.ItemName.HeaderText = "Item";
            this.ItemName.Name = "ItemName";
            this.ItemName.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Date";
            this.dataGridViewTextBoxColumn1.HeaderText = "Date";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Quantity";
            this.dataGridViewTextBoxColumn2.FillWeight = 105.4644F;
            this.dataGridViewTextBoxColumn2.HeaderText = "Quantity";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // Action
            // 
            this.Action.DataPropertyName = "Action";
            this.Action.FillWeight = 111.7548F;
            this.Action.HeaderText = "Action";
            this.Action.Name = "Action";
            this.Action.ReadOnly = true;
            this.Action.Text = "Edit";
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.Visible = false;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "ItemID";
            this.dataGridViewTextBoxColumn3.HeaderText = "ItemID";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Visible = false;
            // 
            // StockInForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 528);
            this.Controls.Add(this.dateTimePickerUserDefineDate);
            this.Controls.Add(this.dataGridViewStockInAllRecord);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.textBoxStockInQuantity);
            this.Controls.Add(this.textBoxAvailableQuantity);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxReorderLevel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBoxItemName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxCategoryName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxCompanyName);
            this.Controls.Add(this.label1);
            this.Location = new System.Drawing.Point(0, 0);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "StockInForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stock In Form";
            this.WindowState = System.Windows.Forms.FormWindowState.Normal;
            this.Load += new System.EventHandler(this.StockInForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.companyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.companiesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStockInAllRecord)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockInsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockManagementDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockOutBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockInsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxCompanyName;
        private System.Windows.Forms.TextBox textBoxReorderLevel;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.DataGridView dataGridViewStockInAllRecord;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxCategoryName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxItemName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxAvailableQuantity;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxStockInQuantity;
       // private StockManagementDBDataSet stockManagementDBDataSet;
        private System.Windows.Forms.BindingSource companiesBindingSource;
      //  private StockManagementDBDataSetTableAdapters.CompaniesTableAdapter companiesTableAdapter;
     //   private StockManagementDBDataSet1 stockManagementDBDataSet1;
        private System.Windows.Forms.BindingSource categoriesBindingSource;
     //   private StockManagementDBDataSet1TableAdapters.CategoriesTableAdapter categoriesTableAdapter;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dateTimePickerUserDefineDate;
      //  private StockManagementDBDataSet3 stockManagementDBDataSet3;
        private System.Windows.Forms.BindingSource stockInsBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockInIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemIdDataGridViewTextBoxColumn;
      //  private StockManagementDBDataSet4 stockManagementDBDataSet4;
        private System.Windows.Forms.BindingSource itemsBindingSource;
        private System.Windows.Forms.BindingSource companyBindingSource;
        private System.Windows.Forms.BindingSource categoryBindingSource;
        private System.Windows.Forms.BindingSource itemBindingSource;
        private System.Windows.Forms.BindingSource stockOutBindingSource;
        private StockManagementDBDataSet stockManagementDBDataSet;
        private System.Windows.Forms.BindingSource stockInsBindingSource1;
        private StockManagementDBDataSetTableAdapters.StockInsTableAdapter stockInsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn SL;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewButtonColumn Action;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        //  private StockManagementDBDataSet4TableAdapters.ItemsTableAdapter itemsTableAdapter;
    }
}