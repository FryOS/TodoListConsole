using System;
using TodoList_BLL;
using TodoList_BLL_Interface;
using TodoList_DAL;
using TodoList_DAL_Interface;
using TodoList_Entities;
using System.IO;


namespace TodoList_PLL
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Добро пожаловать!\nСоздайте задачу?");
            IMyTaskLogic myTaskLogic = new MyTaskLogic(new TaskDAO());

            string name = "";
            int priority = 1;
            string text = "";
           
            var task = CreateTask(out name, out priority, out text, myTaskLogic);
           

            string filePath = @"C:/Users/Alexey/Documents/tasks.txt"; // Укажем путь 
            if (!File.Exists(filePath) || File.Exists(filePath)) // Проверим, существует ли файл по данному пути
            {
                //   Если не существует - создаём и записываем в строку
                using (StreamWriter sw = File.CreateText(filePath))  // Конструкция Using (будет рассмотрена в последующих юнитах)
                {
                    sw.WriteLine(task.Id);
                    sw.WriteLine(task.Name);
                    sw.WriteLine(task.Priority);
                    sw.WriteLine(task.Text);
                }
            }

            using (StreamReader sr = File.OpenText(filePath))
            {
                string str = "";
                while ((str = sr.ReadLine()) != null) // Пока не кончатся строки - считываем из файла по одной и выводим в консоль
                {
                    Console.WriteLine(str);
                }
            }


        }

        private static MyTask CreateTask(out string name, out int priority, out string text, IMyTaskLogic myTaskLogic)
        {
            Console.WriteLine("Введите имя задачи");
            name = Console.ReadLine().ToLower();

            Console.WriteLine("Введите приоритет задачи");
            priority = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите текст задачи");
            text = Console.ReadLine().ToLower();

            var task = new MyTask
            {
                Name = name,
                Priority = priority,
                Text = text
            };

            myTaskLogic.Add(task);
            return task;
            
        }
    }
}
