using CIS174AssignmentsApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace CIS174AssignmentsApp.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Assignments(int accessLevel)
        {
            var students = new List<Student>();
            {
                new Student() { FirstName = "Steph", LastName = "Sink", Grade = 6 };
                new Student() { FirstName = "Kate", LastName = "Linkenmeyer", Grade = 7 };
                new Student() { FirstName = "Emily", LastName = "Woodruff", Grade = 8 };
                new Student() { FirstName = "Bailey", LastName = "Hills", Grade = 9 };
            }

            var viewModel = new Assignment6
            {
                Students = students,
                AccessLevel = accessLevel
            };

            return View();
        }
    }
}
