using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Program4
{
    public class Product
    {
        //Define the values of the object which can be changed later.
        private string supplierName, productName, productType;
        private int productID, aisle;
        private double productPrice;
        //Stock status is false by default upon object creation, but can be made true afterwards
        private bool inStockStatus = false;

        public Product(string supName, string prodName, int prodID, string prodType, double prodPrice, int prodAisle)
        {
            //Set the object's initial values based on parameters provided
            supplierName = supName;
            productName = prodName;
            productID = prodID;
            productType = prodType;
            productPrice = prodPrice;
            aisle = prodAisle;
        }

        public string SupplierName { 
            get { return supplierName; } //Get supplier name value
            set { supplierName = value; } //Set supplier name value
        }
        public string ProductName {
            get { return productName; } //Get product name value
            set { productName = value; } //Set product name value
        }
        public int ProductID {
            get { return productID; } //Get product ID value
            set
            {
                //If not in range 100,000 - 999,999, set default value to 0
                if (value < 100000 || value > 999999) {productID = 0;}
                else { productID = value; }
            }
        }
        public string ProductType { 
            get { return productType; } //Get product type value
            set { productType = value; } //Set product type value
        }
        public double ProductPrice
        {
            get { return productPrice; } //Get price value
            set
            {
                //If price less than zero, set default to zero
                if (value < 0) { productPrice = 0; }
                else { productPrice = value; }
            }
        }
        public int Aisle
        {
            get { return aisle; } //Get aisle location value
            set
            {
                //If outside range of 1-20, set default to 0
                if (value < 1 || value > 20) {aisle = 0;}
                else { aisle = value; }
            }
        }
        
        public void InStock()
        {
            inStockStatus = true; //Set boolean inStockStatus to true; in stock
        }
        public void OutofStock()
        {
            inStockStatus = false; //Set boolean inStockStatus to false; out of stock
        }
        public bool IsInStock()
        {
            return inStockStatus; //Return value of boolean inStockStatus
        }

        public override string ToString()
        {
            string message = "Supplier: " + supplierName + "\n  Product: " + productName + "\n  ID: " 
                + productID + "\n  Category: " + ProductType + "\n  Price: " 
                + productPrice.ToString("C", CultureInfo.CurrentCulture) +
                "\n  Aisle: " + aisle + "\n  In Stock: " + inStockStatus;
            return message;
        }
    }
}
