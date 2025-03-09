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

public static class MathHelper
{
    public static int MaxValue(int[] numbers)
    {
        if (numbers == null || numbers.Length == 0)
            throw new ArgumentException("Tablica nie może być pusta.", nameof(numbers));

        int max = numbers[0];
        foreach (var number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }
        return max;
    }
}


Console.WriteLine("Hello, World!");
