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
    public partial class UpdateForm : Form
    {
        addEmployeeForm addEmployeeForm = new addEmployeeForm();
        public UpdateForm()
        {
            InitializeComponent();
        }

        private void UpdateForm_Load(object sender, EventArgs e)
        {
            EmployeeManagementSystemContext context = new EmployeeManagementSystemContext();
            Functions.render(updateDataGridView, context.Employees.ToList<Employee>());
        }

        private void editButton_Click(object sender, EventArgs e)
        {
           
            addEmployeeForm.editdata(updateDataGridView.CurrentRow.Cells[0].Value.ToString(),updateDataGridView.CurrentRow.Cells[1].Value.ToString(), updateDataGridView.CurrentRow.Cells[2].Value.ToString(), updateDataGridView.CurrentRow.Cells[3].Value.ToString(), updateDataGridView.CurrentRow.Cells[4].Value.ToString(), updateDataGridView.CurrentRow.Cells[5].Value.ToString(), updateDataGridView.CurrentRow.Cells[6].Value.ToString());

            ((Form1)Application.OpenForms["Form1"]).openForm(addEmployeeForm , sender);
        }
    }
}
