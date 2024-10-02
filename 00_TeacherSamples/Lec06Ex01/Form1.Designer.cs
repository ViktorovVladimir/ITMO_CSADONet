namespace Lec06Ex01
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
            this.dtStudents = new System.Data.DataTable();
            this.dtCourses = new System.Data.DataTable();
            this.dtStudentsCourses = new System.Data.DataTable();
            this.dcStudentID = new System.Data.DataColumn();
            this.dcLastName = new System.Data.DataColumn();
            this.dcFirstName = new System.Data.DataColumn();
            this.dataColumn1 = new System.Data.DataColumn();
            this.dcCourseID = new System.Data.DataColumn();
            this.dcCourseName = new System.Data.DataColumn();
            this.dcStudent = new System.Data.DataColumn();
            this.dcCourse = new System.Data.DataColumn();
            this.dgvStudents = new System.Windows.Forms.DataGridView();
            this.dgvCourses = new System.Windows.Forms.DataGridView();
            this.dgvStudentsCourses = new System.Windows.Forms.DataGridView();
            this.lblLastName = new System.Windows.Forms.Label();
            this.txtStudent = new System.Windows.Forms.TextBox();
            this.studentIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.initialsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courseIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courseNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.btnLog = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dsStudents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtStudents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtCourses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtStudentsCourses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCourses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudentsCourses)).BeginInit();
            this.SuspendLayout();
            // 
            // dsStudents
            // 
            this.dsStudents.DataSetName = "Students and Courses";
            this.dsStudents.Tables.AddRange(new System.Data.DataTable[] {
            this.dtStudents,
            this.dtCourses,
            this.dtStudentsCourses});
            // 
            // dtStudents
            // 
            this.dtStudents.Columns.AddRange(new System.Data.DataColumn[] {
            this.dcStudentID,
            this.dcLastName,
            this.dcFirstName,
            this.dataColumn1});
            this.dtStudents.Constraints.AddRange(new System.Data.Constraint[] {
            new System.Data.UniqueConstraint("Constraint1", new string[] {
                        "StudentID"}, true),
            new System.Data.UniqueConstraint("Unique_FirstName_LastName", new string[] {
                        "FirstName",
                        "LastName"}, false)});
            this.dtStudents.PrimaryKey = new System.Data.DataColumn[] {
        this.dcStudentID};
            this.dtStudents.TableName = "Students";
            // 
            // dtCourses
            // 
            this.dtCourses.Columns.AddRange(new System.Data.DataColumn[] {
            this.dcCourseID,
            this.dcCourseName});
            this.dtCourses.Constraints.AddRange(new System.Data.Constraint[] {
            new System.Data.UniqueConstraint("Constraint1", new string[] {
                        "CourseID"}, true)});
            this.dtCourses.PrimaryKey = new System.Data.DataColumn[] {
        this.dcCourseID};
            this.dtCourses.TableName = "Courses";
            // 
            // dtStudentsCourses
            // 
            this.dtStudentsCourses.Columns.AddRange(new System.Data.DataColumn[] {
            this.dcStudent,
            this.dcCourse});
            this.dtStudentsCourses.Constraints.AddRange(new System.Data.Constraint[] {
            new System.Data.UniqueConstraint("Constraint1", new string[] {
                        "Course",
                        "Student"}, true),
            new System.Data.ForeignKeyConstraint("FK_Students", "Students", new string[] {
                        "StudentID"}, new string[] {
                        "Student"}, System.Data.AcceptRejectRule.None, System.Data.Rule.Cascade, System.Data.Rule.Cascade),
            new System.Data.ForeignKeyConstraint("FK_Courses", "Courses", new string[] {
                        "CourseID"}, new string[] {
                        "Course"}, System.Data.AcceptRejectRule.None, System.Data.Rule.Cascade, System.Data.Rule.Cascade)});
            this.dtStudentsCourses.PrimaryKey = new System.Data.DataColumn[] {
        this.dcCourse,
        this.dcStudent};
            this.dtStudentsCourses.TableName = "StudentsCourses";
            // 
            // dcStudentID
            // 
            this.dcStudentID.AllowDBNull = false;
            this.dcStudentID.ColumnName = "StudentID";
            this.dcStudentID.DataType = typeof(long);
            // 
            // dcLastName
            // 
            this.dcLastName.ColumnName = "LastName";
            // 
            // dcFirstName
            // 
            this.dcFirstName.ColumnName = "FirstName";
            // 
            // dataColumn1
            // 
            this.dataColumn1.Caption = "Initials";
            this.dataColumn1.ColumnName = "Initials";
            this.dataColumn1.Expression = "SUBSTRING(FirstName,1,1)+SUBSTRING(LastName,1,1)";
            this.dataColumn1.ReadOnly = true;
            // 
            // dcCourseID
            // 
            this.dcCourseID.AllowDBNull = false;
            this.dcCourseID.ColumnName = "CourseID";
            // 
            // dcCourseName
            // 
            this.dcCourseName.AllowDBNull = false;
            this.dcCourseName.ColumnName = "CourseName";
            // 
            // dcStudent
            // 
            this.dcStudent.AllowDBNull = false;
            this.dcStudent.ColumnName = "Student";
            this.dcStudent.DataType = typeof(long);
            // 
            // dcCourse
            // 
            this.dcCourse.AllowDBNull = false;
            this.dcCourse.ColumnName = "Course";
            // 
            // dgvStudents
            // 
            this.dgvStudents.AutoGenerateColumns = false;
            this.dgvStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudents.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.studentIDDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.initialsDataGridViewTextBoxColumn});
            this.dgvStudents.DataMember = "Students";
            this.dgvStudents.DataSource = this.dsStudents;
            this.dgvStudents.Location = new System.Drawing.Point(12, 12);
            this.dgvStudents.Name = "dgvStudents";
            this.dgvStudents.Size = new System.Drawing.Size(668, 384);
            this.dgvStudents.TabIndex = 0;
            // 
            // dgvCourses
            // 
            this.dgvCourses.AutoGenerateColumns = false;
            this.dgvCourses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCourses.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.courseIDDataGridViewTextBoxColumn,
            this.courseNameDataGridViewTextBoxColumn});
            this.dgvCourses.DataMember = "Courses";
            this.dgvCourses.DataSource = this.dsStudents;
            this.dgvCourses.Location = new System.Drawing.Point(711, 12);
            this.dgvCourses.Name = "dgvCourses";
            this.dgvCourses.Size = new System.Drawing.Size(382, 189);
            this.dgvCourses.TabIndex = 1;
            // 
            // dgvStudentsCourses
            // 
            this.dgvStudentsCourses.AutoGenerateColumns = false;
            this.dgvStudentsCourses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudentsCourses.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.studentDataGridViewTextBoxColumn,
            this.courseDataGridViewTextBoxColumn});
            this.dgvStudentsCourses.DataMember = "StudentsCourses";
            this.dgvStudentsCourses.DataSource = this.dsStudents;
            this.dgvStudentsCourses.Location = new System.Drawing.Point(711, 218);
            this.dgvStudentsCourses.Name = "dgvStudentsCourses";
            this.dgvStudentsCourses.Size = new System.Drawing.Size(382, 178);
            this.dgvStudentsCourses.TabIndex = 2;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(12, 414);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(61, 13);
            this.lblLastName.TabIndex = 3;
            this.lblLastName.Text = "Last Name:";
            // 
            // txtStudent
            // 
            this.txtStudent.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsStudents, "Students.LastName", true));
            this.txtStudent.Location = new System.Drawing.Point(15, 448);
            this.txtStudent.Name = "txtStudent";
            this.txtStudent.Size = new System.Drawing.Size(267, 20);
            this.txtStudent.TabIndex = 4;
            // 
            // studentIDDataGridViewTextBoxColumn
            // 
            this.studentIDDataGridViewTextBoxColumn.DataPropertyName = "StudentID";
            this.studentIDDataGridViewTextBoxColumn.HeaderText = "StudentID";
            this.studentIDDataGridViewTextBoxColumn.Name = "studentIDDataGridViewTextBoxColumn";
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "LastName";
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            // 
            // initialsDataGridViewTextBoxColumn
            // 
            this.initialsDataGridViewTextBoxColumn.DataPropertyName = "Initials";
            this.initialsDataGridViewTextBoxColumn.HeaderText = "Initials";
            this.initialsDataGridViewTextBoxColumn.Name = "initialsDataGridViewTextBoxColumn";
            this.initialsDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // courseIDDataGridViewTextBoxColumn
            // 
            this.courseIDDataGridViewTextBoxColumn.DataPropertyName = "CourseID";
            this.courseIDDataGridViewTextBoxColumn.HeaderText = "CourseID";
            this.courseIDDataGridViewTextBoxColumn.Name = "courseIDDataGridViewTextBoxColumn";
            // 
            // courseNameDataGridViewTextBoxColumn
            // 
            this.courseNameDataGridViewTextBoxColumn.DataPropertyName = "CourseName";
            this.courseNameDataGridViewTextBoxColumn.HeaderText = "CourseName";
            this.courseNameDataGridViewTextBoxColumn.Name = "courseNameDataGridViewTextBoxColumn";
            // 
            // studentDataGridViewTextBoxColumn
            // 
            this.studentDataGridViewTextBoxColumn.DataPropertyName = "Student";
            this.studentDataGridViewTextBoxColumn.HeaderText = "Student";
            this.studentDataGridViewTextBoxColumn.Name = "studentDataGridViewTextBoxColumn";
            // 
            // courseDataGridViewTextBoxColumn
            // 
            this.courseDataGridViewTextBoxColumn.DataPropertyName = "Course";
            this.courseDataGridViewTextBoxColumn.HeaderText = "Course";
            this.courseDataGridViewTextBoxColumn.Name = "courseDataGridViewTextBoxColumn";
            // 
            // txtLog
            // 
            this.txtLog.Location = new System.Drawing.Point(397, 414);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.Size = new System.Drawing.Size(711, 106);
            this.txtLog.TabIndex = 5;
            // 
            // btnLog
            // 
            this.btnLog.Location = new System.Drawing.Point(303, 444);
            this.btnLog.Name = "btnLog";
            this.btnLog.Size = new System.Drawing.Size(75, 23);
            this.btnLog.TabIndex = 6;
            this.btnLog.Text = "Log all data";
            this.btnLog.UseVisualStyleBackColor = true;
            this.btnLog.Click += new System.EventHandler(this.btnLog_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1120, 542);
            this.Controls.Add(this.btnLog);
            this.Controls.Add(this.txtLog);
            this.Controls.Add(this.txtStudent);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.dgvStudentsCourses);
            this.Controls.Add(this.dgvCourses);
            this.Controls.Add(this.dgvStudents);
            this.Name = "Form1";
            this.Text = "Student Data";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dsStudents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtStudents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtCourses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtStudentsCourses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCourses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudentsCourses)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Data.DataSet dsStudents;
        private System.Data.DataTable dtStudents;
        private System.Data.DataColumn dcStudentID;
        private System.Data.DataColumn dcLastName;
        private System.Data.DataColumn dcFirstName;
        private System.Data.DataColumn dataColumn1;
        private System.Data.DataTable dtCourses;
        private System.Data.DataColumn dcCourseID;
        private System.Data.DataColumn dcCourseName;
        private System.Data.DataTable dtStudentsCourses;
        private System.Data.DataColumn dcStudent;
        private System.Data.DataColumn dcCourse;
        private System.Windows.Forms.DataGridView dgvStudents;
        private System.Windows.Forms.DataGridView dgvCourses;
        private System.Windows.Forms.DataGridView dgvStudentsCourses;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox txtStudent;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn initialsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn courseIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn courseNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn courseDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox txtLog;
        private System.Windows.Forms.Button btnLog;
    }
}

