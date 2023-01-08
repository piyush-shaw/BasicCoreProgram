internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter Two Numbers : ");
        Console.WriteLine("Enter Dividend Number ");
        int num1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter Divisor Number");
        int num2 = Convert.ToInt32(Console.ReadLine());
        int result1 = num1 / num2;
        int result2 = num1 % num2;
        Console.WriteLine("Quotient is "+result1);
        Console.WriteLine("Remainder is " + result2);
    }
}