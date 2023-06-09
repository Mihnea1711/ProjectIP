﻿namespace View
{
    partial class AddTaskDialogControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxTaskName = new System.Windows.Forms.TextBox();
            this.textBoxTaskDesc = new System.Windows.Forms.TextBox();
            this.buttonAssignToMe = new System.Windows.Forms.Button();
            this.labelAddTaskName = new System.Windows.Forms.Label();
            this.labelAddTaskDescription = new System.Windows.Forms.Label();
            this.labelAddTaskAssignTo = new System.Windows.Forms.Label();
            this.labelDeadline = new System.Windows.Forms.Label();
            this.comboBoxAssign = new System.Windows.Forms.ComboBox();
            this.labelAddTaskHeader = new System.Windows.Forms.Label();
            this.buttonAddTask = new System.Windows.Forms.Button();
            this.dateTimePickerDeadline = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // textBoxTaskName
            // 
            this.textBoxTaskName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTaskName.Location = new System.Drawing.Point(193, 107);
            this.textBoxTaskName.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxTaskName.Name = "textBoxTaskName";
            this.textBoxTaskName.Size = new System.Drawing.Size(390, 26);
            this.textBoxTaskName.TabIndex = 0;
            // 
            // textBoxTaskDesc
            // 
            this.textBoxTaskDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTaskDesc.Location = new System.Drawing.Point(193, 168);
            this.textBoxTaskDesc.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxTaskDesc.Multiline = true;
            this.textBoxTaskDesc.Name = "textBoxTaskDesc";
            this.textBoxTaskDesc.Size = new System.Drawing.Size(390, 182);
            this.textBoxTaskDesc.TabIndex = 1;
            // 
            // buttonAssignToMe
            // 
            this.buttonAssignToMe.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAssignToMe.Location = new System.Drawing.Point(435, 386);
            this.buttonAssignToMe.Margin = new System.Windows.Forms.Padding(0);
            this.buttonAssignToMe.Name = "buttonAssignToMe";
            this.buttonAssignToMe.Size = new System.Drawing.Size(148, 28);
            this.buttonAssignToMe.TabIndex = 4;
            this.buttonAssignToMe.Text = "Assign To Me";
            this.buttonAssignToMe.UseVisualStyleBackColor = true;
            this.buttonAssignToMe.Click += new System.EventHandler(this.buttonAssignToMe_Click);
            // 
            // labelAddTaskName
            // 
            this.labelAddTaskName.AutoSize = true;
            this.labelAddTaskName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAddTaskName.Location = new System.Drawing.Point(59, 107);
            this.labelAddTaskName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAddTaskName.Name = "labelAddTaskName";
            this.labelAddTaskName.Size = new System.Drawing.Size(94, 20);
            this.labelAddTaskName.TabIndex = 5;
            this.labelAddTaskName.Text = "Task Name";
            // 
            // labelAddTaskDescription
            // 
            this.labelAddTaskDescription.AutoSize = true;
            this.labelAddTaskDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAddTaskDescription.Location = new System.Drawing.Point(17, 168);
            this.labelAddTaskDescription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAddTaskDescription.Name = "labelAddTaskDescription";
            this.labelAddTaskDescription.Size = new System.Drawing.Size(136, 20);
            this.labelAddTaskDescription.TabIndex = 6;
            this.labelAddTaskDescription.Text = "Task Description";
            // 
            // labelAddTaskAssignTo
            // 
            this.labelAddTaskAssignTo.AutoSize = true;
            this.labelAddTaskAssignTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAddTaskAssignTo.Location = new System.Drawing.Point(69, 386);
            this.labelAddTaskAssignTo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAddTaskAssignTo.Name = "labelAddTaskAssignTo";
            this.labelAddTaskAssignTo.Size = new System.Drawing.Size(84, 20);
            this.labelAddTaskAssignTo.TabIndex = 7;
            this.labelAddTaskAssignTo.Text = "Assign To";
            // 
            // labelDeadline
            // 
            this.labelDeadline.AutoSize = true;
            this.labelDeadline.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDeadline.Location = new System.Drawing.Point(101, 458);
            this.labelDeadline.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDeadline.Name = "labelDeadline";
            this.labelDeadline.Size = new System.Drawing.Size(75, 20);
            this.labelDeadline.TabIndex = 8;
            this.labelDeadline.Text = "Deadline";
            // 
            // comboBoxAssign
            // 
            this.comboBoxAssign.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxAssign.FormattingEnabled = true;
            this.comboBoxAssign.Location = new System.Drawing.Point(193, 386);
            this.comboBoxAssign.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxAssign.Name = "comboBoxAssign";
            this.comboBoxAssign.Size = new System.Drawing.Size(214, 28);
            this.comboBoxAssign.TabIndex = 9;
            // 
            // labelAddTaskHeader
            // 
            this.labelAddTaskHeader.AutoSize = true;
            this.labelAddTaskHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAddTaskHeader.Location = new System.Drawing.Point(199, 23);
            this.labelAddTaskHeader.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAddTaskHeader.Name = "labelAddTaskHeader";
            this.labelAddTaskHeader.Size = new System.Drawing.Size(233, 31);
            this.labelAddTaskHeader.TabIndex = 10;
            this.labelAddTaskHeader.Text = "Create a new task";
            // 
            // buttonAddTask
            // 
            this.buttonAddTask.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonAddTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddTask.Location = new System.Drawing.Point(418, 533);
            this.buttonAddTask.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAddTask.Name = "buttonAddTask";
            this.buttonAddTask.Size = new System.Drawing.Size(165, 43);
            this.buttonAddTask.TabIndex = 11;
            this.buttonAddTask.Text = "Create Task";
            this.buttonAddTask.UseVisualStyleBackColor = true;
            // 
            // dateTimePickerDeadline
            // 
            this.dateTimePickerDeadline.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerDeadline.Location = new System.Drawing.Point(193, 458);
            this.dateTimePickerDeadline.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePickerDeadline.Name = "dateTimePickerDeadline";
            this.dateTimePickerDeadline.Size = new System.Drawing.Size(390, 26);
            this.dateTimePickerDeadline.TabIndex = 12;
            // 
            // AddTaskDialogControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dateTimePickerDeadline);
            this.Controls.Add(this.buttonAddTask);
            this.Controls.Add(this.labelAddTaskHeader);
            this.Controls.Add(this.comboBoxAssign);
            this.Controls.Add(this.labelDeadline);
            this.Controls.Add(this.labelAddTaskAssignTo);
            this.Controls.Add(this.labelAddTaskDescription);
            this.Controls.Add(this.labelAddTaskName);
            this.Controls.Add(this.buttonAssignToMe);
            this.Controls.Add(this.textBoxTaskDesc);
            this.Controls.Add(this.textBoxTaskName);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AddTaskDialogControl";
            this.Size = new System.Drawing.Size(654, 605);
            this.Load += new System.EventHandler(this.AddTaskDialogControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxTaskName;
        private System.Windows.Forms.TextBox textBoxTaskDesc;
        private System.Windows.Forms.Button buttonAssignToMe;
        private System.Windows.Forms.Label labelAddTaskName;
        private System.Windows.Forms.Label labelAddTaskDescription;
        private System.Windows.Forms.Label labelAddTaskAssignTo;
        private System.Windows.Forms.Label labelDeadline;
        private System.Windows.Forms.ComboBox comboBoxAssign;
        private System.Windows.Forms.Label labelAddTaskHeader;
        private System.Windows.Forms.Button buttonAddTask;
        private System.Windows.Forms.DateTimePicker dateTimePickerDeadline;
    }
}
