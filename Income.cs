using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpenseTrackingapp
{
    public class Income:Record
    {
        public Income() { }

        public override double getAmount()
        {
            return base.getAmount();

        }
        public override string ToString()
        {
            return string.Format("Record:\n" +
                "Title: {0}\nDescription:{1}\nAmount:{2}\nDate:{3}\n", Title, Description, Amount, Date());
        }
    }
}
