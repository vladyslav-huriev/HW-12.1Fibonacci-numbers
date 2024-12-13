namespace HW_12._1._Fibonacci_numbers_
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Please enter the Fibonacchi number: ");
            int n = int.Parse(Console.ReadLine());
            int result = CalcFibonacchi.Calculate(n-1);
            Console.WriteLine($"The Fibonacchi number {n} is equil to {result}");
            // Console.WriteLine($"The Fibonacchi number {n-1} is equil to {result}");
        }
    }
}
static class CalcFibonacchi
{
    public static int Calculate(int n)
    {
        if (n < 0)
            throw new ArgumentException("The Fibonacchi number can not be negative");
        if (n == 1 || n == 2) return 1;
        // if (n == 1) return 1;
        return Calculate(n - 1) + Calculate(n - 2);
    }
}