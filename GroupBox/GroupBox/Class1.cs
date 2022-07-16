using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupBox
{
    internal class Bank
    {
        public int accountNo;
        public string firstName;
        public string lastName;
        public double amount;
        public double currentBalance;

        public Bank()
        {
           
        }
        public Bank(int accountNo,string firstName,string lastName,double amount, double currentBalance)
        {
            this.accountNo = accountNo;
            this.firstName = firstName; 
            this.lastName = lastName;
            this.amount = amount;   
            this.currentBalance = currentBalance;
            

        }


        public static List<Bank> Banks = new List<Bank>();

        public static void addCustomer(Bank bk)
        {
            Banks.Add(bk);
        }
        public static List<Bank> getAllCustomer() {
            return Banks;
        }

            
    }
}
