using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.IServices
{
    public interface IEmployeeService
    {
        Employee Create(Employee employee);
        Employee Update(int id, Employee employee, string departmentName);
        Employee Delete(Employee employee);
        Employee GetById(int id);
        Employee GetByAge(int age);
        Employee GetByName(string name);
        Employee GetBySurname(string surname);

        List<Employee> GetAll(string name);
        List<Employee> GetAll();
        List<Employee> GetByDepartmentId(int departmentId);
        List<Employee> GetByDepartmentName(Department departmentName);

        int GetAllEmployeeCount();
        int GetEmployeeCountByDepartment();
    }
}
