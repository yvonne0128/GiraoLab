using GiraoLab.Services;
using GiraoLab.Models;
using Microsoft.AspNetCore.Mvc;

namespace GiraoLab.Controllers
{
    public class StudentController : Controller
    {
        private readonly IMyFakeDataService _dummyData;
        public StudentController(IMyFakeDataService dummyData)
            {
                _dummyData = dummyData;
            }

        public IActionResult Index()
        {

            return View(_dummyData.StudentList);
        }


     
        [HttpGet]
        public IActionResult ShowDetail(int id)
        {
            Student? student = _dummyData.StudentList.FirstOrDefault(st => st.Id == id);

            if (student != null)
                return View(student);

            return NotFound();
        }

        [HttpGet]
        public IActionResult DeleteStudent(int id)
        {
            Student? student = _dummyData.StudentList.FirstOrDefault(st => st.Id == id);

            if (student != null)
                return View(student);

            return NotFound();
        }

        [HttpGet]
        public IActionResult AddStudent()
        {
            return View();
        }


        [HttpPost]
        public IActionResult AddStudent(Student newStudent)
        {
            _dummyData.StudentList.Add(newStudent);
            return RedirectToAction("Index");
        }

        public IActionResult UpdateStudent(int id)
        {
            Student? student = _dummyData.StudentList.FirstOrDefault(st => st.Id == id);
            if (student != null)
                return View(student);

            return NotFound();
        }

        [HttpPost]
        public IActionResult UpdateStudent(Student studentChanges)
        {
            Student? student = _dummyData.StudentList.FirstOrDefault(st => st.Id == studentChanges.Id);
            if (student != null)
            {
                student.FirstName = studentChanges.FirstName;
                student.LastName = studentChanges.LastName;
                student.GPA = studentChanges.GPA;
                student.Email = studentChanges.Email;
                student.Course = studentChanges.Course;
                student.AdmissionDate = studentChanges.AdmissionDate;
            }

            return RedirectToAction("Index");
            
        
        }
            [HttpPost]
            public IActionResult DeleteStudent(Student newStudent)
            {
                Student? student = _dummyData.StudentList.FirstOrDefault(st => st.Id == newStudent.Id);

                if (student != null)
                    _dummyData.StudentList.Remove(student);
 
                return View("Index");
            }
    }

}


