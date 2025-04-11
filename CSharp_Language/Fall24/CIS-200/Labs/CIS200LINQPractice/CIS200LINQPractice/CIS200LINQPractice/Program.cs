using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS200LINQPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Invoice n1 = new Invoice(83, "Electric Sander", 7, 57.98m);
            Invoice n2 = new Invoice(24, "Power Saw", 18, 99.99m);
            Invoice n3 = new Invoice(7, "Sledge Hammer", 11, 21.50m);
            Invoice n4 = new Invoice(77, "Hammer",76, 11.99m);
            Invoice n5 = new Invoice(39, "Lawn Mower", 3, 79.50m);
            Invoice n6 = new Invoice(68, "Screwdriver", 106, 6.99m);
            Invoice n7 = new Invoice(56, "Jig saw", 21, 11.00m);
            Invoice n8 = new Invoice(3, "Wrench", 34, 7.50m);


            var linqList = new List<Invoice> { n1, n2, n3, n4, n5, n6, n7, n8 };

            //Sample - sorting by PartNumber
            Console.WriteLine("--------------Sample--------------------");
            var partSorted = from invoice in linqList
                             orderby invoice.PartNumber
                             select invoice;

            foreach (Invoice inv in partSorted)
            {
                Console.WriteLine(inv);
            }


            //a) use LINQ to sort the objects by PartDescription. 
            Console.WriteLine("--------------Part A--------------------");
            var partDescSorted = from invoice in linqList
                                 orderby invoice.PartDescription
                                 select invoice;
            foreach (Invoice inv in partDescSorted)
            {
                Console.WriteLine(inv);
            }

            //b) use LINQ to sort the objects by Price
            Console.WriteLine("--------------Part B--------------------");
            var priceSorted = from invoice in linqList
                                 orderby invoice.Price
                                 select invoice;
            foreach (Invoice inv in priceSorted)
            {
                Console.WriteLine(inv);
            }

            //c) use LINQ to select the PartDescription and Quantity. Sort the results by Quantity
            Console.WriteLine("--------------Part C--------------------");
            var quanSorted = from invoice2 in linqList
                              orderby invoice2.Quantity
                              select (invoice2.PartDescription, invoice2.Quantity);
            foreach (var inv in quanSorted)
            {
                Console.WriteLine(inv);
            }

            //d) use LINQ to select from each invoice the PartDescription and value of the invoice (Quantity * Price). Name the calculated column 
            //  InvoiceTotal. Order the results by InvoiceTotal. (Hint - use let)
            Console.WriteLine("--------------Part D--------------------");
            var invTotalSorted = from invoice2 in linqList
                                 orderby invoice2.Quantity
                                 let InvoiceTotal = invoice2.Quantity * invoice2.Price
                                 select (invoice2.PartDescription, InvoiceTotal);
            foreach (var inv in invTotalSorted)
            {
                Console.WriteLine(inv);
            }

            //e) Use the results from d to select InvoiceTotals in the range of $200 to $500
            Console.WriteLine("--------------Part E--------------------");
            var invTotalFilter = from invoice2 in invTotalSorted
                                 where invoice2.InvoiceTotal >= 200 & invoice2.InvoiceTotal <= 500
                                 select invoice2;
            foreach (var inv in invTotalSorted)
            {
                    Console.WriteLine(inv);
            }

        }
    }
}
