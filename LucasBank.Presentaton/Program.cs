using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LucasBank.Presentaton
{
    internal class Program
    {
        private static int mainMenuChoice;

        static void Main(string[] args)
        {
            //Console.Title = "LucasBank";
            Console.WriteLine("********LucasBank********");
            Console.WriteLine("Welcome to LucasBank");
            Console.WriteLine("::Login Page::");

            //store username and password
            string userName = null, password = null;

            //read username from keybord

            Console.Write("Enter UserName:");
            userName = Console.ReadLine();

            //read password from keybord if only ussename is entered

            if (userName != null)
            {
                Console.Write("Enter Password:");
                password = Console.ReadLine();
            }

            //validate username and password

            if (userName == "lucas" && password == "khanyi")
            {
                do
                {
                    //declare variable to store menu chice
                    int mainMenuChoice = -1;

                    Console.WriteLine("Welcome to LucasBank");
                    Console.WriteLine("");
                    Console.WriteLine("\n:::Main menu:::");
                    Console.WriteLine("1.Customers");
                    Console.WriteLine("2.Accounts");
                    Console.WriteLine("3.Transactions");
                    Console.WriteLine("4.Funds Transfer");
                    Console.WriteLine("5.Funds Transfer Statement");
                    Console.WriteLine("0.Exit");

                    Console.Write("Enter your choice: ");
                    mainMenuChoice = int.Parse(Console.ReadLine());


                    //switch case to handle menu choice

                    switch (mainMenuChoice)
                    {
                        case 1:
                            Console.WriteLine("You have selected Customers");
                            CustomersMenu(); break;

                        case 2:
                            Console.WriteLine("You have selected Accounts");
                            AccountMenu(); break;
                        case 3:
                            Console.WriteLine("You have selected Transactions");
                            break;
                        case 4:
                            Console.WriteLine("You have selected Funds Transfer");
                            break;
                        case 5:
                            Console.WriteLine("You have selected Funds Transfer Statement");
                            break;
                        
                    }
                } while (mainMenuChoice != 0);
            }
            else
            {
                Console.WriteLine("Login Failed");
                Console.WriteLine("Invalid Username or Password");
            }

            //about to exit
            Console.WriteLine("Thank you for using LucasBank! Visit again.");
            Console.ReadKey();
        }

        // Move CustomersMenu to be a private static method of the Program class
        private static void CustomersMenu()
        {
            int customerMenuChoice = -1;
            do
            {
                Console.WriteLine("\n:::Customers Menu:::");
                Console.WriteLine("1.Add Customer");
                Console.WriteLine("2.View Customers");
                Console.WriteLine("3.Search Customer");
                Console.WriteLine("0.Back to Main Menu");

                //accept menu choice
                Console.Write("Enter your choice: ");
                customerMenuChoice = System.Convert.ToInt32(Console.ReadLine());
                switch (customerMenuChoice)
                {
                    case 1:
                        Console.WriteLine("You have selected Add Customer");
                        break;
                    case 2:
                        Console.WriteLine("You have selected View Customers");
                        break;
                    case 3:
                        Console.WriteLine("You have selected Search Customer");
                        break;
                  
                }
            } while (customerMenuChoice != 0);
        }

        private static void AccountMenu()
        {

            int accountMenuChoice = -1;
            do
            {
                Console.WriteLine("\n:::Accounts Menu:::");
                Console.WriteLine("1.Add Account");
                Console.WriteLine("2.View Accounts");
                Console.WriteLine("3.Search Account");
                Console.WriteLine("0.Back to Main Menu");
                //accept menu choice
                Console.Write("Enter your choice: ");
                accountMenuChoice = Convert.ToInt32(Console.ReadLine());
                switch (accountMenuChoice)
                {
                    case 1:
                        Console.WriteLine("You have selected Add Account");
                        break;
                    case 2:
                        Console.WriteLine("You have selected View Accounts");
                        break;
                    case 3:
                        Console.WriteLine("You have selected Search Account");
                        break;
                }
            } while (accountMenuChoice != 0);
        }
    }
}


    

