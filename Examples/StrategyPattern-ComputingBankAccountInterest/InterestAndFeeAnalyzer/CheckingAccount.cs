using System.Runtime.Serialization;

namespace InterestAndFeeAnalyzer
{
    [DataContract]
    public class CheckingAccount : BankAccount
    {
        [DataMember]
        public int MaxChecksPerMonth { get; set; }
    }
}
