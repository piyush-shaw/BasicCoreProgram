internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the Year ");
        int year = Convert.ToInt32(Console.ReadLine());
        if (year % 400 == 0 || year % 4 == 0 && year % 100 != 0)
        {
            Console.WriteLine(year+" is a Leap Year");
        }
        else
        {
            Console.WriteLine(year+" is not a Leap Year");
        }
    }
}