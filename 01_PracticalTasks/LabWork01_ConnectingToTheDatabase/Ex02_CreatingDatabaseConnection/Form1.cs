using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//--.
namespace Ex02_CreatingDatabaseConnection
{
    public partial class Form1 : Form
    {

        //--.
        OleDbConnection connection = new OleDbConnection();
        //--.
        string testConnect = @"Provider = SQLOLEDB.1; Integrated Security = SSPI; Persist Security Info=False;Initial Catalog = Northwind";



        //--.
        public Form1()
        {
            InitializeComponent();
        }

        //--.
        private void connectToolStripMenuItem_Click(object sender, EventArgs e)
        {

            try
            {
                //--.
                if( connection.State != ConnectionState.Open )
                {
                    //--.
                    connection.ConnectionString = testConnect;
                    connection.Open();
                    //--.
                    MessageBox.Show("Database connection successful!");
                }
                else
                {
                    MessageBox.Show("A connection to the database has already been established!!");
                }
            }
            catch
            {
                MessageBox.Show("Database connection error..");
            }
        }

        //--.
        private void disconnectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //--.
            if( connection.State == ConnectionState.Open ) 
            { 
                connection.Close();
                MessageBox.Show("Database connection closed");
            }
            else 
            {
                MessageBox.Show("The database connection has already been closed");
            }
        }
    }
}
