using Employee_Management_System.Forms;
using Employee_Management_System.Models;
using System.Windows.Forms;

namespace Employee_Management_System
{
    public partial class Form1 : Form
    {
        private Form activeForm;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cancelButton.Visible = false;
        }
        private void deletebutton_Click(object sender, EventArgs e)
        {
            openForm(new DeleteForm(), sender);
        }

        public void addButton_Click(object sender, EventArgs e)
        {
            openForm(new addEmployeeForm(), sender);
        }

        private void viewButton_Click(object sender, EventArgs e)
        {
            openForm(new ViewForm(),sender);
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            openForm(new UpdateForm(), sender);
        }
        private void searchButtom_Click(object sender, EventArgs e)
        {
            openForm(new Search(), sender);
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
            {
                activeForm.Close();
                titleLable.Text = "HOME";
            }
            cancelButton.Visible = false;
        }
        // Custom Functions 
        public void openForm(Form form, object btnSender) // custom function that opens different form according to button click 
        {
            cancelButton.Visible = true;
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = form;
            form.TopLevel = false;
            form.AutoScroll = true;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            this.switchPanel.Controls.Add(form);
            this.switchPanel.Tag = form;
            form.BringToFront();
            form.Show();
            titleLable.Text = form.Text;
        }

    }
   
}