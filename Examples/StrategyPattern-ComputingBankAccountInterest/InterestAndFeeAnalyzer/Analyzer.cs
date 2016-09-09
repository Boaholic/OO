using InterestAndFeeAnalyzer.InterestComponents;
using InterestAndFeeAnalyzer.FeeComponents;

namespace InterestAndFeeAnalyzer
{
    public class Analyzer
    {

        public string InputFileName { get; set; }
        public IInterestStrategy InterestStrategy { get; set; }
        public IFeeStrategy FeeStrategy { get; set; }
        public int NumberOfPeriods { get; set; }
        public int BeginningTotal { get; private set; }
        public int EndingTotal { get; private set; }
        public int InterestPaid { get;  private set; }
        public int FeesCollected { get; private set; }

        public void Run()
        {
            BeginningTotal = 0;
            EndingTotal = 0;
            InterestPaid = 0;
            FeesCollected = 0;

            // Create BankAccountSet from file
            BankAccountSet bankAccountSet = new BankAccountSet();
            bankAccountSet.LoadFromXml(InputFileName);

            // Compute beginning balance
            foreach (BankAccount bankAccount in bankAccountSet)
                BeginningTotal += bankAccount.Balance;

            // Foreach account compute fees and interest
            foreach (BankAccount bankAccount in bankAccountSet)
            {
                int interest = InterestStrategy?.Calculate(bankAccount) ?? 0;
                bankAccount.Balance += interest;
                InterestPaid += interest;

                int fee = FeeStrategy?.Calculate(bankAccount) ?? 0;
                bankAccount.Balance -= fee;
                FeesCollected += fee;
            }

            // Compute beginning balance
            foreach (BankAccount bankAccount in bankAccountSet)
                EndingTotal += bankAccount.Balance;
        }

    }
}
