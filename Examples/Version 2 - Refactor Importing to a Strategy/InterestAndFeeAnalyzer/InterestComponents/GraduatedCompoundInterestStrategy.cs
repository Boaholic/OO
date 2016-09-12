using System;

namespace InterestAndFeeAnalyzer.InterestComponents
{
    public class GraduatedCompoundInterestStrategy : IInterestStrategy
    {
        public GraduatedInterestTable InterestRates { get; set; }

        public int Calculate(BankAccount account)
        {
            if (account == null || account.Balance <= 0) return 0;

            double rate = InterestRates?.FindInterest(account.Balance) ?? 0;

            return Convert.ToInt32(Math.Round(account.Balance*rate, 0));
        }
    }
}
