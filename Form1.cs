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
            if (string.IsNullOrEmpty(OwnerTxt.Text))
            {
                MessageBox.Show("Owner name is required to create an account.");
                return;
            }
            BankAccountApp newAccount = new BankAccountApp(OwnerTxt.Text);
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

            if (AmountNum.Value <= 0)
            {
                MessageBox.Show("Deposit amount must be greater than zero.");
                return;
            }

            if (BankAccountGrid.SelectedRows.Count == 1 && AmountNum.Value > 0)
            {
                BankAccountApp selectedAccount = (BankAccountApp)BankAccountGrid.CurrentRow.DataBoundItem;
                selectedAccount.Balance += AmountNum.Value;
                RefreshGrid();
                AmountNum.Value = 0;
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


            if (BankAccountGrid.SelectedRows.Count == 1 && AmountNum.Value > 0)
            {
                BankAccountApp selectedAccount = (BankAccountApp)BankAccountGrid.CurrentRow.DataBoundItem;
                if(AmountNum.Value > selectedAccount.Balance)
                {
                    MessageBox.Show("Insufficient funds for this withdrawal.");
                    return;
                }
                selectedAccount.Balance -= AmountNum.Value;
                RefreshGrid();
                AmountNum.Value = 0;
            }
        }
    }
}
