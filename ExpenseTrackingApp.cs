using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpenseTrackingapp
{
    public class Program
    {
        public static string title;
        public static string desc;
        public static double amt;
        public static int userChoice;
        public static Boolean keepPlaying = true; 

        static void Main(string[] args)
        {
            //Create list 
            List<Record> records = new List<Record>();
            Record r = new Record();

            do
            {
                //execute the user input
                Program.UserMenu();

                //Add Transaction 
                if (userChoice == 1)
                {

                    //Get input 
                    Console.WriteLine("Title: ");
                    title = Console.ReadLine();

                    Console.WriteLine("Description: ");
                    desc = Console.ReadLine();

                    Console.WriteLine("Amount: ");
                    amt = double.Parse(Console.ReadLine());

                    //Check if its expense or income
                    r.StoreAmount(amt);

                    //store into the record list 
                    records.Add(new Record { Title = title, Description = desc, Amount = amt });

                    /*
                    //Enumerate over list to display the transaction 
                    foreach (Record r2 in records)
                    {
                        Console.WriteLine(r2);
                    }*/

                }
                else if (userChoice == 2)
                {
                    double sum = 0;
                    foreach (Record r2 in records)
                    {
                        if (r2.Amount < 0 )
                        {
                            //sum up the amount of expense
                            sum += r2.Amount;
                        }

                    }
                    Console.WriteLine("Your Expense is {0} ", sum);

                }
                else if (userChoice == 3)
                {
                    double sum = 0;
                    foreach (Record r2 in records)
                    {
                        if (r2.Amount > 0)
                        {
                            //sum up the amount of income
                            sum += r2.Amount;
                        }
                        
                    }
                    Console.WriteLine("Your Income is {0} ", sum);
                }
                
                else if (userChoice == 4)
                {
                    double finalAmount = 0;
                    foreach (Record record in records)
                    {
                        finalAmount += record.Amount;
                        Console.WriteLine("Your Transaction history is: {0}", record.Amount);
                        Console.WriteLine("----------------------------------");

                    }
                    Console.WriteLine("Your Balance is: {0}", finalAmount);
                }

                else
                {
                    Console.WriteLine("End");
                    keepPlaying = false; 
                }

            } while (keepPlaying == true); 

        }
        public static void UserMenu()
        {
            Console.WriteLine("1. Add Transaction\n2.View Expenses\n3.View Income\n4.Check Available Balance\n5.Exit");
            Console.WriteLine("Choose an option: ");
            userChoice = int.Parse(Console.ReadLine());
        }

    }
}
