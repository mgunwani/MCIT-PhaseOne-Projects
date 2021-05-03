using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismConcepts
{
    interface IBankAccount
    {
        bool Deposit(double amount);
        bool Withdraw(double amount);
        double Balance();
    }

    public class SavingAccount : IBankAccount
    {
        private double _balance;
        private double _perDayLimit;
        public bool Deposit(double amount)
        {
            this._balance = this._balance + amount;
            return true;
        }
        public bool Withdraw(double amount)
        {
            if(_balance < amount)
            {
                Console.WriteLine("Insufficient Balance!!");
                return false;
            } 
            else if((_perDayLimit + amount) > 5000) // Per Day Limit is 5000
            {
                Console.WriteLine("Withdrawal Attempt Failed!!");
                return false;
            }
            else
            {
                _balance = _balance - amount;
                _perDayLimit += amount;
                Console.WriteLine("Successfully Withdrawal : {0}", amount);
                return true;
            }
        }
        public double Balance()
        {
            return this._balance;
        }        
    }
    class CurrentAccount : IBankAccount
    {
        public double Balance()
        {
            throw new NotImplementedException();
        }

        public bool Deposit(double amount)
        {
            throw new NotImplementedException();
        }

        public bool Withdraw(double amount)
        {
            throw new NotImplementedException();
        }
    }

    class BankingApplicationExercise
    {
        static void Main(string[] args)
        {
            char opt;
            Console.WriteLine("1 - Saving Account");
            Console.WriteLine("2 - Current Account");
            Console.WriteLine("Select Account Type : ");
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    SavingAccount savingAccount = new SavingAccount();
                    do
                    {
                        Console.WriteLine("1 - Deposit");
                        Console.WriteLine("2 - Withdrawal");
                        Console.WriteLine("3 - Balance");
                        Console.Write("Select the Operation : ");
                        int ch = int.Parse(Console.ReadLine());
                        switch (ch)
                        {
                            case 1:
                                Console.WriteLine("Enter Amount that you wanted to Depsoit : ");
                                savingAccount.Deposit(double.Parse(Console.ReadLine()));
                                break;

                            case 2:
                                Console.WriteLine("Enter Amount that you wanted to Withdraw : ");
                                savingAccount.Withdraw(double.Parse(Console.ReadLine()));
                                break;

                            case 3:
                                Console.WriteLine("Balance in Saving Account : " + savingAccount.Balance());
                                break;

                            default:
                                Console.WriteLine("Invalid Operation Type!!");
                                break;
                        }
                        Console.Write("Do you wish to Continue?(yes/No) : ");
                        opt = char.Parse(Console.ReadLine());
                    } while (opt == 'y' || opt == 'Y');
                    break;

                case 2:
                    CurrentAccount currentAccount = new CurrentAccount();
                    Console.WriteLine("1 - Deposit");
                    Console.WriteLine("2 - Withdrawal");
                    Console.WriteLine("3 - Balance");
                    break;

                default:
                    Console.WriteLine("Invalid Choice!!");
                    break;
            }

        }
    }
}
