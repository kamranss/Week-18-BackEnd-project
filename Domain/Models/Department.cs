using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class Department : IBaseInterface
    {
        public int? Id { get ; set; }
        public string Name { get; set; }
        public int Capacity { get; set; }
        //List<Employee> EmployeeList { get; set; }
    }
}
