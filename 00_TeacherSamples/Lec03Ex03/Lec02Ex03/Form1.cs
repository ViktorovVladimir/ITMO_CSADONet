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

namespace Lec02Ex03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTran_Click(object sender, EventArgs e)
        {
            sqlConnection1.Open();
            SqlTransaction tran = sqlConnection1.BeginTransaction(IsolationLevel.ReadCommitted);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = sqlConnection1;
            cmd.Transaction = tran;

            try
            {
                cmd.CommandText = "DELETE [Order Details] WHERE ProductID = 42";
                cmd.ExecuteNonQuery();
                // Try changing Product to Products
                cmd.CommandText = "DELETE Product WHERE ProductID = 42";
                cmd.ExecuteNonQuery();
                tran.Commit();
                MessageBox.Show("Transaction committed");
            }
            catch (Exception ex)
            {
                tran.Rollback();
                MessageBox.Show("Transaction rolled back");
            }
            finally
            {
                sqlConnection1.Close();
            }

        }
    }
}
