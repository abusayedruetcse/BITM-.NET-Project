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
            this.companiesBindingSource = new System.Windows.Forms.BindingSource(this.components);
//            this.stockManagementDBDataSet = new StockManagementSystem.StockManagementDBDataSet();
            this.textBoxReorderLevel = new System.Windows.Forms.TextBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.dataGridViewStockInAllRecord = new System.Windows.Forms.DataGridView();
            this.SL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Action = new System.Windows.Forms.DataGridViewButtonColumn();
            this.stockInIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockInsBindingSource = new System.Windows.Forms.BindingSource(this.components);
//            this.stockManagementDBDataSet3 = new StockManagementSystem.StockManagementDBDataSet3();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxCategoryName = new System.Windows.Forms.ComboBox();
            this.categoriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
//            this.stockManagementDBDataSet1 = new StockManagementSystem.StockManagementDBDataSet1();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxItemName = new System.Windows.Forms.ComboBox();
            this.itemsBindingSource = new System.Windows.Forms.BindingSource(this.components);
//            this.stockManagementDBDataSet4 = new StockManagementSystem.StockManagementDBDataSet4();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxAvailableQuantity = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxStockInQuantity = new System.Windows.Forms.TextBox();
//            this.companiesTableAdapter = new StockManagementSystem.StockManagementDBDataSetTableAdapters.CompaniesTableAdapter();
//            this.categoriesTableAdapter = new StockManagementSystem.StockManagementDBDataSet1TableAdapters.CategoriesTableAdapter();
            this.label7 = new System.Windows.Forms.Label();
            this.dateTimePickerUserDefineDate = new System.Windows.Forms.DateTimePicker();
//            this.stockInsTableAdapter = new StockManagementSystem.StockManagementDBDataSet3TableAdapters.StockInsTableAdapter();
//            this.itemsTableAdapter = new StockManagementSystem.StockManagementDBDataSet4TableAdapters.ItemsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.companiesBindingSource)).BeginInit();
           // ((System.ComponentModel.ISupportInitialize)(this.stockManagementDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStockInAllRecord)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockInsBindingSource)).BeginInit();
          //  ((System.ComponentModel.ISupportInitialize)(this.stockManagementDBDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesBindingSource)).BeginInit();
          //  ((System.ComponentModel.ISupportInitialize)(this.stockManagementDBDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource)).BeginInit();
          //  ((System.ComponentModel.ISupportInitialize)(this.stockManagementDBDataSet4)).BeginInit();
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
            this.comboBoxCompanyName.DataSource = this.companiesBindingSource;
            this.comboBoxCompanyName.DisplayMember = "CompanyName";
            this.comboBoxCompanyName.FormattingEnabled = true;
            this.comboBoxCompanyName.Location = new System.Drawing.Point(264, 60);
            this.comboBoxCompanyName.Name = "comboBoxCompanyName";
            this.comboBoxCompanyName.Size = new System.Drawing.Size(311, 24);
            this.comboBoxCompanyName.TabIndex = 1;
            this.comboBoxCompanyName.ValueMember = "CompanyId";
            this.comboBoxCompanyName.Click += new System.EventHandler(this.comboBoxCompanyName_Click);
            // 
            // companiesBindingSource
            // 
            this.companiesBindingSource.DataMember = "Companies";
//            this.companiesBindingSource.DataSource = this.stockManagementDBDataSet;
            // 
            // stockManagementDBDataSet
            // 
//            this.stockManagementDBDataSet.DataSetName = "StockManagementDBDataSet";
//            this.stockManagementDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.dateDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn,
            this.Action,
            this.stockInIdDataGridViewTextBoxColumn,
            this.itemIdDataGridViewTextBoxColumn});
            this.dataGridViewStockInAllRecord.DataSource = this.stockInsBindingSource;
            this.dataGridViewStockInAllRecord.Location = new System.Drawing.Point(641, 60);
            this.dataGridViewStockInAllRecord.Name = "dataGridViewStockInAllRecord";
            this.dataGridViewStockInAllRecord.ReadOnly = true;
            this.dataGridViewStockInAllRecord.Size = new System.Drawing.Size(631, 403);
            this.dataGridViewStockInAllRecord.TabIndex = 4;
            this.dataGridViewStockInAllRecord.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewStockInAllRecord_CellContentClick);
            // 
            // SL
            // 
            this.SL.DataPropertyName = "StockInId";
            this.SL.HeaderText = "SL";
            this.SL.Name = "SL";
            this.SL.ReadOnly = true;
            // 
            // ItemName
            // 
            this.ItemName.DataPropertyName = "ItemName";
            this.ItemName.HeaderText = "Item";
            this.ItemName.Name = "ItemName";
            this.ItemName.ReadOnly = true;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            this.quantityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Action
            // 
            this.Action.DataPropertyName = "Action";
            this.Action.HeaderText = "Action";
            this.Action.Name = "Action";
            this.Action.ReadOnly = true;
            this.Action.Text = "Edit";
            // 
            // stockInIdDataGridViewTextBoxColumn
            // 
            this.stockInIdDataGridViewTextBoxColumn.DataPropertyName = "StockInId";
            this.stockInIdDataGridViewTextBoxColumn.HeaderText = "StockInId";
            this.stockInIdDataGridViewTextBoxColumn.Name = "stockInIdDataGridViewTextBoxColumn";
            this.stockInIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.stockInIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // itemIdDataGridViewTextBoxColumn
            // 
            this.itemIdDataGridViewTextBoxColumn.DataPropertyName = "ItemId";
            this.itemIdDataGridViewTextBoxColumn.HeaderText = "ItemId";
            this.itemIdDataGridViewTextBoxColumn.Name = "itemIdDataGridViewTextBoxColumn";
            this.itemIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.itemIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // stockInsBindingSource
            // 
            this.stockInsBindingSource.DataMember = "StockIns";
//            this.stockInsBindingSource.DataSource = this.stockManagementDBDataSet3;
            // 
            // stockManagementDBDataSet3
            // 
//            this.stockManagementDBDataSet3.DataSetName = "StockManagementDBDataSet3";
//            this.stockManagementDBDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.comboBoxCategoryName.DataSource = this.categoriesBindingSource;
            this.comboBoxCategoryName.DisplayMember = "CategoryName";
            this.comboBoxCategoryName.FormattingEnabled = true;
            this.comboBoxCategoryName.Location = new System.Drawing.Point(264, 125);
            this.comboBoxCategoryName.Name = "comboBoxCategoryName";
            this.comboBoxCategoryName.Size = new System.Drawing.Size(311, 24);
            this.comboBoxCategoryName.TabIndex = 1;
            this.comboBoxCategoryName.ValueMember = "CategoryId";
            this.comboBoxCategoryName.Click += new System.EventHandler(this.comboBoxCategoryName_Click);
            // 
            // categoriesBindingSource
            // 
            this.categoriesBindingSource.DataMember = "Categories";
//            this.categoriesBindingSource.DataSource = this.stockManagementDBDataSet1;
            // 
            // stockManagementDBDataSet1
            // 
//            this.stockManagementDBDataSet1.DataSetName = "StockManagementDBDataSet1";
//            this.stockManagementDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.comboBoxItemName.DataSource = this.itemsBindingSource;
            this.comboBoxItemName.DisplayMember = "Name";
            this.comboBoxItemName.FormattingEnabled = true;
            this.comboBoxItemName.Location = new System.Drawing.Point(264, 186);
            this.comboBoxItemName.Name = "comboBoxItemName";
            this.comboBoxItemName.Size = new System.Drawing.Size(311, 24);
            this.comboBoxItemName.TabIndex = 1;
            this.comboBoxItemName.ValueMember = "ItemId";
            this.comboBoxItemName.SelectedIndexChanged += new System.EventHandler(this.comboBoxItemName_SelectedIndexChanged);
            this.comboBoxItemName.Click += new System.EventHandler(this.comboBoxItemName_Click);
            // 
            // itemsBindingSource
            // 
            this.itemsBindingSource.DataMember = "Items";
//            this.itemsBindingSource.DataSource = this.stockManagementDBDataSet4;
            // 
            // stockManagementDBDataSet4
            // 
//            this.stockManagementDBDataSet4.DataSetName = "StockManagementDBDataSet4";
//            this.stockManagementDBDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // companiesTableAdapter
            // 
//            this.companiesTableAdapter.ClearBeforeFill = true;
            // 
            // categoriesTableAdapter
            // 
//            this.categoriesTableAdapter.ClearBeforeFill = true;
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
//            this.stockInsTableAdapter.ClearBeforeFill = true;
            // 
            // itemsTableAdapter
            // 
//            this.itemsTableAdapter.ClearBeforeFill = true;
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
            ((System.ComponentModel.ISupportInitialize)(this.companiesBindingSource)).EndInit();
          //  ((System.ComponentModel.ISupportInitialize)(this.stockManagementDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStockInAllRecord)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockInsBindingSource)).EndInit();
        //    ((System.ComponentModel.ISupportInitialize)(this.stockManagementDBDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesBindingSource)).EndInit();
           // ((System.ComponentModel.ISupportInitialize)(this.stockManagementDBDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource)).EndInit();
         //   ((System.ComponentModel.ISupportInitialize)(this.stockManagementDBDataSet4)).EndInit();
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
      //  private StockManagementDBDataSet3TableAdapters.StockInsTableAdapter stockInsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn SL;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Action;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockInIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemIdDataGridViewTextBoxColumn;
      //  private StockManagementDBDataSet4 stockManagementDBDataSet4;
        private System.Windows.Forms.BindingSource itemsBindingSource;
      //  private StockManagementDBDataSet4TableAdapters.ItemsTableAdapter itemsTableAdapter;
    }
}