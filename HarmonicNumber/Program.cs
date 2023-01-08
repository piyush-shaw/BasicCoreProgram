internal class Program
{
    static void Main(string[] args)
    {
        double sum = 0;
        Console.WriteLine("Enter number of terms ");
        int num = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Harmonic series is");
        for (int i = 1; i <= num; i++)
        {
            Console.WriteLine("1/"+i);
            sum += 1 / (float)i;
            Console.WriteLine(sum);
        }
        Console.WriteLine("Sum of harmonic series upto "+num+" terms "+sum);
    }
}