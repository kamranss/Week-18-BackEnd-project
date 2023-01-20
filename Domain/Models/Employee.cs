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
        public double Salary { get; set; }



        
        //public void ShofInfo()
        //{
        //    Console.ForegroundColor = ConsoleColor.Green;
        //    Console.WriteLine($"Id: {Id} || Name: {Name} || Salary: {Salary} || Department: {department} ");
        //    Console.ResetColor();
        //}
        
        
    }
}
