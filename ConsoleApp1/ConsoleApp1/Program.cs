namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kirjuta faili läbi konsooli");
            string filePath = @"C:\Users\opilane\Desktop/Uus Tekstidokument (2).txt";
            string inputText = Console.ReadLine();

            File.WriteAllText(filePath, inputText);
        }
        
        

       
    }
}
