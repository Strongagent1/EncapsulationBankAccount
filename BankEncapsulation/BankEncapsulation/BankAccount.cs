using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankEncapsulation
{
    public class BankAccount
    {
        public BankAccount()
        {

        }
        private double balance = 200;
        public void Deposit(double depositAmount)
        {
            

            balance += depositAmount;
            
        }
        public double GetBalance()
        {
            return balance;
            
        }
    }
}
