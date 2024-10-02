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
using System.Configuration;


//--.
namespace Ex05_WorkingWithConfigurationClasses
{
    public partial class Form1 : Form
    {

        //--.
        OleDbConnection connection = new OleDbConnection();
        //--.
        //string testConnect = @"Provider = SQLOLEDB.1; Integrated Security = SSPI; Persist Security Info=False;Initial Catalog = Northwind; Data Source=(local)";

        //--.
        public Form1()
        {
            InitializeComponent();

            //--. Add a handler for the StateChange event of the connection object to the form constructor
            this.connection.StateChange += new System.Data.StateChangeEventHandler( this.connection_StateChange );
        }

        //--.
        static string GetConnectionStringByName(string name)
        {
            string retValue = null;

            //--.
            ConnectionStringSettings settings = ConfigurationManager.ConnectionStrings[name];

            //--
            if( settings != null ) 
            {
                retValue = settings.ConnectionString;
            }


            //--.
            return retValue;
        }



        //--. Create a handler for the StateChange event of the connection object so that it checks the current state of
        //      the connection and makes the corresponding menu items available/unavailable
        private void connection_StateChange(object sender, System.Data.StateChangeEventArgs e)
        {
            connectToolStripMenuItem.Enabled = (e.CurrentState == ConnectionState.Closed);
            disconnectToolStripMenuItem.Enabled = (e.CurrentState == ConnectionState.Open);
        }



        //--.
        private void connectToolStripMenuItem_Click(object sender, EventArgs e)
        {

            try
            {
                //--.
                if( connection.State != ConnectionState.Open )
                {

                    string testConnect = GetConnectionStringByName("DBConnect.NorthwindConnectionString"); 

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

        //--.
        private void connectionListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //--.
            ConnectionStringSettingsCollection settings = ConfigurationManager.ConnectionStrings;

            //--.
            if( settings != null )
            {
                //--.
                foreach( ConnectionStringSettings cs in settings ) 
                {
                    MessageBox.Show("name = " + cs.Name);
                    MessageBox.Show("providerName = " + cs.ProviderName);
                    MessageBox.Show("connectionString = " + cs.ConnectionString);
                }
            }
        }
    }
}
