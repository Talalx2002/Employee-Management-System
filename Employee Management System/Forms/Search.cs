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
    public partial class Search : Form
    {
        public Search()
        {
            InitializeComponent();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            using (EmployeeManagementSystemContext context = new EmployeeManagementSystemContext())
            {
                //searchDataGridView.DataSource = context.Employees.Find(new Employee { Name = searchTextBox.Text });
                if (searchComboBox.SelectedIndex == 0)
                    searchDataGridView.DataSource = context.Employees.Where(e => e.Name == searchTextBox.Text).ToList();

                if (searchComboBox.SelectedIndex == 1)
                    searchDataGridView.DataSource = context.Employees.Where(e => e.Age == Convert.ToInt32(searchTextBox.Text)).ToList();
            }
        }

        private void searchDataGridView_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            using (EmployeeManagementSystemContext context = new EmployeeManagementSystemContext()) {
                
                if (sortRadioButton.Checked)
                {
                    if (e.ColumnIndex == 1)
                    {
                        searchDataGridView.DataSource = ((List<Employee>)searchDataGridView.DataSource).OrderBy(e => e.Name).ToList();
                    }
                    if (e.ColumnIndex == 3)
                    {
                        searchDataGridView.DataSource = ((List<Employee>)searchDataGridView.DataSource).OrderBy(e => e.Salary).ToList();
                    }
                }
            }
        }
    }
}
