namespace pz18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bank acc1 = new Bank(1000, 123123, AccountType.Debit);
            Bank acc2 = new Bank(1000, 123123, AccountType.Credit);
            Bank acc3 = new Bank(1000, 123, AccountType.Debit);
            Bank acc4 = new Bank(1000, 123123);
            Bank acc5 = new Bank();

            acc1.AccountRefill(39000);
            acc1.AccountWithdraw(99000);

            acc2.AccountWithdraw(99000);
        }
    }
}
