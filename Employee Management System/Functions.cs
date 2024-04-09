using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Employee_Management_System.Forms;
using Employee_Management_System.Models;

namespace Employee_Management_System
{
    public static class Functions 
    {
         public static void render(DataGridView grid , List<Employee> employee)
         {
            grid.DataSource = employee;

            grid.Columns["EmpId"].Visible = false;
            grid.Columns["Name"].HeaderText = "Name";
            grid.Columns["Age"].HeaderText = "Age";
            grid.Columns["Salary"].HeaderText = "Salary";
            grid.Columns["Position"].HeaderText = "Position";
            grid.Columns["Country"].HeaderText = "Country";
            grid.Columns["Gender"].HeaderText = "Gender";
         }

           


    }
}
