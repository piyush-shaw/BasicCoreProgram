internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the number ");
        int num = Convert.ToInt32(Console.ReadLine());
        if (num % 2 == 0)
        {
            Console.WriteLine("Number is even");
        }
        else
        {
            Console.WriteLine("Number is odd ");
        }
    }
}