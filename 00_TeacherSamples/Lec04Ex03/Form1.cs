using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lec04Ex03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataRow[] rows = dsStudents.Tables["Students"].Select("lname LIKE 'A%'");
            foreach (DataRow dataRow in rows)
            {
                Console.WriteLine(dataRow["lname"] + " " + dataRow["fname"]);
            }
        }
    }
}
