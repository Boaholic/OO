namespace InterestAndFeeAnalyzer.FeeComponents
{
    public class GraduatedFeeStrategy : IFeeStrategy
    {
        public GraduatedFeeTable Fees { get; set; }

        public int Calculate(BankAccount account)
        {
            if (account == null || account.Balance <= 0) return 0;

            return Fees?.FindFee(account.Balance) ?? 0;
        }
    }
}
