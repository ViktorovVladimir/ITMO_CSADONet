namespace Lec04Ex03
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
            this.dsStudents = new System.Data.DataSet();
            this.dataTable1 = new System.Data.DataTable();
            this.dc_sid = new System.Data.DataColumn();
            this.dc_fname = new System.Data.DataColumn();
            this.dc_lastname = new System.Data.DataColumn();
            this.dc_majorid = new System.Data.DataColumn();
            this.dataColumn1 = new System.Data.DataColumn();
            this.dataColumn2 = new System.Data.DataColumn();
            this.dataColumn3 = new System.Data.DataColumn();
            this.dataTable2 = new System.Data.DataTable();
            this.dc_id = new System.Data.DataColumn();
            this.dc_major_name = new System.Data.DataColumn();
            this.dataGrid1 = new System.Windows.Forms.DataGrid();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.sidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.majoridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mingradeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maxgradeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.variationDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataView1 = new System.Data.DataView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.sidDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fnameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lnameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.majoridDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mingradeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maxgradeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.variationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataView2 = new System.Data.DataView();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.sidDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fnameDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lnameDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.majoridDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mingradeDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maxgradeDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.variationDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataView3 = new System.Data.DataView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dsStudents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataView3)).BeginInit();
            this.SuspendLayout();
            // 
            // dsStudents
            // 
            this.dsStudents.DataSetName = "Students";
            this.dsStudents.Relations.AddRange(new System.Data.DataRelation[] {
            new System.Data.DataRelation("Relation1", "Majors", "Students", new string[] {
                        "id"}, new string[] {
                        "majorid"}, false)});
            this.dsStudents.Tables.AddRange(new System.Data.DataTable[] {
            this.dataTable1,
            this.dataTable2});
            // 
            // dataTable1
            // 
            this.dataTable1.Columns.AddRange(new System.Data.DataColumn[] {
            this.dc_sid,
            this.dc_fname,
            this.dc_lastname,
            this.dc_majorid,
            this.dataColumn1,
            this.dataColumn2,
            this.dataColumn3});
            this.dataTable1.Constraints.AddRange(new System.Data.Constraint[] {
            new System.Data.UniqueConstraint("Constraint1", new string[] {
                        "sid"}, true),
            new System.Data.ForeignKeyConstraint("Constraint2", "Majors", new string[] {
                        "id"}, new string[] {
                        "majorid"}, System.Data.AcceptRejectRule.None, System.Data.Rule.Cascade, System.Data.Rule.Cascade)});
            this.dataTable1.PrimaryKey = new System.Data.DataColumn[] {
        this.dc_sid};
            this.dataTable1.TableName = "Students";
            // 
            // dc_sid
            // 
            this.dc_sid.AllowDBNull = false;
            this.dc_sid.AutoIncrement = true;
            this.dc_sid.ColumnName = "sid";
            this.dc_sid.DataType = typeof(int);
            // 
            // dc_fname
            // 
            this.dc_fname.AllowDBNull = false;
            this.dc_fname.ColumnName = "fname";
            // 
            // dc_lastname
            // 
            this.dc_lastname.AllowDBNull = false;
            this.dc_lastname.ColumnName = "lname";
            // 
            // dc_majorid
            // 
            this.dc_majorid.ColumnName = "majorid";
            this.dc_majorid.DataType = typeof(int);
            // 
            // dataColumn1
            // 
            this.dataColumn1.ColumnName = "mingrade";
            this.dataColumn1.DataType = typeof(int);
            // 
            // dataColumn2
            // 
            this.dataColumn2.ColumnName = "maxgrade";
            this.dataColumn2.DataType = typeof(int);
            // 
            // dataColumn3
            // 
            this.dataColumn3.ColumnName = "variation";
            this.dataColumn3.DataType = typeof(int);
            this.dataColumn3.Expression = "IIF(maxgrade-mingrade >= 0, maxgrade-mingrade, mingrade-maxgrade)";
            this.dataColumn3.ReadOnly = true;
            // 
            // dataTable2
            // 
            this.dataTable2.Columns.AddRange(new System.Data.DataColumn[] {
            this.dc_id,
            this.dc_major_name});
            this.dataTable2.Constraints.AddRange(new System.Data.Constraint[] {
            new System.Data.UniqueConstraint("Constraint1", new string[] {
                        "id"}, true)});
            this.dataTable2.PrimaryKey = new System.Data.DataColumn[] {
        this.dc_id};
            this.dataTable2.TableName = "Majors";
            // 
            // dc_id
            // 
            this.dc_id.AllowDBNull = false;
            this.dc_id.AutoIncrement = true;
            this.dc_id.ColumnName = "id";
            this.dc_id.DataType = typeof(int);
            // 
            // dc_major_name
            // 
            this.dc_major_name.AllowDBNull = false;
            this.dc_major_name.ColumnName = "major_name";
            // 
            // dataGrid1
            // 
            this.dataGrid1.AlternatingBackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.dataGrid1.BackColor = System.Drawing.Color.White;
            this.dataGrid1.BackgroundColor = System.Drawing.Color.LightGoldenrodYellow;
            this.dataGrid1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dataGrid1.CaptionBackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.dataGrid1.CaptionFont = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.dataGrid1.CaptionForeColor = System.Drawing.Color.DarkSlateBlue;
            this.dataGrid1.DataMember = "";
            this.dataGrid1.DataSource = this.dsStudents;
            this.dataGrid1.FlatMode = true;
            this.dataGrid1.Font = new System.Drawing.Font("Tahoma", 8F);
            this.dataGrid1.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.dataGrid1.GridLineColor = System.Drawing.Color.Peru;
            this.dataGrid1.GridLineStyle = System.Windows.Forms.DataGridLineStyle.None;
            this.dataGrid1.HeaderBackColor = System.Drawing.Color.Maroon;
            this.dataGrid1.HeaderFont = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.dataGrid1.HeaderForeColor = System.Drawing.Color.LightGoldenrodYellow;
            this.dataGrid1.LinkColor = System.Drawing.Color.Maroon;
            this.dataGrid1.Location = new System.Drawing.Point(12, 12);
            this.dataGrid1.Name = "dataGrid1";
            this.dataGrid1.ParentRowsBackColor = System.Drawing.Color.BurlyWood;
            this.dataGrid1.ParentRowsForeColor = System.Drawing.Color.DarkSlateBlue;
            this.dataGrid1.SelectionBackColor = System.Drawing.Color.DarkSlateBlue;
            this.dataGrid1.SelectionForeColor = System.Drawing.Color.GhostWhite;
            this.dataGrid1.Size = new System.Drawing.Size(640, 151);
            this.dataGrid1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sidDataGridViewTextBoxColumn,
            this.fnameDataGridViewTextBoxColumn,
            this.lnameDataGridViewTextBoxColumn,
            this.majoridDataGridViewTextBoxColumn,
            this.mingradeDataGridViewTextBoxColumn1,
            this.maxgradeDataGridViewTextBoxColumn1,
            this.variationDataGridViewTextBoxColumn1});
            this.dataGridView1.DataSource = this.dataView1;
            this.dataGridView1.Location = new System.Drawing.Point(12, 179);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(776, 101);
            this.dataGridView1.TabIndex = 1;
            // 
            // sidDataGridViewTextBoxColumn
            // 
            this.sidDataGridViewTextBoxColumn.DataPropertyName = "sid";
            this.sidDataGridViewTextBoxColumn.HeaderText = "sid";
            this.sidDataGridViewTextBoxColumn.Name = "sidDataGridViewTextBoxColumn";
            // 
            // fnameDataGridViewTextBoxColumn
            // 
            this.fnameDataGridViewTextBoxColumn.DataPropertyName = "fname";
            this.fnameDataGridViewTextBoxColumn.HeaderText = "fname";
            this.fnameDataGridViewTextBoxColumn.Name = "fnameDataGridViewTextBoxColumn";
            // 
            // lnameDataGridViewTextBoxColumn
            // 
            this.lnameDataGridViewTextBoxColumn.DataPropertyName = "lname";
            this.lnameDataGridViewTextBoxColumn.HeaderText = "lname";
            this.lnameDataGridViewTextBoxColumn.Name = "lnameDataGridViewTextBoxColumn";
            // 
            // majoridDataGridViewTextBoxColumn
            // 
            this.majoridDataGridViewTextBoxColumn.DataPropertyName = "majorid";
            this.majoridDataGridViewTextBoxColumn.HeaderText = "majorid";
            this.majoridDataGridViewTextBoxColumn.Name = "majoridDataGridViewTextBoxColumn";
            // 
            // mingradeDataGridViewTextBoxColumn1
            // 
            this.mingradeDataGridViewTextBoxColumn1.DataPropertyName = "mingrade";
            this.mingradeDataGridViewTextBoxColumn1.HeaderText = "mingrade";
            this.mingradeDataGridViewTextBoxColumn1.Name = "mingradeDataGridViewTextBoxColumn1";
            // 
            // maxgradeDataGridViewTextBoxColumn1
            // 
            this.maxgradeDataGridViewTextBoxColumn1.DataPropertyName = "maxgrade";
            this.maxgradeDataGridViewTextBoxColumn1.HeaderText = "maxgrade";
            this.maxgradeDataGridViewTextBoxColumn1.Name = "maxgradeDataGridViewTextBoxColumn1";
            // 
            // variationDataGridViewTextBoxColumn1
            // 
            this.variationDataGridViewTextBoxColumn1.DataPropertyName = "variation";
            this.variationDataGridViewTextBoxColumn1.HeaderText = "variation";
            this.variationDataGridViewTextBoxColumn1.Name = "variationDataGridViewTextBoxColumn1";
            this.variationDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataView1
            // 
            this.dataView1.Sort = "fname ASC";
            this.dataView1.Table = this.dataTable1;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sidDataGridViewTextBoxColumn1,
            this.fnameDataGridViewTextBoxColumn1,
            this.lnameDataGridViewTextBoxColumn1,
            this.majoridDataGridViewTextBoxColumn1,
            this.mingradeDataGridViewTextBoxColumn,
            this.maxgradeDataGridViewTextBoxColumn,
            this.variationDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.dataView2;
            this.dataGridView2.Location = new System.Drawing.Point(12, 293);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(776, 98);
            this.dataGridView2.TabIndex = 1;
            // 
            // sidDataGridViewTextBoxColumn1
            // 
            this.sidDataGridViewTextBoxColumn1.DataPropertyName = "sid";
            this.sidDataGridViewTextBoxColumn1.HeaderText = "sid";
            this.sidDataGridViewTextBoxColumn1.Name = "sidDataGridViewTextBoxColumn1";
            // 
            // fnameDataGridViewTextBoxColumn1
            // 
            this.fnameDataGridViewTextBoxColumn1.DataPropertyName = "fname";
            this.fnameDataGridViewTextBoxColumn1.HeaderText = "fname";
            this.fnameDataGridViewTextBoxColumn1.Name = "fnameDataGridViewTextBoxColumn1";
            // 
            // lnameDataGridViewTextBoxColumn1
            // 
            this.lnameDataGridViewTextBoxColumn1.DataPropertyName = "lname";
            this.lnameDataGridViewTextBoxColumn1.HeaderText = "lname";
            this.lnameDataGridViewTextBoxColumn1.Name = "lnameDataGridViewTextBoxColumn1";
            // 
            // majoridDataGridViewTextBoxColumn1
            // 
            this.majoridDataGridViewTextBoxColumn1.DataPropertyName = "majorid";
            this.majoridDataGridViewTextBoxColumn1.HeaderText = "majorid";
            this.majoridDataGridViewTextBoxColumn1.Name = "majoridDataGridViewTextBoxColumn1";
            // 
            // mingradeDataGridViewTextBoxColumn
            // 
            this.mingradeDataGridViewTextBoxColumn.DataPropertyName = "mingrade";
            this.mingradeDataGridViewTextBoxColumn.HeaderText = "mingrade";
            this.mingradeDataGridViewTextBoxColumn.Name = "mingradeDataGridViewTextBoxColumn";
            // 
            // maxgradeDataGridViewTextBoxColumn
            // 
            this.maxgradeDataGridViewTextBoxColumn.DataPropertyName = "maxgrade";
            this.maxgradeDataGridViewTextBoxColumn.HeaderText = "maxgrade";
            this.maxgradeDataGridViewTextBoxColumn.Name = "maxgradeDataGridViewTextBoxColumn";
            // 
            // variationDataGridViewTextBoxColumn
            // 
            this.variationDataGridViewTextBoxColumn.DataPropertyName = "variation";
            this.variationDataGridViewTextBoxColumn.HeaderText = "variation";
            this.variationDataGridViewTextBoxColumn.Name = "variationDataGridViewTextBoxColumn";
            this.variationDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataView2
            // 
            this.dataView2.Sort = "lname DESC";
            this.dataView2.Table = this.dataTable1;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sidDataGridViewTextBoxColumn2,
            this.fnameDataGridViewTextBoxColumn2,
            this.lnameDataGridViewTextBoxColumn2,
            this.majoridDataGridViewTextBoxColumn2,
            this.mingradeDataGridViewTextBoxColumn2,
            this.maxgradeDataGridViewTextBoxColumn2,
            this.variationDataGridViewTextBoxColumn2});
            this.dataGridView3.DataMember = "Students";
            this.dataGridView3.DataSource = this.dsStudents;
            this.dataGridView3.Location = new System.Drawing.Point(12, 416);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(776, 98);
            this.dataGridView3.TabIndex = 1;
            // 
            // sidDataGridViewTextBoxColumn2
            // 
            this.sidDataGridViewTextBoxColumn2.DataPropertyName = "sid";
            this.sidDataGridViewTextBoxColumn2.HeaderText = "sid";
            this.sidDataGridViewTextBoxColumn2.Name = "sidDataGridViewTextBoxColumn2";
            // 
            // fnameDataGridViewTextBoxColumn2
            // 
            this.fnameDataGridViewTextBoxColumn2.DataPropertyName = "fname";
            this.fnameDataGridViewTextBoxColumn2.HeaderText = "fname";
            this.fnameDataGridViewTextBoxColumn2.Name = "fnameDataGridViewTextBoxColumn2";
            // 
            // lnameDataGridViewTextBoxColumn2
            // 
            this.lnameDataGridViewTextBoxColumn2.DataPropertyName = "lname";
            this.lnameDataGridViewTextBoxColumn2.HeaderText = "lname";
            this.lnameDataGridViewTextBoxColumn2.Name = "lnameDataGridViewTextBoxColumn2";
            // 
            // majoridDataGridViewTextBoxColumn2
            // 
            this.majoridDataGridViewTextBoxColumn2.DataPropertyName = "majorid";
            this.majoridDataGridViewTextBoxColumn2.HeaderText = "majorid";
            this.majoridDataGridViewTextBoxColumn2.Name = "majoridDataGridViewTextBoxColumn2";
            // 
            // mingradeDataGridViewTextBoxColumn2
            // 
            this.mingradeDataGridViewTextBoxColumn2.DataPropertyName = "mingrade";
            this.mingradeDataGridViewTextBoxColumn2.HeaderText = "mingrade";
            this.mingradeDataGridViewTextBoxColumn2.Name = "mingradeDataGridViewTextBoxColumn2";
            // 
            // maxgradeDataGridViewTextBoxColumn2
            // 
            this.maxgradeDataGridViewTextBoxColumn2.DataPropertyName = "maxgrade";
            this.maxgradeDataGridViewTextBoxColumn2.HeaderText = "maxgrade";
            this.maxgradeDataGridViewTextBoxColumn2.Name = "maxgradeDataGridViewTextBoxColumn2";
            // 
            // variationDataGridViewTextBoxColumn2
            // 
            this.variationDataGridViewTextBoxColumn2.DataPropertyName = "variation";
            this.variationDataGridViewTextBoxColumn2.HeaderText = "variation";
            this.variationDataGridViewTextBoxColumn2.Name = "variationDataGridViewTextBoxColumn2";
            this.variationDataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(672, 74);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 74);
            this.button1.TabIndex = 2;
            this.button1.Text = "Print students with lastname A*";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 531);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dataGrid1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dsStudents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataView3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Data.DataSet dsStudents;
        private System.Data.DataTable dataTable1;
        private System.Data.DataColumn dc_sid;
        private System.Data.DataColumn dc_fname;
        private System.Data.DataColumn dc_lastname;
        private System.Data.DataColumn dc_majorid;
        private System.Data.DataTable dataTable2;
        private System.Data.DataColumn dc_id;
        private System.Data.DataColumn dc_major_name;
        private System.Windows.Forms.DataGrid dataGrid1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Data.DataColumn dataColumn1;
        private System.Data.DataColumn dataColumn2;
        private System.Data.DataColumn dataColumn3;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Data.DataView dataView1;
        private System.Data.DataView dataView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn sidDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn fnameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn lnameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn majoridDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn mingradeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maxgradeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn variationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn majoridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mingradeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn maxgradeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn variationDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridViewTextBoxColumn sidDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn fnameDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn lnameDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn majoridDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn mingradeDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn maxgradeDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn variationDataGridViewTextBoxColumn2;
        private System.Data.DataView dataView3;
        private System.Windows.Forms.Button button1;
    }
}

