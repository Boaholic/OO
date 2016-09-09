using System.Collections.Generic;
using System.Linq;

namespace InterestAndFeeAnalyzer.FeeComponents
{
    public class GraduatedFeeTable : List<BalanceFeePair>
    {
        public int FindFee(int balance)
        {
            int rate = 0;
            for (int i = 0; i < Count && (balance >= this[i].Balance); i++)
                rate = this[i].Fee;
            return rate;

        }
    }
}
