using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BinaryAcademia.AllManagerView.Models;


namespace BinaryAcademia.AllManagerView.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
           
            return View();
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult AllManagersWithTasks()
        {

            //Create some customize managers and tasks for testing AllManagerWithTasks View

            Task tempTask = new Task(1, "Super Title", "Super descsription");
            Manager tempManager = new Manager(1, "Vova Pupkin");
            tempManager.Tasks = new Collection<Task>();
            tempManager.Tasks.Add(tempTask);
            ICollection<Manager> managers = new Collection<Manager>();
            managers.Add(tempManager);
            tempManager = new Manager(2, "Ololsha");
            tempManager.Tasks = new Collection<Task>();
            managers.Add(tempManager);
            ViewBag.Managers = managers;
            
            
            return View(managers);
        }
    }
}
