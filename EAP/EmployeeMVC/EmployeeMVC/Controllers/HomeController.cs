using EmployeeMVC.localhost;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EmployeeMVC.Controllers
{

    public class HomeController : Controller
    {

        localhost.Service1 ls = new localhost.Service1();
        public ActionResult Index()
        {
            //lay list tu data de hien thi len view
            return View(ls.GetEmployees());
        }

        [HttpPost]
        public ActionResult Index(String id)
        {
            List<tbEmployee> list = new List<tbEmployee>();
            if (!string.IsNullOrEmpty(id))
            {
                tbEmployee e = ls.SearchEmployees(id);
                if (e != null)
                {
                    list.Add(e);
                }
                
            }
            return View(list);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(tbEmployee e)
        {
            e.EmployeeSalarySpecified = true;
            ls.AddEmployees(e);
            return RedirectToAction("Index", ls.GetEmployees());
        }
    }
}