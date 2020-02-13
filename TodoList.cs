using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace TodoList
{
    class TodoList
    {
        //TODO
        //PreAdd TodoTask
        //List Tasks
        //Create new task
        //Delete Existing Task
        //Edit Existing Task

        public static List<TodoList> todolistArray = new List<TodoList>();

        [MinLength(1), MaxLength(3)]
        public string TaskId { get; set; }
        public string TaskTitle { get; set; }
        public string TaskDescription { get; set; }
        public DateTime TaskCreatedDate { get; set; }

        public TodoList(string id, string taskTitle, string taskDescription, DateTime taskCreatedDate)
        {
            TaskId = id;
            TaskTitle = taskTitle;
            TaskDescription = taskDescription;
            TaskCreatedDate = taskCreatedDate;
        }   

        public void addTask(string taskTitle, string taskDescription)
        {
            var tempTaskID = "AK3";
            var task = new TodoList(tempTaskID, taskTitle, taskDescription, DateGenerator()); ;
            todolistArray.Add(task);
        }

        public void deleteTask()
        {
            
        }

        public void editTask()
        {

        }
        
        public static List<TodoList> showTask()
        {
            Console.WriteLine("Hello What am I");
            Console.WriteLine(todolistArray);
            Console.WriteLine("Hello What am I");

            //todolistArray.FindAll( x => x.TaskId);
            //return TodoList.Select(x => x);
            Console.WriteLine("TaskId | TaskTitle | TaskDescription | TaskCreatedDate");

            foreach (TodoList t in todolistArray)
            {
                Console.WriteLine(t.TaskId + ' ' + t.TaskTitle + ' ' + t.TaskDescription + ' ' + t.TaskCreatedDate);
            }

            //for (int i = 0; i < todolistArray.Count; i++)
            //{
               
            //    Console.WriteLine(todolistArray[i].TaskId + ' ' + todolistArray[i].TaskTitle + ' ' + todolistArray[i].TaskDescription + ' ' + todolistArray[i].TaskCreatedDate);
            //}
            return todolistArray.ToList();
        }

        public static DateTime DateGenerator()
        {
            DateTime localDateTime = DateTime.Now;
            Console.WriteLine(localDateTime);
            return localDateTime;
        }

        public static void preAddTasks()
        {
            //Pre-fill the list with tasks
            
            var task1 = new TodoList("AKY", "Wake up", "Wake up and eat breakfast", DateGenerator());
            var task2 = new TodoList("AKI", "Cut Hair", "Cut hair at the barber", DateGenerator());
            var task3 = new TodoList("AKO", "Go to Meeting", "Meeting with the team", DateGenerator());
            var task4 = new TodoList("AKY", "Cross fit", "Crossfit 8:00-9:00", DateGenerator());
            var task5 = new TodoList("ENO", "Dinner", "Eat fastfood", DateGenerator());
            todolistArray.Add(task1);
            todolistArray.Add(task2);
            todolistArray.Add(task3);
            todolistArray.Add(task4);
            todolistArray.Add(task5);

        }

     


    }

}
