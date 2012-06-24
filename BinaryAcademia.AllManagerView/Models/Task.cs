using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;


namespace BinaryAcademia.AllManagerView.Models
{
    public class Task
    {
        public int TaskId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public virtual Manager Manager { get; set; }

        public Task(
            int id,
            string title,
            string description)
        {
            TaskId = id;
            Title = title;
            Description = description;
        }

        public  Task(
            int id,
            string title,
            string description,
            Manager manager)
        {
            TaskId = id;
            Title = title;
            Description = description;
            Manager = manager;
        }


    }
}