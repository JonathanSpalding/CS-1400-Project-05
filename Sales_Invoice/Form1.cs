// Author: Jonathan Spalding
// Assignment: Project 05
// Instructor Roger deBry
// Clas: CS 1400
// Date Written: 2/27/2016
//
// "I declare that the following source code was written solely by me. I understand that copying any source code, in whole or in part, constitutes cheating, and that I will receive a zero on this project if I am found in violation of this policy."
//----------------------------------------------------
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sales_Invoice
{
    public partial class Form1 : Form
    {
        // create a Invoice_Class object
        Invoice_Class objectRef;

        public Form1()
        {
            InitializeComponent();
        }
        // The exitToolStripMenuItem1_Click Method
        // Purpose: Display a pop up box when you click About
        // Parameters: The sending object, and the event arguments
        // Returns: none
        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        // The aboutToolStripMenuItem_Click Method
        // Purpose: Display a pop up box when you click About
        // Parameters: The sending object, and the event arguments
        // Returns: none
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Jonathan Spalding\nCS1400\nProjecct 05");
        }
        // The buyButton_Click method
        // Purpose: Converts input into strings, then calls back the methods in the class and outputs them in a MessageBox.
        // Parameters: The sending object, and the event arguments
        // returns: none
        private void buyButton_Click(object sender, EventArgs e)
        {
            //convert the input boxes from string to double
            double numItems = double.Parse(items.Text);
            double unitPrice = double.Parse(price.Text);
            //save the values of the input boxes in the Invoice_Class object
            objectRef = new Invoice_Class(numItems, unitPrice);
            //make strings to be displayed in the message box. Each string should call back the proper methods in the class
            string s0 = "Sales Ticket...\n";
            string s1 = string.Format("Quantity: {0} units\n", objectRef.GetNumItems());
            string s2 = string.Format("Unit Price: {0:C2} each\n", objectRef.GetItemPrice());
            string s3 = "-----------------------------------------\n";
            string s4 = string.Format("Net Price: {0:c}\n", objectRef.GetNetPrice());
            string s5 = string.Format("State Sales Tax: {0:C2}\n", objectRef.GetStateSalesTax());
            string s6 = string.Format("Local Sales Tax: {0:C2}\n", objectRef.GetLocalSalesTax());
            string s7 = string.Format("Please pay: {0:C2}\n", objectRef.GetTotalCost());
            //display each string in the MessageBox
            MessageBox.Show(s0 + s1 + s2 + s3 + s4 + s5 + s6 + s7);
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            //empty both input boxes and put the cursor back in the first box.
            items.Clear();
            price.Clear();
            items.Select();
        }
    }
}
