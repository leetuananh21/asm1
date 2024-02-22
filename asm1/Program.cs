// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    static void Main(string[] args)
    {
        // Input customer information
        Console.WriteLine("Enter customer name:");
        string customerName = Console.ReadLine();

        Console.WriteLine("Enter last month's water meter readings:");
        double lastMonthReadings = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter this month's water meter readings:");
        double thisMonthReadings = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter the type of customer:");
        string customerType = Console.ReadLine();

        double pricePerCubicMeter = 0;
        double environmentProtectionFee = 0;

        // Calculate price and environment protection fee based on customer type
        switch (customerType.ToLower())
        {
            case "household":
                Console.WriteLine("Enter the number of people:");
                int numberOfPeople = int.Parse(Console.ReadLine());
                double consumption = thisMonthReadings - lastMonthReadings;

                if (consumption <= 10 * numberOfPeople)
                {
                    pricePerCubicMeter = 5.973;
                    environmentProtectionFee = 597.30;
                }
                else if (consumption <= 20 * numberOfPeople)
                {
                    pricePerCubicMeter = 7.052;
                    environmentProtectionFee = 705.20;
                }
                else if (consumption <= 30 * numberOfPeople)
                {
                    pricePerCubicMeter = 8.699;
                    environmentProtectionFee = 866.90;
                }
                else
                {
                    pricePerCubicMeter = 15.929;
                    environmentProtectionFee = 1592.90;
                }
                break;

            case "administrative agency":
            case "public services":
                pricePerCubicMeter = 9.955;
                environmentProtectionFee = 995.50;
                break;

            case "production units":
                pricePerCubicMeter = 11.615;
                environmentProtectionFee = 1161.50;
                break;

            case "business services":
                pricePerCubicMeter = 22.068;
                environmentProtectionFee = 2206.80;
                break;

            default:
                Console.WriteLine("Invalid customer type.");
                return;
        }

        // Calculate total water bill
        double totalWaterBill = (thisMonthReadings - lastMonthReadings) * pricePerCubicMeter + environmentProtectionFee;

        // Output customer information and total water bill
        Console.WriteLine($"Customer Name: {customerName}");
        Console.WriteLine($"Last Month's Water Meter Readings: {lastMonthReadings}");
        Console.WriteLine($"This Month's Water Meter Readings: {thisMonthReadings}");
        Console.WriteLine($"Amount of Consumption: {thisMonthReadings - lastMonthReadings}");
        Console.WriteLine($"Total Water Bill: {totalWaterBill}");

        // Further features such as sorting, searching, generating invoices, and notifying customers can be implemented here.
    }
}

