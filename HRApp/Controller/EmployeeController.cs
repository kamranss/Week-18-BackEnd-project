using Domain.Models;
using Services.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilities.Helpers;

namespace HRApp.Controller
{
    public class EmployeeController
    {
        EmployeeService employeeService;

        public EmployeeController()
        {
            employeeService = new EmployeeService();
        }

        public void CreateEmployee()
        {
            Helper.consolemessage(ConsoleColor.Green, ConsoleMessages.writeEmployeeName);
            string name = Console.ReadLine();
          
            writeEmployeeAge: Helper.consolemessage(ConsoleColor.Cyan, ConsoleMessages.writeEmployeSalary);
            string selectedSalary = Console.ReadLine();
            double salary;
            bool checkSalary = double.TryParse(selectedSalary, out salary);

            if (checkSalary)
            {
                Employee newemployee = new Employee();
                newemployee.Name = name;
                newemployee.Salary = salary;
                Employee employee = employeeService.Create(newemployee);

                    Helper.consolemessage(ConsoleColor.Blue,
                    $"Following Employee Created\n " +
                    $"{newemployee.Id} " +
                    $"{newemployee.Name}  " +
                    $"{newemployee.Salary}");
            }

        
           
        }


    }
}
