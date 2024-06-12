using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw_22._05
{
    public class Transaction : ITransaction
    {
        public string TransactionId { get; set; }
        public double Amount { get; set; }
        public Dates Date { get; set; }
        public Transaction(string TransictionId, double Amount, Dates Date) 
        {
            this.TransactionId = TransictionId;
            this.Amount = Amount;
            this.Date = Date;
        }
    }
}
