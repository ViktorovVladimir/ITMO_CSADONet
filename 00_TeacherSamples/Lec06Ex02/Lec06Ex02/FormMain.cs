using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Lec06Ex02
{
    //  Make sure to fix the glitch with Designer-generated code described here:
    //  https://www.pcreview.co.uk/threads/constraint-matches-constraint-named-constraint1-already-in-collect.3106129/
    //  Move
    //  ((System.ComponentModel.ISupportInitialize)(this.dsOrders)).EndInit();
    //  to after EndInit() of all tables
    public partial class frmMain : Form
    {
        private int dvFilter = -1;
        private CurrencyManager cmProducts;
        public frmMain()
        {
            InitializeComponent();
            lblPriceLimit.Text = "Price > " + dvFilter.ToString();
            try
            {
                dsOrders.ReadXml(@"data.xml", XmlReadMode.IgnoreSchema);
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("Input file name is not found");
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            DataTable dtProducts = dsOrders.Tables[0];
            txtProductName.DataBindings.Add("Text", dtProducts, "ProductName");
            cmProducts = (CurrencyManager)(this.BindingContext[dtProducts]);
            cmProducts.Position = 0;
            lblPriceLimit.Text = "Price > " + dvFilter.ToString();
            dvProducts.RowFilter = lblPriceLimit.Text;
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            dsOrders.WriteXml(@"data.xml", XmlWriteMode.WriteSchema);
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            cmProducts.Position = 0;
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            if (cmProducts.Position != 0)
            {
                cmProducts.Position -= 1;
            }

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (cmProducts.Position != cmProducts.Count - 1)
            {
                cmProducts.Position += 1;
            }
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            cmProducts.Position = cmProducts.Count - 1;
        }

        private void btnPriceIncrease_Click(object sender, EventArgs e)
        {
            dvFilter++;
            lblPriceLimit.Text = "Price > " + dvFilter.ToString();
            dvProducts.RowFilter = lblPriceLimit.Text;
        }

        private void btnPriceDecrease_Click(object sender, EventArgs e)
        {
            dvFilter--;
            lblPriceLimit.Text = "Price > " + dvFilter.ToString();
            dvProducts.RowFilter = lblPriceLimit.Text;
        }

        private void btnAcceptChanges_Click(object sender, EventArgs e)
        {
            //dsOrders.Tables["Orders"].AcceptChanges();
            dsOrders.AcceptChanges();
        }

        private void btnDiffGram_Click(object sender, EventArgs e)
        {
            dsOrders.WriteXml(@"data_diff.xml", XmlWriteMode.DiffGram);
        }

        private void lstCustomers_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvCustomerDetails.Rows.Clear();
            if (lstCustomers.SelectedItem != null)
            {
                DataRow drCustomer = ((DataRowView)lstCustomers.SelectedItem).Row;
                StringBuilder item;
                foreach (DataRow drOrder in drCustomer.GetChildRows("rel_OrdersCustomers"))
                {
                    item = new StringBuilder("Order with id " + drOrder["OrderID"] + " was placed on ");
                    if (!drOrder.IsNull("Time Stamp"))
                    {
                        item.Append(drOrder["Time Stamp"]);
                    }
                    else
                    {
                        item.Append("N/A");
                    }
                    if (drOrder.GetChildRows("relOrdersDetails_Orders").Length > 0)
                    {
                        item.Append(". It contains:" + Environment.NewLine);
                        foreach (DataRow drOrderDetail in drOrder.GetChildRows("relOrdersDetails_Orders"))
                        {
                            item.Append("\t" + drOrderDetail["Qty"] + " item(s) of product \"" +
                                dsOrders.Tables["Products"].Rows.Find(Convert.ToInt64(drOrderDetail["ProductID"]))["ProductName"] + "\" at $" +
                                drOrderDetail["Price"] + " each." +
                                "The line total is $" + drOrderDetail["LineTotal"] + "." + Environment.NewLine);
                        }
                    }
                    else
                    {
                        item.Append(". Contents: N/A" + Environment.NewLine);
                    }
                    Console.WriteLine(item.ToString().Trim());
                    dgvCustomerDetails.Rows.Add(new string[]{item.ToString().Trim()});
                }
            }
        }

        private void relOrdersDetailsOrdersBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            // See more on Detail - Master binding in https://www.codemag.com/article/0507051/Tackle-Complex-Data-Binding-with-Windows-Forms-2.0
            DataRowView rowView = relOrdersDetailsOrdersBindingSource.Current as DataRowView;
            if (rowView != null) {
                bsProductsBindingSource.Filter = "ProductID = '" + rowView["ProductID"] + "'";
            }
            else
            {
                bsProductsBindingSource.Filter = "False";
            }
        }
    }
}
