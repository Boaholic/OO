using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterestAndFeeAnalyzer.FeeComponents
{
    public interface IFeeStrategy
    {
        int Calculate(BankAccount account);
    }
}
