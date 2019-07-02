using FHole.Common;
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
    public partial class AddCustomer : Form
    {
        private FitnessEntities db = new FitnessEntities();
        public AddCustomer()
        {
            InitializeComponent();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            Employee newEmployee = new Employee()
            {
                FirstName = EmployeeCreateName.Text,
                LastName = EmployeeCreateSurname.Text,
                username = EmployeeCreateUsername.Text,
                RoleId = (int)((ComboboxItem)EmployeeCreateRoles.SelectedItem).Value
            };
            Random randomNumber = new Random();
            var OTP = newEmployee.username + randomNumber.Next(1000, 9999);
            newEmployee.Password = OTP;
            db.Employees.Add(newEmployee);
            db.SaveChanges();
        }

        private void CreateEmployee_Load(object sender, EventArgs e)
        {
            var roles = db.Roles.ToList();
            foreach (var item in roles)
            {

                ComboboxItem comboboxItem = new ComboboxItem()
                {
                    Value = item.id,
                    Text = item.RoleName
                };

                EmployeeCreateRoles.Items.Add(comboboxItem);
            }


            EmployeeCreateRoles.SelectedIndex = 0;
        }

        private void EmployeeCreateName_TextChanged(object sender, EventArgs e)
        {

        }

        private void EmployeeCreateRoles_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
           
            if (EmployeeCreateName.Text == string.Empty)
            {
                MessageBox.Show("Please input name", "Error !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (EmployeeCreateSurname.Text == string.Empty)
            {
                MessageBox.Show("Please input surname", "Error !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (EmployeeCreateUsername.Text == string.Empty)
            {
                MessageBox.Show("Please input username", "Error !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (EmployeeCreatePassword.Text == string.Empty)
            {
                MessageBox.Show("Please input paswword", "Error !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (EmployeeCreateRoles.Text == string.Empty)
            {
                MessageBox.Show("Please input role", "Error !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            db.Employees.Add(new Employee
            {
                FirstName = EmployeeCreateName.Text,
                LastName = EmployeeCreateSurname.Text,
                Password = EmployeeCreatePassword.Text,
                username = EmployeeCreateUsername.Text,
                RoleId =Convert.ToInt32( ((ComboboxItem)EmployeeCreateRoles.SelectedItem).Value)
            });
            db.SaveChanges();
            MessageBox.Show("New employee succsessfully added", "Succsess", MessageBoxButtons.OK, MessageBoxIcon.Information);
            EmployeeCreateName.Text = EmployeeCreatePassword.Text = EmployeeCreateSurname.Text = EmployeeCreateUsername.Text = "";
            EmployeeCreateRoles.SelectedIndex = 0;

            this.Hide();
            FHole.CreateCustomer createCustomer = new CreateCustomer();
            createCustomer.Show();

        }


        private void AddCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new AddCustomer().Show();
        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }
    }
}
