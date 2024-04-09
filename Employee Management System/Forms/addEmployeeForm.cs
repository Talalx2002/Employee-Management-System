using Employee_Management_System.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Employee_Management_System.Forms
{
    public partial class addEmployeeForm : Form
    {
        bool flag = false;
        private void addEmployeeForm_Load(object sender, EventArgs e)
        {
            if (!flag)
            {
                employeeIDTextBox.Text = newEmpId().ToString();
            }
        }
        
        public addEmployeeForm()
        {
            InitializeComponent();
        }
       
        private void saveButton_Click(object sender, EventArgs e)
        {
            try
            {
                isValid();
                if (!flag)
                {
                    using (EmployeeManagementSystemContext context = new EmployeeManagementSystemContext())
                    {
                        context.Employees.Add(new Employee(Convert.ToInt32(employeeIDTextBox.Text), NameTextBox.Text, Convert.ToInt32(ageNumericUpDown.Value), Convert.ToInt32(salaryTextBox.Text), positionComboBox.Text, countryComboBox.Text, maleRadioButton.Checked ? maleRadioButton.Text : femaleRadioButton.Text));
                        context.SaveChanges();
                        clearButton.PerformClick();
                        employeeIDTextBox.Text = newEmpId().ToString();
                    }
                }
                else
                {
                    showEditData();
                    clearButton.PerformClick();
                }
            }
            catch(FormatException formate)
            {
                MessageBox.Show("Please Enter Data Carefully");
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message ); 
            }


        }
           
        

        private void clearButton_Click(object sender, EventArgs e)
        {
            foreach (var Controls in addPanel.Controls)
            {
                if(Controls is TextBox text)
                {
                    text.Clear();
                }
                if (Controls is ComboBox combobox)
                {
                    combobox.Text = default;
                }
                if (Controls is NumericUpDown numericUpDown)
                {
                    numericUpDown.Value = numericUpDown.Minimum;
                }
                if (Controls is System.Windows.Forms.RadioButton radioButton)
                {
                    radioButton.Checked = default;
                }

                employeeIDTextBox.Text=newEmpId().ToString();
            }
        }

        public void editdata(string ID ,  string name ,string age, string salary , string position  , string country ,string gender )
        {
            employeeIDTextBox.Text = ID;
            NameTextBox.Text = name;
            ageNumericUpDown.Value = Convert.ToInt32(age);
            salaryTextBox.Text = salary;
            positionComboBox.Text = position;
            countryComboBox.Text = country;

            if (gender == "Male")
            {
                maleRadioButton.Checked = true;
            }
            else
            {
                femaleRadioButton.Checked = true;
            }

            saveButton.Text = "Update";
            flag = true;
        }

        public void showEditData()
        {
            using (EmployeeManagementSystemContext context = new EmployeeManagementSystemContext())
            {
                var employee = context.Employees.SingleOrDefault(b => b.EmpId == Convert.ToInt32(employeeIDTextBox.Text));
                employee.Name = NameTextBox.Text;
                employee.Position = positionComboBox.Text;
                employee.Age = Convert.ToInt32(ageNumericUpDown.Value);
                employee.Salary = Convert.ToInt32(salaryTextBox.Text);
                employee.Gender = maleRadioButton.Checked ? maleRadioButton.Text : femaleRadioButton.Text;
                employee.EmpId = Convert.ToInt32(employeeIDTextBox.Text);
                context.SaveChanges();
                flag = false;
                saveButton.Text = "Save";
            }
                
        }

        public int newEmpId()
        {
            using (var context = new EmployeeManagementSystemContext())
            {
                var highestIdEmployee = context.Employees.OrderByDescending(e => e.EmpId).ToList<Employee>();
                if(highestIdEmployee.Count == 0)
                {
                    return 1;
                }
                return highestIdEmployee[0].EmpId + 1;
            }

        }

        public void isValid()
        {
            foreach (var Controls in addPanel.Controls)
            {
                if (Controls is TextBox text)
                {
                    if (text.Text.IsNullOrEmpty())
                    {
                        throw new Exception("Cannot leave Text Field Empty");
                    }
                }
                if (Controls is ComboBox combobox)
                {
                    if(combobox.SelectedItem == null)
                    {
                        throw new Exception("Please Select a suitable option");
                    }
                }
            }
            if(maleRadioButton.Checked == false && femaleRadioButton.Checked == false)
            {
                throw new Exception("Please select Gender");

            }
        }
    }
}
