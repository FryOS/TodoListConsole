using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoList_Entities;

namespace TodoList_DAL
{
    public static class MemoryDAO
    {
        public static Dictionary<int, MyTask> tasks = new Dictionary<int, MyTask>();
    }
}
