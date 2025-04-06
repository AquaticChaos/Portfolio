/*
    CIS-199-50-4228 Program #4
    Due: 12/2/22 (formerly 11/30, then 12/1)
    ID: F2233
    Purpose: Using classes, objects, and constructors; create five different products that will display their
        supplier and product name, price, store id, aisle, and whether they're in stock. These values can
        also be changed by the user without direct access to the object's variables but rather through 
        methods that also validate them.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Create individual objects, hard-coded
            Product product1 = new Product("PepsiCo", "Gatorade", 675134, "Beverage", 4.50, 5);
            Product product2 = new Product("KeurigDrPepper", "A&W Root Beer", 622859, "Beverage", 3.50, 4);
            Product product3 = new Product("CocaCola", "Fanta", 545877, "Beverage", 3.50, 4);
            Product product4 = new Product("Kellogg", "Cheez-It", 113086, "Snack", 5.99, 8);
            Product product5 = new Product("MarsInc", "Combos", 343067, "Snack", 4.99, 8);

            //Create array of the above objects
            Product[] productArray = new Product[] {product1, product2, product3, product4, product5};

            //Display each of the objects within array
            Console.WriteLine("Products We Sell \n---------------------");
            printObjects(productArray); //Print array of objects

            //Edit objects' values, hard-coded; test validations for aisle/id/price
            productArray[0].ProductPrice = -9; //Outside valid range, should be set to 0 (default)
            productArray[1].ProductID = 150; //Outside valid range, should be set to 0 (default)
            productArray[2].SupplierName = "Meijer"; //Should be set properly to name of store
            productArray[2].ProductName = "Club Soda"; //Should be set properly to store-brand soda
            productArray[2].ProductPrice = 2.99; //Should be set properly to a lesser value than before
            productArray[3].InStock(); //In-Stock should be equal to "True"
            productArray[4].InStock(); //In-Stock should be equal to "True"
            productArray[4].Aisle = 0; //Outside valid range, but should be set to 0 (default) anyway

            //Display each object in array with changed values
            Console.WriteLine("\nProducts After Changes \n---------------------");
            printObjects(productArray); //Print array of objects

            //Display objects in array that are in-stock only
            Console.WriteLine("\nProducts In Stock \n---------------------");
            foreach (Product product in productArray)
            {
                if(product.IsInStock() == true) //If product's in stock...
                {
                    printObjects(product); //Display product's info
                }
            }

            //Display objects in array one last time.
            Console.WriteLine("\nProducts Once More \n---------------------");
            printObjects(productArray); //Print array of objects
        }

        public static void printObjects (Array objArray) //For array of objects
        {
            foreach (var product in objArray)
            {
                Console.WriteLine(product.ToString()); //Display object info
            }
        }
        public static void printObjects(Product productListing) //For single objects
        {
            Console.WriteLine(productListing.ToString()); //Display object info
        }
    }
}
