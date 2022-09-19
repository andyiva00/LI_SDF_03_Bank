// LinkedIN Learning Challenge
// Learning Path: Software Development Fundamentals
// Course: Learning C#
// Challenge: Bank
// Student: Andrey Ivanov

// Checking account class based on BankAccount

namespace BankClassChallenge
{
    public class CheckingAccount : BankAccount
    {
        // fields
        protected decimal OverdrawCharge = 35m;

        // methods
        public override void Withdraw(decimal amount)
        {
            Balance -= Balance < amount ? (amount + OverdrawCharge) : amount;
        }

        // constructor
        public CheckingAccount(string lastName, string firstName, decimal balance) : base(lastName, firstName, balance) { }
    }
}