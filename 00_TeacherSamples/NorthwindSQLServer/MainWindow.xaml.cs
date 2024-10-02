using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Northwind
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnRefresh_Click(object sender, RoutedEventArgs e)
        {
            string source = string.Empty;
            if (radioSourceLocal.IsChecked == true)
            {
                source = radioSourceLocal.Content.ToString();
            }
            else if (radioSourceLocalDB.IsChecked == true)
            {
                source = radioSourceLocalDB.Content.ToString();
            }
            Debug.Assert(source != string.Empty);
            var connectionString = string.Format("Data Source = {0}; Initial Catalog = Northwind; Integrated Security=SSPI", source);
            SqlConnection conn = new SqlConnection(connectionString);
            try
            {
                conn.Open();
                lstMarkets.Items.Clear();

                SqlCommand cmd = new SqlCommand("SELECT FirstName, LastName FROM Employees WHERE Country = 'USA' AND PostalCode = @ZIP;", conn);
                cmd.Parameters.AddWithValue("@ZIP", NpgsqlTypes.NpgsqlDbType.Integer);
                cmd.Parameters["@ZIP"].Value = Int32.Parse(txtZIP.Text);

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    lstMarkets.Items.Add(string.Format("{0} {1}", reader.GetString(0), reader.GetString(1)));
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine("Failure: " + ex.Message);
            }
            finally
            {
                if (conn.State != System.Data.ConnectionState.Closed)
                {
                    conn.Close();
                    conn.Dispose();
                }
            }
        }
    }
}
