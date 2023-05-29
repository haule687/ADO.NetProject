
namespace CIS266Project
{
    partial class WorkEntriesForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WorkEntriesForm));
            System.Windows.Forms.Label workIDLabel;
            System.Windows.Forms.Label workDateLabel;
            System.Windows.Forms.Label hoursWorkedLabel;
            System.Windows.Forms.Label employeeIDLabel;
            System.Windows.Forms.Label taskIDLabel;
            this.projectsDataSet = new CIS266Project.ProjectsDataSet();
            this.workEntriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.workEntriesTableAdapter = new CIS266Project.ProjectsDataSetTableAdapters.WorkEntriesTableAdapter();
            this.tableAdapterManager = new CIS266Project.ProjectsDataSetTableAdapters.TableAdapterManager();
            this.workEntriesBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.workEntriesBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.workIDLabel1 = new System.Windows.Forms.Label();
            this.workDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.hoursWorkedTextBox = new System.Windows.Forms.TextBox();
            this.employeeIDComboBox = new System.Windows.Forms.ComboBox();
            this.taskIDComboBox = new System.Windows.Forms.ComboBox();
            this.employeesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeesTableAdapter = new CIS266Project.ProjectsDataSetTableAdapters.EmployeesTableAdapter();
            this.tasksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tasksTableAdapter = new CIS266Project.ProjectsDataSetTableAdapters.TasksTableAdapter();
            workIDLabel = new System.Windows.Forms.Label();
            workDateLabel = new System.Windows.Forms.Label();
            hoursWorkedLabel = new System.Windows.Forms.Label();
            employeeIDLabel = new System.Windows.Forms.Label();
            taskIDLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.projectsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workEntriesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workEntriesBindingNavigator)).BeginInit();
            this.workEntriesBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tasksBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // projectsDataSet
            // 
            this.projectsDataSet.DataSetName = "ProjectsDataSet";
            this.projectsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // workEntriesBindingSource
            // 
            this.workEntriesBindingSource.DataMember = "WorkEntries";
            this.workEntriesBindingSource.DataSource = this.projectsDataSet;
            // 
            // workEntriesTableAdapter
            // 
            this.workEntriesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.EmployeesTableAdapter = this.employeesTableAdapter;
            this.tableAdapterManager.ProjectsTableAdapter = null;
            this.tableAdapterManager.StatusTableAdapter = null;
            this.tableAdapterManager.TasksTableAdapter = this.tasksTableAdapter;
            this.tableAdapterManager.UpdateOrder = CIS266Project.ProjectsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.WorkEntriesTableAdapter = this.workEntriesTableAdapter;
            // 
            // workEntriesBindingNavigator
            // 
            this.workEntriesBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.workEntriesBindingNavigator.BindingSource = this.workEntriesBindingSource;
            this.workEntriesBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.workEntriesBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.workEntriesBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.workEntriesBindingNavigatorSaveItem});
            this.workEntriesBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.workEntriesBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.workEntriesBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.workEntriesBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.workEntriesBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.workEntriesBindingNavigator.Name = "workEntriesBindingNavigator";
            this.workEntriesBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.workEntriesBindingNavigator.Size = new System.Drawing.Size(332, 25);
            this.workEntriesBindingNavigator.TabIndex = 0;
            this.workEntriesBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 15);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // workEntriesBindingNavigatorSaveItem
            // 
            this.workEntriesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.workEntriesBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("workEntriesBindingNavigatorSaveItem.Image")));
            this.workEntriesBindingNavigatorSaveItem.Name = "workEntriesBindingNavigatorSaveItem";
            this.workEntriesBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.workEntriesBindingNavigatorSaveItem.Text = "Save Data";
            this.workEntriesBindingNavigatorSaveItem.Click += new System.EventHandler(this.workEntriesBindingNavigatorSaveItem_Click);
            // 
            // workIDLabel
            // 
            workIDLabel.AutoSize = true;
            workIDLabel.Location = new System.Drawing.Point(12, 35);
            workIDLabel.Name = "workIDLabel";
            workIDLabel.Size = new System.Drawing.Size(50, 13);
            workIDLabel.TabIndex = 1;
            workIDLabel.Text = "Work ID:";
            // 
            // workIDLabel1
            // 
            this.workIDLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.workEntriesBindingSource, "WorkID", true));
            this.workIDLabel1.Location = new System.Drawing.Point(97, 35);
            this.workIDLabel1.Name = "workIDLabel1";
            this.workIDLabel1.Size = new System.Drawing.Size(44, 23);
            this.workIDLabel1.TabIndex = 2;
            this.workIDLabel1.Text = "label1";
            // 
            // workDateLabel
            // 
            workDateLabel.AutoSize = true;
            workDateLabel.Location = new System.Drawing.Point(12, 65);
            workDateLabel.Name = "workDateLabel";
            workDateLabel.Size = new System.Drawing.Size(62, 13);
            workDateLabel.TabIndex = 3;
            workDateLabel.Text = "Work Date:";
            // 
            // workDateDateTimePicker
            // 
            this.workDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.workEntriesBindingSource, "WorkDate", true));
            this.workDateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.workDateDateTimePicker.Location = new System.Drawing.Point(97, 61);
            this.workDateDateTimePicker.Name = "workDateDateTimePicker";
            this.workDateDateTimePicker.Size = new System.Drawing.Size(96, 20);
            this.workDateDateTimePicker.TabIndex = 4;
            // 
            // hoursWorkedLabel
            // 
            hoursWorkedLabel.AutoSize = true;
            hoursWorkedLabel.Location = new System.Drawing.Point(12, 90);
            hoursWorkedLabel.Name = "hoursWorkedLabel";
            hoursWorkedLabel.Size = new System.Drawing.Size(79, 13);
            hoursWorkedLabel.TabIndex = 5;
            hoursWorkedLabel.Text = "Hours Worked:";
            // 
            // hoursWorkedTextBox
            // 
            this.hoursWorkedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.workEntriesBindingSource, "HoursWorked", true));
            this.hoursWorkedTextBox.Location = new System.Drawing.Point(97, 87);
            this.hoursWorkedTextBox.Name = "hoursWorkedTextBox";
            this.hoursWorkedTextBox.Size = new System.Drawing.Size(62, 20);
            this.hoursWorkedTextBox.TabIndex = 6;
            // 
            // employeeIDLabel
            // 
            employeeIDLabel.AutoSize = true;
            employeeIDLabel.Location = new System.Drawing.Point(12, 116);
            employeeIDLabel.Name = "employeeIDLabel";
            employeeIDLabel.Size = new System.Drawing.Size(70, 13);
            employeeIDLabel.TabIndex = 7;
            employeeIDLabel.Text = "Employee ID:";
            // 
            // employeeIDComboBox
            // 
            this.employeeIDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.workEntriesBindingSource, "EmployeeID", true));
            this.employeeIDComboBox.DataSource = this.employeesBindingSource;
            this.employeeIDComboBox.DisplayMember = "EmployeeID";
            this.employeeIDComboBox.FormattingEnabled = true;
            this.employeeIDComboBox.Location = new System.Drawing.Point(97, 113);
            this.employeeIDComboBox.Name = "employeeIDComboBox";
            this.employeeIDComboBox.Size = new System.Drawing.Size(115, 21);
            this.employeeIDComboBox.TabIndex = 8;
            this.employeeIDComboBox.ValueMember = "EmployeeID";
            // 
            // taskIDLabel
            // 
            taskIDLabel.AutoSize = true;
            taskIDLabel.Location = new System.Drawing.Point(12, 143);
            taskIDLabel.Name = "taskIDLabel";
            taskIDLabel.Size = new System.Drawing.Size(48, 13);
            taskIDLabel.TabIndex = 9;
            taskIDLabel.Text = "Task ID:";
            // 
            // taskIDComboBox
            // 
            this.taskIDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.workEntriesBindingSource, "TaskID", true));
            this.taskIDComboBox.DataSource = this.tasksBindingSource;
            this.taskIDComboBox.DisplayMember = "TaskID";
            this.taskIDComboBox.FormattingEnabled = true;
            this.taskIDComboBox.Location = new System.Drawing.Point(97, 140);
            this.taskIDComboBox.Name = "taskIDComboBox";
            this.taskIDComboBox.Size = new System.Drawing.Size(115, 21);
            this.taskIDComboBox.TabIndex = 10;
            this.taskIDComboBox.ValueMember = "TaskID";
            // 
            // employeesBindingSource
            // 
            this.employeesBindingSource.DataMember = "Employees";
            this.employeesBindingSource.DataSource = this.projectsDataSet;
            // 
            // employeesTableAdapter
            // 
            this.employeesTableAdapter.ClearBeforeFill = true;
            // 
            // tasksBindingSource
            // 
            this.tasksBindingSource.DataMember = "Tasks";
            this.tasksBindingSource.DataSource = this.projectsDataSet;
            // 
            // tasksTableAdapter
            // 
            this.tasksTableAdapter.ClearBeforeFill = true;
            // 
            // WorkEntriesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 201);
            this.Controls.Add(workIDLabel);
            this.Controls.Add(this.workIDLabel1);
            this.Controls.Add(workDateLabel);
            this.Controls.Add(this.workDateDateTimePicker);
            this.Controls.Add(hoursWorkedLabel);
            this.Controls.Add(this.hoursWorkedTextBox);
            this.Controls.Add(employeeIDLabel);
            this.Controls.Add(this.employeeIDComboBox);
            this.Controls.Add(taskIDLabel);
            this.Controls.Add(this.taskIDComboBox);
            this.Controls.Add(this.workEntriesBindingNavigator);
            this.Name = "WorkEntriesForm";
            this.Text = "WorkEntriesForm";
            this.Load += new System.EventHandler(this.WorkEntriesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.projectsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workEntriesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workEntriesBindingNavigator)).EndInit();
            this.workEntriesBindingNavigator.ResumeLayout(false);
            this.workEntriesBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tasksBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ProjectsDataSet projectsDataSet;
        private System.Windows.Forms.BindingSource workEntriesBindingSource;
        private ProjectsDataSetTableAdapters.WorkEntriesTableAdapter workEntriesTableAdapter;
        private ProjectsDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator workEntriesBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton workEntriesBindingNavigatorSaveItem;
        private ProjectsDataSetTableAdapters.EmployeesTableAdapter employeesTableAdapter;
        private System.Windows.Forms.Label workIDLabel1;
        private System.Windows.Forms.DateTimePicker workDateDateTimePicker;
        private System.Windows.Forms.TextBox hoursWorkedTextBox;
        private System.Windows.Forms.ComboBox employeeIDComboBox;
        private System.Windows.Forms.ComboBox taskIDComboBox;
        private System.Windows.Forms.BindingSource employeesBindingSource;
        private ProjectsDataSetTableAdapters.TasksTableAdapter tasksTableAdapter;
        private System.Windows.Forms.BindingSource tasksBindingSource;
    }
}