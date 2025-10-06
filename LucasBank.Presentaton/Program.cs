using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LucasBank.Presentaton
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.Title = "LucasBank";
            Console.WriteLine("********LucasBank********");
            Console.WriteLine("Welcome to LucasBank");
            Console.WriteLine("::Login Page::");

            //store username and password
            string userName =null,password=null;

            //read username from keybord

            Console.Write("Enter UserName:");
            userName =Console.ReadLine();

            //read password from keybord if only ussename is entered

            if (userName != null)
            {
                Console.Write("Enter Password:");
                password = Console.ReadLine();
            }

            //validate username and password

            if (userName == "lucas" && password == "khanyi")
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

                Console.WriteLine("Enter your choice:");
                mainMenuChoice = Convert.ToInt32(Console.ReadLine());
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
    }
}
