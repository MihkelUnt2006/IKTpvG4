using System.Text;
using System.Text.RegularExpressions;

namespace FindWord
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta otsitav sõna");
            Console.WriteLine("kasuta formaati: s--a. Kus - tähistab tundumatut tähte");
            string choise = Console.ReadLine();

            WordFinder(choise);
        }
        private static void WordFinder(string choise)
        {
            Regex regularExp = new Regex(@"\b" + choise.Replace("-", "\\w"),
            RegexOptions.Compiled | RegexOptions.IgnoreCase);

            try
            {
           
                using (StreamReader sr = new StreamReader("C:/Users/opilane/Desktop/lemmad.txt", Encoding.Default))
                {

                    int LineNumber = 0;
                    while (sr.EndOfStream == false)
                    {
                        string line = sr.ReadLine();
                        if (line.Length == choise.Length)
                        {
                            MatchCollection matchCollection = regularExp.Matches(line);
                            if (matchCollection.Count > 0)
                            {
                                LineNumber++;
                                Console.WriteLine(LineNumber + " " + line);
                            }
                        }
                    }
                    sr.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ei ole olemas sellise pikkusega sõna");
                Console.WriteLine(ex.Message);
                throw;
            }
        }
    }
}
