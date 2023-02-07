using DataAccess.Repositories;
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

      
        public Employee Create(Employee employee)
        {
            Id++;
            employee.Id = Id;
            if (employeeRepository.Create(employee))
            {
                return employee;
            }
            return null;
        }

        public Employee Update(int id, Employee employee, string departmentName)
        {
            Employee updatedemployee = employeeRepository.Get(e => e.Id == id);
            if (updatedemployee != null)
            {
                Department department = departmentService.Get(departmentName);
                if (department != null)
                {
                    updatedemployee.Name = employee.Name;
                    updatedemployee.Surname = employee.Surname;
                    updatedemployee.Age = employee.Age;
                    updatedemployee.Address = employee.Address;
                    updatedemployee.Department = department;
                    employeeRepository.Update(updatedemployee);
                    return updatedemployee;
                }
                return null;
            }
            return null;
        }

        public Employee Delete(Employee employee)
        {
            throw new NotImplementedException();
        }

        public Employee GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Employee GetByAge(int age)
        {
            throw new NotImplementedException();
        }

        public Employee GetByName(string name)
        {
            throw new NotImplementedException();
        }

        public Employee GetBySurname(string surname)
        {
            throw new NotImplementedException();
        }

        public List<Employee> GetAll(string name)
        {
            throw new NotImplementedException();
        }

        public List<Employee> GetAll()
        {
            throw new NotImplementedException();
        }

        public List<Employee> GetByDepartmentId(int departmentId)
        {
            throw new NotImplementedException();
        }

        public List<Employee> GetByDepartmentName(Department departmentName)
        {
            throw new NotImplementedException();
        }

        public int GetAllEmployeeCount()
        {
            throw new NotImplementedException();
        }

        public int GetEmployeeCountByDepartment()
        {
            throw new NotImplementedException();
        }
    }
}
