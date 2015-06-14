using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.BankOfKurtovoKonare
{
    abstract class BasicAccount : IAccount
    {
        private Customer customer;
        private decimal balance;
        private decimal interestRate;

        protected BasicAccount(Customer customer, decimal balance, decimal interestRate)
        {
            this.Customer = customer;
            this.Balance = balance;
            this.InterestRate = interestRate;
        }

        public Customer Customer { get; set; }
        public decimal Balance
        {
            get
            {
                return this.balance;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("balance", "The balance cannot be negative!");
                }

                this.balance = value;
            }
        }

        public decimal InterestRate
        {
            get
            {
                return this.interestRate;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("interestRate", "The interest rate cannot be negative!");
                }

                this.interestRate = value;
            }
        }


        public void DepositMoney(decimal money)
        {
            this.Balance += money;
        }

        public abstract decimal CalculateInterest(int months);
    }
}
