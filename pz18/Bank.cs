using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz18
{
    enum AccountType { Credit, Debit }
    internal class Bank
    {
        private double balanсe; //баланс счета
        private int accountNumber; //номер счета
        private static int debitAccountCount = 0; //кол-во дебетовых счетов
        private static int creditAccountCount = 0; //кол-во кредитных счетов

        public int AccountNumber
        {
            get => accountNumber;
            set
            {
                if (Convert.ToString(value).Length != 6)
                    Console.WriteLine("Ошибка: номер счёта должен состоять из 6 цифр");
                else
                    accountNumber = value;
            }
        }
        public AccountType AccountType { get; set; }
        public double Balance { get; set; }
        public void AccountRefill(double sum) //пополнение счета
        {
            if (sum >= 1000)
            {
                Balance += sum;
                Console.WriteLine($"Счет {AccountNumber} пополнен на сумму {sum}. Баланс: {Balance}");

            }
            else
                Console.WriteLine("Ошибка: маленькая сумма взноса");
        }

        public void AccountWithdraw(double sum) //снятие со счета
        {
            if (AccountType == AccountType.Credit || (AccountType == AccountType.Debit && sum <= Balance))
            {
                Balance -= sum;
                Console.WriteLine($"Счет {AccountNumber} снятие суммы {sum}. Баланс: {Balance}");
            }
            else
            {
                Console.WriteLine("Ошибка: снятие денег со счёта не удалось");
            }
        }

        public static void GetAccountCounts()
        {
            Console.WriteLine($"Количество дебетовых счетов: {debitAccountCount}");
            Console.WriteLine($"Количество кредитных счетов: {creditAccountCount}");
        }
        public Bank(double balance, int accountNumber, AccountType accountType)
        {
            Balance = balance;
            AccountNumber = accountNumber;
            AccountType = accountType;
            if (accountType == AccountType.Debit)
                debitAccountCount++;
            else if (accountType == AccountType.Credit)
                creditAccountCount++;
        }
        public Bank(double balance, int accountNumber)
        {
            Balance = balance;
            AccountNumber = accountNumber;
            AccountType = AccountType.Debit;
        }
        public Bank() { }
    }
}
