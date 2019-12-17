namespace TournamentPlanner
{
    struct BankAccount
    {
        public int Balance;
        public int PinCode;

        public BankAccount(int balance)
        {
            Balance = balance;
            PinCode = 0;
        }

        public BankAccount(int balance, int pincode)
        {
            Balance = balance;
            PinCode = pincode;
        }

        public override string ToString()
        {
            return "Balance: " + Balance + ", PinCode: " + PinCode;
        }
    }
}
