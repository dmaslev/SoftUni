using System;

class Program
{
    static void Main()
    {
        Console.Write("Company name: ");
        string companyName = Console.ReadLine();
        Console.Write("Company address: ");
        string address = Console.ReadLine();
        Console.Write("Phone number: ");
        string phoneNumber = Console.ReadLine();
        Console.Write("Fax number: ");
        string faxNumber = Console.ReadLine();
        Console.Write("Website : ");
        string website = Console.ReadLine();
        Console.Write("Manager first name : ");
        string firstName = Console.ReadLine();
        Console.Write("Manager last name : ");
        string lastName = Console.ReadLine();
        Console.Write("Manager age : ");
        string age = Console.ReadLine();
        Console.Write("Manager phoneNumber : ");
        string managerNumber = Console.ReadLine();
        Console.WriteLine("{0} \r\nAddress: {1} \r\nTel. {2} \r\n ", companyName, address, phoneNumber);
        Console.WriteLine("{0} \r\nFax: {1} \r\nWeb site: {2} \r\nManager: {3} {4} (age: {5}, tel. {6}", faxNumber, faxNumber, website, firstName , lastName, age, managerNumber);


        
    }
}

