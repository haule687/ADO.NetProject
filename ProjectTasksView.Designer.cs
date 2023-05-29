
namespace CIS266Project
{
    partial class ProjectTasksView
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
            this.txtEmployeeID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lvwProjects = new System.Windows.Forms.ListView();
            this.lvwTasks = new System.Windows.Forms.ListView();
            this.label4 = new System.Windows.Forms.Label();
            this.lvwWorkEntries = new System.Windows.Forms.ListView();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtEmployeeID
            // 
            this.txtEmployeeID.Location = new System.Drawing.Point(88, 6);
            this.txtEmployeeID.Name = "txtEmployeeID";
            this.txtEmployeeID.Size = new System.Drawing.Size(100, 20);
            this.txtEmployeeID.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Employee ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Choose a project:";
            // 
            // lvwProjects
            // 
            this.lvwProjects.HideSelection = false;
            this.lvwProjects.Location = new System.Drawing.Point(12, 49);
            this.lvwProjects.Name = "lvwProjects";
            this.lvwProjects.Size = new System.Drawing.Size(521, 146);
            this.lvwProjects.TabIndex = 6;
            this.lvwProjects.UseCompatibleStateImageBehavior = false;
            this.lvwProjects.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.lvwProjects_ItemSelectionChanged);
            // 
            // lvwTasks
            // 
            this.lvwTasks.HideSelection = false;
            this.lvwTasks.Location = new System.Drawing.Point(12, 229);
            this.lvwTasks.Name = "lvwTasks";
            this.lvwTasks.Size = new System.Drawing.Size(521, 146);
            this.lvwTasks.TabIndex = 8;
            this.lvwTasks.UseCompatibleStateImageBehavior = false;
            this.lvwTasks.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.lvwTasks_ItemSelectionChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 212);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Choose a Task:";
            // 
            // lvwWorkEntries
            // 
            this.lvwWorkEntries.HideSelection = false;
            this.lvwWorkEntries.Location = new System.Drawing.Point(9, 410);
            this.lvwWorkEntries.Name = "lvwWorkEntries";
            this.lvwWorkEntries.Size = new System.Drawing.Size(521, 146);
            this.lvwWorkEntries.TabIndex = 10;
            this.lvwWorkEntries.UseCompatibleStateImageBehavior = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 393);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Work Entries";
            // 
            // ProjectTasksView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 585);
            this.Controls.Add(this.lvwWorkEntries);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lvwTasks);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lvwProjects);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtEmployeeID);
            this.Name = "ProjectTasksView";
            this.Text = "ProjectTasksView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEmployeeID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView lvwProjects;
        private System.Windows.Forms.ListView lvwTasks;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListView lvwWorkEntries;
        private System.Windows.Forms.Label label2;
    }
}