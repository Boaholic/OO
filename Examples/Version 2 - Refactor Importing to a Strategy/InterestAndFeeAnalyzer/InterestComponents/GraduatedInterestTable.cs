using System.Collections.Generic;
using System.Linq;

namespace InterestAndFeeAnalyzer.InterestComponents
{
    public class GraduatedInterestTable : List<BalanceInterestPair>
    {
        public double FindInterest(int balance)
        {
            double rate = 0;
            for (int i = 0; i < Count && (balance >= this[i].Balance); i++)
                rate = this[i].Rate;
            return rate;
        }
    }
}
