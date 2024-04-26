using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main(string[] args)
    {
        string pattern = @">>([A-Za-z]+)<<(\d+(\.\d+)?)!(\d+)";
        Regex regex = new Regex(pattern);

        double totalPrice = 0;

        Console.WriteLine("Enter your furniture:");
        while (true)
        {
            string input = Console.ReadLine();

            if (input == "Purchase")
            {
                break;
            }

            Match match = regex.Match(input);

            if (match.Success)
            {
                string furniture = match.Groups[1].Value;
                double price = double.Parse(match.Groups[2].Value);
                int quantity = int.Parse(match.Groups[4].Value);

                totalPrice += price * quantity;

                Console.WriteLine($"Bought furniture: {furniture}");
            }
        }

        Console.WriteLine($"Total money spent: {totalPrice:F2}");
    }
}