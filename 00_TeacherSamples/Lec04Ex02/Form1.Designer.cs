namespace Lec04Ex02
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
            this.btnLoad = new System.Windows.Forms.Button();
            this.lstProducts = new System.Windows.Forms.ListBox();
            this.cnNorthwind = new System.Data.SqlClient.SqlConnection();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.lstCurrentProducts = new System.Windows.Forms.ListBox();
            this.lstDiscontinuedProducts = new System.Windows.Forms.ListBox();
            this.btnSummarize = new System.Windows.Forms.Button();
            this.btnIncerasePrices = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(631, 42);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 23);
            this.btnLoad.TabIndex = 0;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // lstProducts
            // 
            this.lstProducts.FormattingEnabled = true;
            this.lstProducts.Location = new System.Drawing.Point(484, 92);
            this.lstProducts.Name = "lstProducts";
            this.lstProducts.Size = new System.Drawing.Size(293, 329);
            this.lstProducts.TabIndex = 1;
            // 
            // cnNorthwind
            // 
            this.cnNorthwind.ConnectionString = "Data Source=(local);Initial Catalog=Northwind;Integrated Security=True;Encrypt=Fa" +
    "lse";
            this.cnNorthwind.FireInfoMessageEventOnUserErrors = false;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(226, 191);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // lstCurrentProducts
            // 
            this.lstCurrentProducts.FormattingEnabled = true;
            this.lstCurrentProducts.Location = new System.Drawing.Point(73, 250);
            this.lstCurrentProducts.Name = "lstCurrentProducts";
            this.lstCurrentProducts.Size = new System.Drawing.Size(120, 95);
            this.lstCurrentProducts.TabIndex = 3;
            // 
            // lstDiscontinuedProducts
            // 
            this.lstDiscontinuedProducts.FormattingEnabled = true;
            this.lstDiscontinuedProducts.Location = new System.Drawing.Point(334, 250);
            this.lstDiscontinuedProducts.Name = "lstDiscontinuedProducts";
            this.lstDiscontinuedProducts.Size = new System.Drawing.Size(120, 95);
            this.lstDiscontinuedProducts.TabIndex = 3;
            // 
            // btnSummarize
            // 
            this.btnSummarize.Location = new System.Drawing.Point(334, 92);
            this.btnSummarize.Name = "btnSummarize";
            this.btnSummarize.Size = new System.Drawing.Size(86, 23);
            this.btnSummarize.TabIndex = 4;
            this.btnSummarize.Text = "Summarize";
            this.btnSummarize.UseVisualStyleBackColor = true;
            this.btnSummarize.Click += new System.EventHandler(this.btnSummarize_Click);
            // 
            // btnIncerasePrices
            // 
            this.btnIncerasePrices.Location = new System.Drawing.Point(139, 92);
            this.btnIncerasePrices.Name = "btnIncerasePrices";
            this.btnIncerasePrices.Size = new System.Drawing.Size(75, 23);
            this.btnIncerasePrices.TabIndex = 5;
            this.btnIncerasePrices.Text = "Increase Prices";
            this.btnIncerasePrices.UseVisualStyleBackColor = true;
            this.btnIncerasePrices.Click += new System.EventHandler(this.btnIncerasePrices_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnIncerasePrices);
            this.Controls.Add(this.btnSummarize);
            this.Controls.Add(this.lstDiscontinuedProducts);
            this.Controls.Add(this.lstCurrentProducts);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.lstProducts);
            this.Controls.Add(this.btnLoad);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.ListBox lstProducts;
        private System.Data.SqlClient.SqlConnection cnNorthwind;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.ListBox lstCurrentProducts;
        private System.Windows.Forms.ListBox lstDiscontinuedProducts;
        private System.Windows.Forms.Button btnSummarize;
        private System.Windows.Forms.Button btnIncerasePrices;
    }
}

