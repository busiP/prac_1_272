using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace prac_1_272.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            return View();
        }

        //Action method for student list
        public ActionResult StudentList()
        {
            List<Models.students> students = new List<Models.students>();

            students.Add(new Models.students {StudentNum = "u12345678", Name = "Ben", Surname = "Jovi", Email = "benJ@gmail.com" });
            students.Add(new Models.students { StudentNum = "u23456789", Name = "Mary", Surname = "Jane", Email = "mJane@gmail.com" });
            students.Add(new Models.students { StudentNum = "u34567890", Name = "Austin", Surname = "Matinez", Email = "austinm123@gmail.com" });
            students.Add(new Models.students { StudentNum = "u2470478", Name = "James", Surname = "Bond", Email = "jb007@gmail.com" });
            students.Add(new Models.students { StudentNum = "u23691745", Name = "Mike", Surname = "Wazowski", Email = "mwazow@minc.com" });
            students.Add(new Models.students { StudentNum = "U22104789", Name = "Jenna", Surname = "Mackenzie", Email = "jmack@gmail.com" });

            return View(students);
        }
    }
}