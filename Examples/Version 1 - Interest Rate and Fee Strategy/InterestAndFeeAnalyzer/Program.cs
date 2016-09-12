using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterestAndFeeAnalyzer
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            CreateTestData();

            Application.Run(new MainForm());
        }

        private static void CreateTestData()
        {
            Random ran = new Random();
            BankAccountSet set = new BankAccountSet();
            for (int nextAccountNumber = 0; nextAccountNumber < 100; nextAccountNumber++)
            {
                BankAccount account;
                if (ran.NextDouble() < .5)
                    account = new CheckingAccount()
                    {
                        AccountNumber = "C" + nextAccountNumber.ToString().PadLeft(5, '0'),
                        Balance = ran.Next(0, 100000),
                        MaxChecksPerMonth = ran.Next(10, 200)
                    };
                else
                    account = new SavingsAccount()
                    {
                        AccountNumber = "S" + nextAccountNumber.ToString().PadLeft(5, '0'),
                        Balance = ran.Next(1000, 1000000),
                        MaxWithdrawalAmountPerMonth = ran.Next(100000, 1000000)
                    };
                set.Add(account);
            }
            set.SaveToXml("Test.xml");
        }
    }
}
