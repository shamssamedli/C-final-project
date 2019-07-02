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
    public partial class Form1 : Form
    {
        private readonly FitnessEntities _context = new FitnessEntities();
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (!_context.Employees.Any(emp => emp.username == txtUsername.Text))
            {
                MessageBox.Show("Username or password are not valid", "Error !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Employee employee = _context.Employees.First(emp => emp.username == txtUsername.Text);
            if (txtPassword.Text != employee.Password)
            {
                MessageBox.Show("Username or password are not valid", "Error !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (employee.RoleId == 1)
            {
                new Admin(employee).ShowDialog();
                return;
            }
            if (employee.RoleId == 2)
            {
                new Worker().ShowDialog();
                return;
            }

        }

        private void TxtPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
