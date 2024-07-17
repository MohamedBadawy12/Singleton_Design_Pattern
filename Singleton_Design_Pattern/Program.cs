namespace Singleton_Design_Pattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                CurrencyConverter converter = CurrencyConverter.GetInstance();
                Console.Write("Enter your currency do you want to convert: ");
                decimal amountCurreny = decimal.Parse(Console.ReadLine());
                Console.Write("Convert From: ");
                string currency1 = Console.ReadLine();
                Console.Write("Convert To: ");
                string currency2 = Console.ReadLine();
                decimal amount = converter.Convert(currency1, currency2, amountCurreny);
                Console.WriteLine($"{amountCurreny} {currency1} is {amount} {currency2}");
                Console.WriteLine("-----------------------------------");
            }
        }
    }
}