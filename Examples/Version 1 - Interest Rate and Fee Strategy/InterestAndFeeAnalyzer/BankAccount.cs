using System.Runtime.Serialization;

namespace InterestAndFeeAnalyzer
{
    [DataContract]
    public class BankAccount
    {
        [DataMember]
        public string AccountNumber { get; set; }
        /*
        Note: the above property is equalivant to
        private string _accountNumber;
        public string getAccountNumber() { return _accountNumber; }
        public void setAccountNumber(string value) { _accountNumber = value; }
        */

        [DataMember]
        public int Balance { get; set; }
    }
}
