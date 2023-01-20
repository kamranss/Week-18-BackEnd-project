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
    public class DepartmentRepositroy : IRepositroy<Department>
    {
        public int Count()
        {
            throw new NotImplementedException();
        }

        public bool Create(Department entity)
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

        public bool Delete(Department entity)
        {
            throw new NotImplementedException();
        }

        public Department Get(Predicate<Department> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Department> GetAll(Predicate<Department> filter = null)
        {
            throw new NotImplementedException();
        }

        public bool Update(Department entity)
        {
            throw new NotImplementedException();
        }
    }
}
