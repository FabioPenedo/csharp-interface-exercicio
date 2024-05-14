using App.Entities;
using App.Services;
using System.Globalization;

namespace App // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter contract data:");
            Console.Write("Number: ");
            int number = int.Parse(Console.ReadLine()!);
            Console.Write("Date (dd/MM/yyyy): ");
            DateTime date = DateTime.Parse(Console.ReadLine()!);
            Console.Write("Contract value: ");
            double contractValue = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);

            Contract infoContract = new(number, date, contractValue);

            Console.Write("Enter number of installments: ");
            int months = int.Parse(Console.ReadLine()!);

            ContractService contract = new (new PaypalService());
            contract.ProcessContract(infoContract, months);

            Console.WriteLine();
            Console.WriteLine("Installments:");
            Console.WriteLine(infoContract);

        }
    }
}