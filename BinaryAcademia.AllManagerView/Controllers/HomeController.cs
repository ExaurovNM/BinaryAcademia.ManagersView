using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BinaryAcademia.AllManagerView.Content;
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
            AllManagersDataTest testManagersData = new AllManagersDataTest();
       
            
            
            return View(testManagersData.GetManagers());
        }
    }
}
