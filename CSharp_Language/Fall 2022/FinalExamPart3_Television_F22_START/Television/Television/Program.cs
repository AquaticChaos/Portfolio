/*
    CIS-199-50-4228 Final Exam
    Due: 12/10/2022 @ 8 PM
    ID: F2233
*/

using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Television
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // #1 - Put code here to construct 3 televisions
            Television tv1 = new Television("Visio", "Flat Screen", 60, 450, 60, 8);
            tv1.IsSmartTV();
            Television tv2 = new Television("Samsung", "Flat Screen", 65, 3799.99, 60, 8);
            tv2.IsSmartTV();
            Television tv3 = new Television("Komodo", "Wall-Mounted", 50, 299.98, 30, 8);
            tv3.NotSmartTV();

            Television[] tvs = { tv1, tv2, tv3 };

            WriteLine("TVs We Sell:");
            WriteLine("------------");

            TVDisplay(tvs);
        }
        public static void TVDisplay(object[] objectName)
        {
            foreach(object i in objectName)
            {
                WriteLine(i.ToString() + "\n");
            }
        }
    }
}
