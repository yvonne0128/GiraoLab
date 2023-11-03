using System;
using GiraoLab.Models;


namespace GiraoLab.Services
{
    public class MyFakeDataService : IMyFakeDataService
    {
        public List<Student> StudentList { get; }

        public MyFakeDataService() // constructor
        {
            StudentList = new List<Student>
            {
                new Student()
            {
                Id = 1,
                FirstName = "Patricia Yvonne",
                LastName = "Girao",
                Course = Course.BSIT,
                AdmissionDate = DateTime.Parse("2023-01-21"),
                GPA = 1.5,
                Email = "yvonne.girao@gmail.com"
            },
                new Student()
                {
                    Id = 2,
                    FirstName = "Roxanne Alyssandra",
                    LastName = "Debil",
                    Course = Course.BSIT,
                    AdmissionDate = DateTime.Parse("2022-02-22"),
                    GPA = 1,
                    Email = "roxanne.debil@gmail.com"
                },
                new Student()
                {
                    Id = 3,
                    FirstName = "Charlene",
                    LastName = "Arlante",
                    Course = Course.BSCS,
                    AdmissionDate = DateTime.Parse("2021-03-23"),
                    GPA = 1.5,
                    Email = "charlene.arlante@gmail.com"
                },
                new Student()
                {
                    Id = 4,
                    FirstName = "Gabrielle Joanna Marie",
                    LastName = "Belgar",
                    Course = Course.BSCS,
                    AdmissionDate = DateTime.Parse("2020-04-24"),
                    GPA = 1.5,
                    Email = "gabrielle.belgar@gmail.com"
                }
            
            };
        }
    }
}
