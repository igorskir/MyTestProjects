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
    public partial class Users : Form
    {
        public Users()
        {
            InitializeComponent();
        }

        private void Users_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'departmentsDataSet.Employee' table. You can move, or remove it, as needed.
            this.employeeTableAdapter.Fill(this.departmentsDataSet.Employee);
            // TODO: This line of code loads data into the 'departmentsDataSet.Department' table. You can move, or remove it, as needed.
            this.departmentTableAdapter.Fill(this.departmentsDataSet.Department);

        }
    }
}
