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
    public class DepartmentService : IDepartmentService
    {
        private readonly DepartmentRepositroy departmentRepository;
        public static int Id { get; set; } = 1;
        public DepartmentService()
        {
            departmentRepository = new DepartmentRepositroy();
        }

        public Department Create(Department department)
        {
            try
            {
                Department tempdepartment = departmentRepository.Get(d => d.Name.ToLower() == department.Name.ToLower());
                if (tempdepartment == null)
                {
                    department.Id = Id;
                    if (departmentRepository.Create(department))
                    {
                        Id++;
                        return department;
                    }
                    return null;
                }
                return null;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Department Update(Department department, int id)
        {
            throw new NotImplementedException();
        }

        public Department Delete(int Id)
        {
            throw new NotImplementedException();
        }

        public Department Get(int id)
        {
            throw new NotImplementedException();
        }

        public Department Get(string name)
        {
            throw new NotImplementedException();
        }

        public List<Department> GetAllByName(string name)
        {
            throw new NotImplementedException();
        }

        public List<Department> GetALL()
        {
            throw new NotImplementedException();
        }

        public List<Department> GetAllByCapacity(int capacity)
        {
            throw new NotImplementedException();
        }
    }
}
