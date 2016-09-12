using System;
using System.IO;
using System.Windows.Forms;
using InterestAndFeeAnalyzer.FeeComponents;
using InterestAndFeeAnalyzer.InterestComponents;

namespace InterestAndFeeAnalyzer
{
    public partial class MainForm : Form
    {
        public GraduatedInterestTable InterestTable { get; set; }
        public MainForm()
        {
            InitializeComponent();
            AdjustControlVisibility(null, null);
        }

        private void browseButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog
            {
                DefaultExt = "txt",
                Filter = @"XML files (*.xml)|*.xml",
                Multiselect = false
            };
            DialogResult result = dlg.ShowDialog();

            if (result == DialogResult.OK)
                inputFilename.Text = dlg.FileName;
        }

        private void AdjustControlVisibility(object sender, EventArgs e)
        {
            feeLabel.Visible = flatFee.Checked;
            fee.Visible = flatFee.Checked;
            feeDataGrid.Visible = !flatFee.Checked;

            interestRateLabel.Visible = compoundInterest.Checked;
            interestRate.Visible = compoundInterest.Checked;
            interestDataGrid.Visible = !compoundInterest.Checked;
        }

        private void runButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(inputFilename.Text))
            {
                MessageBox.Show(@"Input filename cannot be empty");
                return;
            }

            if (!File.Exists(inputFilename.Text))
            {
                MessageBox.Show(@"Input file must exist");
                return;
            }

            var analyzer = new Analyzer()
            {
                InputFileName = inputFilename.Text,
                InterestStrategy = CreateInterestStrategy(),
                FeeStrategy = CreateFeeStrategy()
            };

            // Run the analyzer
            analyzer.Run();

            // Display the result;
            beginningBalance.Text = FormatToDollars(analyzer.BeginningTotal);
            endingBalance.Text = FormatToDollars(analyzer.EndingTotal);
            interestPaid.Text = FormatToDollars(analyzer.InterestPaid);
            feesCollected.Text = FormatToDollars(analyzer.FeesCollected);
        }

        private IInterestStrategy CreateInterestStrategy()
        {
            IInterestStrategy interestStrategy;
            if (compoundInterest.Checked)
            {
                double rate;
                double.TryParse(interestRate.Text, out rate);
                interestStrategy = new CompoundInterestStrategy()
                {
                    Rate = rate
                };
            }
            else
            {
                var table = new GraduatedInterestTable();
                foreach (DataGridViewRow row in interestDataGrid.Rows)
                {
                    if (!string.IsNullOrWhiteSpace(row.Cells[0].Value as string))
                    {
                        BalanceInterestPair pair = new BalanceInterestPair()
                        {
                            Balance = ConvertDollarStringToInt(row.Cells[0].Value as string),
                            Rate = ConvertToDouble(row.Cells[1].Value as string)
                        };
                        table.Add(pair);
                    }
                }
                interestStrategy = new GraduatedCompoundInterestStrategy() { InterestRates = table };
            }
            return interestStrategy;
        }

        private IFeeStrategy CreateFeeStrategy()
        {
            IFeeStrategy feeStrategy;
            if (flatFee.Checked)
            {
                feeStrategy = new FlatFeeStrategy()
                {
                    FlatFee = ConvertDollarStringToInt(fee.Text)
                };
            }
            else
            {
                var table = new GraduatedFeeTable();
                foreach (DataGridViewRow row in feeDataGrid.Rows)
                {
                    if (!string.IsNullOrWhiteSpace(row.Cells[0].Value as string))
                    {
                        BalanceFeePair pair = new BalanceFeePair()
                        {
                            Balance = ConvertDollarStringToInt(row.Cells[0].Value as string),
                            Fee = ConvertDollarStringToInt(row.Cells[1].Value as string)
                        };
                        table.Add(pair);
                    }
                }
                feeStrategy = new GraduatedFeeStrategy() { Fees = table };
            }

            return feeStrategy;
        }

        private int ConvertDollarStringToInt(string value)
        {
            int result = 0;
            if (!string.IsNullOrWhiteSpace(value))
            {
                double rawValue = 0;
                double.TryParse(value, out rawValue);
                result = Convert.ToInt32(Math.Round(rawValue*100, 0));
            }
            return result;
        }

        private double ConvertToDouble(string value)
        {
            double result = 0;
            if (!string.IsNullOrWhiteSpace(value))
                double.TryParse(value, out result);
            return result;
        }

        private string FormatToDollars(int amount)
        {
            decimal dollars = Convert.ToDecimal(amount)/100;
            return dollars.ToString("C");
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
