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

namespace Persistence
{
    /// <summary>
    /// Employee Data Model Class
    /// </summary>
    public class Employee
    {
        /// <summary>
        /// The class contains the fields stored inside the db so it is easier to build the model inside the application.
        /// </summary>
        #region fields
        private string _uuid;
        private string _username;
        private string _password;
        private string _firstName;
        private string _lastName;
        private string _email;
        private string _phone;
        private int _tasksdone;

        /// <summary>
        /// for ease-of-use of the full employee name
        /// </summary>
        private string _fullname => $"{_firstName} {_lastName}";
        #endregion

        /// <summary>
        /// Getters for the fields.
        /// </summary>
        #region getters
        public string UUID
        {
            get { return _uuid; }
        }
        public string Username
        {
            get { return _username; }
        }
        public string Password
        {
            get { return _password; }
        }
        public string FirstName
        {
            get { return _firstName; }

        }
        public string LastName
        {
            get { return _lastName; }
        }
        public string Email
        {
            get { return _email; }
        }
        public string Phone
        {
            get { return _phone; }
        }
        public int Tasksdone
        {
            get
            {
                return _tasksdone;
            }
        }
        public string FullName
        {
            get
            {
                return _fullname;
            }
        }
        #endregion

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="employeeUUID"></param>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="email"></param>
        /// <param name="phoneNr"></param>
        /// <param name="tasksDone"></param>
        public Employee(string employeeUUID, string username, string password, string firstName, string lastName, string email, string phoneNr, int tasksDone = 0) 
        {
            this._uuid = employeeUUID;
            this._username = username;
            this._password = password;
            this._firstName = firstName;
            this._lastName = lastName;
            this._email = email;
            this._phone = phoneNr;
            this._tasksdone = tasksDone;
        }
    }
}
