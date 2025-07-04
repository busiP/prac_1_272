using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace prac_1_272.Controllers
{
    public class StudentController : Controller
    {
        //STEP 2: CREATE CONTROLLER
        // GET: Student
        public ActionResult Index()
        {
            return View();
        }

        //Action method for student list
        public ActionResult StudentList() //right click "StudentList" and add view
        {
            List<Models.students> students = new List<Models.students>();//create list of students, using model properties

            //add individual students
            students.Add(new Models.students {StudentNum = "u12345678", Name = "Ben", Surname = "Jovi", Email = "benJ@gmail.com", myLink = "~/HTML/person1.html"});
            students.Add(new Models.students { StudentNum = "u23456789", Name = "Mary", Surname = "Jane", Email = "mJane@gmail.com", myLink = "~/HTML/person2.html" });
            students.Add(new Models.students { StudentNum = "u34567890", Name = "Austin", Surname = "Matinez", Email = "austinm123@gmail.com", myLink = "~/HTML/person3.html" });
            students.Add(new Models.students { StudentNum = "u2470478", Name = "James", Surname = "Bond", Email = "jb007@gmail.com", myLink = "~/HTML/person4.html" });
            students.Add(new Models.students { StudentNum = "u23691745", Name = "Mike", Surname = "Wazowski", Email = "mwazow@minc.com" , myLink = "~/HTML/person5.html" });

           
            return View(students);
        }
    }
}