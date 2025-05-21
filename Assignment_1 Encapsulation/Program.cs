using System;
using Assignment_1_Encapsulation;

amespace Assignment_1_Encapsulation
{ /* Design a class in C# that represents a bank Account with  
the data members/Fields.  
 
Use appropriate modifiers with data members and methods.  
 
Identifier             Type ---------                 ---- 
AcNumber           Integer 
AcHolderName   String 
AcBalance           Double 
AcType                String 
AcMinBalance     Double 
 
Functionalities: Add Customer details, Display customer 
Zetails and Show account balance. Implement the properties 
for the appropriate members of the class. */
    class Program
{
    static void Main(string[] args)          // Main method
    {
        BankAccount account = new BankAccount();        // Create an instance of bank account 
        account.AddCustomerDetails(12345, "John Doe", 1000.00, "Savings", 500.00);  // Add customer details
        account.DisplayCustomerDetails();
        account.ShowBalance();
        Console.WriteLine("Press any key to exit...");

         Console.ReadKey();
    }
}
}