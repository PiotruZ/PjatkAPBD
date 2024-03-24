// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.WriteLine("Modyfikacja 1");
Console.WriteLine("Modyfikacja 2");
Console.WriteLine("Modyfikacja 3");

static double CalculateAverage(int[] numbers)
{
    if (numbers == null || numbers.Length == 0)
    {
        throw new ArgumentException("Tablica nie może być pusta");
    }

    double sum = 0;
    foreach (int number in numbers)
    {
        sum += number;
    }
    return sum / numbers.Length;
}

int[] numbers = { 1, 2, 3, 4, 5 };
double average = CalculateAverage(numbers);
Console.WriteLine($"Średnia: {average}");