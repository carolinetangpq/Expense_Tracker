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
        

        static void Main(string[] args)
        {
            //Create list 
            List<Record> records = new List<Record>();
            Record r = new Expense(); 
            Record e = new Expense();
            Record i = new Expense(); 

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

                records.Add(new Record { Title = title, Description = desc, Amount = amt }); 

                //View Expenses 
            } else if (userChoice == 2)
            {

                 Console.WriteLine("Your Expense is: {0}", e.Amount);
            } else if (userChoice == 3)
            {
                 Console.WriteLine("Your Income is: {0}", i.Amount);
            } else
            {
                foreach (Record record in records)
                {
                    Console.WriteLine("Your Balance is: {0}", record.Amount);
                }
                    
            }     

        }
        public static void UserMenu()
        {
            Console.WriteLine("1. Add Transaction\n2.View Expenses\n3.View Income\n.Check Available Balance");
        }

    }
}
