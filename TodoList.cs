using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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

        List<TodoList> todolistArray = new List<TodoList>();

        [MinLength(1), MaxLength(3)]
        public string TaskId { get; set; }
        public string TaskTitle { get; set; }
        public string TaskDescription { get; set; }
        public DateTime TaskCreatedDate { get; set; }

        public TodoList(string id, string taskTitle, string taskDescription, DateTime taskCreatedDate)
        {
            id = TaskId;
            taskTitle = TaskTitle;
            taskCreatedDate = TaskCreatedDate;
            taskCreatedDate = TaskCreatedDate;
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
        
        public DateTime DateGenerator()
        {
            DateTime localDateTime = DateTime.Now;
            Console.WriteLine(localDateTime);
            return localDateTime;
        }

    }
}
