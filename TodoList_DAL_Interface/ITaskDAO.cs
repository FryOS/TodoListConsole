using System;
using System.Collections.Generic;
using TodoList_Entities;

namespace TodoList_DAL_Interface
{
    public interface ITaskDAO
    {
        int Add(MyTask task);

        IEnumerable<MyTask> GetAll();

        MyTask GetById(int id);

        void RemoveById(int id);

        void SortByPriority();

        string SearchByName(string name);
        
    }
}
