using System;

namespace BankingApp
{
    public class BankAccount
    {
        private string accountNumber = String.Empty;
        private string accountName = String.Empty;
        private BankType bankType = BankType.Public;
        private double balance = 0.0;
        private double maxCredit = 1000.0;

        private bool isAccountNumberSet = false;
        private bool isBankTypeSet = false;

        public BankAccount()
        {
        }

        public BankAccount(string accountNumber, string accountName)
        {
            this.accountNumber = accountNumber;
            isAccountNumberSet = true;
            this.accountName = accountName;
        }

        public void SetAccountNumber(string accountNumber)
        {
            if (!isAccountNumberSet)
            {
                this.accountNumber = accountNumber;
                isAccountNumberSet = true;
            }
        }

        public void SetAccountName(string accountName)
        {
            this.accountName = accountName;
        }

        public void SetBankType(BankType bankType)
        {
            if (!isBankTypeSet)
            {
                this.bankType = bankType;
                isBankTypeSet = true;
            }
        }

        public string GetInfo()
        {
            return $"{this.accountNumber} belongs to {this.accountName} at {this.bankType}";
        }

        public void SetMaxCredit(double maxCredit)
        {
            this.maxCredit = maxCredit;
        }

        public bool WithDraw(double amount)
        {
            double newBalance = this.balance - amount;
            if (newBalance >= -maxCredit)
            {
                balance = newBalance;
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Deposit(double amount)
        {
            this.balance = this.balance + amount;
        }

        public double GetBalance()
        {
            return balance;
        }
    }
}
