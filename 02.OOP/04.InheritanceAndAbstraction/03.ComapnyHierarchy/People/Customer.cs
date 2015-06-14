using _03.ComapnyHierarchy.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.ComapnyHierarchy.People
{
    class Customer : Person, ICustomer
    {
        private decimal netSpendingAmount;


        public Customer(string id, string firstName, string lastName, decimal netSpendingAmount)
            : base(id, firstName, lastName)
        {
            this.NetSpendingAmount = netSpendingAmount;
        }

        public decimal NetSpendingAmount
        {
            get
            {
                return this.netSpendingAmount;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("netSpendingAmount", "The net spending amount cannot be negative.");
                }

                this.netSpendingAmount = value;
            }
        }

        public override string ToString()
        {
            string result = base.ToString();
            result += string.Format("Role: Customer\n");
            result += string.Format("Net Spending Amount: {0:c2}\n", this.NetSpendingAmount);
            return result;
        }
    }
}
