/*This form allows user to search the assignments of the specified project.
 * When the user chooses the project in the combobox and clicks search button,
 * the List View will display the informations of this project: Employee Name, Task Name, Work Date,
 * and Work Hours
 * The form is also display the total hours of this project.
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
    public partial class AssignmentsView : Form
    {
        public AssignmentsView(ProjectsDataSet projects)
        {
            InitializeComponent();
            //destroy form's dataset
            projectsDataSet = null;
            //point local dataset variable to incoming dataset
            projectsDataSet = projects;
            //reset binding sources;
            projectsBindingSource.DataSource = projectsDataSet;
            SetAssignmentsColumns();
            lvwAssignments.View = View.Details;
        }

        //create a method to create the header name columns in assignment list view
        private void SetAssignmentsColumns()
        {
            lvwAssignments.Columns.Add("Employee", 100);
            lvwAssignments.Columns.Add("Task", 100);
            lvwAssignments.Columns.Add("Date", 100);
            lvwAssignments.Columns.Add("Hours", 50);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //check if the combobox is empty
            if(cboProjects.SelectedItem != null)
            {
                //clear assignment list view
                lvwAssignments.Items.Clear();
                //declare a local variable named totalHours
                decimal totalHours = 0;
                //get project id
                int projectid = (int)cboProjects.SelectedValue;
                ProjectsDataSet.ProjectsRow projectRow = projectsDataSet.Projects.FindByProjectID(projectid);
                //use data relation to get all the Tasks
                DataRow[] tasks = projectRow.GetChildRows("FK_Tasks_Projects");
                foreach (ProjectsDataSet.EmployeesRow employee in projectsDataSet.Employees)
                {
                    //use data relation to get all the Work entries
                    DataRow[] workentries = employee.GetChildRows("FK_WorkEntries_Employees");
                    foreach(DataRow workentry in workentries)
                    {
                        foreach(DataRow task in tasks)
                        {
                            if ((int)workentry["TaskID"] == (int)task["TaskID"])
                            {
                                ListViewItem itmAssignment = new ListViewItem(employee.FullName);
                                itmAssignment.SubItems.Add(task["TaskName"].ToString());
                                itmAssignment.SubItems.Add(workentry["WorkDate"].ToString());
                                itmAssignment.SubItems.Add(workentry["HoursWorked"].ToString());
                                lvwAssignments.Items.Add(itmAssignment);
                                totalHours += (decimal)workentry["HoursWorked"];
                                txtTotalHours.Text = totalHours.ToString();
                            }
                        }
                    }
                }

            }
            else
            {
                MessageBox.Show("Please choose a project", "Error Entry");
            }


        }
    }
}
