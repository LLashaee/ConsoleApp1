
// See https://aka.ms/new-console-template for more information
//int i ;
//for (i = 5; i < 20; i++) 
//{
//    Console.WriteLine("jjhh");
//}
class program
{
    static void Main()
    {
        Console.WriteLine("enter a start number:");
        int start = int.Parse(Console.ReadLine());
        Console.WriteLine("enter the end number:");
        int end = int.Parse(Console.ReadLine());
        Console.WriteLine($"the prime number between {start} and {end} ");
        for (int i = start; i < end; i++)
        {
            if (Isprime(i))
            {
                Console.WriteLine(i + " ");
            }
        }
        static bool Isprime(int number)
        {
            if (number < 2) { return true; }
            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % 2 == 0) { return false; }
            }
            return true;

        }
    }
}

