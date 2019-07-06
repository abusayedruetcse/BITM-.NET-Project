namespace StockManagementSystem.Screens
{
    partial class StockOutForm
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
            this.stockOutsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stockManagementDBDataSet5 = new StockManagementSystem.StockManagementDBDataSet5();
            this.stockOutsTableAdapter = new StockManagementSystem.StockManagementDBDataSet5TableAdapters.StockOutsTableAdapter();
            this.dataGridViewStockOutAllRecord = new System.Windows.Forms.DataGridView();
            this.dateTimePickerStockOut = new System.Windows.Forms.DateTimePicker();
            this.buttonDamage = new System.Windows.Forms.Button();
            this.buttonLost = new System.Windows.Forms.Button();
            this.buttonSell = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.textBoxStockOutQuantity = new System.Windows.Forms.TextBox();
            this.textBoxAvailableQuantity = new System.Windows.Forms.TextBox();
            this.textBoxReorderLevel = new System.Windows.Forms.TextBox();
            this.comboBoxItemName = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxCategoryName = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxCompanyName = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.stockManagementDBDataSet = new StockManagementSystem.StockManagementDBDataSet();
            this.companiesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.companiesTableAdapter = new StockManagementSystem.StockManagementDBDataSetTableAdapters.CompaniesTableAdapter();
            this.stockManagementDBDataSet1 = new StockManagementSystem.StockManagementDBDataSet1();
            this.categoriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.categoriesTableAdapter = new StockManagementSystem.StockManagementDBDataSet1TableAdapters.CategoriesTableAdapter();
            this.stockManagementDBDataSet4 = new StockManagementSystem.StockManagementDBDataSet4();
            this.itemsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.itemsTableAdapter = new StockManagementSystem.StockManagementDBDataSet4TableAdapters.ItemsTableAdapter();
            this.stockManagementDBDataSet6 = new StockManagementSystem.StockManagementDBDataSet6();
            this.stockOutsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.stockOutsTableAdapter1 = new StockManagementSystem.StockManagementDBDataSet6TableAdapters.StockOutsTableAdapter();
            this.SL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.companyNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.actionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.stockOutsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockManagementDBDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStockOutAllRecord)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockManagementDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.companiesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockManagementDBDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockManagementDBDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockManagementDBDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockOutsBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // stockOutsBindingSource
            // 
            this.stockOutsBindingSource.DataMember = "StockOuts";
            this.stockOutsBindingSource.DataSource = this.stockManagementDBDataSet5;
            // 
            // stockManagementDBDataSet5
            // 
            this.stockManagementDBDataSet5.DataSetName = "StockManagementDBDataSet5";
            this.stockManagementDBDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // stockOutsTableAdapter
            // 
            this.stockOutsTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridViewStockOutAllRecord
            // 
            this.dataGridViewStockOutAllRecord.AllowUserToAddRows = false;
            this.dataGridViewStockOutAllRecord.AllowUserToDeleteRows = false;
            this.dataGridViewStockOutAllRecord.AutoGenerateColumns = false;
            this.dataGridViewStockOutAllRecord.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewStockOutAllRecord.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStockOutAllRecord.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SL,
            this.itemNameDataGridViewTextBoxColumn,
            this.companyNameDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.iDDataGridViewTextBoxColumn,
            this.itemIDDataGridViewTextBoxColumn,
            this.actionDataGridViewTextBoxColumn});
            this.dataGridViewStockOutAllRecord.DataSource = this.stockOutsBindingSource1;
            this.dataGridViewStockOutAllRecord.Location = new System.Drawing.Point(545, 47);
            this.dataGridViewStockOutAllRecord.Name = "dataGridViewStockOutAllRecord";
            this.dataGridViewStockOutAllRecord.ReadOnly = true;
            this.dataGridViewStockOutAllRecord.Size = new System.Drawing.Size(587, 315);
            this.dataGridViewStockOutAllRecord.TabIndex = 5;
            // 
            // dateTimePickerStockOut
            // 
            this.dateTimePickerStockOut.CustomFormat = "yyyy/MM/dd";
            this.dateTimePickerStockOut.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerStockOut.Location = new System.Drawing.Point(376, 272);
            this.dateTimePickerStockOut.Name = "dateTimePickerStockOut";
            this.dateTimePickerStockOut.Size = new System.Drawing.Size(127, 23);
            this.dateTimePickerStockOut.TabIndex = 4;
            // 
            // buttonDamage
            // 
            this.buttonDamage.Location = new System.Drawing.Point(1057, 384);
            this.buttonDamage.Name = "buttonDamage";
            this.buttonDamage.Size = new System.Drawing.Size(75, 32);
            this.buttonDamage.TabIndex = 3;
            this.buttonDamage.Text = "Damage";
            this.buttonDamage.UseVisualStyleBackColor = true;
            this.buttonDamage.Click += new System.EventHandler(this.buttonDamage_Click);
            // 
            // buttonLost
            // 
            this.buttonLost.Location = new System.Drawing.Point(951, 384);
            this.buttonLost.Name = "buttonLost";
            this.buttonLost.Size = new System.Drawing.Size(75, 32);
            this.buttonLost.TabIndex = 3;
            this.buttonLost.Text = "Lost";
            this.buttonLost.UseVisualStyleBackColor = true;
            this.buttonLost.Click += new System.EventHandler(this.buttonLost_Click);
            // 
            // buttonSell
            // 
            this.buttonSell.Location = new System.Drawing.Point(851, 384);
            this.buttonSell.Name = "buttonSell";
            this.buttonSell.Size = new System.Drawing.Size(75, 32);
            this.buttonSell.TabIndex = 3;
            this.buttonSell.Text = "Sell";
            this.buttonSell.UseVisualStyleBackColor = true;
            this.buttonSell.Click += new System.EventHandler(this.buttonSell_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(354, 384);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(149, 30);
            this.buttonAdd.TabIndex = 3;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // textBoxStockOutQuantity
            // 
            this.textBoxStockOutQuantity.Location = new System.Drawing.Point(218, 316);
            this.textBoxStockOutQuantity.Name = "textBoxStockOutQuantity";
            this.textBoxStockOutQuantity.Size = new System.Drawing.Size(140, 23);
            this.textBoxStockOutQuantity.TabIndex = 2;
            // 
            // textBoxAvailableQuantity
            // 
            this.textBoxAvailableQuantity.Location = new System.Drawing.Point(218, 271);
            this.textBoxAvailableQuantity.Name = "textBoxAvailableQuantity";
            this.textBoxAvailableQuantity.Size = new System.Drawing.Size(140, 23);
            this.textBoxAvailableQuantity.TabIndex = 2;
            // 
            // textBoxReorderLevel
            // 
            this.textBoxReorderLevel.Location = new System.Drawing.Point(218, 219);
            this.textBoxReorderLevel.Name = "textBoxReorderLevel";
            this.textBoxReorderLevel.Size = new System.Drawing.Size(140, 23);
            this.textBoxReorderLevel.TabIndex = 2;
            // 
            // comboBoxItemName
            // 
            this.comboBoxItemName.DataSource = this.itemsBindingSource;
            this.comboBoxItemName.DisplayMember = "Name";
            this.comboBoxItemName.FormattingEnabled = true;
            this.comboBoxItemName.Location = new System.Drawing.Point(218, 155);
            this.comboBoxItemName.Name = "comboBoxItemName";
            this.comboBoxItemName.Size = new System.Drawing.Size(285, 24);
            this.comboBoxItemName.TabIndex = 1;
            this.comboBoxItemName.ValueMember = "ItemId";
            this.comboBoxItemName.SelectedIndexChanged += new System.EventHandler(this.comboBoxItemName_SelectedIndexChanged);
            this.comboBoxItemName.Click += new System.EventHandler(this.comboBoxItemName_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(49, 317);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(135, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Stock Out Quantity :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(101, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Item Name :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(54, 272);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Available Quantity :";
            // 
            // comboBoxCategoryName
            // 
            this.comboBoxCategoryName.DataSource = this.categoriesBindingSource;
            this.comboBoxCategoryName.DisplayMember = "CategoryName";
            this.comboBoxCategoryName.FormattingEnabled = true;
            this.comboBoxCategoryName.Location = new System.Drawing.Point(218, 101);
            this.comboBoxCategoryName.Name = "comboBoxCategoryName";
            this.comboBoxCategoryName.Size = new System.Drawing.Size(285, 24);
            this.comboBoxCategoryName.TabIndex = 1;
            this.comboBoxCategoryName.ValueMember = "CategoryId";
            this.comboBoxCategoryName.Click += new System.EventHandler(this.comboBoxCategoryName_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Category Name :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(78, 222);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Reorder Level :";
            // 
            // comboBoxCompanyName
            // 
            this.comboBoxCompanyName.DataSource = this.companiesBindingSource;
            this.comboBoxCompanyName.DisplayMember = "CompanyName";
            this.comboBoxCompanyName.FormattingEnabled = true;
            this.comboBoxCompanyName.Location = new System.Drawing.Point(218, 45);
            this.comboBoxCompanyName.Name = "comboBoxCompanyName";
            this.comboBoxCompanyName.Size = new System.Drawing.Size(285, 24);
            this.comboBoxCompanyName.TabIndex = 1;
            this.comboBoxCompanyName.ValueMember = "CompanyId";
            this.comboBoxCompanyName.Click += new System.EventHandler(this.comboBoxCompanyName_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Company Name :";
            // 
            // stockManagementDBDataSet
            // 
            this.stockManagementDBDataSet.DataSetName = "StockManagementDBDataSet";
            this.stockManagementDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // companiesBindingSource
            // 
            this.companiesBindingSource.DataMember = "Companies";
            this.companiesBindingSource.DataSource = this.stockManagementDBDataSet;
            // 
            // companiesTableAdapter
            // 
            this.companiesTableAdapter.ClearBeforeFill = true;
            // 
            // stockManagementDBDataSet1
            // 
            this.stockManagementDBDataSet1.DataSetName = "StockManagementDBDataSet1";
            this.stockManagementDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // categoriesBindingSource
            // 
            this.categoriesBindingSource.DataMember = "Categories";
            this.categoriesBindingSource.DataSource = this.stockManagementDBDataSet1;
            // 
            // categoriesTableAdapter
            // 
            this.categoriesTableAdapter.ClearBeforeFill = true;
            // 
            // stockManagementDBDataSet4
            // 
            this.stockManagementDBDataSet4.DataSetName = "StockManagementDBDataSet4";
            this.stockManagementDBDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // itemsBindingSource
            // 
            this.itemsBindingSource.DataMember = "Items";
            this.itemsBindingSource.DataSource = this.stockManagementDBDataSet4;
            // 
            // itemsTableAdapter
            // 
            this.itemsTableAdapter.ClearBeforeFill = true;
            // 
            // stockManagementDBDataSet6
            // 
            this.stockManagementDBDataSet6.DataSetName = "StockManagementDBDataSet6";
            this.stockManagementDBDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // stockOutsBindingSource1
            // 
            this.stockOutsBindingSource1.DataMember = "StockOuts";
            this.stockOutsBindingSource1.DataSource = this.stockManagementDBDataSet6;
            // 
            // stockOutsTableAdapter1
            // 
            this.stockOutsTableAdapter1.ClearBeforeFill = true;
            // 
            // SL
            // 
            this.SL.DataPropertyName = "SL";
            this.SL.HeaderText = "SL";
            this.SL.Name = "SL";
            this.SL.ReadOnly = true;
            // 
            // itemNameDataGridViewTextBoxColumn
            // 
            this.itemNameDataGridViewTextBoxColumn.DataPropertyName = "ItemName";
            this.itemNameDataGridViewTextBoxColumn.HeaderText = "Item";
            this.itemNameDataGridViewTextBoxColumn.Name = "itemNameDataGridViewTextBoxColumn";
            this.itemNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // companyNameDataGridViewTextBoxColumn
            // 
            this.companyNameDataGridViewTextBoxColumn.DataPropertyName = "CompanyName";
            this.companyNameDataGridViewTextBoxColumn.HeaderText = "Company";
            this.companyNameDataGridViewTextBoxColumn.Name = "companyNameDataGridViewTextBoxColumn";
            this.companyNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            this.quantityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.ReadOnly = true;
            this.dateDataGridViewTextBoxColumn.Visible = false;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.Visible = false;
            // 
            // itemIDDataGridViewTextBoxColumn
            // 
            this.itemIDDataGridViewTextBoxColumn.DataPropertyName = "ItemID";
            this.itemIDDataGridViewTextBoxColumn.HeaderText = "ItemID";
            this.itemIDDataGridViewTextBoxColumn.Name = "itemIDDataGridViewTextBoxColumn";
            this.itemIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.itemIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // actionDataGridViewTextBoxColumn
            // 
            this.actionDataGridViewTextBoxColumn.DataPropertyName = "Action";
            this.actionDataGridViewTextBoxColumn.HeaderText = "Action";
            this.actionDataGridViewTextBoxColumn.Name = "actionDataGridViewTextBoxColumn";
            this.actionDataGridViewTextBoxColumn.ReadOnly = true;
            this.actionDataGridViewTextBoxColumn.Visible = false;
            // 
            // StockOutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1186, 477);
            this.Controls.Add(this.dataGridViewStockOutAllRecord);
            this.Controls.Add(this.dateTimePickerStockOut);
            this.Controls.Add(this.buttonDamage);
            this.Controls.Add(this.buttonLost);
            this.Controls.Add(this.buttonSell);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.textBoxStockOutQuantity);
            this.Controls.Add(this.textBoxAvailableQuantity);
            this.Controls.Add(this.textBoxReorderLevel);
            this.Controls.Add(this.comboBoxItemName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBoxCategoryName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBoxCompanyName);
            this.Controls.Add(this.label1);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "StockOutForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stock Out Form";
            this.WindowState = System.Windows.Forms.FormWindowState.Normal;
            this.Load += new System.EventHandler(this.StockOutForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.stockOutsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockManagementDBDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStockOutAllRecord)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockManagementDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.companiesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockManagementDBDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockManagementDBDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockManagementDBDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockOutsBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxCompanyName;
        private System.Windows.Forms.TextBox textBoxReorderLevel;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.DateTimePicker dateTimePickerStockOut;
        private System.Windows.Forms.DataGridView dataGridViewStockOutAllRecord;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxCategoryName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxItemName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxAvailableQuantity;
        private System.Windows.Forms.TextBox textBoxStockOutQuantity;
        private System.Windows.Forms.Button buttonSell;
        private System.Windows.Forms.Button buttonLost;
        private System.Windows.Forms.Button buttonDamage;
        private StockManagementDBDataSet5 stockManagementDBDataSet5;
        private System.Windows.Forms.BindingSource stockOutsBindingSource;
        private StockManagementDBDataSet5TableAdapters.StockOutsTableAdapter stockOutsTableAdapter;
        private StockManagementDBDataSet stockManagementDBDataSet;
        private System.Windows.Forms.BindingSource companiesBindingSource;
        private StockManagementDBDataSetTableAdapters.CompaniesTableAdapter companiesTableAdapter;
        private StockManagementDBDataSet1 stockManagementDBDataSet1;
        private System.Windows.Forms.BindingSource categoriesBindingSource;
        private StockManagementDBDataSet1TableAdapters.CategoriesTableAdapter categoriesTableAdapter;
        private StockManagementDBDataSet4 stockManagementDBDataSet4;
        private System.Windows.Forms.BindingSource itemsBindingSource;
        private StockManagementDBDataSet4TableAdapters.ItemsTableAdapter itemsTableAdapter;
        private StockManagementDBDataSet6 stockManagementDBDataSet6;
        private System.Windows.Forms.BindingSource stockOutsBindingSource1;
        private StockManagementDBDataSet6TableAdapters.StockOutsTableAdapter stockOutsTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn SL;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn companyNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn actionDataGridViewTextBoxColumn;
    }
}