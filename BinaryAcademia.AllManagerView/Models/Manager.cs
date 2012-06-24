using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BinaryAcademia.AllManagerView.Models
{
    public class Manager
    {
        public int ManagerId { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Task> Tasks { get; set; }

        public Manager(int managerId, string name)
        {
            ManagerId = managerId;
            Name = name;
        }
    }
}