using System;
using System.Collections.Generic;
using TodoList_Entities;

namespace TodoList_BLL_Interface
{
    public interface IMyTaskLogic
    {

        int Add(MyTask task);

        IEnumerable<MyTask> GetAll();

        MyTask GetById(int id);

        void SortByPriority();

        void SearchByName(string name);
    }
}
