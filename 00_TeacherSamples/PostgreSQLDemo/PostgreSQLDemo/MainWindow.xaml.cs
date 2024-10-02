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

namespace PostgreSQLDemo
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

        //--.
        private void btnLoadData_Click(object sender, RoutedEventArgs e)
        {
            var connStringBuilder = "Host=localhost;Port=5432;Database=fm;Username=vva;Password=vva";
            NpgsqlConnection conn = new NpgsqlConnection(connStringBuilder);
            try
            {
                conn.Open();
                lstMarkets.Items.Clear();

                NpgsqlCommand empPrepCmd = new NpgsqlCommand("SELECT market_name, city, state FROM markets WHERE zip = @ZIP", conn);
                empPrepCmd.Parameters.Add("@ZIP", NpgsqlTypes.NpgsqlDbType.Integer);

                empPrepCmd.Parameters["@ZIP"].Value = Int32.Parse(txtZIPcode.Text);
                NpgsqlDataReader reader = empPrepCmd.ExecuteReader();

                Console.WriteLine("Query returned:\nName\tAge\tLanguage");
                while (reader.Read())
                {
                    Console.WriteLine("{0}\t{1}\t{2}", reader.GetString(0), reader.GetInt32(1), reader.GetInt32(2));
                    lstMarkets.Items.Add(reader.GetString(0));
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
