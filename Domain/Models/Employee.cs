using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class Employee : IBaseInterface
    {
        public int? Id { get ; set ; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public DateTime Created { get; set; }
        public DateTime Birthday { get; set; }
        public DateTime hireDateTime { get; set; }
        public bool beenInMilitary { get; set; }

        public int Age { get; set; }
        public string Address { get; set; }
        public Department Department { get; set; }
        public double Salary { get; set; }

        



        
        //public void ShofInfo()
        //{
        //    Console.ForegroundColor = ConsoleColor.Green;
        //    Console.WriteLine($"Id: {Id} || Name: {Name} || Salary: {Salary} || Department: {department} ");
        //    Console.ResetColor();
        //}
        
        
    }
}
