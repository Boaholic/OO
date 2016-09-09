using System.Runtime.Serialization;

namespace InterestAndFeeAnalyzer
{
    [DataContract]
    public class SavingsAccount : BankAccount
    {
        [DataMember]
        public int MaxWithdrawalAmountPerMonth { get; set; }
    }
}
