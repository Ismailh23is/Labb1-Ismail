namespace Labb1
{
    internal class Program
    {
        // Här tillsätter jag en static void Main(string[] args) för att de som skrivs hamnar i konsolen. 
        static void Main(string[] args)
        {
         // Här används string och Console.WriteLine för att skriva ut utdata från konsolen med en ny rad som läggs till efter texten.
            Console.WriteLine("Skriv namnet på person 1:");
            string Name_1 = Console.ReadLine();
         // Här används Convert.ToInt32(Console.readLine()) och int för att tillåta användaren att skriva åldern på personen med heltal.
            Console.WriteLine("Skriv åldern på person 1:");
            int Age_1=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Skriv namnet på person 2:");
            string Name_2 = Console.ReadLine();

            Console.WriteLine("Skriv åldern på person 2:");
            int Age_2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Skriv namnet på person 3:");
            string Name_3 = Console.ReadLine();

            Console.WriteLine("Skriv åldern på person 3:");
            int Age_3= Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Skriv namnet på person 4:");
            string Name_4 = Console.ReadLine();

            Console.WriteLine("Skriv åldern på person 4:");
            int Age_4= Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine(Name_1 + " är " + Age_1 + " år gammal");
            Console.WriteLine(Name_2 + " är " + Age_2 + " år gammal");
            Console.WriteLine(Name_3 + " är " + Age_3 + " år gammal");
            Console.WriteLine(Name_4 + " är " + Age_4 + " år gammal");
            // Int gör det möjligt så att vi får heltal
            int TotalAge= Age_1+Age_2+Age_3+Age_4;
            Console.WriteLine("Sammanlagd ålder är:" + TotalAge);
            // double gör det möjligt för oss att få in flera decimaler
            double MedianAge = (double)TotalAge / 4;
            string Decimaler = MedianAge.ToString("0.00");
            Console.WriteLine("Medelvädet är:" + Decimaler);

        }
    }
}
