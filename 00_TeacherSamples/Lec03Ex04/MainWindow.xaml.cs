using Npgsql;
using System;
using System.Configuration;
using System.Data.Common;
using System.Data.SqlClient;
using System.Data.OleDb;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Data;

namespace Lec03Ex02
{
    public class ConnectionString
    {
        public int ID { get; set; }

        public string? Name { get; set; }
        public required string Provider { get; set; }

        public required Type ConnectionType { get; set; }

        public required string ConnectionStringValue { get; set; }

        public string Color { get; set; } = "Blue";
    }

    public class ConnectionObject
    {
        public int ID { get; set; }

        public required string Provider { get; set; }

        public required DbConnection Connection { get; set; }

        public required ConnectionState PreviousState { get; set; }

        public string Color { get; set; } = "Blue";
    }

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Dictionary<int, ConnectionString> connectionStrings = new Dictionary<int, ConnectionString>();
        List<ConnectionString> connectionStringItems = new List<ConnectionString>();
        private Dictionary<int, ConnectionObject> connections = new Dictionary<int, ConnectionObject>();
        List<ConnectionObject> connectionItems = new List<ConnectionObject>();
        Random randomGen = new Random(Guid.NewGuid().GetHashCode());

        public MainWindow()
        {
            InitializeComponent();
        }

        private String GetUniqueRandomColorName()
        {
            List<string> poorColors = ["Black", "Ivory", "PaleGoldenrod", "LemonChiffon", "Azure", "LavenderBlush", "SeaShell", "Snow"];
            KnownColor[] names = (KnownColor[])Enum.GetValues(typeof(KnownColor));
            names = names[28..163];
            String colorName = "Blue";
            bool duplicate;
            do
            {
                duplicate = false;
                colorName = names[randomGen.Next(names.Length)].ToString();
                if (connectionStringItems != null)
                {
                    foreach (var item in connectionStringItems)
                    {
                        if (colorName.Equals(item.Color))
                        {
                            duplicate = true;
                        }
                    }
                }
            } while (poorColors.Contains(colorName) || duplicate || colorName.Contains("Light")
            || colorName.Contains("White") || colorName.Contains("Yellow"));
            Trace.WriteLine(colorName);
            return colorName;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            System.Configuration.Configuration config =
                    ConfigurationManager.OpenExeConfiguration(
                    ConfigurationUserLevel.None);

            // Get the conectionStrings section.
            ConnectionStringsSection csSection =
                config.ConnectionStrings;
            // See https://wpf-tutorial.com/listview-control/listview-with-gridview/
            for (int i = 0; i < ConfigurationManager.ConnectionStrings.Count; i++)
            {
                ConnectionStringSettings cs =
                    csSection.ConnectionStrings[i];
                Type connectionType = typeof(System.Data.SqlClient.SqlConnection);
                switch (cs.ProviderName)
                {
                    case "System.Data.SqlClient":
                        connectionType = typeof(System.Data.SqlClient.SqlConnection);
                        break;
                    case "System.Data.OleDbClient":
                        connectionType = typeof(System.Data.OleDb.OleDbConnection);
                        break;
                    case "Npgsql":
                        connectionType = typeof(Npgsql.NpgsqlConnection);
                        break;
                }
                connectionStrings.Add(i, new ConnectionString()
                {
                    ID = i,
                    Name = cs.Name,
                    Provider = cs.ProviderName,
                    ConnectionStringValue = cs.ConnectionString,
                    Color = GetUniqueRandomColorName(),
                    ConnectionType = connectionType
                });
                connectionStringItems.Add(connectionStrings[i]);
            }
            lstConnectionStrings.ItemsSource = connectionStringItems;
            lstConnections.ItemsSource = connectionItems;
        }

        private void btnAddConnectionString_Click(object sender, RoutedEventArgs e)
        {
            var i = connectionStrings.Count > 0 ? connectionStrings.MaxBy(kvp => kvp.Key).Key + 1 : 0;
            var checkedValue = panelRadioProvider.Children.OfType<RadioButton>()
                 .FirstOrDefault(r => r.IsChecked.HasValue && r.IsChecked.Value);
            checkedValue ??= radioSQLServer;
            ConnectionString? connStr = null;
            switch (checkedValue.Name)
            {
                case "radioSQLServer":
                    {
                        // See https://learn.microsoft.com/en-us/dotnet/api/system.data.sqlclient.sqlconnectionstringbuilder?view=dotnet-plat-ext-8.0
                        SqlConnectionStringBuilder connStrBuilder;
                        try
                        {
                            connStrBuilder = new SqlConnectionStringBuilder(txtOther.Text);

                            if (txtServer.Text != string.Empty)
                            {
                                connStrBuilder.DataSource = txtServer.Text;
                            }
                            if (txtDatabase.Text != string.Empty)
                            {
                                connStrBuilder.InitialCatalog = txtDatabase.Text;
                            }
                            connStr = new ConnectionString()
                            {
                                ID = i,
                                Provider = "System.Data.SqlClient",
                                ConnectionStringValue = connStrBuilder.ConnectionString,
                                Color = GetUniqueRandomColorName(),
                                ConnectionType = typeof(System.Data.SqlClient.SqlConnection)
                            };
                        }
                        catch (ArgumentException ex)
                        {

                            MessageBox.Show(string.Format("Unable to build the connection string. Error: {0}", ex.Message));
                        }
                    }
                    break;
                case "radioPostgreSQL":
                    {
                        try
                        {
                            NpgsqlConnectionStringBuilder connStrBuilder = new NpgsqlConnectionStringBuilder(txtOther.Text);
                            if (txtServer.Text != string.Empty)
                            {
                                connStrBuilder.Host = txtServer.Text;
                            }
                            if (txtDatabase.Text != string.Empty)
                            {
                                connStrBuilder.Database = txtDatabase.Text;
                            }
                            connStr = new ConnectionString()
                            {
                                ID = i,
                                Provider = "Npgsql",
                                ConnectionStringValue = connStrBuilder.ConnectionString,
                                Color = GetUniqueRandomColorName(),
                                ConnectionType = typeof(NpgsqlConnection)
                            };
                        }
                        catch (ArgumentException ex)
                        {

                            MessageBox.Show(string.Format("Unable to build the connection string. Error: {0}", ex.Message));
                        }
                    }
                    break;
            }
            if (connStr != null)
            {
                // Check for duplicate connection strings
                // See: https://learn.microsoft.com/en-us/dotnet/framework/data/adonet/sql-server-connection-pooling
                foreach (var pair in connectionStrings)
                {
                    if (pair.Value.Provider.Equals(connStr.Provider) && connStr.ConnectionStringValue.Equals(pair.Value.ConnectionStringValue))
                    {
                        //MessageBox.Show(string.Format("ConnectionObject string {0} already exists. Duplicate was not added.", connStr.ConnectionStringValue));
                        connStr.Color = pair.Value.Color;
                        break;
                    }
                }
                connectionStrings.Add(i, connStr);
                connectionStringItems.Add(connectionStrings[i]);
                lstConnectionStrings.Items.Refresh();
            }
        }

        private int FindConnectionStringID(RoutedEventArgs e)
        {
            MenuItem menuItem = (MenuItem)e.Source;
            int ID = -1;
            ContextMenu? contextMenu = menuItem.CommandParameter as ContextMenu;
            if (contextMenu != null)
            {
                ListView item = (ListView)contextMenu.PlacementTarget;
                ID = ((ConnectionString)(item.SelectedItem)).ID;
            }
            return ID;
        }

        private int FindConnectionID(RoutedEventArgs e)
        {
            MenuItem menuItem = (MenuItem)e.Source;
            int ID = -1;
            ContextMenu? contextMenu = menuItem.CommandParameter as ContextMenu;
            if (contextMenu != null)
            {
                ListView item = (ListView)contextMenu.PlacementTarget;
                ID = ((ConnectionObject)(item.SelectedItem)).ID;
            }
            return ID;
        }

        private void connection_StateChange(object sender, System.Data.StateChangeEventArgs e)
        {
            lstConnections.Items.Refresh();
        }

        // See: https://learn.microsoft.com/en-us/dotnet/api/system.data.sqlclient.sqlconnection.infomessage?view=dotnet-plat-ext-8.0
        //      https://www.codeproject.com/Articles/37102/Using-InfoMessage-Event-of-SqlConnection-Object
        private void connection_InfoMessage(object sender, System.Data.SqlClient.SqlInfoMessageEventArgs e)
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("Info Message: ");
            stringBuilder.Append(e.Message + "\nDetails:\n");
            foreach (var error in e.Errors)
            {
                stringBuilder.Append(error.ToString() + "\n");
            }
            MessageBox.Show(stringBuilder.ToString(), "Informational Message", MessageBoxButton.OK, MessageBoxImage.Information);
        }


        // See https://wpf-tutorial.com/common-interface-controls/contextmenu/
        //     https://itecnote.com/tecnote/wpf-how-to-get-the-selected-item-in-context-menu/
        private void CreateConnection_Click(object sender, RoutedEventArgs e)
        {
            ConnectionString connectionStringItem = connectionStrings[FindConnectionStringID(e)];
            String connectionString = connectionStringItem.ConnectionStringValue;
            var i = connections.Count() > 0 ? connections.MaxBy(kvp => kvp.Key).Key + 1 : 0;
            DbConnection? dbConn = Activator.CreateInstance(connectionStringItem.ConnectionType) as DbConnection;
            if (dbConn != null)
            {
                dbConn.StateChange += new StateChangeEventHandler(this.connection_StateChange);
                if (dbConn is SqlConnection)
                {
                    ((SqlConnection)dbConn).InfoMessage += new SqlInfoMessageEventHandler(this.connection_InfoMessage);
                }
                dbConn.ConnectionString = connectionString;
                ConnectionObject conn = new ConnectionObject()
                {
                    ID = i,
                    Provider = connectionStringItem.Provider,
                    Connection = dbConn,
                    Color = connectionStringItem.Color,
                    PreviousState = dbConn.State
                };
                connections.Add(i, conn);
                connectionItems.Add(connections[i]);
                lstConnections.Items.Refresh();
            }
        }

        private void RemoveConnectionString_Click(object sender, RoutedEventArgs e)
        {
            var ID = FindConnectionStringID(e);
            connectionStringItems.Remove(connectionStrings[ID]);
            lstConnectionStrings.Items.Refresh();
            connectionStrings.Remove(ID);
        }

        private void OpenConnection_Click(object sender, RoutedEventArgs e)
        {
            var ID = FindConnectionID(e);
            try
            {
                connections[ID].Connection.Open();
            }
            catch (System.Data.SqlClient.SqlException XcpSQL)
            {
                string sErrorMsg;
                foreach (System.Data.SqlClient.SqlError se in XcpSQL.Errors)
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
                    MessageBox.Show(sErrorMsg, string.Format("SQL Server Error {0}, Severity {1}", se.Number, se.Class),
                        MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(string.Format("Unable to open a connection with connection string \"{0}\". It is already open. Error: {1}",
                    connections[ID].Connection.ConnectionString, ex.Message), "Database Connection Error",
                    MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }


        private void CloseConnection_Click(object sender, RoutedEventArgs e)
        {
            var ID = FindConnectionID(e);
            connections[ID].Connection.Close();
        }

        private void RemoveConnection_Click(object sender, RoutedEventArgs e)
        {
            CloseConnection_Click(sender, e);
            var ID = FindConnectionID(e);
            connectionItems.Remove(connections[ID]);
            lstConnections.Items.Refresh();
            connections.Remove(ID);
        }

        private void ChangeContext_Click(object sender, RoutedEventArgs e)
        {
            var ID = FindConnectionID(e);
            if (connections[ID].Connection is SqlConnection)
            {
                String database = connections[ID].Connection.Database;
                if (!string.IsNullOrEmpty(database))
                {
                    SqlCommand cmd = new SqlCommand(string.Format("USE {0};", database),
                        (SqlConnection)connections[ID].Connection);
                    try
                    {
                        cmd.ExecuteNonQuery();
                    }
                    catch (InvalidOperationException ex)
                    {
                        MessageBox.Show(string.Format("Unable to execute a command over connection string \"{0}\". It hasn't been open. Error: {1}",
                            connections[ID].Connection.ConnectionString, ex.Message), "Database Connection Error",
                            MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                }
            }

        }
    }
}