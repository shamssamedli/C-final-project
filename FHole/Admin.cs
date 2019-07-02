using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FHole
{
    public partial class Admin : Form
    {
        private Employee employee;
        public Admin (Employee emp)
        
        {
            InitializeComponent();
            employee = emp;
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            label1.Text = $"Hello, {employee.FirstName }. You are Wellcome ..";
            


        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {
          
        }

        private void CreateEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new AddCustomer().Show();
        }

        private void Label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
