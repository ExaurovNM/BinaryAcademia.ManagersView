using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Web;
using BinaryAcademia.AllManagerView.Models;

namespace BinaryAcademia.AllManagerView.Content
{

    //Generate test data for AllManagersView
    public class AllManagersDataTest
    {
        public ICollection<Manager> managers;
        private ICollection<Task> _tasks;
        public AllManagersDataTest()
        {
            
        }

        public ICollection<Manager> GetManagers()
        {
            ICollection<Manager> managers = new Collection<Manager>();
            Manager tempManager = new Manager(1, "Vova Pupkin");
            tempManager.Tasks = new Collection<Task>();
            Task tempTask = new Task(1, "Super Title", "Super descsription");
            tempManager.Tasks.Add(tempTask);
            tempTask = new Task(2, "Its simple!", "Just try add some tasks!");
            tempManager.Tasks.Add(tempTask);
            tempTask = new Task(3, "Oh no!", "Something was broken!");
            tempManager.Tasks.Add(tempTask);
            managers.Add(tempManager);

            tempManager = new Manager(2, "Olololo");
            tempManager.Tasks = new Collection<Task>();
            managers.Add(tempManager);

            tempManager = new Manager(3, "IronMan");
            tempManager.Tasks = new Collection<Task>();
            tempTask = new Task(4, "Shaurma time!", "Lets eat some shaurma. P.S. Tor'll get it after saving the World");
            tempManager.Tasks.Add(tempTask);
            managers.Add(tempManager);
            return managers;
        }

    }
}