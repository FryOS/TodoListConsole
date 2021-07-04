using System;
using TodoList_BLL;
using TodoList_BLL_Interface;
using TodoList_DAL;
using TodoList_DAL_Interface;
using TodoList_Entities;

namespace TodoList_PLL
{
    class Program
    {
        static void Main(string[] args)
        {
           IMyTaskLogic myTaskLogic = new MyTaskLogic(new TaskDAO());

           var id = myTaskLogic.Add(new MyTask
           {
                Name = "Test",
                Priority = 1,
                Text = "Hello"
           });

            var task = myTaskLogic.GetById(id);

            Console.WriteLine(task.Name);

        }
    }
}
