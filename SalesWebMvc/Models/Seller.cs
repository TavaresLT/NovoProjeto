﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace SalesWebMvc.Models
{
    public class Seller
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime Date { get; set; }
        public double BaseSalary { get; set; }
        public Department Department { get; set; }
        public ICollection<SalesRecord> Sales { get; set; } = new List<SalesRecord> ();

        public Seller() 
        {
        
        }

        public Seller(int id, string name, string email, DateTime date, double baseSalary, Department department)
        {
            Id = id;
            Name = name;
            Email = email;
            Date = date;
            BaseSalary = baseSalary;
            Department = department;
        }

        public void AddSales(SalesRecord salesRecord) 
        {
            Sales.Add(salesRecord);
        }

        public void RemoveSales(SalesRecord salesRecord) 
        {
            Sales.Remove(salesRecord);
        }

        public double TotalSales(DateTime initial, DateTime final) 
        {
            return Sales.Where(x => x.Date >= initial && x.Date <= final).Sum(x => x.Amount);
        }
    }
}