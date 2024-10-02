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

namespace Lec04Ex02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            SqlCommand cmdProducts = new SqlCommand("SELECT [ProductName],[UnitsInStock] FROM [dbo].[Products]",
                cnNorthwind);
            cnNorthwind.Open();
            SqlDataReader rdrProducts = cmdProducts.ExecuteReader(CommandBehavior.CloseConnection);

            while (rdrProducts.Read())
            {
                lstProducts.Items.Add(rdrProducts.GetString(0) + "\t" + rdrProducts.GetInt16(1));
            }

            rdrProducts.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SqlCommand cmdUpdate = new SqlCommand();
            cmdUpdate.CommandText = "dbo.AdjustProductAvailability";
            cmdUpdate.CommandType = CommandType.StoredProcedure;
            cmdUpdate.Connection = cnNorthwind;
            cnNorthwind.Open();
            SqlDataReader rdrProducts;
            rdrProducts = cmdUpdate.ExecuteReader(CommandBehavior.CloseConnection);
            while (rdrProducts.Read())
            {
                lstDiscontinuedProducts.Items.Add(rdrProducts.GetString(0));
            }
            rdrProducts.NextResult();
            while (rdrProducts.Read())
            {
                lstCurrentProducts.Items.Add(rdrProducts.GetString(0));
            }
            MessageBox.Show("Records affected: " + rdrProducts.RecordsAffected);
            rdrProducts.Close();
        }

        private void btnSummarize_Click(object sender, EventArgs e)
        {
            SqlCommand cmSummarizeProducts = new SqlCommand(
                "dbo.SummarizeProducts", cnNorthwind);

            cmSummarizeProducts.CommandType = CommandType.StoredProcedure;

            cnNorthwind.Open();

            int affected = cmSummarizeProducts.ExecuteNonQuery();

            cnNorthwind.Close();

            MessageBox.Show("Rows affected: " + affected);
        }

        private void btnIncerasePrices_Click(object sender, EventArgs e)
        {
            SqlCommand cmSummarizeProducts = new SqlCommand(
                "dbo.[IncreaseProductPrices]", cnNorthwind);

            cmSummarizeProducts.CommandType = CommandType.StoredProcedure;

            cnNorthwind.Open();

            int affected = cmSummarizeProducts.ExecuteNonQuery();

            cnNorthwind.Close();

            MessageBox.Show("Rows affected: " + affected);
        }
    }
}
