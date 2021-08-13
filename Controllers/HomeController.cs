using Dynamic_Model_to_View_Multiple_Model_in_Single_View.Models;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Dynamic_Model_to_View_Multiple_Model_in_Single_View;

namespace Dynamic_Model_to_View_Multiple_Model_in_Single_View.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var student = GetStudent();
            var employee = GetEmployee();

            dynamic model = new ExpandoObject();
            model.Employees = employee;
            model.Student = student;


            return View(model);
        }

        private List<Student> GetStudent()
        {
            return new List<Student>
            {
                new Student(){Name="Udit", Email="udit@gmai.com"},
                new Student(){Name="Singh", Email="singh@gmai.com"}
            };
        }
        
        private List<Employee> GetEmployee()
        {
            return new List<Employee>
            {
                new Employee(){Name="Udit", Email="udit@gmai.com"},
                new Employee(){Name="Singh", Email="singh@gmai.com"}

            };
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}