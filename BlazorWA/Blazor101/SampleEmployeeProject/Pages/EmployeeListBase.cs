using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using SampleEmployeeProject.Models;

namespace SampleEmployeeProject.Pages
{
    public class EmployeeListBase: ComponentBase
    {
        public IEnumerable<EmployeeObj> EmployeeList { get; set; }


        public EmployeeListBase()
        {
        }

        protected override Task OnInitializedAsync()
        {
            LoadEmployees();
            return base.OnInitializedAsync();
        }

        private void LoadEmployees()
        {
            EmployeeObj e1 = new  EmployeeObj{EmpId = 1,
            DateofBirth = new DateTime(1995,04,10),
            Email = "aravind@gmail.com",
            Gender = Gender.Male,
            FirstName = "Aravind",
            Department = new Department{DeptId = 2},
            PhotoPath = "images/aravind.jpg"
            };
            
            EmployeeObj e2 = new  EmployeeObj{EmpId = 2,
                DateofBirth = new DateTime(1995,11,25),
                Email = "ram@gmail.com",
                Gender = Gender.Male,
                FirstName = "Ram",
                Department = new Department{DeptId = 1},
                PhotoPath = "images/ram.jpg"
            };
            
            EmployeeList = new List<EmployeeObj> {e1, e2};

        }



    }
}
