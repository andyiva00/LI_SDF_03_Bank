// LinkedIN Learning Challenge
// Learning Path: Software Development Fundamentals
// Course: Learning C#
// Challenge: Bank
// Student: Andrey Ivanov

// Saving account class based on BankAccount

namespace BankClassChallenge
{
    public class SavingAccount : BankAccount
    {
        // fields
        protected decimal Interest;
        protected decimal FreeWithdrawCount;
        protected decimal AdditionalWithdrawCharge;

        // methods
        public override void Withdraw(decimal amount)
        {
            if (Balance >= amount && FreeWithdrawCount > 0
                || Balance - AdditionalWithdrawCharge >= amount && FreeWithdrawCount == 0)
            {                
                if (FreeWithdrawCount == 0)
                {
                    Console.WriteLine("More than 3 withdrawals - extra charge");
                    Balance -= AdditionalWithdrawCharge;
                }
                FreeWithdrawCount--;
                FreeWithdrawCount = Math.Max(FreeWithdrawCount, 0);
                
                base.Withdraw(amount);
            }
            else
            {
                Console.WriteLine("Attempt to overdraw saving - denied");
            }
        }

        public void ApplyInterest()
        {
            Balance *= 1 + Interest;
        }

        // constructor
        public SavingAccount(string lastName, string firstName, decimal interest, decimal balance) : base(lastName, firstName, balance)
        {
            Interest = interest;
            FreeWithdrawCount = 3m;
            AdditionalWithdrawCharge = 2m;
        }
    }
}