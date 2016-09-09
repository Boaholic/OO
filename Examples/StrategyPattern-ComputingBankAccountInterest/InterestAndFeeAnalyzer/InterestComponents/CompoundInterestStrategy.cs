using System;

namespace InterestAndFeeAnalyzer.InterestComponents
{
    public class CompoundInterestStrategy : IInterestStrategy
    {
        public double Rate { get; set; }
        public int Calculate(BankAccount account)
        {
            return (account == null || account.Balance <= 0) ? 0 :
                    Convert.ToInt32(Math.Round(account.Balance*Rate, 0));
        }
    }
}
