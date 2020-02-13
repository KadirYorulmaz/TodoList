using System;


namespace TodoList
{
    class Program
    {
        static void Main(string[] args)
        {
            TodoList.preAddTasks();

            Console.WriteLine("Hello World!");
            Console.WriteLine(TodoList.showTask());


            var name = Console.ReadLine();
            Console.WriteLine("Hello you wrote: " + name);
        }
    }
}
