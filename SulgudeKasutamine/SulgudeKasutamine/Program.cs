namespace SulgudeKasutamine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sulgude kasutamine");
            Console.WriteLine("Kui palju on 3+8/(4-2) *4 = ?");

            double calculation1 = 3 + 8/(4 - 2) * 4;
            float calculation2 = 3 + 8 / 4 - 2 * 4;
            float calculation3 = (3 + 8) / (4 - 2) * 4;
            float calucalation4 = 3 + 8 / ((4-2) * 4);
            Console.WriteLine("3 + 8/(4 - 2) * 4 = " + calculation1);
            Console.WriteLine("3 + 8 / 4 - 2 * 4 = " + calculation2);
            Console.WriteLine("(3 + 8) / (4-2) * 4 = " + calculation3);
            Console.WriteLine("3 + 8 / ((4-2) * 4) = "  + calucalation4);



        }
    }
}
