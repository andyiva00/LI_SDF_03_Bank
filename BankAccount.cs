// LinkedIN Learning Challenge
// Learning Path: Software Development Fundamentals
// Course: Learning C#
// Challenge: Bank
// Student: Andrey Ivanov

// Basic banking account class

namespace BankClassChallenge
{
    public class BankAccount
    {
        // fields
        public string AccountOwner;
        public decimal Balance;
        
        // methods
        public void Deposit(decimal amount)
        {
            Balance += amount;
        }

        public virtual void Withdraw(decimal amount)
        {
            Balance -= amount;
        }

        // constructor
        public BankAccount(string lastName, string firstName, decimal balance)
        {
            AccountOwner = firstName + " " + lastName;
            Balance = balance;
        }

    }
}