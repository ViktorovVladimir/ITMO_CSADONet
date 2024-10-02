namespace Lec04Ex01
{
    partial class Form1
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
            this.cnNorthwind = new System.Data.SqlClient.SqlConnection();
            this.cmdProductCnt = new System.Data.SqlClient.SqlCommand();
            this.cmdCheapProducts = new System.Data.SqlClient.SqlCommand();
            this.txtMaxPrice = new System.Windows.Forms.TextBox();
            this.btnGetCheapest = new System.Windows.Forms.Button();
            this.txtProductCnt = new System.Windows.Forms.TextBox();
            this.lblMaxPrice = new System.Windows.Forms.Label();
            this.txtExpensiveItem = new System.Windows.Forms.TextBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.btnGetProductCnt = new System.Windows.Forms.Button();
            this.txtCategoryId = new System.Windows.Forms.TextBox();
            this.lblCategoryId = new System.Windows.Forms.Label();
            this.lblProductCount = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cnNorthwind
            // 
            this.cnNorthwind.ConnectionString = "Data Source=(local);Initial Catalog=Northwind;Integrated Security=True;Encrypt=Fa" +
    "lse";
            this.cnNorthwind.FireInfoMessageEventOnUserErrors = false;
            // 
            // cmdProductCnt
            // 
            this.cmdProductCnt.CommandText = "SELECT       COUNT(*) AS ProductCount\r\nFROM            Products";
            this.cmdProductCnt.Connection = this.cnNorthwind;
            // 
            // cmdCheapProducts
            // 
            this.cmdCheapProducts.Connection = this.cnNorthwind;
            // 
            // txtMaxPrice
            // 
            this.txtMaxPrice.Location = new System.Drawing.Point(81, 196);
            this.txtMaxPrice.Name = "txtMaxPrice";
            this.txtMaxPrice.Size = new System.Drawing.Size(100, 20);
            this.txtMaxPrice.TabIndex = 0;
            this.txtMaxPrice.TextChanged += new System.EventHandler(this.txtMaxPrice_TextChanged);
            // 
            // btnGetCheapest
            // 
            this.btnGetCheapest.Location = new System.Drawing.Point(81, 12);
            this.btnGetCheapest.Name = "btnGetCheapest";
            this.btnGetCheapest.Size = new System.Drawing.Size(287, 67);
            this.btnGetCheapest.TabIndex = 1;
            this.btnGetCheapest.Text = "Get product count";
            this.btnGetCheapest.UseVisualStyleBackColor = true;
            this.btnGetCheapest.Click += new System.EventHandler(this.btnGetCheapest_Click);
            // 
            // txtProductCnt
            // 
            this.txtProductCnt.Location = new System.Drawing.Point(81, 94);
            this.txtProductCnt.Name = "txtProductCnt";
            this.txtProductCnt.ReadOnly = true;
            this.txtProductCnt.Size = new System.Drawing.Size(100, 20);
            this.txtProductCnt.TabIndex = 2;
            // 
            // lblMaxPrice
            // 
            this.lblMaxPrice.AutoSize = true;
            this.lblMaxPrice.Location = new System.Drawing.Point(81, 180);
            this.lblMaxPrice.Name = "lblMaxPrice";
            this.lblMaxPrice.Size = new System.Drawing.Size(100, 13);
            this.lblMaxPrice.TabIndex = 3;
            this.lblMaxPrice.Text = "Enter max unit price";
            // 
            // txtExpensiveItem
            // 
            this.txtExpensiveItem.Location = new System.Drawing.Point(246, 195);
            this.txtExpensiveItem.Name = "txtExpensiveItem";
            this.txtExpensiveItem.Size = new System.Drawing.Size(100, 20);
            this.txtExpensiveItem.TabIndex = 4;
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(246, 176);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(216, 13);
            this.lblResult.TabIndex = 5;
            this.lblResult.Text = "The name of the most expensive cheap item";
            // 
            // btnGetProductCnt
            // 
            this.btnGetProductCnt.Location = new System.Drawing.Point(518, 71);
            this.btnGetProductCnt.Name = "btnGetProductCnt";
            this.btnGetProductCnt.Size = new System.Drawing.Size(105, 23);
            this.btnGetProductCnt.TabIndex = 6;
            this.btnGetProductCnt.Text = "Get Product Count";
            this.btnGetProductCnt.UseVisualStyleBackColor = true;
            this.btnGetProductCnt.Click += new System.EventHandler(this.btnGetProductCnt_Click);
            // 
            // txtCategoryId
            // 
            this.txtCategoryId.Location = new System.Drawing.Point(518, 36);
            this.txtCategoryId.Name = "txtCategoryId";
            this.txtCategoryId.Size = new System.Drawing.Size(100, 20);
            this.txtCategoryId.TabIndex = 7;
            // 
            // lblCategoryId
            // 
            this.lblCategoryId.AutoSize = true;
            this.lblCategoryId.Location = new System.Drawing.Point(412, 43);
            this.lblCategoryId.Name = "lblCategoryId";
            this.lblCategoryId.Size = new System.Drawing.Size(89, 13);
            this.lblCategoryId.TabIndex = 8;
            this.lblCategoryId.Text = "Enter Category Id";
            // 
            // lblProductCount
            // 
            this.lblProductCount.AutoSize = true;
            this.lblProductCount.Location = new System.Drawing.Point(518, 114);
            this.lblProductCount.Name = "lblProductCount";
            this.lblProductCount.Size = new System.Drawing.Size(81, 13);
            this.lblProductCount.TabIndex = 9;
            this.lblProductCount.Text = "Product Count: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 277);
            this.Controls.Add(this.lblProductCount);
            this.Controls.Add(this.lblCategoryId);
            this.Controls.Add(this.txtCategoryId);
            this.Controls.Add(this.btnGetProductCnt);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.txtExpensiveItem);
            this.Controls.Add(this.lblMaxPrice);
            this.Controls.Add(this.txtProductCnt);
            this.Controls.Add(this.btnGetCheapest);
            this.Controls.Add(this.txtMaxPrice);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Data.SqlClient.SqlConnection cnNorthwind;
        private System.Data.SqlClient.SqlCommand cmdProductCnt;
        private System.Data.SqlClient.SqlCommand cmdCheapProducts;
        private System.Windows.Forms.TextBox txtMaxPrice;
        private System.Windows.Forms.Button btnGetCheapest;
        private System.Windows.Forms.TextBox txtProductCnt;
        private System.Windows.Forms.Label lblMaxPrice;
        private System.Windows.Forms.TextBox txtExpensiveItem;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button btnGetProductCnt;
        private System.Windows.Forms.TextBox txtCategoryId;
        private System.Windows.Forms.Label lblCategoryId;
        private System.Windows.Forms.Label lblProductCount;
    }
}

