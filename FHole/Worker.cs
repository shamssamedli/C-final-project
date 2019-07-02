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
    public partial class Worker : Form
    {
        private readonly FitnessEntities _context;
        public Worker()
        {
            InitializeComponent();
            _context = new FitnessEntities();
        }

        private void Worker_Load(object sender, EventArgs e)
        {

        }

        private void CreateCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new CreateCustomer().Show();
        }
    }
}
