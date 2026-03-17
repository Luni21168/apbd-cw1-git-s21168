namespace ConsoleApp1;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        int num1 = 10;
        int[] val = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        Console.WriteLine(val[0]);
        Console.WriteLine(num1);
        

        Console.WriteLine("Feature-average v2");
        double average = CalculateAverage(val);
        Console.WriteLine(average);
        
    }

    public static double CalculateAverage(int[] values)
    {
        if (values == null || values.Length == 0)
            throw new ArgumentNullException("Array cant be null or empty");

        int sum = 0;
        foreach (int value in values)
        {
            sum += value;
        }

        return (double)sum / values.Length;
    }
}
    
