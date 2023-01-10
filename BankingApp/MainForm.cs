using System;
using System.Windows.Forms;

namespace BankingApp
{
    public partial class MainForm : Form
    {
        //List<BankAccount> bankAccounts = new List<BankAccount>();
        BankAccount bankAccount = new BankAccount();

        public MainForm()
        {
            InitializeComponent();
            //for(int i=0; i < 5; i++)
            //{
            //    BankAccount bankAccount = new BankAccount();
            //    bankAccount.SetAccountNumber("BankAccountNumber" + (i+1).ToString());
            //    bankAccounts.Add(bankAccount);
            //}

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            bankAccount.SetAccountNumber("NLRABO06142874261");
            bankAccount.SetMaxCredit(2500.0);
        }

        private void tbAccountName_TextChanged(object sender, EventArgs e)
        {
            bankAccount.SetAccountName(tbAccountName.Text);
            lblInfo.Text = bankAccount.GetInfo();
        }

        private void btnWithDraw_Click(object sender, EventArgs e)
        {
            if (!bankAccount.WithDraw(Convert.ToDouble(nudAmount.Value)))
            {
                MessageBox.Show("You're overdrawn");
            }
            else
            {
                lblBalance.Text = $"{bankAccount.GetBalance():f2}";
            }
        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            bankAccount.Deposit(Convert.ToDouble(nudAmount.Value));
            lblBalance.Text = $"{bankAccount.GetBalance():f2}";
        }

        private void tmrWithDraw_Tick(object sender, EventArgs e)
        {
            tmrWithDraw.Enabled = false;
            bankAccount.WithDraw(10.5);
            lblBalance.Text = $"{bankAccount.GetBalance():f2}";
            tmrWithDraw.Enabled = true;
        }

        private void btnEmptyMyAccount_Click(object sender, EventArgs e)
        {
            tmrWithDraw.Enabled = !tmrWithDraw.Enabled;
            if (tmrWithDraw.Enabled)
            {
                btnEmptyMyAccount.Text = "Stop emptying";
            }
            else
            {
                btnEmptyMyAccount.Text = "Empty my account";
            }
        }
    }
}
