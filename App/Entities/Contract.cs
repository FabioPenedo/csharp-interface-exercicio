﻿using System.Globalization;
using System.Text;

namespace App.Entities
{
    internal class Contract
    {
        public int Number { get; private set; }
        public DateTime Date { get; private set; }
        public double TotalValue { get; private set; }
        public List<Installment> Installments { get; private set; } = [];

        public Contract(int number, DateTime date, double totalValue)
        {
            Number = number;
            Date = date;
            TotalValue = totalValue;
        }
        public void AddInstallment(Installment installment)
        {
            Installments.Add(installment);
        }
        public override string ToString()
        {
            StringBuilder sb = new();
            foreach (Installment item in Installments)
            {
                sb.AppendLine(item.ToString());  
            }
            return sb.ToString();
        }
    }
}
