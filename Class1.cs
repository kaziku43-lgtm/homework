using System;

public class Class1
{
	public Class1()
	{
        using System;

class Program
    {
        static void Main()
        {
            string productName = "Laptop";
            double price = 850;
            int qty = 2;
            double amount = price * qty;

            Console.WriteLine("******** PRODUCT INFORMATION ********");
            Console.WriteLine("Product Name : " + productName);
            Console.WriteLine("Price        : $" + price);
            Console.WriteLine("Qty          : " + qty);
            Console.WriteLine("Amount       : $" + amount.ToString("N2"));

            Console.Redkey();
        }
    }

}
}
