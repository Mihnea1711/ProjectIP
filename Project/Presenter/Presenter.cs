﻿/**************************************************************************
 *                                                                        *
 *  Description: Task Management Tool                    		          *
 *  Website Mihnea: https://github.com/Mihnea1711               	      *
 *  Website Robert: https://github.com/cioocan               	          *
 *  Copyright:   (c) 2023, Mihnea Bejinaru, Robert Ciocan                 *
 *                                                                        *
 *  This code and information is provided "as is" without warranty of     *
 *  any kind, either expressed or implied, including but not limited      *
 *  to the implied warranties of merchantability or fitness for a         *
 *  particular purpose. You are free to use this source code in your      *
 *  applications as long as the original copyright not                    *
 *                                                                        *
 **************************************************************************/

using System.Windows.Forms;
using Persistence;

namespace Presenters
{   
    public class Presenter : IPresenter
    {
        /// <summary>
        /// The view builder. 
        /// </summary>
        private IBuilder _builder;

        /// <summary>
        /// Instances of the services needed.
        /// </summary>
        #region services
        private ITaskService _taskService;
        private ISubtaskService _subtaskService;
        private IEmployeeService _employeeService;
        private ICommentService _commentService;
        #endregion

        #region service getters
        public TaskService TaskSRV
        {
            get
            {
                return (TaskService)this._taskService;
            }
        }
        public CommentService CommentSRV
        {
            get
            {
                return (CommentService)this._commentService;
            }
        }
        public EmployeeService EmployeeSRV
        {
            get
            {
                return (EmployeeService)this._employeeService;
            }
        }
        public SubtaskService SubtaskSRV
        {
            get
            {
                return (SubtaskService)this._subtaskService;
            }
        }
        #endregion

        /// <summary>
        /// Constructor. Initializes all the services.
        /// </summary>
        public Presenter() {
            this._taskService = new TaskService();
            this._subtaskService = new SubtaskService();
            this._employeeService = new EmployeeService();
            this._commentService = new CommentService();
        }
        
        /// <summary>
        /// Method to create an employee row inside a data grid view.
        /// </summary>
        /// <param name="employee"></param>
        /// <returns>Returns the complete data grid view row with employee data.</returns>
        public DataGridViewRow makeEmployeeRow(Employee employee)
        {
            this._builder= new EmployeeBuilder();
            EmployeeBuilder employeeBuilder = (EmployeeBuilder)_builder;

            employeeBuilder.Reset();
            employeeBuilder.SetUsername(employee.Username);
            employeeBuilder.SetName(employee.FullName);
            employeeBuilder.SetEmail(employee.Email);
            employeeBuilder.SetPhoneNr(employee.Phone);
            employeeBuilder.SetGoToButton();

            return employeeBuilder.GetResult();
        }

        /// <summary>
        /// Method to create an task row inside a data grid view.
        /// </summary>
        /// <param name="task"></param>
        /// <returns>Returns the complete data grid view row with task data.</returns>
        public DataGridViewRow makeTaskRow(Task task)
        {
            this._builder = new TaskBuilder();
            TaskBuilder taskBuilder = (TaskBuilder)_builder;

            taskBuilder.Reset();
            taskBuilder.SetID(task.ID.ToString());
            taskBuilder.SetTitle(task.Name);
            taskBuilder.SetDescription(task.Description);
            taskBuilder.SetStatus(task.Status);
            taskBuilder.SetProgress(task.Progress);
            taskBuilder.SetDeadline(task.Deadline);
            taskBuilder.SetGoToButton();

            return taskBuilder.GetResult();
        }
        /// <summary>
        /// Method to create a subtask row inside a data grid view.
        /// </summary>
        /// <param name="subtask"></param>
        /// <returns>Returns the complete data grid view row with subtask data.</returns>
        public DataGridViewRow makeSubtaskRow(Subtask subtask)
        {
            this._builder = new SubtaskBuilder();
            SubtaskBuilder subtaskBuilder = (SubtaskBuilder)_builder;

            subtaskBuilder.Reset();
            subtaskBuilder.SetID(subtask.Id.ToString());
            subtaskBuilder.SetTitle(subtask.Title);
            subtaskBuilder.SetDescription(subtask.Description);
            subtaskBuilder.SetStatus(subtask.Status);
            subtaskBuilder.SetGoToButton(); 

            return subtaskBuilder.GetResult();
        }
        /// <summary>
        /// Method to create a comment row inside a data grid view.
        /// </summary>
        /// <param name="comment"></param>
        /// <returns>Returns the complete data grid view row with comment data.</returns>
        public DataGridViewRow makeCommentRow(Comment comment)
        {
            this._builder = new CommentBuilder();
            CommentBuilder commentBuilder = (CommentBuilder)_builder;

            commentBuilder.Reset();
            commentBuilder.SetTitle(comment.Title);
            commentBuilder.SetDescription(comment.Description);
            commentBuilder.SetTimeReported(comment.TimeReported);

            return commentBuilder.GetResult();
        }

    }
}
