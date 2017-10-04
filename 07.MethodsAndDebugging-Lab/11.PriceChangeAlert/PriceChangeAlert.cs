using System;

class PriceChangeAlert
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        double threshold = double.Parse(Console.ReadLine());
        double price = double.Parse(Console.ReadLine());

        for (int i = 0; i < n - 1; i++)
        {
            double nextPrice = double.Parse(Console.ReadLine());
            double difference = GetDiffAsPercent(price, nextPrice);
            bool isSignificantDifference = GetDiff(difference, threshold);
            string message = GetMessage(nextPrice, price, difference, isSignificantDifference);
            Console.WriteLine(message);
            price = nextPrice;
        }
    }
    private static string GetMessage(double nextPrice, double price, double difference, bool GetDiff)
    {
        string message = "";
        if (difference == 0)
        {
            message = string.Format("NO CHANGE: {0}", nextPrice);
            return message;
        }
        else if (!GetDiff)
        {
            message = string.Format("MINOR CHANGE: {0} to {1} ({2:F2}%)", price, nextPrice, difference * 100);
            return message;
        }
        else if (GetDiff && (difference > 0))
        {
            message = string.Format("PRICE UP: {0} to {1} ({2:F2}%)", price, nextPrice, difference * 100);
            return message;
        }
        else if (GetDiff && (difference < 0))
        {
            message = string.Format("PRICE DOWN: {0} to {1} ({2:F2}%)", price, nextPrice, difference * 100);
            return message;
        }
        return message;
    }
    private static bool GetDiff(double threshold, double diff)
    {
        if (Math.Abs(threshold) >= diff)
        {
            return true;
        }
        return false;
    }
    private static double GetDiffAsPercent(double price, double nextPrice)
    {
        double difference = (nextPrice - price) / price;
        return difference;
    }
}
