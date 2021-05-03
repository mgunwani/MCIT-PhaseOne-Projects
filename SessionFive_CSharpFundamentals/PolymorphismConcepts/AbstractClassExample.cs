/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismConcepts
{
    abstract class ManageBankAccount {
        public void Message()
        {
            Console.WriteLine("Welcome to ABC Bank!!");
        }
        public abstract void OpenBankAccount();
        public abstract void CloseBankAccount();

    }

    abstract class BankAccount : ManageBankAccount
    {
        public abstract void Deposit();
        public abstract void Withdraw();
        public abstract void Balance();
    }

    class SavingAccount : BankAccount
    {
        public override void Deposit()
        {
            Console.WriteLine("Deposit in Saving Account!!");
        }
        public override void Withdraw()
        {
            Console.WriteLine("Withdraw from Saving Account!!");
        }
        public override void Balance()
        {
            Console.WriteLine("Balance in Saving Account!!");
        }

        public override void OpenBankAccount()
        {
            Console.WriteLine("Opening new Saving Account!!");
        }

        public override void CloseBankAccount()
        {
            Console.WriteLine("Closing existing Saving Account!!");
        }
    }

    class CurrentAccount : BankAccount
    {
        public override void Balance()
        {
            Console.WriteLine("Balance in Current Account!!");
        }

        public override void CloseBankAccount()
        {
            Console.WriteLine("Closing existing Current Account!!");
        }

        public override void Deposit()
        {
            Console.WriteLine("Deposit in Current Account!!");
        }

        public override void OpenBankAccount()
        {
            Console.WriteLine("Openinng new Current Account!!");
        }

        public override void Withdraw()
        {
            Console.WriteLine("Withdraw from Current Account!!");
        }
    }


    class AbstractClassExample
    {
        static void Main(string[] args)
        {
            

            SavingAccount savingAccount = new SavingAccount();
            savingAccount.Message();
            savingAccount.OpenBankAccount();
            savingAccount.Deposit();
            savingAccount.Withdraw();
            savingAccount.Balance();
            savingAccount.CloseBankAccount();

            Console.WriteLine("-------------------------------");

            CurrentAccount currentAccount = new CurrentAccount();
            currentAccount.Message();
            currentAccount.OpenBankAccount();
            currentAccount.Deposit();
            currentAccount.Withdraw();
            currentAccount.Balance();
            currentAccount.CloseBankAccount();

            Console.ReadLine();
        }
    }
}
*/