using DataAccess.Interfaces;
using Domain.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Text.Json;
using System.Threading.Tasks;
using JsonSerializer = Newtonsoft.Json.JsonSerializer;

namespace DataAccess.Repositories
{

         
    public class EmployeeRepository : IRepositroy<Employee>
    {
        public int Count()
        {
            throw new NotImplementedException();
        }

        public bool Create(Employee entity)
        {
            
            Employee employee1 = new Employee();
            employee1.Name = "alma";
            employee1.Salary = 39833;

            List<Employee> employees = new List<Employee>();
            employees.Add(entity);
            employees.Add(employee1);

            var jsonFormatedEmployee = JsonConvert.SerializeObject(employees);
            //var jsonFormatedEmployee1 = JsonSerializer.Serialize(entity);
              

            string fileName = @"C:\Users\kamra\Desktop\Files\Database.json";

            if (System.IO.File.Exists(fileName) != false)
            {
                System.IO.File.WriteAllText(fileName, jsonFormatedEmployee);
            }
            else
            {
                System.IO.File.Delete(fileName);
            }

            if (jsonFormatedEmployee != null)
            {
                return true;
            }
            return false;
        }

        public bool Delete(Employee entity)
        {
            throw new NotImplementedException();
        }

        public Employee Get(Predicate<Employee> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Employee> GetAll(Predicate<Employee> filter = null)
        {
            throw new NotImplementedException();
        }

        public bool Update(Employee entity)
        {
            throw new NotImplementedException();
        }
    }
}
