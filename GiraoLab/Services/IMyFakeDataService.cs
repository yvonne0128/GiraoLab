using System;
using GiraoLab.Models;


namespace GiraoLab.Services
{
    public interface IMyFakeDataService
    { 
        List<Student> StudentList { get; }
    }
}
