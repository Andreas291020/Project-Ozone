namespace Project_Ozone;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, Git!");
        Console.WriteLine("I am Andreas");

        CountTo(num: 5);
    }
    
    /// <summary>
    /// This method counts to the number specified
    /// </summary>
    /// <param name="num"></param>
    static void CountTo(int num)
    {
        Console.WriteLine($"Counting to {num}");
        for (int i = 1; i <= num; i++)
        {
            Console.WriteLine(i+"...");
        }
    }
}