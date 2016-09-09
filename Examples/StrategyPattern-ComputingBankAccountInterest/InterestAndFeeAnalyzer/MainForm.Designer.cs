namespace InterestAndFeeAnalyzer
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.inputFilenameLabel = new System.Windows.Forms.Label();
            this.inputFilename = new System.Windows.Forms.TextBox();
            this.browseButton = new System.Windows.Forms.Button();
            this.numberOfPeriodsLabel = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.interestTypeGroup = new System.Windows.Forms.GroupBox();
            this.graduatedInterest = new System.Windows.Forms.RadioButton();
            this.compoundInterest = new System.Windows.Forms.RadioButton();
            this.interestDataGrid = new System.Windows.Forms.DataGridView();
            this.gciMinBalance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gciInterestRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.feeTypeGroupBox = new System.Windows.Forms.GroupBox();
            this.graduatedFee = new System.Windows.Forms.RadioButton();
            this.flatFee = new System.Windows.Forms.RadioButton();
            this.feeDataGrid = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.runButton = new System.Windows.Forms.Button();
            this.beginningBalanceLabel = new System.Windows.Forms.Label();
            this.endingBalanceLabel = new System.Windows.Forms.Label();
            this.feeCollectedLabel = new System.Windows.Forms.Label();
            this.interestPaidLabel = new System.Windows.Forms.Label();
            this.beginningBalance = new System.Windows.Forms.Label();
            this.endingBalance = new System.Windows.Forms.Label();
            this.interestPaid = new System.Windows.Forms.Label();
            this.feesCollected = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.interestRateLabel = new System.Windows.Forms.Label();
            this.interestRate = new System.Windows.Forms.TextBox();
            this.fee = new System.Windows.Forms.TextBox();
            this.feeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.interestTypeGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.interestDataGrid)).BeginInit();
            this.feeTypeGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.feeDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // inputFilenameLabel
            // 
            this.inputFilenameLabel.AutoSize = true;
            this.inputFilenameLabel.Location = new System.Drawing.Point(34, 20);
            this.inputFilenameLabel.Name = "inputFilenameLabel";
            this.inputFilenameLabel.Size = new System.Drawing.Size(79, 13);
            this.inputFilenameLabel.TabIndex = 0;
            this.inputFilenameLabel.Text = "Input Filename:";
            // 
            // inputFilename
            // 
            this.inputFilename.Location = new System.Drawing.Point(119, 17);
            this.inputFilename.Name = "inputFilename";
            this.inputFilename.Size = new System.Drawing.Size(316, 20);
            this.inputFilename.TabIndex = 1;
            this.inputFilename.Text = "BankAccounts.xml";
            // 
            // browseButton
            // 
            this.browseButton.Location = new System.Drawing.Point(441, 15);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(32, 23);
            this.browseButton.TabIndex = 2;
            this.browseButton.Text = "...";
            this.browseButton.UseVisualStyleBackColor = true;
            this.browseButton.Click += new System.EventHandler(this.browseButton_Click);
            // 
            // numberOfPeriodsLabel
            // 
            this.numberOfPeriodsLabel.AutoSize = true;
            this.numberOfPeriodsLabel.Location = new System.Drawing.Point(34, 69);
            this.numberOfPeriodsLabel.Name = "numberOfPeriodsLabel";
            this.numberOfPeriodsLabel.Size = new System.Drawing.Size(161, 13);
            this.numberOfPeriodsLabel.TabIndex = 3;
            this.numberOfPeriodsLabel.Text = "Number of Periods (e.g. months):";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(211, 67);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(53, 20);
            this.numericUpDown1.TabIndex = 4;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // interestTypeGroup
            // 
            this.interestTypeGroup.Controls.Add(this.graduatedInterest);
            this.interestTypeGroup.Controls.Add(this.compoundInterest);
            this.interestTypeGroup.Location = new System.Drawing.Point(37, 100);
            this.interestTypeGroup.Name = "interestTypeGroup";
            this.interestTypeGroup.Size = new System.Drawing.Size(227, 98);
            this.interestTypeGroup.TabIndex = 6;
            this.interestTypeGroup.TabStop = false;
            this.interestTypeGroup.Text = "Type of Interest";
            // 
            // graduatedInterest
            // 
            this.graduatedInterest.AutoSize = true;
            this.graduatedInterest.Location = new System.Drawing.Point(20, 63);
            this.graduatedInterest.Name = "graduatedInterest";
            this.graduatedInterest.Size = new System.Drawing.Size(167, 17);
            this.graduatedInterest.TabIndex = 1;
            this.graduatedInterest.Text = "Graduated Compound Interest";
            this.graduatedInterest.UseVisualStyleBackColor = true;
            this.graduatedInterest.CheckedChanged += new System.EventHandler(this.AdjustControlVisibility);
            // 
            // compoundInterest
            // 
            this.compoundInterest.AutoSize = true;
            this.compoundInterest.Checked = true;
            this.compoundInterest.Location = new System.Drawing.Point(20, 30);
            this.compoundInterest.Name = "compoundInterest";
            this.compoundInterest.Size = new System.Drawing.Size(114, 17);
            this.compoundInterest.TabIndex = 0;
            this.compoundInterest.TabStop = true;
            this.compoundInterest.Text = "Compound Interest";
            this.compoundInterest.UseVisualStyleBackColor = true;
            this.compoundInterest.CheckedChanged += new System.EventHandler(this.AdjustControlVisibility);
            // 
            // interestDataGrid
            // 
            this.interestDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.interestDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gciMinBalance,
            this.gciInterestRate});
            this.interestDataGrid.Location = new System.Drawing.Point(293, 109);
            this.interestDataGrid.Name = "interestDataGrid";
            this.interestDataGrid.Size = new System.Drawing.Size(252, 121);
            this.interestDataGrid.TabIndex = 7;
            this.interestDataGrid.Visible = false;
            // 
            // gciMinBalance
            // 
            this.gciMinBalance.HeaderText = "Min. Balance";
            this.gciMinBalance.Name = "gciMinBalance";
            // 
            // gciInterestRate
            // 
            this.gciInterestRate.HeaderText = "Interest Rate";
            this.gciInterestRate.Name = "gciInterestRate";
            // 
            // feeTypeGroupBox
            // 
            this.feeTypeGroupBox.Controls.Add(this.graduatedFee);
            this.feeTypeGroupBox.Controls.Add(this.flatFee);
            this.feeTypeGroupBox.Location = new System.Drawing.Point(37, 246);
            this.feeTypeGroupBox.Name = "feeTypeGroupBox";
            this.feeTypeGroupBox.Size = new System.Drawing.Size(227, 98);
            this.feeTypeGroupBox.TabIndex = 7;
            this.feeTypeGroupBox.TabStop = false;
            this.feeTypeGroupBox.Text = "Type of Fee";
            // 
            // graduatedFee
            // 
            this.graduatedFee.AutoSize = true;
            this.graduatedFee.Location = new System.Drawing.Point(20, 63);
            this.graduatedFee.Name = "graduatedFee";
            this.graduatedFee.Size = new System.Drawing.Size(96, 17);
            this.graduatedFee.TabIndex = 1;
            this.graduatedFee.Text = "Graduated Fee";
            this.graduatedFee.UseVisualStyleBackColor = true;
            this.graduatedFee.CheckedChanged += new System.EventHandler(this.AdjustControlVisibility);
            // 
            // flatFee
            // 
            this.flatFee.AutoSize = true;
            this.flatFee.Checked = true;
            this.flatFee.Location = new System.Drawing.Point(20, 30);
            this.flatFee.Name = "flatFee";
            this.flatFee.Size = new System.Drawing.Size(63, 17);
            this.flatFee.TabIndex = 0;
            this.flatFee.TabStop = true;
            this.flatFee.Text = "Flat Fee";
            this.flatFee.UseVisualStyleBackColor = true;
            this.flatFee.CheckedChanged += new System.EventHandler(this.AdjustControlVisibility);
            // 
            // feeDataGrid
            // 
            this.feeDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.feeDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.feeDataGrid.Location = new System.Drawing.Point(293, 255);
            this.feeDataGrid.Name = "feeDataGrid";
            this.feeDataGrid.Size = new System.Drawing.Size(252, 126);
            this.feeDataGrid.TabIndex = 8;
            this.feeDataGrid.Visible = false;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Min. Balance";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Interest Rate";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // runButton
            // 
            this.runButton.Location = new System.Drawing.Point(37, 391);
            this.runButton.Name = "runButton";
            this.runButton.Size = new System.Drawing.Size(161, 23);
            this.runButton.TabIndex = 9;
            this.runButton.Text = "Run Analysis";
            this.runButton.UseVisualStyleBackColor = true;
            this.runButton.Click += new System.EventHandler(this.runButton_Click);
            // 
            // beginningBalanceLabel
            // 
            this.beginningBalanceLabel.AutoSize = true;
            this.beginningBalanceLabel.Location = new System.Drawing.Point(34, 426);
            this.beginningBalanceLabel.Name = "beginningBalanceLabel";
            this.beginningBalanceLabel.Size = new System.Drawing.Size(126, 13);
            this.beginningBalanceLabel.TabIndex = 10;
            this.beginningBalanceLabel.Text = "Beginning Total Balance:";
            // 
            // endingBalanceLabel
            // 
            this.endingBalanceLabel.AutoSize = true;
            this.endingBalanceLabel.Location = new System.Drawing.Point(34, 458);
            this.endingBalanceLabel.Name = "endingBalanceLabel";
            this.endingBalanceLabel.Size = new System.Drawing.Size(112, 13);
            this.endingBalanceLabel.TabIndex = 11;
            this.endingBalanceLabel.Text = "Ending Total Balance:";
            // 
            // feeCollectedLabel
            // 
            this.feeCollectedLabel.AutoSize = true;
            this.feeCollectedLabel.Location = new System.Drawing.Point(310, 458);
            this.feeCollectedLabel.Name = "feeCollectedLabel";
            this.feeCollectedLabel.Size = new System.Drawing.Size(80, 13);
            this.feeCollectedLabel.TabIndex = 13;
            this.feeCollectedLabel.Text = "Fees Collected:";
            // 
            // interestPaidLabel
            // 
            this.interestPaidLabel.AutoSize = true;
            this.interestPaidLabel.Location = new System.Drawing.Point(310, 426);
            this.interestPaidLabel.Name = "interestPaidLabel";
            this.interestPaidLabel.Size = new System.Drawing.Size(69, 13);
            this.interestPaidLabel.TabIndex = 12;
            this.interestPaidLabel.Text = "Interest Paid:";
            // 
            // beginningBalance
            // 
            this.beginningBalance.AutoSize = true;
            this.beginningBalance.Location = new System.Drawing.Point(173, 426);
            this.beginningBalance.Name = "beginningBalance";
            this.beginningBalance.Size = new System.Drawing.Size(34, 13);
            this.beginningBalance.TabIndex = 14;
            this.beginningBalance.Text = "$0.00";
            // 
            // endingBalance
            // 
            this.endingBalance.AutoSize = true;
            this.endingBalance.Location = new System.Drawing.Point(173, 458);
            this.endingBalance.Name = "endingBalance";
            this.endingBalance.Size = new System.Drawing.Size(34, 13);
            this.endingBalance.TabIndex = 15;
            this.endingBalance.Text = "$0.00";
            // 
            // interestPaid
            // 
            this.interestPaid.AutoSize = true;
            this.interestPaid.Location = new System.Drawing.Point(403, 426);
            this.interestPaid.Name = "interestPaid";
            this.interestPaid.Size = new System.Drawing.Size(34, 13);
            this.interestPaid.TabIndex = 16;
            this.interestPaid.Text = "$0.00";
            // 
            // feesCollected
            // 
            this.feesCollected.AutoSize = true;
            this.feesCollected.Location = new System.Drawing.Point(403, 458);
            this.feesCollected.Name = "feesCollected";
            this.feesCollected.Size = new System.Drawing.Size(34, 13);
            this.feesCollected.TabIndex = 17;
            this.feesCollected.Text = "$0.00";
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(470, 503);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 18;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // interestRateLabel
            // 
            this.interestRateLabel.AutoSize = true;
            this.interestRateLabel.Location = new System.Drawing.Point(302, 130);
            this.interestRateLabel.Name = "interestRateLabel";
            this.interestRateLabel.Size = new System.Drawing.Size(133, 13);
            this.interestRateLabel.TabIndex = 19;
            this.interestRateLabel.Text = "Interest Rate (for 1 period):";
            // 
            // interestRate
            // 
            this.interestRate.Location = new System.Drawing.Point(441, 127);
            this.interestRate.Name = "interestRate";
            this.interestRate.Size = new System.Drawing.Size(100, 20);
            this.interestRate.TabIndex = 20;
            this.interestRate.Text = ".00167";
            // 
            // fee
            // 
            this.fee.Location = new System.Drawing.Point(441, 273);
            this.fee.Name = "fee";
            this.fee.Size = new System.Drawing.Size(100, 20);
            this.fee.TabIndex = 22;
            this.fee.Text = "9.99";
            // 
            // feeLabel
            // 
            this.feeLabel.AutoSize = true;
            this.feeLabel.Location = new System.Drawing.Point(302, 276);
            this.feeLabel.Name = "feeLabel";
            this.feeLabel.Size = new System.Drawing.Size(116, 13);
            this.feeLabel.TabIndex = 21;
            this.feeLabel.Text = "Fee Rate (for 1 period):";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 538);
            this.Controls.Add(this.fee);
            this.Controls.Add(this.feeLabel);
            this.Controls.Add(this.interestRate);
            this.Controls.Add(this.interestRateLabel);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.feesCollected);
            this.Controls.Add(this.interestPaid);
            this.Controls.Add(this.endingBalance);
            this.Controls.Add(this.beginningBalance);
            this.Controls.Add(this.feeCollectedLabel);
            this.Controls.Add(this.interestPaidLabel);
            this.Controls.Add(this.endingBalanceLabel);
            this.Controls.Add(this.beginningBalanceLabel);
            this.Controls.Add(this.runButton);
            this.Controls.Add(this.feeDataGrid);
            this.Controls.Add(this.feeTypeGroupBox);
            this.Controls.Add(this.interestDataGrid);
            this.Controls.Add(this.interestTypeGroup);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.numberOfPeriodsLabel);
            this.Controls.Add(this.browseButton);
            this.Controls.Add(this.inputFilename);
            this.Controls.Add(this.inputFilenameLabel);
            this.Name = "MainForm";
            this.Text = "Interest and Fee Analyzer";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.interestTypeGroup.ResumeLayout(false);
            this.interestTypeGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.interestDataGrid)).EndInit();
            this.feeTypeGroupBox.ResumeLayout(false);
            this.feeTypeGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.feeDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label inputFilenameLabel;
        private System.Windows.Forms.TextBox inputFilename;
        private System.Windows.Forms.Button browseButton;
        private System.Windows.Forms.Label numberOfPeriodsLabel;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.GroupBox interestTypeGroup;
        private System.Windows.Forms.RadioButton graduatedInterest;
        private System.Windows.Forms.RadioButton compoundInterest;
        private System.Windows.Forms.DataGridView interestDataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn gciMinBalance;
        private System.Windows.Forms.DataGridViewTextBoxColumn gciInterestRate;
        private System.Windows.Forms.GroupBox feeTypeGroupBox;
        private System.Windows.Forms.RadioButton graduatedFee;
        private System.Windows.Forms.RadioButton flatFee;
        private System.Windows.Forms.DataGridView feeDataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.Button runButton;
        private System.Windows.Forms.Label beginningBalanceLabel;
        private System.Windows.Forms.Label endingBalanceLabel;
        private System.Windows.Forms.Label feeCollectedLabel;
        private System.Windows.Forms.Label interestPaidLabel;
        private System.Windows.Forms.Label beginningBalance;
        private System.Windows.Forms.Label endingBalance;
        private System.Windows.Forms.Label interestPaid;
        private System.Windows.Forms.Label feesCollected;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label interestRateLabel;
        private System.Windows.Forms.TextBox interestRate;
        private System.Windows.Forms.TextBox fee;
        private System.Windows.Forms.Label feeLabel;
    }
}

