using System.Runtime.ExceptionServices;

namespace fibanaccifor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Fibonacci");
            int prv = 0, pre = 1, trm, i, n;
            Console.WriteLine("sisesta number");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Siin ob Fibonacci seeria kuni {0}: \n", n);
            Console.WriteLine($"{0}  {1}", prv, pre);
            for (i  = 0; i <= n; i++)
            {
                trm = prv + pre;
                Console.Write("{0} ", trm);
                prv = pre;
                pre = prv;
            }
        }
    }
}