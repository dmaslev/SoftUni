using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.BankOfKurtovoKonare
{
    interface IAccount
    {
        Customer Customer { get; set; }

        decimal Balance { get; set; }

        decimal InterestRate { get; set; }

        
    }
}
