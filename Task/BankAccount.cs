using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    class BankAccount<T>
    {
        T accountNumber;
        double accountBalance;
        string accountFullName;

        public BankAccount()
        { }
        public BankAccount(T AccountNumber, string AccountFullName, double AccountBalance)
        {
            accountNumber = AccountNumber;
            accountFullName = AccountFullName;
            accountBalance = AccountBalance;
        }
        public void setAccNumber(T AccNumber)
        {
            this.accountNumber = AccNumber;
        }
        public T getAccNumber()
        {
            return accountNumber;
        }
        public void setAccBalance(double AccBalance)
        {
            this.accountBalance = AccBalance;
        }
        public double getAccBalance()
        {
            return accountBalance;
        }
        public void setAccName(string AccFullName)
        {
            this.accountFullName = AccFullName;
        }
        public string getAccName()
        {
            return accountFullName;
        }
        public string GetInfo()
        {
            return $"Номер акканта: {accountNumber} / ФИО: {accountFullName} / Баланс : {accountBalance}";
        }
    }
}
