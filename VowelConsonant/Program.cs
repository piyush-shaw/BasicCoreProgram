internal class Program
{
    static void Main(string[] args)

    {
        char ch ;
        Console.WriteLine("Enter any character");
        ch = Convert.ToChar(Console.ReadLine());
        if (ch == 'a' || ch == 'A' || ch == 'e' || ch == 'E' || ch == 'i' || ch == 'I' || ch == 'o' || ch == 'O' || ch == 'u' || ch == 'U')
        {
            Console.WriteLine(ch+" is a Vowel ");
        }
        else if ((ch >= 'a' && ch <= 'z') || (ch >= 'A' && ch <= 'Z'))
        {
            Console.WriteLine(ch+" is Consonant");
        }
    }
}