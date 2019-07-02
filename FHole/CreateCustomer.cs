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
    public partial class CreateCustomer : Form
    {
        private readonly FitnessEntities _context;
        public CreateCustomer()
        {
            InitializeComponent();
            _context = new FitnessEntities();
        }

        private void CreateCustomer_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = _context.Customers.Select(c => new { c.FirstName, c.LastName, c.CardNo }).ToArray();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (txtFname.Text == string.Empty || txtLname.Text == string.Empty)
            {
                MessageBox.Show("Please fill the all textboxes", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Random rnd = new Random();
            int cardNo = rnd.Next(1000, 9999);
            while (_context.Customers.Any(c=> c.CardNo == cardNo))
            {
                cardNo = rnd.Next(1000, 9999);
            }
            _context.Customers.Add(new Customer { FirstName = txtFname.Text, LastName = txtLname.Text, CardNo = cardNo});
            _context.SaveChanges();
            MessageBox.Show("New customer succsessfully added", "Succsess", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dataGridView1.DataSource = _context.Customers.Select(c => new { c.FirstName, c.LastName, c.CardNo }).ToArray();
            txtLname.Text = txtFname.Text = "";
            dataGridView1.DataSource = _context.Customers.ToList();
        }

        private void TxtLname_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
