using System;
using System.Collections.Generic;
using System.Linq;
using TodoList_Entities;

namespace TodoList_DAL
{
    public class TaskDAO
    {

        public int Add(MyTask task)
        {
            int lastId = GetLastId() + 1;

            task.Id = ++lastId;
            MemoryDAO.tasks.Add(lastId,task);
            return lastId;

        }

        public IEnumerable<MyTask> GetAll()
        {
            return MemoryDAO.tasks.Values.ToList();
        }

        public MyTask GetBtId(int id)
        {
            if (MemoryDAO.tasks.TryGetValue(id, out var task))
            {
                return null;
            }
            return task;
        }



        private static int GetLastId()
        {
            int lastId;
            if (MemoryDAO.tasks.Count == 0)
            {
                lastId = 0;
            }
            else
            {
                lastId = MemoryDAO.tasks.Keys.Max(item => item);
            }
            return lastId;
        }
    }
}
