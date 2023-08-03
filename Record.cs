using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpenseTrackingapp
{
    public class Record
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public double Amount { get; set; }
        //public DateTime Date { get; set; }

        public DateTime Date()
        {
            return DateTime.Now; 
        }


        public Record(string title, string description, double amount)
        {
            this.Title = title;
            this.Description = description;
            this.Amount = amount;
        }

        public Record() { }

        public virtual double getAmount()
        {
            return Amount; 
        }

        public virtual double StoreAmount(double d)
        {
            //double ans; 
            //double ans = double.Parse(Console.ReadLine()); 
             if (d < 0)
            {
                Expense e = new Expense();
                Console.WriteLine("Expense has been added: {0}", d);
                return e.getAmount();
            } else
            {
                Income i = new Income();
                //i.Amount = ans;
                Console.WriteLine("Income has been added: {0}", d);
                Amount = d; 
                return i.getAmount(); 
            }

        }

        public override string ToString()
        {
            return string.Format("\nRecord:\n" +
                "Title: {0}\nDescription:{1}\nAmount:{2}\nDate:{3}\n", Title, Description, Amount, Date()); 
        }

    }
}
