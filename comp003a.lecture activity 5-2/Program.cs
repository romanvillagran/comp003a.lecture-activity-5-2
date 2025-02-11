namespace comp003a.lecture_activity_5_2
{
    internal class BankAccount
    {
        //fields
        private string _accountNumber;
        private double _balance;

        //properties
        ///<summary>
        ///gets the accound number
        /// </summary>
         
        public string AccountNumber
        {
            get { return _accountNumber; }
        }

        ///<summary>
        ///gets or sets the accounf balance with validation
        /// </summary>

        public double Balance
        {
            get { return _balance; }
            set
            {
                if(value >= 0)
                    _balance = value;
            }
        }

        public BankAccount(string accountNumber, double initialBalance)
        {
            _accountNumber = accountNumber;
            Balance = initialBalance;
        }

        ///<summary>
        ///deposits money into the account 
        /// </summary>
        /// <param> name="amount"</param>

        public void Deposit(double amount)
        {
            if (amount > 0)
            {
                _balance += amount;
                Console.WriteLine($"Deposited: {amount:C}. New Balance: {_balance:C}");
            }
        }

        ///<summary>
        ///withdraws money from the account if sufficient balace is available
        /// </summary>
        /// <param> name="amount"</param>
        
        public void Withdraw(double amount)
        {
            if (amount > 0 && _balance >= amount)
            {
                _balance -= amount;
                Console.WriteLine($"Withdrawn: {amount:C}. New Balance: {_balance:C}");
            }
            else
            {
                Console.WriteLine("Insufficient funds.");
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            //create a new bankaccount object
            BankAccount myAccount = new BankAccount("12345678", 500.00);

            //display the account number and initial balance
            Console.WriteLine($"Account Number: {myAccount.AccountNumber}");
            Console.WriteLine($"Initial Balance: {myAccount.Balance:C}");

            //despite and withdraw money
            myAccount.Deposit(150.0);
            myAccount.Withdraw(50.00);
            myAccount.Withdraw(700.00);
        }
    }
}
