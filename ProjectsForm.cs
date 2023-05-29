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
    public partial class ProjectsForm : Form
    {
        public ProjectsForm()
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
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Saving Error");
            }

        }

        private void ProjectsForm_Load(object sender, EventArgs e)
        {

            try
            {
                // TODO: This line of code loads data into the 'projectsDataSet.Employees' table. You can move, or remove it, as needed.
                this.employeesTableAdapter.Fill(this.projectsDataSet.Employees);
                // TODO: This line of code loads data into the 'projectsDataSet.Status' table. You can move, or remove it, as needed.
                this.statusTableAdapter.Fill(this.projectsDataSet.Status);
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
