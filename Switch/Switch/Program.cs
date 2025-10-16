namespace Switch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("sisesta täht ja vajuta enter");
            string input = Console.ReadLine();
            switch (input)
            {
                case "a":
                    Console.WriteLine("sisestasid tähe a");
                    break;

                case "e":
                    Console.WriteLine("sisestasid tähe e");
                    break;

                case "i":
                    Console.WriteLine("sisestasid tähe i");
                    break;
                default:
                    Console.WriteLine("ei ole vokaal");
                    break;

            }
        }
    }
}
