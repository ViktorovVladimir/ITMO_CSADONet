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

namespace Lec04Ex01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            SqlParameter param = new SqlParameter();
            param.ParameterName = "@price";
            param.DbType = DbType.Decimal;
            param.Direction = ParameterDirection.Input;
            cmdCheapProducts.Parameters.Add(param);
        }

        private void btnGetCheapest_Click(object sender, EventArgs e)
        {
            cnNorthwind.Open();
            String res = String.Format("{0}", cmdProductCnt.ExecuteScalar());
            txtProductCnt.Text = res;
            cnNorthwind.Close();
        }

        private void txtMaxPrice_TextChanged(object sender, EventArgs e)
        {
            try
            {
                cnNorthwind.Open();

                cmdCheapProducts.Parameters["@price"].Value = txtMaxPrice.Text;
                // SQL injection: "5); CREATE TABLE P2(i int);--"
                cmdCheapProducts.CommandText = "SELECT ProductName,UnitPrice FROM Products WHERE (UnitPrice < @price) ORDER BY UnitPrice DESC";
            }
            catch (FormatException ex)
            {
                cmdCheapProducts.Parameters["@price"].Value = 0;
            }
            String res = (String)cmdCheapProducts.ExecuteScalar();
            txtExpensiveItem.Text = res;
            cnNorthwind.Close();
        }

        private void btnGetProductCnt_Click(object sender, EventArgs e)
        {
            SqlCommand cmProductCnt = new SqlCommand();
            cmProductCnt.Connection = cnNorthwind;
            cmProductCnt.CommandText = "dbo.CountProductsInCategory";
            cmProductCnt.CommandType =CommandType.StoredProcedure;
            SqlParameter param = cmProductCnt.Parameters.Add(new SqlParameter("@CatID", SqlDbType.Int, 4));
            cmProductCnt.Parameters["@CatID"].Value = Convert.ToInt32(txtCategoryId.Text);
            param = cmProductCnt.Parameters.Add(new SqlParameter("@CatName", SqlDbType.NVarChar, 15));
            param.Direction = ParameterDirection.Output;
            param = cmProductCnt.Parameters.Add(new SqlParameter("@RETURN_VALUE", SqlDbType.Int, 4));
            param.Direction = ParameterDirection.ReturnValue;
            cnNorthwind.Open();

            Convert.ToInt32(cmProductCnt.ExecuteScalar());

            cnNorthwind.Close();
            lblProductCount.Text = "Product Count: " + cmProductCnt.Parameters["@RETURN_VALUE"].Value;
        }
    }
}
