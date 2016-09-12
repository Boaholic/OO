using System;

namespace InterestAndFeeAnalyzer.FeeComponents
{
    public class FlatFeeStrategy :IFeeStrategy
    {
        public int FlatFee { get; set; }

        public int Calculate(BankAccount account)
        {
            return FlatFee;
        }
    }
}
