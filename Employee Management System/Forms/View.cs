using Employee_Management_System.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Employee_Management_System.Forms
{
    public partial class ViewForm : Form
    {
        public ViewForm()
        {
            InitializeComponent();
        }

        private void ViewForm_Load(object sender, EventArgs e)
        {
            EmployeeManagementSystemContext context = new EmployeeManagementSystemContext();
            Functions.render(dataGridView1,context.Employees.ToList<Employee>());
        }
    }
}
