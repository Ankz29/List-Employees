using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EmployeeDemo.Models;


namespace EmployeeDemo.Controllers
{
    public class EmployeeController : Controller
    {
        //
        // GET: /Employee/
        public ActionResult Index()
        {
            List<Employee> model = new List<Employee>()
               {
                   new Employee{
                       EmpName = "ankita",
                       EmpId = 001,
                       Emp_Email = "ankita@gmail.com",
                       Gender = " female",
                       Emp_City = " belagavi"
                   },
                   new Employee{
                       EmpName = "anisha",
                       EmpId = 002,
                       Emp_Email = "anisha@gmail.com",
                       Gender = " female",
                       Emp_City = " belagavi"
                   },
                   
               };
            return View(model);

        }
    }
}