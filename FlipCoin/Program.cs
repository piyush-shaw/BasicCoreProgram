internal class Program
{
    static void Main(string[] args)
    {
        int head = 0;
        int tail = 0;
        //input data
        Console.WriteLine("enter no of times you want to flip the coin : ");
        int input = Convert.ToInt32(Console.ReadLine());
        //computation
        for(int i = 0; i < input; i++)
        {
            Random random = new Random();
            int value = random.Next(0, 2);
            if (value < 0.5)
            {
                tail++;
            }
            else
            {
                head++;
            }
            
        }
        double head_count = head / (double)input * 100;
        double tail_count = tail / (double)input * 100;
        Console.WriteLine("Percantage of heads : " + head_count + "%");
        Console.WriteLine("Percentage of tails : " + tail_count + "%");
    }
}