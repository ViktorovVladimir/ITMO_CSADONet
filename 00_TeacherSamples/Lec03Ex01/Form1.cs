using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using static System.Windows.Forms.ListViewItem;

namespace Lec03Ex01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // Get the application configuration file.
            System.Configuration.Configuration config =
                    ConfigurationManager.OpenExeConfiguration(
                    ConfigurationUserLevel.None);

            // Get the conectionStrings section.
            ConnectionStringsSection csSection =
                config.ConnectionStrings;

            for (int i = 0; i <
                ConfigurationManager.ConnectionStrings.Count; i++)
            {
                ConnectionStringSettings cs =
                    csSection.ConnectionStrings[i];

                ListViewItem item = new ListViewItem(String.Format("{0}", i));
                ListViewSubItem si = new ListViewSubItem();
                si.Text = cs.Name;
                si.Name = "Name";
                item.SubItems.Add(si);
                si = new ListViewSubItem();
                si.Text = cs.ProviderName;
                si.Name = "Provider";
                item.SubItems.Add(si);
                si = new ListViewSubItem();
                si.Text = cs.ConnectionString;
                si.Name = "ConnectionString";
                item.SubItems.Add(si);
                lstvConnectionStrings.Items.Add(item);
            }

            foreach (ColumnHeader clm in lstvConnectionStrings.Columns)
            {
                clm.Width = -1;
            }

        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=" + txtDBServer.Text + ";Initial Catalog=" +
                txtDatabase.Text + "; Integrated Security=true;Min Pool Size=5;Max Pool Size=7;";
            try
            {
                if (connection != null && connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
                connection = new SqlConnection(connectionString);
                this.connection.StateChange += new StateChangeEventHandler(this.cnNorthwind_StateChange);
                connection.Open();
                lblStatus.Text = "Status: Connection opened";
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
                lblStatus.Text = "Status: Unable to open connection";
            }
        }

        private void cnNorthwind_StateChange(object sender, StateChangeEventArgs e)
        {
            MessageBox.Show(
                "Current State: " + e.CurrentState.ToString() + "\n" +
                "Original State: " + e.OriginalState.ToString() + "\n",
                "cnNorthwind.StateChange",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
                );
        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            if (connection.State == ConnectionState.Closed) {
                lblStatus.Text = "Status: Connection is already closed";
            }
            else
            {
                try
                {
                    connection.Close();
                    lblStatus.Text = "Status: Connection closed";
                }
                catch (SqlException ex)
                {
                    lblStatus.Text = "Status: The connection-level error that occurred while closing the connection";
                }
            }
        }

        private void btnOpenClose_Click(object sender, EventArgs e)
        {
            SqlConnection cnNorthwind = null;
            try
            {
                if (lstvConnectionStrings.SelectedItems.Count == 0)
                {
                    MessageBox.Show("Select one of the connections from the list below");
                    return;
                }
                cnNorthwind = new SqlConnection();
                cnNorthwind.ConnectionString = lstvConnectionStrings.SelectedItems[0].SubItems["ConnectionString"].Text;
                cnNorthwind.Open();
                MessageBox.Show("Successfully opened and closed connection " +
                     lstvConnectionStrings.SelectedItems[0].SubItems["Name"].Text);
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show("You must close the connection first");
            }
            catch (SqlException ex)
            {
                string sErrorMsg;

                foreach (System.Data.SqlClient.SqlError se in ex.Errors)
                {
                    switch (se.Number)
                    {
                        case 17:
                            sErrorMsg = "Wrong or missing server!"; break;
                        case 4060:
                            sErrorMsg = "Wrong or missing database!"; break;
                        case 18456:
                            sErrorMsg = "Wrong or missing user name or password!"; break;
                        default:
                            sErrorMsg = se.Message; break;
                    }
                    MessageBox.Show(sErrorMsg, "SQL Server Error " +
                        se.Number + " " + se.Class, MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
            catch (System.Exception Xcp)
            {
                MessageBox.Show(Xcp.ToString());
            }
            finally
            {
                if (cnNorthwind != null)
                {
                    cnNorthwind.Close();
                    cnNorthwind.Dispose();
                    cnNorthwind = null;
                }
            }
        }

        private SqlConnection connection;
    }
}
