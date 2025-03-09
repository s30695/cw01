// See https://aka.ms/new-console-template for more information

public static class MathHelper
{
    public static double CalculateAverage(int[] numbers)
    {
        if (numbers == null || numbers.Length == 0)
            throw new ArgumentException("Tablica nie może być pusta.", nameof(numbers));
        double sum = 0;
        foreach (var num in numbers)
        {
            sum += num;
        }
        return sum / numbers.Length;
    }
}


Console.WriteLine("Hello, World!");
