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
 *  applications as long as the original copyright notice is included.    *
 *                                                                        *
 **************************************************************************/

using System;

namespace Persistence
{
    /// <summary>
    /// Task Data Model Class
    /// </summary>
    public class Task
    {
        /// <summary>
        /// The class contains the fields stored inside the db so it is easier to build the model inside the application.
        /// </summary>
        #region fields
        private int _taskID;
        private string _taskName;
        private string _taskDescription;
        private string _taskStatus;
        private int _taskProgress;
        private DateTime _taskDeadline;
        private string _employeeUUID;
        #endregion

        /// <summary>
        /// Getters for the fields.
        /// </summary>
        #region getters
        public int ID
        {
            get { return _taskID; }
        }

        public string Name
        {
            get
            {
                return _taskName;
            }
        }

        public string Description
        {
            get
            {
                return _taskDescription;
            }
        }

        public string Status
        {
            get
            {
                return _taskStatus;
            }
        }

        public int Progress
        {
            get
            {
                return _taskProgress;
            }
        }

        public DateTime Deadline
        {
            get
            {
                return _taskDeadline;
            }
        }

        public string EmployeeUUID
        {
            get
            {
                return _employeeUUID;
            }
        }
        #endregion

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="taskID"></param>
        /// <param name="taskName"></param>
        /// <param name="taskDescription"></param>
        /// <param name="taskStatus"></param>
        /// <param name="taskDeadline"></param>
        /// <param name="employeeUUID"></param>
        public Task(int taskID, string taskName, string taskDescription, string taskStatus, int taskProgress, DateTime taskDeadline, string employeeUUID)
        {
            this._taskID = taskID;
            this._taskName = taskName;
            this._taskDescription = taskDescription;
            this._taskStatus = taskStatus;
            this._taskProgress = taskProgress;
            this._taskDeadline = taskDeadline;
            this._employeeUUID = employeeUUID;
        }
    }
}
