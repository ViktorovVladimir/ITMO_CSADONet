using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


//--.
namespace Lec01Ex02_SQLite
{
    public partial class Form1 : Form, INotifyPropertyChanged
    {
        public const int US_IN_MS = 1000;
        public string DBName
        {
            get { return _dbname; }
            set
            {
                _dbname = value;
                OnPropertyChanged("DBName");
            }
        }

        public string ProfileName
        {
            get { return _profilename; }
            set
            {
                _profilename = value;
                OnPropertyChanged("ProfileName");
            }
        }

        protected virtual void OnPropertyChanged(string property)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(property));
        }

        #region INotifyPropertyChanged Members

        public event PropertyChangedEventHandler PropertyChanged;

        #endregion

        public Form1()
        {
            InitializeComponent();
            openUsersFileDialog = new OpenFileDialog();
            openUsersFileDialog.InitialDirectory = Directory.GetCurrentDirectory();
            openFirefoxFileDialog = new OpenFileDialog();
            openFirefoxFileDialog.InitialDirectory = Environment.GetFolderPath(
                Environment.SpecialFolder.ApplicationData) + @"\Mozilla\Firefox\Profiles\";
            lblDBName.DataBindings.Add(new Binding("Text", this, "DBName"));
            lblProfileName.DataBindings.Add(new Binding("Text", this, "ProfileName"));
            DBName = DBNamePrefix;
            ProfileName = ProfileNamePrefix;
        }

        private OpenFileDialog openUsersFileDialog;
        private string _dbname;
        private const string DBNamePrefix = "Selected SQLite Database File: ";

        private OpenFileDialog openFirefoxFileDialog;
        private string _profilename;
        private const string ProfileNamePrefix = "Selected Firefox Profile File: ";

        //--.
        private void btnLoadData_Click(object sender, EventArgs e)
        {
            using (var connection = new SqliteConnection(@"Data Source=" + openUsersFileDialog.FileName))
            {
                connection.Open();
                listView1.Items.Clear();

                var command = connection.CreateCommand();
                command.CommandText =
                @"
                  SELECT userid, fname, lname
                  FROM users
                  WHERE userid <= $id
                ";
                command.Parameters.AddWithValue("$id", "15");

                using (var reader = command.ExecuteReader())
                {
                    int userid;
                    String fname, lname;
                    while (reader.Read())
                    {
                        userid = Convert.ToInt32(reader.GetString(0));
                        fname = (String)reader.GetValue(reader.GetOrdinal("fname"));
                        lname = (String)reader.GetValue(reader.GetOrdinal("lname"));

                        listView1.Items.Add(new ListViewItem(
                            new string[] { userid.ToString(), fname, lname }));
                    }
                }
            }
        }

        //--.
        private void btnSelectDBFile_Click(object sender, EventArgs e)
        {
            //--.
            if( openUsersFileDialog.ShowDialog() == DialogResult.OK )
            {   
                StreamReader sr = null;
                
                //--.
                try
                {
                    sr = new StreamReader(openUsersFileDialog.FileName);
                }
                catch( SecurityException ex )
                {
                    MessageBox.Show($"Security error.\n\nError message: {ex.Message}\n\n" +
                    $"Details:\n\n{ex.StackTrace}");
                }
                finally
                {
                    sr.Close();
                }
                
                //--.
                DBName = DBNamePrefix + openUsersFileDialog.FileName;
            }
        }

        //--.
        private void btnSelectFFFile_Click(object sender, EventArgs e)
        {   
            //--.
            if( openFirefoxFileDialog.ShowDialog() == DialogResult.OK )
            {   
                //--.
                FileStream fs = null;
                
                //--.
                try
                {
                    fs = File.Open(openFirefoxFileDialog.FileName, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
                }
                catch (SecurityException ex)
                {
                    MessageBox.Show($"Security error.\n\nError message: {ex.Message}\n\n" +
                    $"Details:\n\n{ex.StackTrace}");
                }
                catch (IOException ex)
                {
                    MessageBox.Show($"IO error.\n\nError message: {ex.Message}\n\n" + $"Details:\n\n{ex.StackTrace}");
                }
                finally
                {
                    if (fs != null) fs.Close();
                }
                
                //--.
                ProfileName = ProfileNamePrefix + openFirefoxFileDialog.FileName;
            }


            //--.
            using( var connection = new SqliteConnection(@"Data Source=" + openFirefoxFileDialog.FileName) )
            {
                //--.
                connection.Open();
                listView2.Items.Clear();

                //--.
                var command = connection.CreateCommand();
                command.CommandText =
                @"
                  SELECT url, title, last_visit_date
                  FROM moz_places
                ";


                //--.
                using( var reader = command.ExecuteReader() )
                {
                    String last_visit_date;
                    String url, title;
                    Object value;
                    
                    //--.
                    while( reader.Read() )
                    {
                        //--.
                        url = (String)reader.GetValue(reader.GetOrdinal("url"));
                        //--.
                        value = reader.GetValue(reader.GetOrdinal("title"));
                        
                        //--.
                        if( Convert.IsDBNull(value) )
                        {
                            title = "N/A";
                        }
                        else
                        {
                            title = (String)value;
                        }
                        
                        //--.
                        value = reader.GetValue(reader.GetOrdinal("last_visit_date"));
                        //--.
                        if( Convert.IsDBNull(value) )
                        {
                            last_visit_date = "N/A";
                        }
                        else
                        {
                            last_visit_date = DateTimeOffset.FromUnixTimeMilliseconds(
                            Convert.ToInt64(value) / US_IN_MS).DateTime.ToString();
                        }

                        //--.
                        if( listView2.Items.Count <= 200 ) 
                        {
                            listView2.Items.Add(new ListViewItem(
                            new string[] { title, url, last_visit_date }));
                        }
                    }
                }
            }
        }
    }
}
