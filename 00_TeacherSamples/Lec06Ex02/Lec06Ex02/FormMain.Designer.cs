namespace Lec06Ex02
{
    partial class frmMain
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dsOrders = new System.Data.DataSet();
            this.dtProducts = new System.Data.DataTable();
            this.dcProductID = new System.Data.DataColumn();
            this.dcProductName = new System.Data.DataColumn();
            this.dcPrice = new System.Data.DataColumn();
            this.dcProductPrice = new System.Data.DataColumn();
            this.dtOrderDetails = new System.Data.DataTable();
            this.dcOrderID = new System.Data.DataColumn();
            this.dcProduct = new System.Data.DataColumn();
            this.dcQty = new System.Data.DataColumn();
            this.dataColumn1 = new System.Data.DataColumn();
            this.dcProductQtyPriceTotal = new System.Data.DataColumn();
            this.dcLineTotal = new System.Data.DataColumn();
            this.dtOrders = new System.Data.DataTable();
            this.dcOrder = new System.Data.DataColumn();
            this.dcTimeStamp = new System.Data.DataColumn();
            this.dcCustomer = new System.Data.DataColumn();
            this.dcOrderTime = new System.Data.DataColumn();
            this.dtCustomers = new System.Data.DataTable();
            this.dcCustomerID = new System.Data.DataColumn();
            this.dcFirstName = new System.Data.DataColumn();
            this.dcLastName = new System.Data.DataColumn();
            this.dcIDName = new System.Data.DataColumn();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.lblProductName = new System.Windows.Forms.Label();
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.productIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dvProducts = new System.Data.DataView();
            this.btnFirst = new System.Windows.Forms.Button();
            this.btnPrev = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnLast = new System.Windows.Forms.Button();
            this.btnPriceIncrease = new System.Windows.Forms.Button();
            this.btnPriceDecrease = new System.Windows.Forms.Button();
            this.dgvOrderDetails = new System.Windows.Forms.DataGridView();
            this.orderIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qtyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productQtyPriceTotalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lineTotalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgCustomers = new System.Windows.Forms.DataGrid();
            this.dgvOrders = new System.Windows.Forms.DataGridView();
            this.orderIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeStampDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAcceptChanges = new System.Windows.Forms.Button();
            this.btnDiffGram = new System.Windows.Forms.Button();
            this.lblOrders = new System.Windows.Forms.Label();
            this.lblOrderDetails = new System.Windows.Forms.Label();
            this.lblCustomers = new System.Windows.Forms.Label();
            this.tabCtlMain = new System.Windows.Forms.TabControl();
            this.tabPGrids = new System.Windows.Forms.TabPage();
            this.lblPriceLimit = new System.Windows.Forms.Label();
            this.tabPBindings = new System.Windows.Forms.TabPage();
            this.lblProduct = new System.Windows.Forms.Label();
            this.lblCustomDetails = new System.Windows.Forms.Label();
            this.lstProduct = new System.Windows.Forms.ListBox();
            this.bsProductsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblCustomerOrderDetails = new System.Windows.Forms.Label();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.relOrdersDetailsOrdersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.relOrdersCustomersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bsCustomers = new System.Windows.Forms.BindingSource(this.components);
            this.lblCustomerOrders = new System.Windows.Forms.Label();
            this.lstCustomerOrders = new System.Windows.Forms.ListBox();
            this.lblCustomersList = new System.Windows.Forms.Label();
            this.lstCustomers = new System.Windows.Forms.ListBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.dgvCustomerDetails = new System.Windows.Forms.DataGridView();
            this.Details = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dsOrders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtOrderDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtOrders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtCustomers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgCustomers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsOrders)).BeginInit();
            this.tabCtlMain.SuspendLayout();
            this.tabPGrids.SuspendLayout();
            this.tabPBindings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsProductsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.relOrdersDetailsOrdersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.relOrdersCustomersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCustomers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomerDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // dsOrders
            // 
            this.dsOrders.DataSetName = "OrdersDataSet";
            this.dsOrders.Relations.AddRange(new System.Data.DataRelation[] {
            new System.Data.DataRelation("rel_OrdersCustomers", "Customers", "Orders", new string[] {
                        "CustomerID"}, new string[] {
                        "Customer"}, false),
            new System.Data.DataRelation("relOrders_Products", "Products", "OrderDetails", new string[] {
                        "ProductID"}, new string[] {
                        "ProductID"}, false),
            new System.Data.DataRelation("relOrdersDetails_Orders", "Orders", "OrderDetails", new string[] {
                        "OrderID"}, new string[] {
                        "OrderID"}, false)});
            this.dsOrders.Tables.AddRange(new System.Data.DataTable[] {
            this.dtProducts,
            this.dtOrderDetails,
            this.dtOrders,
            this.dtCustomers});
            // 
            // dtProducts
            // 
            this.dtProducts.Columns.AddRange(new System.Data.DataColumn[] {
            this.dcProductID,
            this.dcProductName,
            this.dcPrice,
            this.dcProductPrice});
            this.dtProducts.Constraints.AddRange(new System.Data.Constraint[] {
            new System.Data.UniqueConstraint("PK_ProductID", new string[] {
                        "ProductID"}, true)});
            this.dtProducts.TableName = "Products";
            // 
            // dcProductID
            // 
            this.dcProductID.AllowDBNull = false;
            this.dcProductID.ColumnName = "ProductID";
            // 
            // dcProductName
            // 
            this.dcProductName.ColumnName = "ProductName";
            // 
            // dcPrice
            // 
            this.dcPrice.ColumnName = "Price";
            this.dcPrice.DataType = typeof(decimal);
            // 
            // dcProductPrice
            // 
            this.dcProductPrice.ColumnName = "Product&Price";
            this.dcProductPrice.Expression = "ProductName + \' \' + Price";
            this.dcProductPrice.ReadOnly = true;
            // 
            // dtOrderDetails
            // 
            this.dtOrderDetails.Columns.AddRange(new System.Data.DataColumn[] {
            this.dcOrderID,
            this.dcProduct,
            this.dcQty,
            this.dataColumn1,
            this.dcProductQtyPriceTotal,
            this.dcLineTotal});
            this.dtOrderDetails.Constraints.AddRange(new System.Data.Constraint[] {
            new System.Data.UniqueConstraint("Constraint1", new string[] {
                        "OrderID",
                        "ProductID"}, false),
            new System.Data.ForeignKeyConstraint("FK_OrderDetailsOrders", "Orders", new string[] {
                        "OrderID"}, new string[] {
                        "OrderID"}, System.Data.AcceptRejectRule.None, System.Data.Rule.Cascade, System.Data.Rule.Cascade),
            new System.Data.ForeignKeyConstraint("FK_OrderDetailsProducts", "Products", new string[] {
                        "ProductID"}, new string[] {
                        "ProductID"}, System.Data.AcceptRejectRule.None, System.Data.Rule.Cascade, System.Data.Rule.Cascade)});
            this.dtOrderDetails.PrimaryKey = new System.Data.DataColumn[] {
        this.dcOrderID,
        this.dcProduct};
            this.dtOrderDetails.TableName = "OrderDetails";
            // 
            // dcOrderID
            // 
            this.dcOrderID.AllowDBNull = false;
            this.dcOrderID.ColumnName = "OrderID";
            this.dcOrderID.DataType = typeof(int);
            // 
            // dcProduct
            // 
            this.dcProduct.AllowDBNull = false;
            this.dcProduct.ColumnName = "ProductID";
            // 
            // dcQty
            // 
            this.dcQty.ColumnName = "Qty";
            this.dcQty.DataType = typeof(int);
            // 
            // dataColumn1
            // 
            this.dataColumn1.ColumnName = "Price";
            this.dataColumn1.DataType = typeof(decimal);
            // 
            // dcProductQtyPriceTotal
            // 
            this.dcProductQtyPriceTotal.ColumnName = "Product&Qty&Price&Total";
            this.dcProductQtyPriceTotal.Expression = "ProductID + \' \' + Qty + \' \' + Price + \' \' + LineTotal";
            this.dcProductQtyPriceTotal.ReadOnly = true;
            // 
            // dcLineTotal
            // 
            this.dcLineTotal.ColumnName = "LineTotal";
            this.dcLineTotal.DataType = typeof(decimal);
            this.dcLineTotal.Expression = "Price * Qty";
            this.dcLineTotal.ReadOnly = true;
            // 
            // dtOrders
            // 
            this.dtOrders.Columns.AddRange(new System.Data.DataColumn[] {
            this.dcOrder,
            this.dcTimeStamp,
            this.dcCustomer,
            this.dcOrderTime});
            this.dtOrders.Constraints.AddRange(new System.Data.Constraint[] {
            new System.Data.UniqueConstraint("PK_OrderID", new string[] {
                        "OrderID"}, true),
            new System.Data.ForeignKeyConstraint("FK_OrdersCustomers", "Customers", new string[] {
                        "CustomerID"}, new string[] {
                        "Customer"}, System.Data.AcceptRejectRule.None, System.Data.Rule.Cascade, System.Data.Rule.Cascade)});
            this.dtOrders.TableName = "Orders";
            // 
            // dcOrder
            // 
            this.dcOrder.AllowDBNull = false;
            this.dcOrder.AutoIncrement = true;
            this.dcOrder.ColumnName = "OrderID";
            this.dcOrder.DataType = typeof(int);
            // 
            // dcTimeStamp
            // 
            this.dcTimeStamp.ColumnName = "Time Stamp";
            this.dcTimeStamp.DataType = typeof(System.DateTime);
            // 
            // dcCustomer
            // 
            this.dcCustomer.ColumnName = "Customer";
            this.dcCustomer.DataType = typeof(int);
            // 
            // dcOrderTime
            // 
            this.dcOrderTime.ColumnName = "OrderID&Date";
            this.dcOrderTime.Expression = "OrderID + \' \' + [Time Stamp]";
            this.dcOrderTime.ReadOnly = true;
            // 
            // dtCustomers
            // 
            this.dtCustomers.Columns.AddRange(new System.Data.DataColumn[] {
            this.dcCustomerID,
            this.dcFirstName,
            this.dcLastName,
            this.dcIDName});
            this.dtCustomers.Constraints.AddRange(new System.Data.Constraint[] {
            new System.Data.UniqueConstraint("PK_CustomerID", new string[] {
                        "CustomerID"}, true)});
            this.dtCustomers.TableName = "Customers";
            // 
            // dcCustomerID
            // 
            this.dcCustomerID.AllowDBNull = false;
            this.dcCustomerID.AutoIncrement = true;
            this.dcCustomerID.ColumnName = "CustomerID";
            this.dcCustomerID.DataType = typeof(int);
            // 
            // dcFirstName
            // 
            this.dcFirstName.ColumnName = "FirstName";
            // 
            // dcLastName
            // 
            this.dcLastName.ColumnName = "LastName";
            // 
            // dcIDName
            // 
            this.dcIDName.ColumnName = "ID&FullName";
            this.dcIDName.Expression = "CustomerID + \' \' + FirstName + \' \' + LastName";
            this.dcIDName.ReadOnly = true;
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(410, 233);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(100, 20);
            this.txtProductName.TabIndex = 0;
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Location = new System.Drawing.Point(407, 217);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(75, 13);
            this.lblProductName.TabIndex = 1;
            this.lblProductName.Text = "Product Name";
            // 
            // dgvProducts
            // 
            this.dgvProducts.AutoGenerateColumns = false;
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productIDDataGridViewTextBoxColumn,
            this.productNameDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn});
            this.dgvProducts.DataSource = this.dvProducts;
            this.dgvProducts.Location = new System.Drawing.Point(413, 22);
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.Size = new System.Drawing.Size(507, 192);
            this.dgvProducts.TabIndex = 2;
            // 
            // productIDDataGridViewTextBoxColumn
            // 
            this.productIDDataGridViewTextBoxColumn.DataPropertyName = "ProductID";
            this.productIDDataGridViewTextBoxColumn.HeaderText = "ProductID";
            this.productIDDataGridViewTextBoxColumn.Name = "productIDDataGridViewTextBoxColumn";
            // 
            // productNameDataGridViewTextBoxColumn
            // 
            this.productNameDataGridViewTextBoxColumn.DataPropertyName = "ProductName";
            this.productNameDataGridViewTextBoxColumn.HeaderText = "ProductName";
            this.productNameDataGridViewTextBoxColumn.Name = "productNameDataGridViewTextBoxColumn";
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            // 
            // dvProducts
            // 
            this.dvProducts.RowFilter = "Price > 300";
            this.dvProducts.Sort = "ProductName DESC";
            this.dvProducts.Table = this.dtProducts;
            // 
            // btnFirst
            // 
            this.btnFirst.Location = new System.Drawing.Point(516, 230);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(75, 23);
            this.btnFirst.TabIndex = 4;
            this.btnFirst.Text = "<<";
            this.btnFirst.UseVisualStyleBackColor = true;
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // btnPrev
            // 
            this.btnPrev.Location = new System.Drawing.Point(597, 230);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(75, 23);
            this.btnPrev.TabIndex = 5;
            this.btnPrev.Text = "<";
            this.btnPrev.UseVisualStyleBackColor = true;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(678, 230);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 6;
            this.btnNext.Text = ">";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnLast
            // 
            this.btnLast.Location = new System.Drawing.Point(759, 230);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(75, 23);
            this.btnLast.TabIndex = 7;
            this.btnLast.Text = ">>";
            this.btnLast.UseVisualStyleBackColor = true;
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // btnPriceIncrease
            // 
            this.btnPriceIncrease.Location = new System.Drawing.Point(937, 86);
            this.btnPriceIncrease.Name = "btnPriceIncrease";
            this.btnPriceIncrease.Size = new System.Drawing.Size(98, 23);
            this.btnPriceIncrease.TabIndex = 8;
            this.btnPriceIncrease.Text = "More Expensive";
            this.btnPriceIncrease.UseVisualStyleBackColor = true;
            this.btnPriceIncrease.Click += new System.EventHandler(this.btnPriceIncrease_Click);
            // 
            // btnPriceDecrease
            // 
            this.btnPriceDecrease.Location = new System.Drawing.Point(937, 115);
            this.btnPriceDecrease.Name = "btnPriceDecrease";
            this.btnPriceDecrease.Size = new System.Drawing.Size(98, 23);
            this.btnPriceDecrease.TabIndex = 9;
            this.btnPriceDecrease.Text = "Less Expensive";
            this.btnPriceDecrease.UseVisualStyleBackColor = true;
            this.btnPriceDecrease.Click += new System.EventHandler(this.btnPriceDecrease_Click);
            // 
            // dgvOrderDetails
            // 
            this.dgvOrderDetails.AutoGenerateColumns = false;
            this.dgvOrderDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrderDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orderIDDataGridViewTextBoxColumn,
            this.productIDDataGridViewTextBoxColumn1,
            this.qtyDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn1,
            this.productQtyPriceTotalDataGridViewTextBoxColumn,
            this.lineTotalDataGridViewTextBoxColumn});
            this.dgvOrderDetails.DataMember = "Orders.relOrdersDetails_Orders";
            this.dgvOrderDetails.DataSource = this.dsOrders;
            this.dgvOrderDetails.Location = new System.Drawing.Point(409, 305);
            this.dgvOrderDetails.Name = "dgvOrderDetails";
            this.dgvOrderDetails.Size = new System.Drawing.Size(644, 207);
            this.dgvOrderDetails.TabIndex = 10;
            // 
            // orderIDDataGridViewTextBoxColumn
            // 
            this.orderIDDataGridViewTextBoxColumn.DataPropertyName = "OrderID";
            this.orderIDDataGridViewTextBoxColumn.HeaderText = "OrderID";
            this.orderIDDataGridViewTextBoxColumn.Name = "orderIDDataGridViewTextBoxColumn";
            // 
            // productIDDataGridViewTextBoxColumn1
            // 
            this.productIDDataGridViewTextBoxColumn1.DataPropertyName = "ProductID";
            this.productIDDataGridViewTextBoxColumn1.HeaderText = "ProductID";
            this.productIDDataGridViewTextBoxColumn1.Name = "productIDDataGridViewTextBoxColumn1";
            // 
            // qtyDataGridViewTextBoxColumn
            // 
            this.qtyDataGridViewTextBoxColumn.DataPropertyName = "Qty";
            this.qtyDataGridViewTextBoxColumn.HeaderText = "Qty";
            this.qtyDataGridViewTextBoxColumn.Name = "qtyDataGridViewTextBoxColumn";
            // 
            // priceDataGridViewTextBoxColumn1
            // 
            this.priceDataGridViewTextBoxColumn1.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn1.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn1.Name = "priceDataGridViewTextBoxColumn1";
            // 
            // productQtyPriceTotalDataGridViewTextBoxColumn
            // 
            this.productQtyPriceTotalDataGridViewTextBoxColumn.DataPropertyName = "Product&Qty&Price&Total";
            this.productQtyPriceTotalDataGridViewTextBoxColumn.HeaderText = "Product&Qty&Price&Total";
            this.productQtyPriceTotalDataGridViewTextBoxColumn.Name = "productQtyPriceTotalDataGridViewTextBoxColumn";
            this.productQtyPriceTotalDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lineTotalDataGridViewTextBoxColumn
            // 
            this.lineTotalDataGridViewTextBoxColumn.DataPropertyName = "LineTotal";
            this.lineTotalDataGridViewTextBoxColumn.HeaderText = "LineTotal";
            this.lineTotalDataGridViewTextBoxColumn.Name = "lineTotalDataGridViewTextBoxColumn";
            this.lineTotalDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dgCustomers
            // 
            this.dgCustomers.AlternatingBackColor = System.Drawing.Color.GhostWhite;
            this.dgCustomers.BackColor = System.Drawing.Color.GhostWhite;
            this.dgCustomers.BackgroundColor = System.Drawing.Color.Lavender;
            this.dgCustomers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgCustomers.CaptionBackColor = System.Drawing.Color.RoyalBlue;
            this.dgCustomers.CaptionForeColor = System.Drawing.Color.White;
            this.dgCustomers.DataMember = "Customers";
            this.dgCustomers.DataSource = this.dsOrders;
            this.dgCustomers.FlatMode = true;
            this.dgCustomers.Font = new System.Drawing.Font("Tahoma", 8F);
            this.dgCustomers.ForeColor = System.Drawing.Color.MidnightBlue;
            this.dgCustomers.GridLineColor = System.Drawing.Color.RoyalBlue;
            this.dgCustomers.HeaderBackColor = System.Drawing.Color.MidnightBlue;
            this.dgCustomers.HeaderFont = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.dgCustomers.HeaderForeColor = System.Drawing.Color.Lavender;
            this.dgCustomers.LinkColor = System.Drawing.Color.Teal;
            this.dgCustomers.Location = new System.Drawing.Point(12, 19);
            this.dgCustomers.Name = "dgCustomers";
            this.dgCustomers.ParentRowsBackColor = System.Drawing.Color.Lavender;
            this.dgCustomers.ParentRowsForeColor = System.Drawing.Color.MidnightBlue;
            this.dgCustomers.SelectionBackColor = System.Drawing.Color.Teal;
            this.dgCustomers.SelectionForeColor = System.Drawing.Color.PaleGreen;
            this.dgCustomers.Size = new System.Drawing.Size(379, 234);
            this.dgCustomers.TabIndex = 11;
            // 
            // dgvOrders
            // 
            this.dgvOrders.AutoGenerateColumns = false;
            this.dgvOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orderIDDataGridViewTextBoxColumn1,
            this.timeStampDataGridViewTextBoxColumn1,
            this.customerDataGridViewTextBoxColumn1});
            this.dgvOrders.DataMember = "Orders";
            this.dgvOrders.DataSource = this.dsOrders;
            this.dgvOrders.Location = new System.Drawing.Point(12, 304);
            this.dgvOrders.Name = "dgvOrders";
            this.dgvOrders.Size = new System.Drawing.Size(379, 208);
            this.dgvOrders.TabIndex = 12;
            // 
            // orderIDDataGridViewTextBoxColumn1
            // 
            this.orderIDDataGridViewTextBoxColumn1.DataPropertyName = "OrderID";
            this.orderIDDataGridViewTextBoxColumn1.HeaderText = "OrderID";
            this.orderIDDataGridViewTextBoxColumn1.Name = "orderIDDataGridViewTextBoxColumn1";
            // 
            // timeStampDataGridViewTextBoxColumn1
            // 
            this.timeStampDataGridViewTextBoxColumn1.DataPropertyName = "Time Stamp";
            this.timeStampDataGridViewTextBoxColumn1.HeaderText = "Time Stamp";
            this.timeStampDataGridViewTextBoxColumn1.Name = "timeStampDataGridViewTextBoxColumn1";
            // 
            // customerDataGridViewTextBoxColumn1
            // 
            this.customerDataGridViewTextBoxColumn1.DataPropertyName = "Customer";
            this.customerDataGridViewTextBoxColumn1.HeaderText = "Customer";
            this.customerDataGridViewTextBoxColumn1.Name = "customerDataGridViewTextBoxColumn1";
            // 
            // btnAcceptChanges
            // 
            this.btnAcceptChanges.Location = new System.Drawing.Point(28, 531);
            this.btnAcceptChanges.Name = "btnAcceptChanges";
            this.btnAcceptChanges.Size = new System.Drawing.Size(142, 23);
            this.btnAcceptChanges.TabIndex = 13;
            this.btnAcceptChanges.Text = "Accept Changes";
            this.btnAcceptChanges.UseVisualStyleBackColor = true;
            this.btnAcceptChanges.Click += new System.EventHandler(this.btnAcceptChanges_Click);
            // 
            // btnDiffGram
            // 
            this.btnDiffGram.Location = new System.Drawing.Point(221, 531);
            this.btnDiffGram.Name = "btnDiffGram";
            this.btnDiffGram.Size = new System.Drawing.Size(111, 23);
            this.btnDiffGram.TabIndex = 14;
            this.btnDiffGram.Text = "Create DiffGram";
            this.btnDiffGram.UseVisualStyleBackColor = true;
            this.btnDiffGram.Click += new System.EventHandler(this.btnDiffGram_Click);
            // 
            // lblOrders
            // 
            this.lblOrders.AutoSize = true;
            this.lblOrders.Location = new System.Drawing.Point(12, 285);
            this.lblOrders.Name = "lblOrders";
            this.lblOrders.Size = new System.Drawing.Size(297, 13);
            this.lblOrders.TabIndex = 15;
            this.lblOrders.Text = "Select an order below. Order details will be shown on the right";
            // 
            // lblOrderDetails
            // 
            this.lblOrderDetails.AutoSize = true;
            this.lblOrderDetails.Location = new System.Drawing.Point(410, 284);
            this.lblOrderDetails.Name = "lblOrderDetails";
            this.lblOrderDetails.Size = new System.Drawing.Size(219, 13);
            this.lblOrderDetails.TabIndex = 16;
            this.lblOrderDetails.Text = "Order details for the order selected on the left";
            // 
            // lblCustomers
            // 
            this.lblCustomers.AutoSize = true;
            this.lblCustomers.Location = new System.Drawing.Point(3, 3);
            this.lblCustomers.Name = "lblCustomers";
            this.lblCustomers.Size = new System.Drawing.Size(144, 13);
            this.lblCustomers.TabIndex = 17;
            this.lblCustomers.Text = "Customer -> Orders drill-down";
            // 
            // tabCtlMain
            // 
            this.tabCtlMain.Controls.Add(this.tabPGrids);
            this.tabCtlMain.Controls.Add(this.tabPBindings);
            this.tabCtlMain.Location = new System.Drawing.Point(12, 1);
            this.tabCtlMain.Name = "tabCtlMain";
            this.tabCtlMain.SelectedIndex = 0;
            this.tabCtlMain.Size = new System.Drawing.Size(1067, 600);
            this.tabCtlMain.TabIndex = 18;
            // 
            // tabPGrids
            // 
            this.tabPGrids.Controls.Add(this.lblPriceLimit);
            this.tabPGrids.Controls.Add(this.lblOrders);
            this.tabPGrids.Controls.Add(this.btnPriceIncrease);
            this.tabPGrids.Controls.Add(this.btnLast);
            this.tabPGrids.Controls.Add(this.lblProductName);
            this.tabPGrids.Controls.Add(this.txtProductName);
            this.tabPGrids.Controls.Add(this.btnFirst);
            this.tabPGrids.Controls.Add(this.dgvProducts);
            this.tabPGrids.Controls.Add(this.btnNext);
            this.tabPGrids.Controls.Add(this.btnPrev);
            this.tabPGrids.Controls.Add(this.btnPriceDecrease);
            this.tabPGrids.Controls.Add(this.dgvOrderDetails);
            this.tabPGrids.Controls.Add(this.dgCustomers);
            this.tabPGrids.Controls.Add(this.dgvOrders);
            this.tabPGrids.Controls.Add(this.btnAcceptChanges);
            this.tabPGrids.Controls.Add(this.btnDiffGram);
            this.tabPGrids.Controls.Add(this.lblOrderDetails);
            this.tabPGrids.Controls.Add(this.lblCustomers);
            this.tabPGrids.Location = new System.Drawing.Point(4, 22);
            this.tabPGrids.Name = "tabPGrids";
            this.tabPGrids.Padding = new System.Windows.Forms.Padding(3);
            this.tabPGrids.Size = new System.Drawing.Size(1059, 574);
            this.tabPGrids.TabIndex = 0;
            this.tabPGrids.Text = "DataGrid and DataGridView";
            this.tabPGrids.UseVisualStyleBackColor = true;
            // 
            // lblPriceLimit
            // 
            this.lblPriceLimit.AutoSize = true;
            this.lblPriceLimit.Location = new System.Drawing.Point(948, 61);
            this.lblPriceLimit.Name = "lblPriceLimit";
            this.lblPriceLimit.Size = new System.Drawing.Size(40, 13);
            this.lblPriceLimit.TabIndex = 18;
            this.lblPriceLimit.Text = "Price >";
            // 
            // tabPBindings
            // 
            this.tabPBindings.Controls.Add(this.dgvCustomerDetails);
            this.tabPBindings.Controls.Add(this.lblProduct);
            this.tabPBindings.Controls.Add(this.lblCustomDetails);
            this.tabPBindings.Controls.Add(this.lstProduct);
            this.tabPBindings.Controls.Add(this.lblCustomerOrderDetails);
            this.tabPBindings.Controls.Add(this.listBox2);
            this.tabPBindings.Controls.Add(this.lblCustomerOrders);
            this.tabPBindings.Controls.Add(this.lstCustomerOrders);
            this.tabPBindings.Controls.Add(this.lblCustomersList);
            this.tabPBindings.Controls.Add(this.lstCustomers);
            this.tabPBindings.Location = new System.Drawing.Point(4, 22);
            this.tabPBindings.Name = "tabPBindings";
            this.tabPBindings.Padding = new System.Windows.Forms.Padding(3);
            this.tabPBindings.Size = new System.Drawing.Size(1059, 574);
            this.tabPBindings.TabIndex = 1;
            this.tabPBindings.Text = "Bindings";
            this.tabPBindings.UseVisualStyleBackColor = true;
            // 
            // lblProduct
            // 
            this.lblProduct.AutoSize = true;
            this.lblProduct.Location = new System.Drawing.Point(741, 19);
            this.lblProduct.Name = "lblProduct";
            this.lblProduct.Size = new System.Drawing.Size(44, 13);
            this.lblProduct.TabIndex = 9;
            this.lblProduct.Text = "Product";
            // 
            // lblCustomDetails
            // 
            this.lblCustomDetails.AutoSize = true;
            this.lblCustomDetails.Location = new System.Drawing.Point(25, 234);
            this.lblCustomDetails.Name = "lblCustomDetails";
            this.lblCustomDetails.Size = new System.Drawing.Size(97, 13);
            this.lblCustomDetails.TabIndex = 8;
            this.lblCustomDetails.Text = "All customer details";
            // 
            // lstProduct
            // 
            this.lstProduct.DataSource = this.bsProductsBindingSource;
            this.lstProduct.DisplayMember = "ProductName";
            this.lstProduct.FormattingEnabled = true;
            this.lstProduct.Location = new System.Drawing.Point(744, 46);
            this.lstProduct.Name = "lstProduct";
            this.lstProduct.Size = new System.Drawing.Size(292, 30);
            this.lstProduct.TabIndex = 6;
            // 
            // bsProductsBindingSource
            // 
            this.bsProductsBindingSource.DataMember = "Products";
            this.bsProductsBindingSource.DataSource = this.dsOrders;
            // 
            // lblCustomerOrderDetails
            // 
            this.lblCustomerOrderDetails.AutoSize = true;
            this.lblCustomerOrderDetails.Location = new System.Drawing.Point(475, 20);
            this.lblCustomerOrderDetails.Name = "lblCustomerOrderDetails";
            this.lblCustomerOrderDetails.Size = new System.Drawing.Size(68, 13);
            this.lblCustomerOrderDetails.TabIndex = 5;
            this.lblCustomerOrderDetails.Text = "Order Details";
            // 
            // listBox2
            // 
            this.listBox2.DataSource = this.relOrdersDetailsOrdersBindingSource;
            this.listBox2.DisplayMember = "Product&Qty&Price&Total";
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(475, 46);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(239, 160);
            this.listBox2.TabIndex = 4;
            // 
            // relOrdersDetailsOrdersBindingSource
            // 
            this.relOrdersDetailsOrdersBindingSource.DataMember = "relOrdersDetails_Orders";
            this.relOrdersDetailsOrdersBindingSource.DataSource = this.relOrdersCustomersBindingSource;
            this.relOrdersDetailsOrdersBindingSource.CurrentChanged += new System.EventHandler(this.relOrdersDetailsOrdersBindingSource_CurrentChanged);
            // 
            // relOrdersCustomersBindingSource
            // 
            this.relOrdersCustomersBindingSource.DataMember = "rel_OrdersCustomers";
            this.relOrdersCustomersBindingSource.DataSource = this.bsCustomers;
            // 
            // bsCustomers
            // 
            this.bsCustomers.DataMember = "Customers";
            this.bsCustomers.DataSource = this.dsOrders;
            // 
            // lblCustomerOrders
            // 
            this.lblCustomerOrders.AutoSize = true;
            this.lblCustomerOrders.Location = new System.Drawing.Point(272, 19);
            this.lblCustomerOrders.Name = "lblCustomerOrders";
            this.lblCustomerOrders.Size = new System.Drawing.Size(92, 13);
            this.lblCustomerOrders.TabIndex = 3;
            this.lblCustomerOrders.Text = "Customer\'s Orders";
            // 
            // lstCustomerOrders
            // 
            this.lstCustomerOrders.DataSource = this.relOrdersCustomersBindingSource;
            this.lstCustomerOrders.DisplayMember = "OrderID&Date";
            this.lstCustomerOrders.FormattingEnabled = true;
            this.lstCustomerOrders.Location = new System.Drawing.Point(272, 46);
            this.lstCustomerOrders.Name = "lstCustomerOrders";
            this.lstCustomerOrders.Size = new System.Drawing.Size(166, 160);
            this.lstCustomerOrders.TabIndex = 2;
            // 
            // lblCustomersList
            // 
            this.lblCustomersList.AutoSize = true;
            this.lblCustomersList.Location = new System.Drawing.Point(19, 20);
            this.lblCustomersList.Name = "lblCustomersList";
            this.lblCustomersList.Size = new System.Drawing.Size(93, 13);
            this.lblCustomersList.TabIndex = 1;
            this.lblCustomersList.Text = "Browse customers";
            // 
            // lstCustomers
            // 
            this.lstCustomers.DataSource = this.bsCustomers;
            this.lstCustomers.DisplayMember = "ID&FullName";
            this.lstCustomers.FormattingEnabled = true;
            this.lstCustomers.Location = new System.Drawing.Point(22, 46);
            this.lstCustomers.Name = "lstCustomers";
            this.lstCustomers.Size = new System.Drawing.Size(221, 160);
            this.lstCustomers.TabIndex = 0;
            this.lstCustomers.SelectedIndexChanged += new System.EventHandler(this.lstCustomers_SelectedIndexChanged);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(797, 186);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(200, 160);
            this.listBox1.TabIndex = 11;
            // 
            // dgvCustomerDetails
            // 
            this.dgvCustomerDetails.AllowUserToAddRows = false;
            this.dgvCustomerDetails.AllowUserToDeleteRows = false;
            this.dgvCustomerDetails.AllowUserToOrderColumns = true;
            this.dgvCustomerDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCustomerDetails.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvCustomerDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomerDetails.ColumnHeadersVisible = false;
            this.dgvCustomerDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Details});
            this.dgvCustomerDetails.Location = new System.Drawing.Point(22, 261);
            this.dgvCustomerDetails.Name = "dgvCustomerDetails";
            this.dgvCustomerDetails.ReadOnly = true;
            this.dgvCustomerDetails.RowHeadersVisible = false;
            this.dgvCustomerDetails.Size = new System.Drawing.Size(1034, 293);
            this.dgvCustomerDetails.TabIndex = 10;
            // 
            // Details
            // 
            this.Details.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Details.DefaultCellStyle = dataGridViewCellStyle4;
            this.Details.HeaderText = "Details";
            this.Details.Name = "Details";
            this.Details.ReadOnly = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1091, 599);
            this.Controls.Add(this.tabCtlMain);
            this.Name = "frmMain";
            this.Text = "Untyped Dataset Demo";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtOrderDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtOrders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtCustomers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgCustomers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsOrders)).EndInit();
            this.tabCtlMain.ResumeLayout(false);
            this.tabPGrids.ResumeLayout(false);
            this.tabPGrids.PerformLayout();
            this.tabPBindings.ResumeLayout(false);
            this.tabPBindings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsProductsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.relOrdersDetailsOrdersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.relOrdersCustomersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCustomers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomerDetails)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Data.DataSet dsOrders;
        private System.Data.DataTable dtProducts;
        private System.Data.DataColumn dcProductID;
        private System.Data.DataColumn dcProductName;
        private System.Data.DataColumn dcPrice;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Data.DataTable dtOrderDetails;
        private System.Data.DataColumn dcOrderID;
        private System.Data.DataColumn dcProduct;
        private System.Data.DataColumn dcQty;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnLast;
        private System.Data.DataView dvProducts;
        private System.Windows.Forms.Button btnPriceIncrease;
        private System.Windows.Forms.Button btnPriceDecrease;
        private System.Data.DataTable dtOrders;
        private System.Windows.Forms.DataGridView dgvOrderDetails;
        private System.Data.DataColumn dcOrder;
        private System.Data.DataColumn dcTimeStamp;
        private System.Windows.Forms.DataGrid dgCustomers;
        private System.Windows.Forms.DataGridViewTextBoxColumn productIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Data.DataColumn dcCustomer;
        private System.Data.DataTable dtCustomers;
        private System.Data.DataColumn dcCustomerID;
        private System.Data.DataColumn dcFirstName;
        private System.Data.DataColumn dcLastName;
        private System.Windows.Forms.DataGridView dgvOrders;
        private System.Windows.Forms.Button btnAcceptChanges;
        private System.Windows.Forms.Button btnDiffGram;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeStampDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerDataGridViewTextBoxColumn1;
        private System.Windows.Forms.Label lblOrders;
        private System.Windows.Forms.Label lblOrderDetails;
        private System.Windows.Forms.Label lblCustomers;
        private System.Windows.Forms.TabControl tabCtlMain;
        private System.Windows.Forms.TabPage tabPGrids;
        private System.Windows.Forms.TabPage tabPBindings;
        private System.Windows.Forms.ListBox lstCustomers;
        private System.Windows.Forms.Label lblCustomersList;
        private System.Windows.Forms.BindingSource bsCustomers;
        private System.Data.DataColumn dcIDName;
        private System.Windows.Forms.ListBox lstCustomerOrders;
        private System.Windows.Forms.BindingSource relOrdersCustomersBindingSource;
        private System.Windows.Forms.Label lblCustomerOrders;
        private System.Data.DataColumn dcOrderTime;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.BindingSource relOrdersDetailsOrdersBindingSource;
        private System.Data.DataColumn dcProductPrice;
        private System.Data.DataColumn dataColumn1;
        private System.Data.DataColumn dcProductQtyPriceTotal;
        private System.Data.DataColumn dcLineTotal;
        private System.Windows.Forms.Label lblCustomerOrderDetails;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn productQtyPriceTotalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lineTotalDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label lblProduct;
        private System.Windows.Forms.Label lblCustomDetails;
        private System.Windows.Forms.ListBox lstProduct;
        private System.Windows.Forms.Label lblPriceLimit;
        private System.Windows.Forms.BindingSource bsProductsBindingSource;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.DataGridView dgvCustomerDetails;
        private System.Windows.Forms.DataGridViewTextBoxColumn Details;
    }
}

