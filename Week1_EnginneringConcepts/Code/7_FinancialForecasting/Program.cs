using System;
using System.Collections.Generic;

class Program
{
    // Recursive method to calculate future value
    public static double CalculateFutureValueRecursive(int years, double currentValue, double growthRate)
    {
        if (years == 0)
            return currentValue;

        return CalculateFutureValueRecursive(years - 1, currentValue, growthRate) * (1 + growthRate);
    }

    // Optimized with memoization to avoid redundant computation
    public static double CalculateFutureValueMemo(int years, double currentValue, double growthRate, Dictionary<int, double> memo)
    {
        if (years == 0)
            return currentValue;

        if (memo.ContainsKey(years))
            return memo[years];

        double result = CalculateFutureValueMemo(years - 1, currentValue, growthRate, memo) * (1 + growthRate);
        memo[years] = result;
        return result;
    }

    // Main method
    static void Main()
    {
        double currentValue = 10000;       // Starting value in dollars
        double annualGrowthRate = 0.05;    // 5% growth per year
        int years = 10;

        Console.WriteLine("=== Financial Forecasting Tool ===");

        // Simple recursive version
        double futureValue = CalculateFutureValueRecursive(years, currentValue, annualGrowthRate);
        Console.WriteLine($"\nRecursive Prediction after {years} years: ${futureValue:F2}");

        // Optimized version with memoization
        var memo = new Dictionary<int, double>();
        double futureValueMemo = CalculateFutureValueMemo(years, currentValue, annualGrowthRate, memo);
        Console.WriteLine($"Memoized Prediction after {years} years: ${futureValueMemo:F2}");
    }
}

