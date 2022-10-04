namespace HW_6_3
{
    internal class Program
    {
        static ulong Factorial(uint n)
        {
                         
            if (n == 0)
            {
                return 1;
            }
            else
            {
                return Factorial(n - 1) * n;
            }
            
        }

        static void Main(string[] args)
        {
            Console.Write("Enter factorial n = ");
            var n = Convert.ToUInt32(Console.ReadLine());
            Console.WriteLine($"Factorial of a number {n} is equal {Factorial(n)}");
            Console.ReadLine();
        }
    }
}
