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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            //create an instance of the grading dataset
            myProjects = new ProjectsDataSet();
            FillMyData();
        }
        // create a class level ProjectsDataSet instance
        private ProjectsDataSet myProjects;
        // create a method to get the Projects DataSet
        public ProjectsDataSet MyProjects
        {
            get
            {
                return myProjects;
            }
        }
        // method to set status to the strip status label
        public void SetReadyLabel(string message)
        {
            tslReady.Text = message;
        }

        //Create a public method that fills the tables of the dataset.
        public void FillMyData()
        {
            ProjectsDataSetTableAdapters.EmployeesTableAdapter taEmployees =
                new ProjectsDataSetTableAdapters.EmployeesTableAdapter();
            ProjectsDataSetTableAdapters.ProjectsTableAdapter taProjects =
                new ProjectsDataSetTableAdapters.ProjectsTableAdapter();
            ProjectsDataSetTableAdapters.StatusTableAdapter taStatus =
                new ProjectsDataSetTableAdapters.StatusTableAdapter();
            ProjectsDataSetTableAdapters.TasksTableAdapter taTasks =
                new ProjectsDataSetTableAdapters.TasksTableAdapter();
            ProjectsDataSetTableAdapters.WorkEntriesTableAdapter taWorkEntries =
                new ProjectsDataSetTableAdapters.WorkEntriesTableAdapter();
            try
            {
                taEmployees.Fill(myProjects.Employees);
                taProjects.Fill(myProjects.Projects);
                taStatus.Fill(myProjects.Status);
                taTasks.Fill(myProjects.Tasks);
                taWorkEntries.Fill(myProjects.WorkEntries);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error loading data");
            }
        }

        //Create a public method to update all the tables of the dataset based on table adapter manager
        public void SaveData()
        {
            ProjectsDataSetTableAdapters.EmployeesTableAdapter taEmployees =
                new ProjectsDataSetTableAdapters.EmployeesTableAdapter();
            ProjectsDataSetTableAdapters.ProjectsTableAdapter taProjects =
                new ProjectsDataSetTableAdapters.ProjectsTableAdapter();
            ProjectsDataSetTableAdapters.StatusTableAdapter taStatus =
                new ProjectsDataSetTableAdapters.StatusTableAdapter();
            ProjectsDataSetTableAdapters.TasksTableAdapter taTasks =
                new ProjectsDataSetTableAdapters.TasksTableAdapter();
            ProjectsDataSetTableAdapters.WorkEntriesTableAdapter taWorkEntries =
                new ProjectsDataSetTableAdapters.WorkEntriesTableAdapter();
            ProjectsDataSetTableAdapters.TableAdapterManager taManager =
                new ProjectsDataSetTableAdapters.TableAdapterManager();

            // Attach related table to Table Adapter Manager
            taManager.EmployeesTableAdapter = taEmployees;
            taManager.ProjectsTableAdapter = taProjects;
            taManager.StatusTableAdapter = taStatus;
            taManager.TasksTableAdapter = taTasks;
            taManager.WorkEntriesTableAdapter = taWorkEntries;
            try
            {
                taManager.UpdateAll(MyProjects);
                SetReadyLabel("Data saved");
            }
            catch(Exception ex)
            {
                SetReadyLabel(ex.Message);
            }
        }

        //Set this MainForm the Mdi parent of the form.
        private void ShowForm(Form form)
        {
            //turn this form a child of main form
            form.MdiParent = this;
            // display the form
            form.Show();
            // show message that the form is ready in strip status label
            string message = string.Format("{0} ready for use", form.Text);
            SetReadyLabel(message);
        }
        private void tileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void cascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void closeAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form child in this.MdiChildren)
                child.Close();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //Set status label to "Ready" when load the main form
            SetReadyLabel("Ready");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        //event raise when closing the main form
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Display the Dialog which Yes-No buttons to re-confirm with the user when the user clicks the exit
            DialogResult dialog = MessageBox.Show("Are you sure you want to exit?",
               "Close", MessageBoxButtons.YesNo);
            //If the user chooses "No" button.
            if (dialog == DialogResult.No)
            {
                // cancle the closing form event.
                e.Cancel = true;
            }
        }

        private void tasksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowForm(new TasksForm());
        }

        private void sectionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowForm(new ProjectsForm());
        }

        private void coursesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowForm(new Employees());
        }

        private void workEntriesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowForm(new WorkEntriesForm(MyProjects));
        }

        private void projectTasksViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowForm(new ProjectTasksView(MyProjects));
        }

        private void assignmentsViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowForm(new AssignmentsView(MyProjects));
        }
    }
}
