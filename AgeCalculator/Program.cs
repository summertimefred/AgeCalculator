using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            //parse()
            string strYear = "2001";
            int year = Int32.Parse(strYear);

            Console.WriteLine("The year is:" + year);


            //System.Date

            int currentYear = System.DateTime.Now.Year;

            Console.WriteLine("The current year is:" + currentYear);

        }
    }
}
