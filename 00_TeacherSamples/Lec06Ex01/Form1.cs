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

namespace Lec06Ex01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            try
            {
                //dsStudents.EnforceConstraints = false;
                dsStudents.ReadXml(@"data.xml");
                //dsStudents.EnforceConstraints = true;
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("Unable to read input data file");
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            dsStudents.WriteXml(@"data.xml");
        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            foreach (DataTable table in dsStudents.Tables)
            {
                txtLog.Text += "-----------------------------------------------------" + Environment.NewLine;
                foreach (DataRow dr in dsStudents.Tables[table.TableName].Rows)
                {
                    foreach (DataColumn col in dsStudents.Tables[table.TableName].Columns)
                    {
                        txtLog.Text += String.Format("{0} ", dr[col]);
                    }
                    txtLog.Text += Environment.NewLine;
                }
            }
        }
    }
}
