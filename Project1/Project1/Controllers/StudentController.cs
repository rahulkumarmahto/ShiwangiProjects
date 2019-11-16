using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Project1.Models;

namespace Project1.Controllers
{
    public class StudentController : Controller
    {
        List<Student> students = new List<Student>();

        public StudentController()
        {

            Student s1 = new Student() { ID = 1, Age = 20, Email = "Shiwangi@gmail.com", Name = "Shiwangi" };
            Student s2 = new Student() { ID = 2, Age = 22, Email = "Shiwangi2@gmail.com", Name = "Shiwangi2" };
            Student s3 = new Student() { ID = 3, Age = 23, Email = "Shiwangi3@gmail.com", Name = "Shiwangi3" };
            Student s4 = new Student() { ID = 4, Age = 24, Email = "Shiwangi4@gmail.com", Name = "Shiwangi4" };
            Student s5 = new Student() { ID = 5, Age = 25, Email = "Shiwangi5@gmail.com", Name = "Shiwangi5" };
            students.Add(s1);
            students.Add(s2);
            students.Add(s3);
            students.Add(s4);
            students.Add(s5);
        }
        public IActionResult ShowStudentData(string name)
        {
            string message = "Welcome to the world of ASP.NET Core application";
            ViewBag.ShiwangiMessage = $"Dear {name}, {message}";
            return View();
        }


        public IActionResult Sample()
        {
            return View(students);
        }
        public IActionResult SearchStudentByName(string name)
        {
            var studentFounds = students.Where(s => s.Name.ToLower().Contains(name.ToLower()));
            return View("Sample", studentFounds);
        }

        public IActionResult Details(int id)
        {
            var studentFounds = students.Where(s => s.ID==id).FirstOrDefault();
            return View(studentFounds);
        }
    }
}