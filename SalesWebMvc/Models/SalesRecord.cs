using System;
using SalesWebMvc.Models.Enums;

namespace SalesWebMvc.Models
{
    public class SalesRecord
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public double Amount { get; set; }
        public SaleStatus Status { get; set; }
        public int MyProperty { get; set; }
        public Seller Sellers { get; set; }

        public SalesRecord() 
        {
        
        }

        public SalesRecord(int id, DateTime date, double amount, SaleStatus status, int myProperty, Seller sellers)
        {
            Id = id;
            Date = date;
            Amount = amount;
            Status = status;
            MyProperty = myProperty;
            Sellers = sellers;
        }
    }
}
