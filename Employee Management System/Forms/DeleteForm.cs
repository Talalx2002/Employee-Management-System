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
    public partial class DeleteForm : Form
    {
        public DeleteForm()
        {
            InitializeComponent();
        }
        private void DeleteForm_Load(object sender, EventArgs e)
        {
            using (EmployeeManagementSystemContext context = new EmployeeManagementSystemContext())
            {
                Functions.render(deleteDataGridView, context.Employees.ToList<Employee>());
                deleteDataGridView.Visible = true;
            }
            if (deleteDataGridView.Rows.Count < 1)
            {
                deleteDataGridView.Visible = false;
                MessageBox.Show("No Record ");
            }
        }
        private void deleteButton_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(deleteDataGridView.CurrentRow.Cells[0].Value.ToString());
            using (EmployeeManagementSystemContext context = new EmployeeManagementSystemContext())
            {
                context.Employees.Remove(new Employee { EmpId = id });
                context.SaveChanges();
            }
            DeleteForm_Load(sender, e);
        }
        private void clearAllButton_Click(object sender, EventArgs e)
        {
            using (var context = new EmployeeManagementSystemContext())
            {
                var employees = context.Employees;
                context.Employees.RemoveRange(employees);
                context.SaveChanges();
            }
            DeleteForm_Load(sender, e);
        }
    }
}
