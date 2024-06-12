using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw_22._05
{
    public interface ITransaction
    {
        string TransactionId { get; set; }
        double Amount { get; set; }
        Dates Date { get; set; }
    }
}
