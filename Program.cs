using System;


namespace TodoList
{
    class Program
    {
        static void Main(string[] args)
        {
            TodoList.PreAddTasks();

            Console.WriteLine("Hi, this is a To do task manager!");
            Console.WriteLine("You have 4 options");
            Console.WriteLine("Add new task press [a]");
            Console.WriteLine("Edit a task press  [e]");
            Console.WriteLine("Delete task press  [d]");
            Console.WriteLine("See the list press [s]");

            var readline = Console.ReadLine();
            var readlineToLower = readline.ToLower();
            switch (readlineToLower)
            {
                case "a":
                    Console.WriteLine("Enter title");
                    string taskTitle = Console.ReadLine();
                    Console.WriteLine("Enter Description");
                    string taskDescription = Console.ReadLine();
                    TodoList.AddTask(taskTitle, taskDescription);
                    break;

                case "e":
                    Console.WriteLine("Please write the ID to edit task");
                    string itemEditId = Console.ReadLine();
                    // Tjek om taskId findes
                    Console.WriteLine("Select what you want to edit");
                    Console.WriteLine("For title press       [t]");
                    Console.WriteLine("For Description press [d]");
                    string columnToEdit = Console.ReadLine();

                    Console.WriteLine("Please enter your phrase");

                    string enteredPhrase = Console.ReadLine();

                    TodoList.EditTask(itemEditId, columnToEdit, enteredPhrase);

                    TodoList.showTask();
                    break;

                case "d":
                    Console.WriteLine("Please wirte the ID of the task you want to delete");
                    //Include -> it is not existing try again
                    string itemDeleteId = Console.ReadLine();
                    
                    TodoList.DeleteTask(itemDeleteId);

                    TodoList.CheckTaskExist(itemDeleteId);
                    
                    break;

                case "s":
                    Console.WriteLine(TodoList.showTask());
                    break;

                default:
                    Console.WriteLine("You have 4 options");
                    Console.WriteLine("Add new task press [a]");
                    Console.WriteLine("Edit a task press  [e]");
                    Console.WriteLine("Delete task press  [d]");
                    Console.WriteLine("See the list press [s]");
                    break;
            }
            


        }
    }
}
