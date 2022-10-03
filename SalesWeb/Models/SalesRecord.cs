using SalesWeb.Models.Enums;
using System;

namespace SalesWeb.Models
{
    public class SalesRecord
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public double Amount { get; set; }
        public SalesStatus Satatus { get; set; }
        public Seller Seller { get; set; }

        public SalesRecord()
        {

        }

        public SalesRecord(int id, DateTime date, double amount, SalesStatus satatus, Seller seller)
        {
            Id = id;
            Date = date;
            Amount = amount;
            Satatus = satatus;
            Seller = seller;
        }
    }
}
