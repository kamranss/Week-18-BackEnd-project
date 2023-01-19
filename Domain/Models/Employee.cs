﻿using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class Employee : IBaseInterface
    {
        public int? Id { get ; set ; }
        public string Name { get; set; }
        public decimal Salary { get; set; }
        Department department;

        public void ShofInfo()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Id: {Id} || Name: {Name} || Salary: {Salary} || Department: {department} ");
            Console.ResetColor();
        }
    }
}