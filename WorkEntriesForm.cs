/*
 * This Form will add and edit the Work Entries based on a task id and employee id
 * the form' dataset is replaced by the private dataset provided by main form.
 * this form also have a condition, which allow a task have only one entry per employee per day
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CIS266Project
{
    public partial class WorkEntriesForm : Form
    {
        public WorkEntriesForm(ProjectsDataSet projects)
        {
            InitializeComponent();
            //destroy form's dataset
            projectsDataSet = null;
            //point local dataset variable to incoming dataset
            projectsDataSet = projects;
            //reset binding sources;
            employeesBindingSource.DataSource = projectsDataSet;
            tasksBindingSource.DataSource = projectsDataSet;
            workEntriesBindingSource.DataSource = projectsDataSet;
        }

        
        private void workEntriesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            int count = 0;
            try
            {
                this.Validate();  
                foreach (ProjectsDataSet.WorkEntriesRow workentry in projectsDataSet.WorkEntries)
                {
                    if ((workDateDateTimePicker.Text == workentry.WorkDate.ToShortDateString())
                        && ((int)employeeIDComboBox.SelectedValue == workentry.EmployeeID)
                        && ((int)taskIDComboBox.SelectedValue == workentry.TaskID))
                    {
                        count++;
                    }
                }
                if (count <= 1)
                {
                    this.workEntriesBindingSource.EndEdit();
                    this.tableAdapterManager.UpdateAll(this.projectsDataSet);
                }    
                else
                    MessageBox.Show("a task should have only one entry per employee per day.", "Error entry");

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error entry");
            }

        }

        private void WorkEntriesForm_Load(object sender, EventArgs e)
        {
            //// TODO: This line of code loads data into the 'projectsDataSet.Tasks' table. You can move, or remove it, as needed.
            //tasksTableAdapter.Fill(projectsDataSet.Tasks);
            //// TODO: This line of code loads data into the 'projectsDataSet.Employees' table. You can move, or remove it, as needed.
            //employeesTableAdapter.Fill(projectsDataSet.Employees);
            //// TODO: This line of code loads data into the 'projectsDataSet.WorkEntries' table. You can move, or remove it, as needed.
            //workEntriesTableAdapter.Fill(projectsDataSet.WorkEntries);

        }
    }
}
