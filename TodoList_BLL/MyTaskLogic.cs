using System;
using System.Collections.Generic;
using TodoList_BLL_Interface;
using TodoList_DAL_Interface;
using TodoList_Entities;

namespace TodoList_BLL
{
    public class MyTaskLogic : IMyTaskLogic
    {
        private readonly ITaskDAO _taskDAO;

        public MyTaskLogic(ITaskDAO taskDAO)
        {
            _taskDAO = taskDAO;
        }

        public int Add(MyTask task)
        {
            if (task.Name.Length < 2)
            {
                throw new ArgumentException("Name of task must be 3 or higher");
            }
            return _taskDAO.Add(task);
        }

        public IEnumerable<MyTask> GetAll()
        {
            return _taskDAO.GetAll();
        }

        public MyTask GetById(int id)
        {
            return _taskDAO.GetById(id);
        }

        public void SortByPriority()
        {
             _taskDAO.SortByPriority();
        }

        public void SearchByName(string name)
        {
            _taskDAO.SearchByName(name);
        }
    }
}
