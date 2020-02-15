using System;

namespace TodoList
{
    class Program
    {
        static void Main(string[] args)
        {
            TodoList.PreAddTasks();
            Console.WriteLine("Hi, this is a Todo task manager! ");

            while (true)
            {
                
                
                TodoList.ShowOptions();

                var readline = Console.ReadLine();
                var readlineToLower = readline.ToLower();

                switch (readlineToLower)
                {
                    case "a":
                        Console.WriteLine("     Enter title");
                        string taskTitle = Console.ReadLine();
                        Console.WriteLine("     Enter Description");
                        string taskDescription = Console.ReadLine();
                        TodoList.AddTask(taskTitle, taskDescription);
                        TodoList.ShowTask();
                        break;

                    case "e":
                        Console.WriteLine("     Please write the ID to edit task");
                        string itemEditId = Console.ReadLine().ToUpper();
 
                        //Task Exist ?  
                        if (TodoList.CheckTaskExist(itemEditId) == 0)
                        {
                            Console.WriteLine("******");
                            Console.WriteLine("     The entered Id does not exist, please try again");
                            Console.WriteLine("******");
                        }
                        else
                        {
                            Console.WriteLine("     Select what you want to edit");
                            Console.WriteLine("     For title press       [t]");
                            Console.WriteLine("     For Description press [d]");

                            string columnToEdit = Console.ReadLine();

                            Console.WriteLine("     Please enter your phrase");

                            string enteredPhrase = Console.ReadLine();
                            TodoList.EditTask(itemEditId, columnToEdit, enteredPhrase);
                        }

                        TodoList.ShowTask();
                        break;

                    case "d":
                        Console.WriteLine("     Please write the ID of the task you want to delete");
                        string itemDeleteId = Console.ReadLine().ToUpper();
                        //Task Exist ? 
                        if (TodoList.CheckTaskExist(itemDeleteId) == 0)
                        {
                            Console.WriteLine("******");
                            Console.WriteLine("     The entered Id does not exist, please try again");
                            Console.WriteLine("******");
                        }
                        else
                        {
                            TodoList.DeleteTask(itemDeleteId);

                        }
                        TodoList.ShowTask();
                        break;

                    case "s":
                        TodoList.ShowTask();
                        break;

                    default:
                        TodoList.ShowOptions();
                        break;
                }
            }
            
        }
    }
}
