﻿using Project.Business.Interfaces;
using Project.Models;
using Project.Persistence.Interfaces;
using System;
using System.Collections.Generic;

namespace Project.Business.Services
{
    internal class SubtaskService : ISubtaskService
    {
        private SubtaskRepository subtaskRepository;

        public SubtaskService()
        {
            this.subtaskRepository = new SubtaskRepository();
        }

        public (bool, Exception) AddSubstask(string title, string description, string status, DateTime deadline, int taskId, string employeeId)
        {
            // create the subtask model
            Subtask subtask = new Subtask(0,title, description, status, deadline, taskId, employeeId);

            // store subtask in db
            Exception exception = this.subtaskRepository.AddSubstask(subtask);
            if (exception != null)
            {
                return (false, exception);
            }

            return (true, null);
        }

        public (Subtask, Exception) GetSubtaskById(int subtaskId)
        {
            (Subtask subtask, Exception exception) = subtaskRepository.GetSubtaskById(subtaskId);

            if (exception != null)
            {
                return (null, exception);
            }

            return (subtask, null);
        }

        public (IList<Subtask>, Exception) GetSubtasksByTask(int taskId)
        {
            (IList<Subtask> subtasks, Exception exception) = subtaskRepository.GetSubtasksByTask(taskId);

            if (exception != null)
            {
                return (null, exception);
            }

            return (subtasks, null);
        }
    }
}
