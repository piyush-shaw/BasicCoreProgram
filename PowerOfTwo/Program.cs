internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the N value ");
        int powerOfTwo = Convert.ToInt32(Console.ReadLine());
        if (powerOfTwo <= 0 || powerOfTwo < 31)
        {
            Console.WriteLine("Power of 2's ");
            for(int i = 0; i <= powerOfTwo; i++)
            {
                int value = ((int)Math.Pow(2, i)); //2^i
                Console.WriteLine("The of value 2^"+i+" is "+value);
            }
        }
        else
        {
            Console.WriteLine("Value overflow int value");
        }
    }
}