namespace switchconsolebeep
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("sisesta number");
            int number = Convert.ToInt32(Console.ReadLine());
            switch (number)
            {
                case 1:
                 Console.Beep(1000, 500);
                    Console.WriteLine("1");
                    break;
                    case 2:
                    Console.WriteLine("2");
                    Console.Beep(1000, 500);
                    Console.Beep(1000, 500);
                    
                    break;
                    case 3:
                    Console.WriteLine("3");
                    Console.Beep(1000, 500);
                    Console.Beep(1000, 500);
                    Console.Beep(1000, 500);
                    break;
                    default:
                    Console.WriteLine("error");
                    break;


            }
        }  
        
        
    }
}
