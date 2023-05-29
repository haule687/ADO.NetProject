/*
 * This Form is for adding and editing the employee informations using bound controls.
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
    public partial class Employees : Form
    {
        public Employees()
        {
            InitializeComponent();
        }

        private void employeesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.employeesBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.projectsDataSet);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Saving Error");
            }
           

        }

        private void Employees_Load(object sender, EventArgs e)
        {
            try
            {
                // TODO: This line of code loads data into the 'projectsDataSet.Employees' table. You can move, or remove it, as needed.
                this.employeesTableAdapter.Fill(this.projectsDataSet.Employees);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Reading Error");
            }
            

        }
    }
}
