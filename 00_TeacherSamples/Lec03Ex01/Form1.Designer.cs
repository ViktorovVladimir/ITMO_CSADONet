namespace Lec03Ex01
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
            this.txtDBServer = new System.Windows.Forms.TextBox();
            this.txtDatabase = new System.Windows.Forms.TextBox();
            this.lblDBServer = new System.Windows.Forms.Label();
            this.lblDatabase = new System.Windows.Forms.Label();
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lstvConnectionStrings = new System.Windows.Forms.ListView();
            this.Seq = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ConnectionName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Provider = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ConnectionString = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnOpenClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtDBServer
            // 
            this.txtDBServer.Location = new System.Drawing.Point(78, 42);
            this.txtDBServer.Name = "txtDBServer";
            this.txtDBServer.Size = new System.Drawing.Size(100, 20);
            this.txtDBServer.TabIndex = 0;
            this.txtDBServer.Text = "(local)";
            // 
            // txtDatabase
            // 
            this.txtDatabase.Location = new System.Drawing.Point(256, 42);
            this.txtDatabase.Name = "txtDatabase";
            this.txtDatabase.Size = new System.Drawing.Size(100, 20);
            this.txtDatabase.TabIndex = 0;
            // 
            // lblDBServer
            // 
            this.lblDBServer.AutoSize = true;
            this.lblDBServer.Location = new System.Drawing.Point(75, 23);
            this.lblDBServer.Name = "lblDBServer";
            this.lblDBServer.Size = new System.Drawing.Size(54, 13);
            this.lblDBServer.TabIndex = 1;
            this.lblDBServer.Text = "DB server";
            // 
            // lblDatabase
            // 
            this.lblDatabase.AutoSize = true;
            this.lblDatabase.Location = new System.Drawing.Point(256, 23);
            this.lblDatabase.Name = "lblDatabase";
            this.lblDatabase.Size = new System.Drawing.Size(53, 13);
            this.lblDatabase.TabIndex = 2;
            this.lblDatabase.Text = "Database";
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(78, 91);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 23);
            this.btnConnect.TabIndex = 3;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.Location = new System.Drawing.Point(256, 91);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(75, 23);
            this.btnDisconnect.TabIndex = 3;
            this.btnDisconnect.Text = "Disconnect";
            this.btnDisconnect.UseVisualStyleBackColor = true;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(78, 130);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(43, 13);
            this.lblStatus.TabIndex = 4;
            this.lblStatus.Text = "Status: ";
            // 
            // lstvConnectionStrings
            // 
            this.lstvConnectionStrings.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Seq,
            this.ConnectionName,
            this.Provider,
            this.ConnectionString});
            this.lstvConnectionStrings.HideSelection = false;
            this.lstvConnectionStrings.Location = new System.Drawing.Point(8, 186);
            this.lstvConnectionStrings.MultiSelect = false;
            this.lstvConnectionStrings.Name = "lstvConnectionStrings";
            this.lstvConnectionStrings.Size = new System.Drawing.Size(780, 252);
            this.lstvConnectionStrings.TabIndex = 5;
            this.lstvConnectionStrings.UseCompatibleStateImageBehavior = false;
            this.lstvConnectionStrings.View = System.Windows.Forms.View.Details;
            // 
            // Seq
            // 
            this.Seq.Text = "#";
            this.Seq.Width = 25;
            // 
            // ConnectionName
            // 
            this.ConnectionName.Text = "Name";
            this.ConnectionName.Width = 40;
            // 
            // Provider
            // 
            this.Provider.Text = "Provider";
            // 
            // ConnectionString
            // 
            this.ConnectionString.Text = "ConnectionString";
            this.ConnectionString.Width = 25;
            // 
            // btnOpenClose
            // 
            this.btnOpenClose.Location = new System.Drawing.Point(682, 157);
            this.btnOpenClose.Name = "btnOpenClose";
            this.btnOpenClose.Size = new System.Drawing.Size(106, 23);
            this.btnOpenClose.TabIndex = 6;
            this.btnOpenClose.Text = "Open and Close";
            this.btnOpenClose.UseVisualStyleBackColor = true;
            this.btnOpenClose.Click += new System.EventHandler(this.btnOpenClose_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnOpenClose);
            this.Controls.Add(this.lstvConnectionStrings);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnDisconnect);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.lblDatabase);
            this.Controls.Add(this.lblDBServer);
            this.Controls.Add(this.txtDatabase);
            this.Controls.Add(this.txtDBServer);
            this.Name = "Form1";
            this.Text = "SqlConnection Demo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDBServer;
        private System.Windows.Forms.TextBox txtDatabase;
        private System.Windows.Forms.Label lblDBServer;
        private System.Windows.Forms.Label lblDatabase;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnDisconnect;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ListView lstvConnectionStrings;
        private System.Windows.Forms.ColumnHeader Seq;
        private System.Windows.Forms.ColumnHeader ConnectionName;
        private System.Windows.Forms.ColumnHeader Provider;
        private System.Windows.Forms.ColumnHeader ConnectionString;
        private System.Windows.Forms.Button btnOpenClose;
    }
}

