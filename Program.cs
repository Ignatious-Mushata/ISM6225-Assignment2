// ISM 6225 - Practice Assignment 2 (Scracthpad)
// Name: Ignatious Mushata
// All ten questions are in this single Program.cs
using System;

Console.Write("Enter current number of customers: ");
string inputCustomers = Console.ReadLine();
Console.Write("Enter monthly price per customer: ");
string inputMonthlyPrice = Console.ReadLine();
Console.Write("Enter percentage price increase (e.g., 5 for 5%): ");
string inputPercentage = Console.ReadLine();

try
{
    int customerCount = Convert.ToInt32(inputCustomers);
    decimal monthlyPrice = Convert.ToDecimal(inputMonthlyPrice);
    decimal percentageIncrease = Convert.ToDecimal(inputPercentage);

    if (customerCount < 0)
    {
        Console.WriteLine("Error: Customer count cannot be negative.");
        return;
    }

    if (monthlyPrice < 0m)
    {
        Console.WriteLine("Error: Monthly price cannot be negative.");
        return;
    }

    if (percentageIncrease < 0m)
    {
        Console.WriteLine("Error: Percentage increase cannot be negative.");
        return;
    }

    decimal priceIncreaseMultiplier = percentageIncrease / 100m;
    decimal currentMonthlyRevenue = customerCount * monthlyPrice;
    decimal projectedMonthlyPrice = monthlyPrice * (1m + priceIncreaseMultiplier);
    decimal projectedMonthlyRevenue = customerCount * projectedMonthlyPrice;
    decimal dollarIncrease = projectedMonthlyRevenue - currentMonthlyRevenue;

    Console.WriteLine();
    Console.WriteLine($"Current customers: {customerCount}");
    Console.WriteLine($"Monthly price per customer: {monthlyPrice:C2}");
    Console.WriteLine($"Percentage increase: {percentageIncrease}%");
    Console.WriteLine($"Price increase multiplier: {priceIncreaseMultiplier}");
    Console.WriteLine($"Current monthly revenue: {currentMonthlyRevenue:C2}");
    Console.WriteLine($"Projected monthly price: {projectedMonthlyPrice:C2}");
    Console.WriteLine($"Projected monthly revenue: {projectedMonthlyRevenue:C2}");
    Console.WriteLine($"Dollar increase: {dollarIncrease:C2}");
}
catch (FormatException)
{
    Console.WriteLine("Input error: please enter numeric values for customer count, monthly price, and percentage increase.");
} 