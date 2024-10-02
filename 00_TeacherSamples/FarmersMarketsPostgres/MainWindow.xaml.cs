using Npgsql;
using System;
using System.Collections.Generic;
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

namespace FarmersMarkets
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
            var connectionString = "Host=localhost;Port=5432;Database=farmers_markets;Server Compatibility Mode=NoTypeLoading;Username=marketsuser;Password=Pa$$W0rd";
            NpgsqlConnection conn = new NpgsqlConnection(connectionString);
            try
            {
                conn.Open();
                lstMarkets.Items.Clear();

                NpgsqlCommand cmd = new NpgsqlCommand("SELECT market_name, c.city, s.state_abbr FROM markets m, cities c, states s WHERE m.city = c.city_id AND m.state = s.state_id AND zip = @ZIP;", conn);
                cmd.Parameters.Add("@ZIP", NpgsqlTypes.NpgsqlDbType.Integer);
                cmd.Parameters["@ZIP"].Value = Int32.Parse(txtZIP.Text);

                NpgsqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    lstMarkets.Items.Add(reader.GetString(0) + " " + reader.GetString(1) + ", " + reader.GetString(2));
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
                }
            }
        }
    }
}
