using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM_Simulator
{
     class Program
    {
        static void DisplayMenu()
        {
            Console.WriteLine("\n*********** ATM MENU ***********");
            Console.WriteLine("1. View Balance");
            Console.WriteLine("2. Withdraw Cash");
            Console.WriteLine("3. Deposit Funds");
            Console.WriteLine("4. Change PIN");
            Console.WriteLine("5. Exit");
            Console.WriteLine("********************************");
        }

        static void Main(string[] args)
        {
            int pin, option;
            int PIN = 5555;
            float balance = 10000;

            Console.WriteLine("Welcome to Rushikesh's ATM Service");
            Console.Write("Enter Your PIN: ");
            pin = int.Parse(Console.ReadLine());

            if (pin == PIN)
            {
                while (true)
                {
                    DisplayMenu();
                    Console.Write("Enter Option: ");
                    option = int.Parse(Console.ReadLine());

                    switch (option)
                    {
                        case 1:
                            Console.WriteLine($"\nBalance: Rs {balance}");
                            break;

                        case 2:
                            Console.Write("Enter Withdraw Amount: Rs ");
                            float withdrawAmount = float.Parse(Console.ReadLine());
                            if (withdrawAmount <= balance)
                            {
                                balance -= withdrawAmount;
                                Console.WriteLine($"Withdrawal Successful. New Balance: Rs {balance}");
                            }
                            else
                            {
                                Console.WriteLine("Insufficient Balance. Withdrawal Failed.");
                            }
                            break;

                        case 3:
                            Console.Write("Enter Deposit Amount: Rs ");
                            float depositAmount = float.Parse(Console.ReadLine());
                            balance += depositAmount;
                            Console.WriteLine($"Deposit Successful. New Balance: Rs {balance}");
                            break;

                        case 4:
                            Console.Write("Enter New PIN: ");
                            int newPin = int.Parse(Console.ReadLine());
                            PIN = newPin;
                            Console.WriteLine("PIN Changed Successfully.");
                            break;

                        case 5:
                            Console.WriteLine("Thank you for using Rushikesh's ATM. Goodbye!");
                            return;

                        default:
                            Console.WriteLine("Invalid Option. Please try again");
                            break;
                    }
                }
            }

            else
            {
                Console.WriteLine("Wrong PIN.Access Denied");
            }

        }

    }
}