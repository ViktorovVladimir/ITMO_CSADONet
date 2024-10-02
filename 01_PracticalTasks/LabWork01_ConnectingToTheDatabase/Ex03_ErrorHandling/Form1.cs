using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


//--.
namespace Ex03_ErrorHandling
{
    public partial class Form1 : Form
    {

        //--.
        OleDbConnection connection = new OleDbConnection();
        //--.
        string testConnect = @"Provider = SQLOLEDB.1; Integrated Security = SSPI; Persist Security Info=False;Initial Catalog = Northwind; Data Source=(local)";



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
            catch(OleDbException XcpSQL)
            {
                foreach(OleDbError se in XcpSQL.Errors)
                {
                    MessageBox.Show(se.Message, "SQL Error code " + se.NativeError, MessageBoxButtons.OK);
                }
            }
            catch( Exception Xcp ) 
            {
                MessageBox.Show(Xcp.Message, "Unexpected Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
