using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormLab5
{
    public partial class Department : Form
    {
        public Department()
        {
            InitializeComponent();
        }

        private void Department_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'departmentsDataSet.Department' table. You can move, or remove it, as needed.
            this.departmentTableAdapter.Fill(this.departmentsDataSet.Department);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
