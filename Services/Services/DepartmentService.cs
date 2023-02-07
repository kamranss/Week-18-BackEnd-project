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
            try
            {
                Department updatedepartment = departmentRepository.Get(e => e.Id == department.Id);
                if (updatedepartment != null)
                {
                    departmentRepository.Update(updatedepartment);
                    return updatedepartment;
                }
                return null;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public Department Delete(int Id)
        {
            try
            {
                Department tempDepartment = departmentRepository.Get(d => d.Id == Id);
                if (tempDepartment != null)
                {
                    departmentRepository.Delete(tempDepartment);
                    return tempDepartment;
                }
                return null;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public Department Get(int id)
        {
            try
            {
                if (true)
                {
                    Department department = departmentRepository.Get(d => d.Id == id);
                    return department;
                }
                return null;
            }

            catch (Exception)
            {
                return null;
            }
        }

        public Department Get(string name)
        {
            try
            {
                Department department = departmentRepository.Get(d => d.Name.ToLower() == name.ToLower());
                return department != null ? department : null;
            }
            catch (Exception)
            {

                return null;
            }
        }

        public List<Department> GetAllByName(string name)
        {
            try
            {
                List<Department> tempdepartment = departmentRepository.GetAll(d => d.Name == name);
                return tempdepartment;
            }
            catch (Exception)
            {

                return null;
            }
        }

        public List<Department> GetALL()
        {
            try
            {
                List<Department> departments = departmentRepository.GetAll();
                return departments;
            }
            catch (Exception)
            {

                return null;
            }
        }

        public List<Department> GetAllByCapacity(int capacity)
        {
            try
            {
                List<Department> department = departmentRepository.GetAll(d => d.Capacity == capacity);
                return department;
            }
            catch (Exception)
            {

                return null;
            }
        }
    }
}
