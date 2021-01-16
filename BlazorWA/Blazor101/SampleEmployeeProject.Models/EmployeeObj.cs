using System;
namespace SampleEmployeeProject.Models
{
    public class EmployeeObj
    {
        public int EmpId { get; set; }
        public string FirstName { get; set; }
        public string Email { get; set; }
        public DateTime DateofBirth { get; set; }
        public Gender Gender { get; set; }
        public Department Department { get; set; }
        public string PhotoPath { get; set; }
        public EmployeeObj()
        {
        }
    }
}
