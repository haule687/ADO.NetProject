/*
 * Summary: This form will view the Work Date and Hours Worked.
 * When the user chooses a specified project, the Tasks list view will display all the Associated Tasks in that Project.
 * then the user chooses a task, the form will compare the task and the employee id text box to display the Work Date and Hours worked.
 * Appear a message error when the user doesn't enter the employee id.
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
    public partial class ProjectTasksView : Form
    {
        public ProjectTasksView(ProjectsDataSet project)
        {
            InitializeComponent();
            myProjects = project;
            SetProjectColumns();
            FillProjectList();
            lvwProjects.View = View.Details;
            SetTaskColumns();
            lvwTasks.View = View.Details;
            SetWorkEntriesColumns();
            lvwWorkEntries.View = View.Details;
        }
        //Create a private Projects Dataset instance
        private ProjectsDataSet myProjects;

        //create a method for columns in Projects List View
        private void SetProjectColumns()
        {
            lvwProjects.Columns.Add("Project ID", 20);
            lvwProjects.Columns.Add("Project Name", 100);
            lvwProjects.Columns.Add("Project Description", 100);
            lvwProjects.Columns.Add("Project Start", 100);
            lvwProjects.Columns.Add("Project End", 100);
            lvwProjects.Columns.Add("Status ID", 20);
            lvwProjects.Columns.Add("Project Manager", 20);

        }

        //create a method for columns in Tasks List View
        private void SetTaskColumns()
        {
            lvwTasks.Columns.Add("Task Id", 20);
            lvwTasks.Columns.Add("Task Name", 100);
            lvwTasks.Columns.Add("Task Description", 100);
            lvwTasks.Columns.Add("Task Start", 100);
            lvwTasks.Columns.Add("Task End", 100);
            lvwTasks.Columns.Add("Status ID", 20);
        }
        //create a method for columns in Work Entries List View
        private void SetWorkEntriesColumns()
        {
            lvwWorkEntries.Columns.Add("WorkDate", 100);
            lvwWorkEntries.Columns.Add("Hours Worked", 100);
        }
        // Get data from project table in dataset
        private void FillProjectList()
        {
            lvwProjects.Items.Clear();
            foreach (ProjectsDataSet.ProjectsRow project in myProjects.Projects)
            {
                ListViewItem itmProject = new ListViewItem(project.ProjectID.ToString());
                itmProject.SubItems.Add(project.ProjectName);
                itmProject.SubItems.Add(project.ProjectDescription);
                itmProject.SubItems.Add(project.ProjectStart.ToString());
                itmProject.SubItems.Add(project.ProjectEnd.ToString());
                itmProject.SubItems.Add(project.StatusID.ToString());
                itmProject.SubItems.Add(project.ProjectManager.ToString());
                itmProject.Tag = project.ProjectID;
                lvwProjects.Items.Add(itmProject);
            }
        }
        //Get data from tasks table in dataset based on project id
        private void FillTasksList(int projectid)
        {
            foreach (ProjectsDataSet.TasksRow task in myProjects.Tasks)
            {
                //Compare the project id to find the associated Tasks
                if(task.ProjectID == projectid)
                {
                    ListViewItem itmTask = new ListViewItem(task.TaskID.ToString());
                    itmTask.SubItems.Add(task.TaskName);
                    itmTask.SubItems.Add(task.TaskDescription);
                    itmTask.SubItems.Add(task.TaskStart.ToString());
                    itmTask.SubItems.Add(task.TaskEnd.ToString());
                    itmTask.SubItems.Add(task.StatusID.ToString());
                    itmTask.Tag = task.TaskID;
                    lvwTasks.Items.Add(itmTask);
                }
            }
        }
        // Get data from Work Entries table in dataset
        private void FillWorkEntriesList(int taskid)
        {
            // get task row
            ProjectsDataSet.TasksRow taskRow = myProjects.Tasks.FindByTaskID(taskid);
            //use data relation to get all the Work entries
            DataRow[] workentries = taskRow.GetChildRows("FK_WorkEntries_Tasks");
            //find which workentries has the employee id
            if (txtEmployeeID.Text == "")
            {
                MessageBox.Show("Please enter the Employee ID", " Entry Error");
            }
            else
            {
                foreach (DataRow workentry in workentries)
                {
                    //compare to the employee id
                    if (workentry["EmployeeID"].ToString() == txtEmployeeID.Text)
                    {
                        //display work date and work hours
                        ListViewItem itmworkentry = new ListViewItem(workentry["WorkDate"].ToString());
                        itmworkentry.SubItems.Add(workentry["HoursWorked"].ToString());
                        lvwWorkEntries.Items.Add(itmworkentry);
                    }
                }
            }
        }
        // The Event will be called when an item in Projects list view is selected
        private void lvwProjects_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            //clear the Task list view
            lvwTasks.Items.Clear();
            // get the project id from the selected item
            int projectid = (int)e.Item.Tag;
            // invoke FillTasksList to display data in tasks table which has the project id
            FillTasksList(projectid);
        }

        // The Event will be called when an item in Tasks list view is selected
        private void lvwTasks_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            //clear work date and work hour textboxes
            lvwWorkEntries.Items.Clear();
            //get the task id from the selected item
            int taskid = (int)e.Item.Tag;
            FillWorkEntriesList(taskid);
        }
    }
}
