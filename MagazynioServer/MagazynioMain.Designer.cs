﻿namespace MagazynioServer
{
    partial class MagazynioMain
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qAvailableDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productsSaledProducedAvailableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.magazynioDataSet = new MagazynioServer.MagazynioDataSet();
            this.productsSaledProducedAvailableTableAdapter = new MagazynioServer.MagazynioDataSetTableAdapters.ProductsSaledProducedAvailableTableAdapter();
            this.MagazynioTabs = new System.Windows.Forms.TabControl();
            this.ProductListTab = new System.Windows.Forms.TabPage();
            this.ProductListRefresh = new System.Windows.Forms.Button();
            this.ProductManagmentTab = new System.Windows.Forms.TabPage();
            this.ProductCreateGroupBox = new System.Windows.Forms.GroupBox();
            this.ProductCreateDescriptionLabel = new System.Windows.Forms.Label();
            this.ProductCreatePriceLabel = new System.Windows.Forms.Label();
            this.ProductCreateNameLabel = new System.Windows.Forms.Label();
            this.ProductCreateConfirm = new System.Windows.Forms.Button();
            this.ProductCreateDescription = new System.Windows.Forms.RichTextBox();
            this.ProductCreatePrice = new System.Windows.Forms.TextBox();
            this.ProductCreateName = new System.Windows.Forms.TextBox();
            this.ProductDeleteGroupBox = new System.Windows.Forms.GroupBox();
            this.ProductDeleteConfirm = new System.Windows.Forms.Button();
            this.ProductDeleteSelect = new System.Windows.Forms.ComboBox();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ProductionTab = new System.Windows.Forms.TabPage();
            this.ProductProduceConfirm = new System.Windows.Forms.Button();
            this.ProductProduceQuantity = new System.Windows.Forms.TextBox();
            this.ProductProduceQuantityLabel = new System.Windows.Forms.Label();
            this.ProductProduceSelectLabel = new System.Windows.Forms.Label();
            this.ProductProduceSelect = new System.Windows.Forms.ComboBox();
            this.SalesHistory = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.salesHistoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productTableAdapter = new MagazynioServer.MagazynioDataSetTableAdapters.ProductTableAdapter();
            this.magazynioDataSet1 = new MagazynioServer.MagazynioDataSet();
            this.productionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productionTableAdapter = new MagazynioServer.MagazynioDataSetTableAdapters.ProductionTableAdapter();
            this.salesmanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.salesmanTableAdapter = new MagazynioServer.MagazynioDataSetTableAdapters.SalesmanTableAdapter();
            this.salesHistoryTableAdapter = new MagazynioServer.MagazynioDataSetTableAdapters.SalesHistoryTableAdapter();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Salesman = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsSaledProducedAvailableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.magazynioDataSet)).BeginInit();
            this.MagazynioTabs.SuspendLayout();
            this.ProductListTab.SuspendLayout();
            this.ProductManagmentTab.SuspendLayout();
            this.ProductCreateGroupBox.SuspendLayout();
            this.ProductDeleteGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            this.ProductionTab.SuspendLayout();
            this.SalesHistory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesHistoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.magazynioDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesmanBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.qAvailableDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.productsSaledProducedAvailableBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(9, 38);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(543, 316);
            this.dataGridView1.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // qAvailableDataGridViewTextBoxColumn
            // 
            this.qAvailableDataGridViewTextBoxColumn.DataPropertyName = "QAvailable";
            this.qAvailableDataGridViewTextBoxColumn.HeaderText = "QAvailable";
            this.qAvailableDataGridViewTextBoxColumn.Name = "qAvailableDataGridViewTextBoxColumn";
            this.qAvailableDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productsSaledProducedAvailableBindingSource
            // 
            this.productsSaledProducedAvailableBindingSource.DataMember = "ProductsSaledProducedAvailable";
            this.productsSaledProducedAvailableBindingSource.DataSource = this.magazynioDataSet;
            // 
            // magazynioDataSet
            // 
            this.magazynioDataSet.DataSetName = "MagazynioDataSet";
            this.magazynioDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productsSaledProducedAvailableTableAdapter
            // 
            this.productsSaledProducedAvailableTableAdapter.ClearBeforeFill = true;
            // 
            // MagazynioTabs
            // 
            this.MagazynioTabs.Controls.Add(this.ProductListTab);
            this.MagazynioTabs.Controls.Add(this.ProductManagmentTab);
            this.MagazynioTabs.Controls.Add(this.ProductionTab);
            this.MagazynioTabs.Controls.Add(this.SalesHistory);
            this.MagazynioTabs.Location = new System.Drawing.Point(12, 12);
            this.MagazynioTabs.Name = "MagazynioTabs";
            this.MagazynioTabs.SelectedIndex = 0;
            this.MagazynioTabs.Size = new System.Drawing.Size(566, 387);
            this.MagazynioTabs.TabIndex = 4;
            // 
            // ProductListTab
            // 
            this.ProductListTab.Controls.Add(this.dataGridView1);
            this.ProductListTab.Controls.Add(this.ProductListRefresh);
            this.ProductListTab.Location = new System.Drawing.Point(4, 22);
            this.ProductListTab.Name = "ProductListTab";
            this.ProductListTab.Padding = new System.Windows.Forms.Padding(3);
            this.ProductListTab.Size = new System.Drawing.Size(558, 361);
            this.ProductListTab.TabIndex = 0;
            this.ProductListTab.Text = "Lista produktów";
            this.ProductListTab.UseVisualStyleBackColor = true;
            // 
            // ProductListRefresh
            // 
            this.ProductListRefresh.Image = global::MagazynioServer.Properties.Resources._1358455773_arrow_circle_double;
            this.ProductListRefresh.Location = new System.Drawing.Point(521, 7);
            this.ProductListRefresh.Name = "ProductListRefresh";
            this.ProductListRefresh.Size = new System.Drawing.Size(28, 25);
            this.ProductListRefresh.TabIndex = 3;
            this.ProductListRefresh.UseCompatibleTextRendering = true;
            this.ProductListRefresh.UseVisualStyleBackColor = true;
            this.ProductListRefresh.Click += new System.EventHandler(this.ProductListRefresh_Click);
            // 
            // ProductManagmentTab
            // 
            this.ProductManagmentTab.Controls.Add(this.ProductCreateGroupBox);
            this.ProductManagmentTab.Controls.Add(this.ProductDeleteGroupBox);
            this.ProductManagmentTab.Location = new System.Drawing.Point(4, 22);
            this.ProductManagmentTab.Name = "ProductManagmentTab";
            this.ProductManagmentTab.Padding = new System.Windows.Forms.Padding(3);
            this.ProductManagmentTab.Size = new System.Drawing.Size(558, 361);
            this.ProductManagmentTab.TabIndex = 1;
            this.ProductManagmentTab.Text = "Zarządzanie produktami";
            this.ProductManagmentTab.UseVisualStyleBackColor = true;
            // 
            // ProductCreateGroupBox
            // 
            this.ProductCreateGroupBox.Controls.Add(this.ProductCreateDescriptionLabel);
            this.ProductCreateGroupBox.Controls.Add(this.ProductCreatePriceLabel);
            this.ProductCreateGroupBox.Controls.Add(this.ProductCreateNameLabel);
            this.ProductCreateGroupBox.Controls.Add(this.ProductCreateConfirm);
            this.ProductCreateGroupBox.Controls.Add(this.ProductCreateDescription);
            this.ProductCreateGroupBox.Controls.Add(this.ProductCreatePrice);
            this.ProductCreateGroupBox.Controls.Add(this.ProductCreateName);
            this.ProductCreateGroupBox.Location = new System.Drawing.Point(6, 6);
            this.ProductCreateGroupBox.Name = "ProductCreateGroupBox";
            this.ProductCreateGroupBox.Size = new System.Drawing.Size(549, 264);
            this.ProductCreateGroupBox.TabIndex = 2;
            this.ProductCreateGroupBox.TabStop = false;
            this.ProductCreateGroupBox.Text = "Dodawanie produktu";
            // 
            // ProductCreateDescriptionLabel
            // 
            this.ProductCreateDescriptionLabel.AutoSize = true;
            this.ProductCreateDescriptionLabel.Location = new System.Drawing.Point(68, 85);
            this.ProductCreateDescriptionLabel.Name = "ProductCreateDescriptionLabel";
            this.ProductCreateDescriptionLabel.Size = new System.Drawing.Size(73, 13);
            this.ProductCreateDescriptionLabel.TabIndex = 6;
            this.ProductCreateDescriptionLabel.Text = "Opis produktu";
            // 
            // ProductCreatePriceLabel
            // 
            this.ProductCreatePriceLabel.AutoSize = true;
            this.ProductCreatePriceLabel.Location = new System.Drawing.Point(64, 58);
            this.ProductCreatePriceLabel.Name = "ProductCreatePriceLabel";
            this.ProductCreatePriceLabel.Size = new System.Drawing.Size(77, 13);
            this.ProductCreatePriceLabel.TabIndex = 5;
            this.ProductCreatePriceLabel.Text = "Cena produktu";
            // 
            // ProductCreateNameLabel
            // 
            this.ProductCreateNameLabel.AutoSize = true;
            this.ProductCreateNameLabel.Location = new System.Drawing.Point(56, 32);
            this.ProductCreateNameLabel.Name = "ProductCreateNameLabel";
            this.ProductCreateNameLabel.Size = new System.Drawing.Size(85, 13);
            this.ProductCreateNameLabel.TabIndex = 4;
            this.ProductCreateNameLabel.Text = "Nazwa produktu";
            // 
            // ProductCreateConfirm
            // 
            this.ProductCreateConfirm.Location = new System.Drawing.Point(408, 235);
            this.ProductCreateConfirm.Name = "ProductCreateConfirm";
            this.ProductCreateConfirm.Size = new System.Drawing.Size(130, 23);
            this.ProductCreateConfirm.TabIndex = 3;
            this.ProductCreateConfirm.Text = "Utwórz produkt";
            this.ProductCreateConfirm.UseVisualStyleBackColor = true;
            this.ProductCreateConfirm.Click += new System.EventHandler(this.ProductCreateConfirm_Click);
            // 
            // ProductCreateDescription
            // 
            this.ProductCreateDescription.Location = new System.Drawing.Point(147, 82);
            this.ProductCreateDescription.Name = "ProductCreateDescription";
            this.ProductCreateDescription.Size = new System.Drawing.Size(392, 147);
            this.ProductCreateDescription.TabIndex = 2;
            this.ProductCreateDescription.Text = "";
            // 
            // ProductCreatePrice
            // 
            this.ProductCreatePrice.Location = new System.Drawing.Point(147, 55);
            this.ProductCreatePrice.Name = "ProductCreatePrice";
            this.ProductCreatePrice.Size = new System.Drawing.Size(392, 20);
            this.ProductCreatePrice.TabIndex = 1;
            // 
            // ProductCreateName
            // 
            this.ProductCreateName.Location = new System.Drawing.Point(147, 29);
            this.ProductCreateName.Name = "ProductCreateName";
            this.ProductCreateName.Size = new System.Drawing.Size(392, 20);
            this.ProductCreateName.TabIndex = 0;
            // 
            // ProductDeleteGroupBox
            // 
            this.ProductDeleteGroupBox.Controls.Add(this.ProductDeleteConfirm);
            this.ProductDeleteGroupBox.Controls.Add(this.ProductDeleteSelect);
            this.ProductDeleteGroupBox.Location = new System.Drawing.Point(6, 276);
            this.ProductDeleteGroupBox.Name = "ProductDeleteGroupBox";
            this.ProductDeleteGroupBox.Size = new System.Drawing.Size(546, 79);
            this.ProductDeleteGroupBox.TabIndex = 1;
            this.ProductDeleteGroupBox.TabStop = false;
            this.ProductDeleteGroupBox.Text = "Usuwanie produktu";
            // 
            // ProductDeleteConfirm
            // 
            this.ProductDeleteConfirm.Location = new System.Drawing.Point(408, 47);
            this.ProductDeleteConfirm.Name = "ProductDeleteConfirm";
            this.ProductDeleteConfirm.Size = new System.Drawing.Size(131, 23);
            this.ProductDeleteConfirm.TabIndex = 1;
            this.ProductDeleteConfirm.Text = "Usuń wybrany produkt";
            this.ProductDeleteConfirm.UseVisualStyleBackColor = true;
            this.ProductDeleteConfirm.Click += new System.EventHandler(this.ProductDeleteConfirm_Click);
            // 
            // ProductDeleteSelect
            // 
            this.ProductDeleteSelect.DataSource = this.productBindingSource;
            this.ProductDeleteSelect.DisplayMember = "Name";
            this.ProductDeleteSelect.Location = new System.Drawing.Point(6, 19);
            this.ProductDeleteSelect.Name = "ProductDeleteSelect";
            this.ProductDeleteSelect.Size = new System.Drawing.Size(534, 21);
            this.ProductDeleteSelect.TabIndex = 0;
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataMember = "Product";
            this.productBindingSource.DataSource = this.magazynioDataSet;
            // 
            // ProductionTab
            // 
            this.ProductionTab.Controls.Add(this.ProductProduceConfirm);
            this.ProductionTab.Controls.Add(this.ProductProduceQuantity);
            this.ProductionTab.Controls.Add(this.ProductProduceQuantityLabel);
            this.ProductionTab.Controls.Add(this.ProductProduceSelectLabel);
            this.ProductionTab.Controls.Add(this.ProductProduceSelect);
            this.ProductionTab.Location = new System.Drawing.Point(4, 22);
            this.ProductionTab.Name = "ProductionTab";
            this.ProductionTab.Padding = new System.Windows.Forms.Padding(3);
            this.ProductionTab.Size = new System.Drawing.Size(558, 361);
            this.ProductionTab.TabIndex = 2;
            this.ProductionTab.Text = "Produkcja";
            this.ProductionTab.UseVisualStyleBackColor = true;
            // 
            // ProductProduceConfirm
            // 
            this.ProductProduceConfirm.Location = new System.Drawing.Point(106, 75);
            this.ProductProduceConfirm.Name = "ProductProduceConfirm";
            this.ProductProduceConfirm.Size = new System.Drawing.Size(75, 23);
            this.ProductProduceConfirm.TabIndex = 5;
            this.ProductProduceConfirm.Text = "Produkuj";
            this.ProductProduceConfirm.UseVisualStyleBackColor = true;
            this.ProductProduceConfirm.Click += new System.EventHandler(this.ProductProduceConfirm_Click);
            // 
            // ProductProduceQuantity
            // 
            this.ProductProduceQuantity.Location = new System.Drawing.Point(106, 40);
            this.ProductProduceQuantity.Name = "ProductProduceQuantity";
            this.ProductProduceQuantity.Size = new System.Drawing.Size(100, 20);
            this.ProductProduceQuantity.TabIndex = 4;
            // 
            // ProductProduceQuantityLabel
            // 
            this.ProductProduceQuantityLabel.AutoSize = true;
            this.ProductProduceQuantityLabel.Location = new System.Drawing.Point(56, 43);
            this.ProductProduceQuantityLabel.Name = "ProductProduceQuantityLabel";
            this.ProductProduceQuantityLabel.Size = new System.Drawing.Size(29, 13);
            this.ProductProduceQuantityLabel.TabIndex = 3;
            this.ProductProduceQuantityLabel.Text = "Ilość";
            // 
            // ProductProduceSelectLabel
            // 
            this.ProductProduceSelectLabel.AutoSize = true;
            this.ProductProduceSelectLabel.Location = new System.Drawing.Point(56, 9);
            this.ProductProduceSelectLabel.Name = "ProductProduceSelectLabel";
            this.ProductProduceSelectLabel.Size = new System.Drawing.Size(44, 13);
            this.ProductProduceSelectLabel.TabIndex = 2;
            this.ProductProduceSelectLabel.Text = "Produkt";
            // 
            // ProductProduceSelect
            // 
            this.ProductProduceSelect.DataSource = this.productBindingSource;
            this.ProductProduceSelect.DisplayMember = "Name";
            this.ProductProduceSelect.Location = new System.Drawing.Point(106, 6);
            this.ProductProduceSelect.Name = "ProductProduceSelect";
            this.ProductProduceSelect.Size = new System.Drawing.Size(446, 21);
            this.ProductProduceSelect.TabIndex = 1;
            this.ProductProduceSelect.ValueMember = "Id";
            // 
            // SalesHistory
            // 
            this.SalesHistory.Controls.Add(this.button1);
            this.SalesHistory.Controls.Add(this.dataGridView2);
            this.SalesHistory.Location = new System.Drawing.Point(4, 22);
            this.SalesHistory.Name = "SalesHistory";
            this.SalesHistory.Padding = new System.Windows.Forms.Padding(3);
            this.SalesHistory.Size = new System.Drawing.Size(558, 361);
            this.SalesHistory.TabIndex = 3;
            this.SalesHistory.Text = "Historia sprzedaży";
            this.SalesHistory.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dateDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn1,
            this.Salesman,
            this.quantityDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.salesHistoryBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(6, 37);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(546, 318);
            this.dataGridView2.TabIndex = 0;
            // 
            // salesHistoryBindingSource
            // 
            this.salesHistoryBindingSource.DataMember = "SalesHistory";
            this.salesHistoryBindingSource.DataSource = this.magazynioDataSet;
            // 
            // productTableAdapter
            // 
            this.productTableAdapter.ClearBeforeFill = true;
            // 
            // magazynioDataSet1
            // 
            this.magazynioDataSet1.DataSetName = "MagazynioDataSet";
            this.magazynioDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productionBindingSource
            // 
            this.productionBindingSource.DataMember = "Production";
            this.productionBindingSource.DataSource = this.magazynioDataSet;
            // 
            // productionTableAdapter
            // 
            this.productionTableAdapter.ClearBeforeFill = true;
            // 
            // salesmanBindingSource
            // 
            this.salesmanBindingSource.DataMember = "Salesman";
            this.salesmanBindingSource.DataSource = this.magazynioDataSet;
            // 
            // salesmanTableAdapter
            // 
            this.salesmanTableAdapter.ClearBeforeFill = true;
            // 
            // salesHistoryTableAdapter
            // 
            this.salesHistoryTableAdapter.ClearBeforeFill = true;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn1
            // 
            this.nameDataGridViewTextBoxColumn1.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn1.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn1.Name = "nameDataGridViewTextBoxColumn1";
            this.nameDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // Salesman
            // 
            this.Salesman.DataPropertyName = "Salesman";
            this.Salesman.HeaderText = "Salesman";
            this.Salesman.Name = "Salesman";
            this.Salesman.ReadOnly = true;
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            this.quantityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // button1
            // 
            this.button1.Image = global::MagazynioServer.Properties.Resources._1358455773_arrow_circle_double;
            this.button1.Location = new System.Drawing.Point(524, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(28, 25);
            this.button1.TabIndex = 4;
            this.button1.UseCompatibleTextRendering = true;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MagazynioMain
            // 
            this.ClientSize = new System.Drawing.Size(590, 412);
            this.Controls.Add(this.MagazynioTabs);
            this.Name = "MagazynioMain";
            this.Text = "Magazynio - Aplikacja dziwna, acz serwerowa (:";
            this.Load += new System.EventHandler(this.MagazynioMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsSaledProducedAvailableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.magazynioDataSet)).EndInit();
            this.MagazynioTabs.ResumeLayout(false);
            this.ProductListTab.ResumeLayout(false);
            this.ProductManagmentTab.ResumeLayout(false);
            this.ProductCreateGroupBox.ResumeLayout(false);
            this.ProductCreateGroupBox.PerformLayout();
            this.ProductDeleteGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            this.ProductionTab.ResumeLayout(false);
            this.ProductionTab.PerformLayout();
            this.SalesHistory.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesHistoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.magazynioDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesmanBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private MagazynioDataSet magazynioDataSet;
        private System.Windows.Forms.BindingSource productsSaledProducedAvailableBindingSource;
        private MagazynioDataSetTableAdapters.ProductsSaledProducedAvailableTableAdapter productsSaledProducedAvailableTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qAvailableDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button ProductListRefresh;
        private System.Windows.Forms.TabControl MagazynioTabs;
        private System.Windows.Forms.TabPage ProductListTab;
        private System.Windows.Forms.TabPage ProductManagmentTab;
        private System.Windows.Forms.TabPage ProductionTab;
        private System.Windows.Forms.GroupBox ProductDeleteGroupBox;
        private System.Windows.Forms.Button ProductDeleteConfirm;
        private System.Windows.Forms.ComboBox ProductDeleteSelect;
        private System.Windows.Forms.BindingSource productBindingSource;
        private MagazynioDataSetTableAdapters.ProductTableAdapter productTableAdapter;
        private System.Windows.Forms.GroupBox ProductCreateGroupBox;
        private System.Windows.Forms.Label ProductCreateDescriptionLabel;
        private System.Windows.Forms.Label ProductCreatePriceLabel;
        private System.Windows.Forms.Label ProductCreateNameLabel;
        private System.Windows.Forms.Button ProductCreateConfirm;
        private System.Windows.Forms.RichTextBox ProductCreateDescription;
        private System.Windows.Forms.TextBox ProductCreatePrice;
        private System.Windows.Forms.TextBox ProductCreateName;
        private System.Windows.Forms.TabPage SalesHistory;
        private MagazynioDataSet magazynioDataSet1;
        private System.Windows.Forms.ComboBox ProductProduceSelect;
        private System.Windows.Forms.TextBox ProductProduceQuantity;
        private System.Windows.Forms.Label ProductProduceQuantityLabel;
        private System.Windows.Forms.Label ProductProduceSelectLabel;
        private System.Windows.Forms.Button ProductProduceConfirm;
        private System.Windows.Forms.BindingSource productionBindingSource;
        private MagazynioDataSetTableAdapters.ProductionTableAdapter productionTableAdapter;
        private System.Windows.Forms.BindingSource salesmanBindingSource;
        private MagazynioDataSetTableAdapters.SalesmanTableAdapter salesmanTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource salesHistoryBindingSource;
        private MagazynioDataSetTableAdapters.SalesHistoryTableAdapter salesHistoryTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Salesman;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;


    }
}

