using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console; // eliminate typing 'Console' repeatedly

namespace CSC105_0801_Seasons_wsc
{
    enum Months
    {
        January = 1, Febuary, March, April, May, June, July, August, Septemeber, October, November, December
    }
    enum Seasons
    {
        Spring = 1, Summer, Fall, Winter
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            // STORAGE
            int monthNumber;

            // INPUT
            Write("Please enter the number of a month (1-12) :");
            monthNumber = Convert.ToInt16(ReadLine());

            // PROCESS
            if (monthNumber < 1 || monthNumber > 12)
            {
                WriteLine(" ** Input Error. ** {0} is not a valid month number. ", monthNumber);
            }
            else
            {
                switch (monthNumber)
                {
                    case 1:
                        WriteLine("This month is in the Winter season."); // OUTPUT
                        break;
                    case 2:
                        WriteLine("This month is in the Winter Season."); // OUTPUT
                        break;
                    case 3:
                        WriteLine("This month is in the Spring Season."); // etc.
                        break;
                    case 4:
                        WriteLine("This month is in the Spring season.");
                        break;
                    case 5:
                        WriteLine("This month is in the Spring season.");
                        break;
                    case 6:
                    case 7:
                    case 8:
                        WriteLine("This month is in the {0} season.", Seasons.Summer);
                        break;
                    case 9:
                    case 10:
                    case 11:
                        WriteLine("This month is in the {0} season.", Seasons.Fall);
                        break;
                    case 12:
                        WriteLine("This month is in the Winter season.");
                        break;
                } // end switch 
            } // end else
        } // end Main method
    } // end class
} // end namespace
