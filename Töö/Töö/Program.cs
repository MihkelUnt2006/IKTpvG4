 namespace Töö
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("vali meetod ");
            Console.WriteLine("Sisesta number");
            Console.WriteLine("1.Teksti sisestus ja .txt-faili genereerimine");
            Console.WriteLine("2.Kalkulaator");
            Console.WriteLine("3.Ruut");

            int choice = int .Parse(Console.ReadLine());
            if (choice == 1)
            {
                txtFail();
            }
            else if (choice == 2)
            {
                Calc();
            }
            else if (choice == 3)
            {
                Ruut();
            }
            else
            {
                Console.WriteLine("Vale valik");
            }
        }
        static void txtFail()
        {
            Console.Clear();
            Console.WriteLine("Sisesta tekst");


            string filePath = "C:/Users/opilane/Desktop/Fail.txt";
            string input = Console.ReadLine();

            File.WriteAllText(filePath, input);
        }
        static void Calc()
        {
            Console.WriteLine("Vali tehe");
            Console.WriteLine("1.Litmine");
            Console.WriteLine("2.Lahutamine");
            Console.WriteLine("3.Korrutamine");
            Console.WriteLine("4.Jagamine");
            Console.WriteLine("5.Ruutvõrrand");

            string valik = Console.ReadLine();

            switch (valik)
            {
                case "1":
                    Liitmine();
                    break;
                case "2":
                    Lahutamine();
                    break;
                case "3":
                    Korrutamine();
                    break;
                case "4":
                    Jagamine();
                    break;
                case "5":
                    Ruutvõrrand();
                    break;
                default:
                    Console.WriteLine("vale valik");
                    break;

            }
            static void Liitmine ()
            {
                Console.Write("Arv 1:");
                double a = Convert.ToDouble(Console.ReadLine());
                Console.Write("Arv 2: ");
                double b = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Tulemus: " + (a + b));
                Console.ReadKey();
            }
            static void Lahutamine()
            {
                Console.Write("Arv 1: ");
                double a = Convert.ToDouble(Console.ReadLine());
                Console.Write("Arv 2:");
                double b = Convert.ToDouble (Console.ReadLine());
                Console.WriteLine("Tulemus:" + (a - b));
                Console.ReadKey ();

            }
            static void Korrutamine()
            {
                Console.Write("Arv 1: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Arv 2: ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Tulemus: " + (a * b));
            Console.ReadKey();
            }
            static void Jagamine()
            {
                Console.Write("Arv 1; ");
                double a = Convert.ToDouble(Console.ReadLine());
                Console.Write("Arv 2: ");
                double b = Convert.ToDouble(Console.ReadLine());
                if (b != 0)
                    Console.WriteLine("Tulemus: " + (a / b));
                else
                    Console.WriteLine("Nulliga Jagata ei saa");

            }
            static void Ruutvõrrand()
            {
                Console.WriteLine("Sisesta arv A");
                double a = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Siseta arv B");
                double b = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Sisesta arv C");
                double c = Convert.ToDouble(Console.ReadLine());

                double D = b * b - 4 * a * c;

                if (D > 0)
                {
                    double x1 = (-b + Math.Sqrt(D)) / (2 * a);
                    double x2 = (-b - Math.Sqrt(D)) / (2 * a);
                    Console.WriteLine("Lahendid: x1 = " + x1 + ", x2 = " + x2);
                }
                else if (D == 0)
                {
                    double x = -b / (2 * a);
                    Console.WriteLine("Üks lahend: x = " + x);
                }
                else
                {
                    Console.WriteLine("Lahendeid pole");
                }


            }

        }
        static void Ruut()
        {
            Console.WriteLine("sisesta ruudu suurus");
            int scale = int .Parse(Console.ReadLine());
            for (int i = 0; i < scale; i++)
            {
                for (int j = 0; j < scale; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }
    }
 }
