using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1_Encapsulation           //  namespace for encapsulation  --->  works as a container for classes)
{
    public class BankAccount             //  class BankAccount
    {
        public int AcNumber { get; set; }                  
        //  validation of account number
        public string AcNumberValidation
        {
            get { return AcNumber.ToString(); }
            set
            {
                if (value.Length == 10)
                    AcNumber = int.Parse(value);
                else
                    throw new ArgumentException("Account number must be 10 digits long.");
            }
        }
        public string AcHolderName { get; set; }
        //  validation of account holder name
        public string AcHolderNameValidation
        {
            get { return AcHolderName; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    AcHolderName = value;
                else
                    throw new ArgumentException("Account holder name cannot be empty.");
            }
        }
        public double AcBalance { get; private set; }
        // validation of account balance
        public double AcBalanceValidation
        {
            get { return AcBalance; }
            set
            {
                if (value >= 0)
                    AcBalance = value;
                else
                    throw new ArgumentException("Account balance cannot be negative.");
            }
        }
        public string AcType { get; set; }
        // validation of account type
        public string AcTypeValidation
        {
            get { return AcType; }
            set
            {
                if (value == "Savings" || value == "Current")
                    AcType = value;
                else
                    throw new ArgumentException("Account type must be either 'Savings' or 'Current'.");
                // validation of account type
            }
        }
        public double AcMinBalance { get; set; }
        // validation of minimum balance
        public double AcMinBalanceValidation       
        {
            get { return AcMinBalance; }
            set
            {
                if (value >= 0)                   // condition for minimum balance
                    AcMinBalance = value;      
                else
                    throw new ArgumentException("Minimum balance cannot be negative.");   // validation of minimum balance 
            }
        }

        public void AddCustomerDetails(int number, string name, double balance, string type, double minBalance) 
            // Add customer details
        {
            AcNumber = number;              // Account number  
            AcHolderName = name;
            AcBalance = balance;
            AcType = type;
            AcMinBalance = minBalance;
        }
        {
            AcNumber = number;
            AcHolderName = name;
            AcBalance = balance;
            AcType = type;
            AcMinBalance = minBalance;
        }

        public void DisplayCustomerDetails()           // Display customer details
        {
            Console.WriteLine("---- Customer Details ----");
            Console.WriteLine($"Account No: {AcNumber}");
            Console.WriteLine($"Holder Name: {AcHolderName}");
            Console.WriteLine($"Account Type: {AcType}");
            Console.WriteLine($"Balance: {AcBalance}");
            Console.WriteLine($"Minimum Balance: {AcMinBalance}");
        }

          pulic void ShowBalance()         // Show account balance
    {
            Console.WriteLine($"Current Balance: {AcBalance}");
           
        
        }
    }

}
 
