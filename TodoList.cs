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

        public static void AddTask(string taskTitle, string taskDescription)
        {

            //var tempTaskID = "AK3";
            var task = new TodoList(IdGenerator(), taskTitle, taskDescription, DateGenerator());
            todolistArray.Add(task);
        }

        public static void DeleteTask(string taskId)
        {
            var ItemToRemove = todolistArray.Find(x => x.TaskId == taskId);
            todolistArray.Remove(ItemToRemove);
            Console.WriteLine(todolistArray.Find(x => x.TaskId == taskId));
            showTask();
        }

        public static void EditTask(string taskId, string columnToEdit, string enteredPhrase)
        {
            //Capital ID
            var findTaskToEdit = todolistArray.Find(x => x.TaskId == taskId);
            if (columnToEdit == "t")
            {
                todolistArray.Where(x => x.TaskId == taskId)
                    .Select(x => { x.TaskTitle = enteredPhrase; return x; })
                    .ToList();

                var findTaskToEdit1 = todolistArray.Find(x => x.TaskId == taskId);
            }
            else if (columnToEdit == "d")
            {
                todolistArray.Where(x => x.TaskId == taskId)
                    .Select(x => { x.TaskDescription = enteredPhrase; return x; })
                    .ToList();

                var findTaskToEdit1 = todolistArray.Find(x => x.TaskId == taskId);
            }

        }

        public static List<TodoList> showTask()
        {
            //todolistArray.FindAll( x => x.TaskId);
            //return TodoList.Select(x => x);
            Console.WriteLine("TaskId | TaskTitle | TaskDescription | TaskCreatedDate");

            foreach (TodoList t in todolistArray)
            {
                Console.WriteLine(t.TaskId + ' ' + t.TaskTitle + ' ' + t.TaskDescription + ' ' + t.TaskCreatedDate);
            }
            return todolistArray.ToList();
        }

        public static void CheckTaskExist(string taskId)
        {
            string taskIdToUpper = taskId.ToUpper();

            var task = todolistArray.Find(x => x.TaskId == taskIdToUpper);
            if (task == null)
            {
                Console.WriteLine("Task {0} is now deleted", taskIdToUpper);
            }
            else
            {
                Console.WriteLine("Something went wrong");
            }
        }

        public static DateTime DateGenerator()
        {
            DateTime localDateTime = DateTime.Now;
            //Console.WriteLine(localDateTime);
            return localDateTime;
        }

        public static string IdGenerator()
        {
            //Lav random id generator
            //3 bogstaver
            //tjek hvis den er allerede i todolistens id (Skal være unik)
            return "Random String ID";
        }

        public static void PreAddTasks()
        {
            //Pre-fill the list with tasks
            var task1 = new TodoList("AEA", "Wake up", "Wake up and eat breakfast", DateGenerator());
            var task2 = new TodoList("BDB", "Cut Hair", "Cut hair at the barber", DateGenerator());
            var task3 = new TodoList("CCC", "Go to Meeting", "Meeting with the team", DateGenerator());
            var task4 = new TodoList("DBD", "Cross fit", "Crossfit 8:00-9:00", DateGenerator());
            var task5 = new TodoList("EAE", "Dinner", "Eat fastfood", DateGenerator());
            todolistArray.Add(task1);
            todolistArray.Add(task2);
            todolistArray.Add(task3);
            todolistArray.Add(task4);
            todolistArray.Add(task5);
        }

    }

}
