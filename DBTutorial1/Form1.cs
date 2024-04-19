using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBTutorial1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using (var classicContext = new classicmodelsEntities())
            {
                var emp = (from list in classicContext.employees
                           select list);    // select * from employees

                foreach (var emp2 in emp.ToList())
                {
                    dataGridView1.Rows.Add(emp2.employeeNumber, emp2.lastName, emp2.firstName, emp2.extension, emp2.email, emp2.officeCode, emp2.jobTitle);
                }
            }

        }
        var classicContext = new classicmodelsEntities();

        private void button1_Click(object sender, EventArgs e)
        {
            var custQuery = from list in classicContext.customers
                            where list.customerName == "Mini"    //.Contains("Mini") 
                            select list;

            var custName = custQuery.FirstOrDefault<customer>();
            textBox1.Text = custName.customerName;

            Like searching in LINQ:
            var custQuery = from list in classicContext.customers
                            where list.customerName.Contains("Mini")
                            select list;

        }
    }
}
