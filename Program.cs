/*Pledge : I understand Solano's honor Code and abide by its rules - 
 * Name  :Sarah Sanchez 
 * Date : 11.29.2024
 * Email : ssanch58@students.solano.edu
 * MW : morning Ciss002
 * Decription : This project allows the user to enter their User name, Password, pin number to access 
 * their balance and savings. The user will have the option to deposit or withdraw money from their balance or savings account.The user has unlimited choices, Unless they Exit from menu
 * ##################################################################################################################################################################
 */
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Net.Configuration;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Microsoft.Win32;

namespace ConsoleProject1
{
    internal class Program
    {
        public class CardHolder
        {
            string cardNum;
            int pin;
            string firstname;
            string lastname;
            public double balance;
            public double saving;
           

        }
        public static int pin = 1234;

       
        
        public static double balance = 500.00;
        public static double saving = 500.00;
        public static void showsaving()
        {
            //user will be able to view their savings 
            Console.WriteLine("Your Saving to **** is: $" + saving);
            //user will be able to access the following options 
            Console.WriteLine("________________________________________________________________");
            Console.WriteLine("Please select the following");
            Console.WriteLine("________________________________________________________________");
            Console.WriteLine("B. Balance");
            Console.WriteLine("S. Saving");
            Console.WriteLine(" 1. Deposit");
            Console.WriteLine(" 2. Withdraw");
            Console.WriteLine("3. Exit");
            string choice = Console.ReadLine();
            //user will have options to select due switch choices
            switch (choice)
            {
                case "B":
                    Console.WriteLine("");
                    showbalance();
                    break;
                case "S":
                    Console.WriteLine("");
                    showsaving();
                    break;

                case "1":
                    Console.WriteLine("");
                    Deposit();
                    break;
                case "2":
                    Console.WriteLine("");
                    withdrawl();
                    break;
                case "3":
                    Console.WriteLine();
                    Environment.Exit(0);
                    break;
            }


        }
        
       
        public static void showbalance()
        {
            //user will be able to view their balance 
            Console.WriteLine("Your balance to **** is: $" + balance);
            //user will be able to acess the following options 
            Console.WriteLine("Please select the following");
            Console.WriteLine("B. Balance");
            Console.WriteLine("S. Saving");
            Console.WriteLine(" 1. Deposit");
            Console.WriteLine(" 2. Withdraw");
            Console.WriteLine("3. Exit");
            string choice = Console.ReadLine();
            //user will have options to the following due to switch choices 
            switch (choice)
            {
                case "B":
                    Console.WriteLine("");
                    showbalance();
                    break;
                case "S":
                    Console.WriteLine("");
                    showsaving();
                    break;
                case "1":
                    Console.WriteLine("");
                    Deposit();
                    break;
                case "2":
                    Console.WriteLine("");
                    withdrawl();
                    break;
                case "3":
                    Console.WriteLine();
                    Environment.Exit(0);
                    break;
            }
        }
        public static void Deposit() {

            //user will be able to deposit money into the following options (Balance, Savings) 
            Console.WriteLine("How would you like to deposit");
            Console.WriteLine("Please select the following");
            Console.WriteLine("B. Balance");
             Console.WriteLine("S. Saving");
            string choice = Console.ReadLine().ToUpper();
            Console.Write("Enter Deposit Amount: ");
            double depositAmount = Double.Parse(Console.ReadLine());
           
            Console.WriteLine("___________________________________________________________________");
            /*user will be able to access the options they would like to deposit from if they choose to 
             deposit from their balance money would be added to the balance. If they were to 
            choose to deposit from their Savings account money would be added to savings*/
            if (choice == "B")
            {
                balance += depositAmount;
                Console.WriteLine("You deposited: $" + depositAmount + " In your balance. Your new balance is : $" + balance);
            }
            else if (choice == "S")
            {
                saving += depositAmount;
                Console.WriteLine("You deposited: $" + depositAmount + " In your savings. Your new balance is : $" + saving);
            }
            Menu();

           

        }
        public static void withdrawl() {
            Console.WriteLine("How would you like to withdrawl?");
            Console.WriteLine("Please select the following");
            Console.WriteLine("B. Balance");
            Console.WriteLine("S. Saving");
            string choice = Console.ReadLine().ToUpper();
            Console.Write("Enter withdrawl amount: ");
            //user can withdraw money however if the amount does not match the amount of the balance then a message will show stating Funds have not been met 
            double withdrawlamount = Double.Parse(Console.ReadLine());
            Console.WriteLine("___________________________________________________________________");
            /* User will be able to access the options they would like to withdraw from if they choose to 
             withdraw from their balance money would be taken from their balance. If they were to 
            choose to withdraw from their Savings account money would be taken from their savings*/
            if (choice == "B")
            {
                if (withdrawlamount <= balance)
                {
                    balance -= withdrawlamount;
                    Console.WriteLine("You withdrew: $" + withdrawlamount + ". Your new balance is $" + balance);
                }
            }
            else 
            {
                Console.WriteLine("Funds not found");
            }
             if (choice == "S")
                if (withdrawlamount <= saving)
                {
                    saving -= withdrawlamount;
                    Console.WriteLine("You withdrew: $" + withdrawlamount + ". In your savings. Your new balance is : $" + saving);
                }
            Menu();
            
            
            {

            }
            if (withdrawlamount <= balance)
            {
                balance -= withdrawlamount;
                Console.WriteLine("You withdrew: $" + withdrawlamount + ". Your new balance is: $" + balance);
            }
            else
            {
               Console.WriteLine("Funds not found.");
            }
           

        }
        public static void Menu()
            //User will have access to their menu when chosen option or finished choosing options 
        {
            Console.WriteLine("___________________________________________________________________");
            Console.WriteLine("Please select the following ");
            Console.WriteLine("B. Balance: ****");
            Console.WriteLine("S. Saving: ****");
            Console.WriteLine("1. Deposit: **** ");
            Console.WriteLine("2. Withdraw: ****");
            Console.WriteLine("3. Exit ");
            Console.WriteLine("___________________________________________________________________ ");
            string choice = Console.ReadLine();
            switch (choice)
            {

                case "B":
                    Console.WriteLine("");
                    showbalance();
                    break;
                case "s":
                    Console.WriteLine("");
                    showsaving();
                    break;
                case "1":
                    Console.WriteLine("");
                    Deposit();
                    break;
                case "2":
                    Console.WriteLine("");
                    withdrawl();
                    break;
                case "3":
                    Console.WriteLine();
                    Environment.Exit(0);
                    break;




            }
        }

        static void Main(string[] args)
        {
            //When the program first starts the user will veiw the main menu
            //main menu
            Console.WriteLine("=============================================");
            Console.WriteLine("Welcome to Yadi's NorthBank");
            Console.WriteLine("============================================");
            // User name and Password
            Console.Write("Enter in your username: ");
            string username = Console.ReadLine();
            Console.Write("Enter in your password: ");
            Console.ReadLine();
            Console.WriteLine("___________________________________________________________________");
            Console.Write("Welcome " + username + ", please enter your pin: ");
            Console.ReadLine();
            Menu();
            


          
        }
    }
}
