using DataAccess.Interfaces;
using Domain.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            var jsonFormatedEmployee = JsonConvert.SerializeObject(entity);

            string fileName = @"C:\Users\kamra\Desktop\Files\Databse.json";
            if (System.IO.File.Exists(fileName) == false)
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
