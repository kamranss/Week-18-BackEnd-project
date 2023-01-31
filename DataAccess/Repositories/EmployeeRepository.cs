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
using Newtonsoft.Json.Linq;

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
            string filePath = @"C:\Users\kamra\Desktop\Files\Database.json";

            var jsonformatedEmployeeFromFile = File.ReadAllText(filePath);
            List<Employee> employeelist = new List<Employee>();
            employeelist = JsonConvert.DeserializeObject<List<Employee>>(jsonformatedEmployeeFromFile);
           
            // Checking whether the updating repository is working or not
            //employeelist.Add(employeelist);
            employeelist.Add(entity);
            var jsonFormatedEmployee = JsonConvert.SerializeObject(employeelist);
            //var jsonFormatedEmployee1 = JsonSerializer.Serialize(entity);
              

            if (System.IO.File.Exists(filePath) != false)
            {
                System.IO.File.WriteAllText(filePath, jsonFormatedEmployee);
            }
            else
            {
                System.IO.File.Delete(filePath);
            }

            if (jsonFormatedEmployee != null)
            {
                return true;
            }
            return false;
        }

        public bool Delete(Employee entity)
        {
            //string filePath = @"C:\Users\kamra\Desktop\Files\Database.json";

            //var jsonformatedEmployeeFromFile = File.ReadAllText(filePath);
            //List<Employee> employeelist = new List<Employee>();
            //employeelist = JsonConvert.DeserializeObject<List<Employee>>(jsonformatedEmployeeFromFile);



            //if (employeelist.Find(entity) != null)
            //{
            //    employeelist.Remove(entity);
            //    return employeelist;
            //}

            //var jsonFormatedEmployee = JsonConvert.SerializeObject(employeelist);
            //if (System.IO.File.Exists(filePath) != false)
            //{
            //    System.IO.File.WriteAllText(filePath, jsonFormatedEmployee);
            //}
            //else
            //{
            //    System.IO.File.Delete(filePath);
            //}

            //if (jsonFormatedEmployee != null)
            //{
            //    return true;
            //}
            return false;
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
