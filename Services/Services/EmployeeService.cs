﻿using DataAccess.Repositories;
using Domain.Models;
using Services.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Services
{
    public class EmployeeService : IEmployeeService
    {
         private readonly EmployeeRepository employeeRepository;
        private readonly DepartmentService departmentService;
        private static int Id { get; set; }
        public EmployeeService()
        {
            employeeRepository = new EmployeeRepository();
            departmentService = new DepartmentService();
        }
        public Employee Create(Employee employee, string departmentName)
        {
            if (employeeRepository.Create(employee))
            {
                Id++;
                employee.Id = Id;
                return employee;
            }
            return null;
        }
    }
}