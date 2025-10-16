namespace switchrandomnumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("random number");
            int number = new Random().Next(1, 7);
             
            switch (number)
            {
                case 1:
                Console.WriteLine("number 1");
                break;
                case 2:
                    Console.WriteLine("number 2");
                    break;
                case 3:
                    Console.WriteLine("number 3");
                    break;
                case 4:
                    Console.WriteLine("number 4");
                    break;
                case 5:
                    Console.WriteLine("nuber 5");
                    break;
                case 6:
                    Console.WriteLine("number 6");
                    break;
                    default:
                    Console.WriteLine("error");
                    break; 

            }

        }
    }
}
