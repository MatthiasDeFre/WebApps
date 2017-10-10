namespace BankingApp.Models
{
    internal class BankAccount
    {
        #region Fields

        //private readonly string _accountnumber;
        //   private decimal _balance;
        //   public const decimal WithdrawCost = 0.25M;

        #endregion

        #region Constructors

        public BankAccount(string accountnumber)
        {
            AccountNumber = accountnumber;
        }

        #endregion


        #region Properties

        public string AccountNumber { get; set; }

        /*public decimal Balance
        {
            get { return _balance; }
            private set { _balance = value; }
        }*/
        public decimal Balance { get; private set; }

        #endregion


        #region Methods

        public virtual void Withdraw(decimal amount)
        {
            Balance -= amount;
        }

        public void Deposit(decimal amount)
        {
            Balance += amount;
        }

        #endregion
    }
}