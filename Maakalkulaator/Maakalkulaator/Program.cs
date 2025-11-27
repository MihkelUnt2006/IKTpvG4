namespace Maakalkulaator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            int coinDiameter = 26 ;
            long earthRadius = 6371000000000;
            Console.WriteLine("maa ümbermõõt " + (2 * Math.PI * earthRadius));
            Console.WriteLine("Müntide arv ümber Maa "+ (2 * Math.PI * earthRadius) / coinDiameter);

        }
    }
}
