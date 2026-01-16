using System.Xml;

namespace Pyramid
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("vali  meetod");
            Console.WriteLine("1 - Pyramid");
            Console.WriteLine("2 - Ristkuluk");
            Console.WriteLine("3 - RuutVõrrand");


            int choise = int.Parse(Console.ReadLine());
            switch (choise)
            {
                case 1:
                    PyramidMethod();
                    break;
                case 2:
                    RistkulikMethod();
                    break;
                case 3:
                    RuutvorrandMethod();
                    break;
                default:
                    Console.WriteLine("Vale valik");
                    break;
            }
            static void PyramidMethod()
            {
                int i, j, n;

                Console.Write("Loo Püramiid tärnidest: \n");
                Console.Write("----------------------");
                Console.Write("\n\n");
                Console.WriteLine("Sisesta Püramiidi suurus");
                n = Convert.ToInt32(Console.ReadLine());
                for (i = n - 1; i >= 1; i--)
                {
                    for (j = 1; j <= n - i; j++)
                    {
                        Console.Write(" ");
                    }
                    for (j = 1; j <= 2 * i - 1; j++)
                    {
                        Console.Write("*");
                    }
                    Console.Write("\n");
                }
            }
            static void RistkulikMethod()
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
            static void RuutvorrandMethod()
            {
                Console.WriteLine("Ruutvõrrand");

             

                Console.Write("Sisesta a väärtus ");
                double a = double.Parse(Console.ReadLine());

                Console.Write("Sisesta b väärtus ");
                double b = double.Parse(Console.ReadLine());

                Console.Write("Sisesta c väärtus ");
                double c = double.Parse(Console.ReadLine());

                double d = b * b - 4 * a * c;

                Console.WriteLine($"x1 = {(-b + Math.Sqrt(d)) / (2 * a)}, " +
                    $"x2 = {(-b + Math.Sqrt(d)) / (2 * a)}");
            }


        }
    }
}
