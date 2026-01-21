namespace VigadeParandus
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            string choice = Console.ReadLine();
            
            switch (choice)
            {
                case "1":
                   
                    UpsidePyramiid();
                    break;
                case "2":
                    
                    Rectangle();
                    break;
                case "3":
                    
                    break;
                default:
                    Console.WriteLine("vale valik");
                    break;

            }
            static void UpsidePyramiid()
            {
                int i, j, n;
                Console.Write("Loo Püramiid tärnidest: \n");
                Console.Write("----------------------");
                Console.Write("\n\n");
                Console.WriteLine("Sisesta Püramiidi suurus");
                n = Convert.ToInt32(Console.ReadLine());
                for (i = n - 0; i >= 1; i--)
                {
                    for (j = 1; j <= n - i; j++)
                    {

                        Console.Write(" ");
                    }
                    for (j = 1; j <= 2 * i - 1; j++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
            }
            static void Rectangle()
            {
                Console.WriteLine("Sisesta pikkus");
                int row = int.Parse(Console.ReadLine());
                Console.WriteLine("Sisesta laius");
                int col = int.Parse(Console.ReadLine());
                for (int i = 0; i < row; i++)
                {
                    for (int j = 0; j < col; j++)
                    {
                        Console.Write("* ");
                    }
                    Console.WriteLine();
                }

                int S = row * col;
                int P = 2 * (row + col);
                Console.WriteLine("Pindala on " + S);
                Console.WriteLine("Ümbermõõt on " + P);
            }
            
            
        }  
    }
}
