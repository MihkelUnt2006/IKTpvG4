namespace Kujundikalkulaator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            int roundRadius = 3;
            //int roundDiameter = 6;
            Console.WriteLine("Ruudu pindala "+(2 * roundRadius) * (2 * roundRadius ));
            Console.WriteLine("Ruudu ümbermõõt " + (2 * roundRadius) *4);
            Console.WriteLine("ringi ümbermõõt " + (2 * Math.PI * roundRadius));
            Console.WriteLine("Ringi pindala "+ (Math.PI) * (roundRadius*roundRadius));
           

        }
    } 
}
