using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
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

namespace FarmersMarketsApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            btnPrev.IsEnabled = false;
            btnNext.IsEnabled = false;
            loadPage();
        }
        private void loadPage()
        {
            markets.Clear();
            try
            {
                cnFarmersMarkets.Open();
                NpgsqlCommand cmd = new NpgsqlCommand(@"SELECT COUNT(*)
                                                      FROM markets m, cities c, states s
                                                      WHERE m.city = c.city_id AND c.state_id = s.state_id;",
                                    cnFarmersMarkets);
                total = Convert.ToInt32(cmd.ExecuteScalar());

                cmd = new NpgsqlCommand(String.Format(@"SELECT market_name, c.city, s.state_abbr, market_id
                                                      FROM markets m, cities c, states s
                                                      WHERE m.city = c.city_id AND c.state_id = s.state_id
                                                      LIMIT {0} OFFSET {1};", PAGE_SIZE, offset),
                                    cnFarmersMarkets);
                NpgsqlDataReader reader = cmd.ExecuteReader();
                string item;
                lstMarkets.Items.Clear();
                while (reader.Read())
                {
                    item = reader["market_name"] + " " + reader["city"] + " " + reader["state_abbr"];
                    lstMarkets.Items.Add(item);
                    if (!markets.ContainsKey(item))
                    {
                        markets.Add(item, Convert.ToInt32(reader["market_id"]));
                    }
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Failure: " + ex.Message);
            }
            finally
            {
                if (cnFarmersMarkets.State != System.Data.ConnectionState.Closed)
                {
                    cnFarmersMarkets.Close();
                }
            }
            if (offset > 0)
            {
                btnPrev.IsEnabled = true;
            }
            else
            {
                btnPrev.IsEnabled = false;
            }
            if (offset + PAGE_SIZE < total) {
                btnNext.IsEnabled = true;
            }
            else
            {
                btnNext.IsEnabled = false;
            }
        }
        private static String cnStrFarmersMarkets =
            "Host=localhost;Port=5432;Database=farmers_markets;Server Compatibility Mode=NoTypeLoading;Username=marketsuser;Password=Pa$$W0rd";
        private NpgsqlConnection cnFarmersMarkets = new NpgsqlConnection(cnStrFarmersMarkets);
        private const int PAGE_SIZE = 15;
        private int offset = 0;
        private int total = 0;
        private Dictionary<string, int> markets = new Dictionary<string, int>();

        private void btnPrev_Click(object sender, RoutedEventArgs e)
        {
            if (offset > 0)
            {
                offset = Math.Max(0, offset - PAGE_SIZE);
                loadPage();
            }
        }

        private void btnNext_Click(object sender, RoutedEventArgs e)
        {
            if (offset + PAGE_SIZE <= total)
            {
                offset += PAGE_SIZE;
                loadPage();
            }
        }

        private void lstMarkets_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            //Console.WriteLine(lstMarkets.SelectedItem);
            try
            {
                cnFarmersMarkets.Open();

                NpgsqlCommand cmd = new NpgsqlCommand(
                    String.Format(@"SELECT market_name, c.city, s.state_abbr, zip, lat, lon, market_id
                                    FROM markets m, cities c, states s
                                    WHERE m.city = c.city_id AND c.state_id = s.state_id AND market_id = {0};",
                                    markets[(String)lstMarkets.SelectedItem]),
                                    cnFarmersMarkets);
                NpgsqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    MessageBox.Show(reader.GetInt32(6) + "\n" +
                                    reader["market_name"] + "\n" + 
                                    reader["city"] + "\n" +
                                    reader["state_abbr"] + "\n" +
                                    reader.GetInt32(3) + "\n" +
                                    reader.GetFloat(4) + "\n" +
                                    reader.GetFloat(5) + "\n", "Detailed Info about market " + reader.GetInt32(6), MessageBoxButton.OK);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Failure: " + ex.Message);
            }
            finally
            {
                if (cnFarmersMarkets.State != System.Data.ConnectionState.Closed)
                {
                    cnFarmersMarkets.Close();
                }
            }
        }
    }
}
