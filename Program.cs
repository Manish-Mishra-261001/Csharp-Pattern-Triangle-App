using System;

class Program
{
    
    static void Main()
    {
                Console.Write("Enter the number of rows for the triangle: \n");
                 if (!int.TryParse(Console.ReadLine(), out int n) || n <= 0)
        {
            Console.WriteLine("Please enter a positive integer.");
            return;
        }
        for(int i=1;i<=n;i++)
        {
            Console.Write(new string(' ', n - i));
            Console.WriteLine(new string('*', 2 * i - 1));
        }

    }
}
