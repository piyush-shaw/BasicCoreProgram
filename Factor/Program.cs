internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the number to find prime factorization ");
        int num = Convert.ToInt32(Console.ReadLine());
        for(int i = 1; i <= num; i++)
        {
            if (num % i == 0)
            {
                Console.WriteLine("The prime factors of "+num+" is "+i);
            }
        }
    }
}