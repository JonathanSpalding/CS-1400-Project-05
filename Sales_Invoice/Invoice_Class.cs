// Author: Jonathan Spalding
// Assignment: Lab 15
// Instructor "Roger deBry
// Clas: CS 1400
// Date Written: 2/25/2016
//
// "I declare that the following source code was written solely by me. I understand that copying any source code, in whole or in part, constitutes cheating, and that I will receive a zero on this project if I am found in violation of this policy."
//----------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sales_Invoice
{
    // The Invoice_Class definition
    class Invoice_Class
    {
        //State constants
        private const double STATETAX = .0745;
        private const double LOCALTAX = .025;
        //State the data members of the class and assign their default values.
        private double numItems = 0;
        private double itemPrice = 0;
        // The parameterized constructor
        // Purpose: It sets all declared variables (data members of the class) to the values passed in.
        // Parameters: doubles, the numItems and itemPrice.
        // Returns: None
        public Invoice_Class(double p1, double p2)
        {
            numItems = p1;
            itemPrice = p2;
        }
        //-----------------------------Getters--------------------------------
        // The GetNumItems method
        // Purpose: Get numItems
        // Parameters: None
        // Returns: double numItems
        public double GetNumItems()
        {
            return numItems;
        }
        // The GetItemPrice method
        // Purpose: To return itemPrice.
        // Parameters: None
        // Returns: double itemPrice
        public double GetItemPrice()
        {
            return itemPrice;
        }
        //-----------------------------Setters--------------------------------
        // The setNumItems method
        // Purpose: setter for numItems
        // Parameters: double p1
        // Returns: none
        public void SetNumItems(double p1)
        {
            numItems = p1;
        }
        // The CalcSideC method
        // Purpose: setter for itemPrice
        // Parameters: double p2
        // Returns: none
        public void SetItemPrice(double p2)
        {
            itemPrice = p2;
        }
        //-----------------------------More Getters----------------------------
        // The GetNetPrice method
        // Purpose: Return the numItems multiplied by itemPrice
        // Parameters: None
        // Returns: double netPrice
        public double GetNetPrice()
        {
            double netPrice = numItems * itemPrice;
            return netPrice;
        }
        // The GetStateSalesTax method
        // Purpose: returns the state tax.
        // Parameters: None
        // Returns: double stateSalesTax
        public double GetStateSalesTax()
        {
            double stateSalesTax = GetNetPrice() * STATETAX;
            return stateSalesTax;
        }
        // The GetLocalSalesTax method
        // Purpose: returns the local sales tax
        // Parameters: None
        // Returns: double localSalesTax
        public double GetLocalSalesTax()
        {
            double localSalesTax = GetNetPrice() * LOCALTAX;
            return localSalesTax;
        }
        // The GetTotalCost method
        // Purpose: returns the total of the net cost, state, and local tax
        // Parameters: None
        // Returns: double total
        public double GetTotalCost()
        {
            double total = GetNetPrice() + GetStateSalesTax() + GetLocalSalesTax();
            return total;
        }
    }
}
