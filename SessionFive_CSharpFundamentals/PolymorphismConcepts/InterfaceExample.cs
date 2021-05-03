/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismConcepts
{
    interface IManageBankAccount
    {
        void OpenBankAccount();
        void CloseBankAccount();
    }
    interface IBankAccount
    {
        void Deposit();
        void Withdraw();
        void Balance();
    }
    class SavingAccount : IBankAccount, IManageBankAccount
    {
        public void Balance()
        {
            Console.WriteLine("Balance in Saving Account!!");
        }

        public void CloseBankAccount()
        {
            Console.WriteLine("Close Existing Bank Account");
        }

        public void Deposit()
        {
            Console.WriteLine("Deposit in Saving Account!!");
        }

        public void OpenBankAccount()
        {
            Console.WriteLine("Open New Bank Account!!");
        }

        public void Withdraw()
        {
            Console.WriteLine("Withdraw from Saving Account!!");
        }
    }
    class CurrentAccount : IBankAccount
    {
        public void Balance()
        {
            Console.WriteLine("Balance in Current Account!!");
        }

        public void Deposit()
        {
            Console.WriteLine("Deposit in Current Account!!");
        }

        public void Withdraw()
        {
            Console.WriteLine("Withdraw from CurrentAccount!!");
        }
    }

    class InterfaceExample
    {
        static void Main(string[] args)
        {
            SavingAccount savingAccount = new SavingAccount();
            savingAccount.OpenBankAccount();
            savingAccount.Deposit();
            savingAccount.Withdraw();
            savingAccount.Balance();
            savingAccount.CloseBankAccount();

            Console.WriteLine("-------------------------------");

            CurrentAccount currentAccount = new CurrentAccount();
            currentAccount.Deposit();
            currentAccount.Withdraw();
            currentAccount.Balance();

            Console.ReadLine();
        }
    }
}
*/