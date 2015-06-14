using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.BankOfKurtovoKonare
{
    class BankOfKurtovoKonare
    {
        static void Main()
        {
            DepositAccount deposit = new DepositAccount(Customer.Company, 2206, 1.06m);
            deposit.DepositMoney(2145);
            deposit.Withdraw(123);
            Console.WriteLine(deposit.CalculateInterest(6));

            LoanAccount loan = new LoanAccount(Customer.Individual, 10000, 1.1111m);
            loan.DepositMoney(1111);
            Console.WriteLine(loan.CalculateInterest(6));

            MortgageAccount mortgage = new MortgageAccount(Customer.Individual, 10, 2);
            mortgage.DepositMoney(2);
            Console.WriteLine(mortgage.CalculateInterest(7));
        }
    }
}
