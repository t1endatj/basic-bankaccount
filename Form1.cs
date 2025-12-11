using System.Linq;

namespace MiniBankAccount
{
    public partial class Form1 : Form
    {
        List<BankAccountApp> bankAccounts = new List<BankAccountApp>();
        public Form1()
        {
            InitializeComponent();
        }
        private void CreateAccountBtn_Click(object sender, EventArgs e)
        {
            string owner = OwnerTxt.Text.Trim();
            if (string.IsNullOrEmpty(OwnerTxt.Text))
            {
                MessageBox.Show("Owner name is required to create an account.");
                return;
            }
            
            BankAccountApp newAccount = new BankAccountApp(OwnerTxt.Text);
            if (bankAccounts.Any(a => string.Equals(a.Owner, owner, StringComparison.OrdinalIgnoreCase)))
            {
                MessageBox.Show("An account for this owner already exists.");
                return;
            }
            bankAccounts.Add(newAccount);

            RefreshGrid();
            OwnerTxt.Text = "";
        }
        private void RefreshGrid()
        {
            BankAccountGrid.DataSource = null;
            BankAccountGrid.DataSource = bankAccounts;
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void DepositeBtn_Click(object sender, EventArgs e)
        {
            if (BankAccountGrid.CurrentRow == null)
            {
                MessageBox.Show("Please select an account to deposit into.");
                return;
            }

            if (BankAccountGrid.SelectedRows.Count == 1)
            {
                try
                {
                    BankAccountApp selectedAccount = (BankAccountApp)BankAccountGrid.CurrentRow.DataBoundItem;
                    selectedAccount.Deposit(AmountNum.Value);
                    RefreshGrid();
                    AmountNum.Value = 0;
                }
                catch (ArgumentException ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }
            }
        }

        private void WithdrawBtn_Click(object sender, EventArgs e)
        {
            if (BankAccountGrid.CurrentRow == null)
            {
                MessageBox.Show("Please select an account to deposit into.");
                return;
            }

            if (AmountNum.Value <= 0)
            {
                MessageBox.Show("Deposit amount must be greater than zero.");
                return;
            }


            if (BankAccountGrid.SelectedRows.Count == 1)
            {
                try
                {
                    BankAccountApp selectedAccount = (BankAccountApp)BankAccountGrid.CurrentRow.DataBoundItem;
                    selectedAccount.Withdraw(AmountNum.Value);
                    RefreshGrid();
                    AmountNum.Value = 0;
                }
                catch (ArgumentException ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }
            }
        }
    }
}
