/*
 * Summary: This Form will add and edit the Tasks based on the Project choosed by combobox
 * This Form is using the bound control.
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
    public partial class TasksForm : Form
    {
        public TasksForm()
        {
            InitializeComponent();
        }

        private void projectsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.projectsBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.projectsDataSet);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Saving Error");
            }

        }

        private void TasksForm_Load(object sender, EventArgs e)
        {
            try
            {
                // TODO: This line of code loads data into the 'projectsDataSet.Status' table. You can move, or remove it, as needed.
                this.statusTableAdapter.Fill(this.projectsDataSet.Status);
                // TODO: This line of code loads data into the 'projectsDataSet.Tasks' table. You can move, or remove it, as needed.
                this.tasksTableAdapter.Fill(this.projectsDataSet.Tasks);
                // TODO: This line of code loads data into the 'projectsDataSet.Projects' table. You can move, or remove it, as needed.
                this.projectsTableAdapter.Fill(this.projectsDataSet.Projects);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Reading Error");
            }

        }
    }
}
