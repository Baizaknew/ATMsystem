using System;
using System.Windows.Forms;

namespace CS_ATM
{
    public partial class Form1 : Form
    {
        double InterestRate, monthlyInterestRate, loanAmount, MonthlyPayment, TotalPayment;
        int numberOfYears;
        String iMonthlyPayment, iTotalPayment;

        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void lblPin_Click(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            lblPin.Text = lblPin.Text + "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            lblPin.Text = lblPin.Text + "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            lblPin.Text = lblPin.Text + "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            lblPin.Text = lblPin.Text + "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            lblPin.Text = lblPin.Text + "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            lblPin.Text = lblPin.Text + "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            lblPin.Text = lblPin.Text + "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            lblPin.Text = lblPin.Text + "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            lblPin.Text = lblPin.Text + "9";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            lblPin.Text = lblPin.Text + "0";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lblPin.Text = "";
            lblBalance.Visible = false;
            lblDeposit.Visible = false;
            lblLoan.Visible = false;
            lblWithdrawal.Visible = false;
            btnLoan.Enabled = false;
            btnDeposit.Enabled = false;
            btnBalance.Enabled = false;
            btnWithdrawal.Enabled = false;

            btnLoanSystem.Enabled = true;
            btnExit.Enabled = true;
            btnReceipt.Enabled = true;
            btnReset.Enabled = true;

        }
        
        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult iExit;

            iExit = MessageBox.Show("Confirm you want to exit", "ATM System", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (iExit == DialogResult.Yes) 
            { 
                Application.Exit();
            }
        }

        private void btnLoanSystem_Click(object sender, EventArgs e)
        {
            InterestRate = Convert.ToDouble(txtInterestRate.Text);
            monthlyInterestRate = InterestRate / 1200;
            numberOfYears = Convert.ToInt32(txtNumberOfYears.Text);
            loanAmount = Convert.ToDouble(txtAmountOfLoan.Text);

            MonthlyPayment = loanAmount * monthlyInterestRate / (1-1 / Math.Pow(1+monthlyInterestRate, numberOfYears*12));
            //------------------------------------------------------------------------------------------------------------
            iMonthlyPayment = Convert.ToString(MonthlyPayment);
            iMonthlyPayment = String.Format("{0:C}", MonthlyPayment);
            lblMonthlyPayment.Text = (iMonthlyPayment);
            //------------------------------------------------------------------------------------------------------------
            TotalPayment = MonthlyPayment * numberOfYears * 12;
            iTotalPayment = String.Format("{0:C}", TotalPayment);
            lblTotalPayment.Text = (iTotalPayment);

            txtAmountOfLoan.Text = String.Format("{0:C}", loanAmount);
        }

        private void btnReceipt_Click(object sender, EventArgs e)
        {
            rtfReceipt.AppendText("Loan Management Systems Calculator" + "\n");
            rtfReceipt.AppendText("----------------------------------------------------------" + "\n");
            rtfReceipt.AppendText("Enter amount of Loan" + "\t" + txtAmountOfLoan.Text + "\n");
            rtfReceipt.AppendText("Enter number of Year" + "\t" + txtNumberOfYears.Text + "\n");
            rtfReceipt.AppendText("Enter Interest Rate" + "\t" + "\t" + txtInterestRate.Text + "\n");
            rtfReceipt.AppendText("Monthly Payment" + "\t" + "\t" + lblMonthlyPayment.Text + "\n");
            rtfReceipt.AppendText("Total Payment" + "\t" + "\t" + "\t" + lblTotalPayment.Text + "\n");
            rtfReceipt.AppendText("----------------------------------------------------------" + "\n");
            rtfReceipt.AppendText("------------------------Thank You----------------------" + "\n");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblBalance.Visible = false;
            lblDeposit.Visible = false;
            lblLoan.Visible = false;
            lblWithdrawal.Visible = false;

            btnLoan.Enabled = false;
            btnDeposit.Enabled = false;
            btnBalance.Enabled = false;
            btnWithdrawal.Enabled = false;

            btnLoanSystem.Enabled = false;
            btnExit.Enabled = false;
            btnReceipt.Enabled = false;
            btnReset.Enabled = false;
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            String pin1 = String.Format(lblPin.Text);
            String pin2 = String.Format(lblPin.Text);
            String pin3 = String.Format(lblPin.Text);
            String pin4 = String.Format(lblPin.Text);
            String pin5 = String.Format(lblPin.Text);

            if (pin1 == "1234") 
            {
                lblBalance.Visible = true;
                lblDeposit.Visible = true;
                lblLoan.Visible = true;
                lblWithdrawal.Visible = true;
                btnLoan.Enabled = true;
                btnDeposit.Enabled = true;
                btnBalance.Enabled = true;
                btnWithdrawal.Enabled = true;
                lblPin.Text = "";
            }

            else if (pin1 == "2345")
            {
                lblBalance.Visible = true;
                lblDeposit.Visible = true;
                lblLoan.Visible = true;
                lblWithdrawal.Visible = true;
                btnLoan.Enabled = true;
                btnDeposit.Enabled = true;
                btnBalance.Enabled = true;
                btnWithdrawal.Enabled = true;
                lblPin.Text = "";
            }

            else if (pin1 == "3456")
            {
                lblBalance.Visible = true;
                lblDeposit.Visible = true;
                lblLoan.Visible = true;
                lblWithdrawal.Visible = true;
                btnLoan.Enabled = true;
                btnDeposit.Enabled = true;
                btnBalance.Enabled = true;
                btnWithdrawal.Enabled = true;
                lblPin.Text = "";
            }

            else if (pin1 == "4567")
            {
                lblBalance.Visible = true;
                lblDeposit.Visible = true;
                lblLoan.Visible = true;
                lblWithdrawal.Visible = true;
                btnLoan.Enabled = true;
                btnDeposit.Enabled = true;
                btnBalance.Enabled = true;
                btnWithdrawal.Enabled = true;
                lblPin.Text = "";
            }

            else if (pin1 == "5678")
            {
                lblBalance.Visible = true;
                lblDeposit.Visible = true;
                lblLoan.Visible = true;
                lblWithdrawal.Visible = true;
                btnLoan.Enabled = true;
                btnDeposit.Enabled = true;
                btnBalance.Enabled = true;
                btnWithdrawal.Enabled = true;
                lblPin.Text = "";
            }
            else
            {
                lblPin.Text = "Invalid Pin";
            }
        }

        private void btnLoan_Click(object sender, EventArgs e)
        {
            btnLoanSystem.Enabled = true;
            btnExit.Enabled = true;
            btnReceipt.Enabled = true;
            btnReset.Enabled = true;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult iExit;

            iExit = MessageBox.Show("Confirm you want to exit", "ATM System", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (iExit == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtAmountOfLoan.Clear();
            txtNumberOfYears.Clear();
            txtInterestRate.Clear();
            lblMonthlyPayment.Text = "";
            lblTotalPayment.Text = "";
            rtfReceipt.Clear();
        }

        
    }
}
