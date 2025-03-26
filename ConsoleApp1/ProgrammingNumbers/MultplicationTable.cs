namespace ConsoleApp1
{
    internal class MultplicationTable
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number to print the multiplication table : " );
            int number =  Convert.ToInt32(Console.ReadLine());
            for(int i=0; i <= 10; i++)
            {
                // 9 * 1 = 9
                Console.WriteLine($"{number} * {i} = "+number*i);
            }
            Console.Read();
        }
    }
}
