internal class Program
{
    static void Main(string[] args)
    {
        int x, y, s;
        Console.WriteLine("Enter the value of X ");
        x = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the value of Y ");
        y = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Before swapping the number are "+x+" "+y);
        s = x;
        x = y;
        y = s;
        Console.WriteLine("Afer swapping the number are "+x+" "+y);
    }
}