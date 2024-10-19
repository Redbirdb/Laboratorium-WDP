namespace Laboratorium_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Zadanie1();
            //Zadanie2();
            //Zadanie3();
            //Zadanie4();
            //Zadanie5();
            //Zadanie6();
        }
        public static void Zadanie1()
        {
            int number = 45;
            int numberHundred = 300;
            int numberTens = 33;
            int numberOnes = 9;
            Console.WriteLine(number + numberHundred);
            Console.WriteLine(number - numberTens);
            Console.WriteLine(number / numberOnes);
        }
        public static void Zadanie2()
        {
            double degree = 45;
            double sinValue = Math.Sin(degree * Math.PI / 180);
            Console.WriteLine(sinValue);
        }
        public static void Zadanie3()
        {
            double area = -189;
            double radius = area >= 0 ? Math.Sqrt(area / Math.PI) : 0;
            Console.WriteLine(radius);
        }
        public static void Zadanie4()
        {
            double x = 0.45;
            double a = 1.5;
            double b = 3.2;
            double c = 4;
            double y = a* Math.Pow(x, 2) + b * x + c;
            Console.WriteLine(y);
        }
        public static void Zadanie5()
        {
            int a = 12;
            int b = 11;
            int c = 29;
            int max = 29;
            int min = 11;
            Console.WriteLine(max);
            Console.WriteLine(min);

         }
        public static void Zadanie6()
        {
            double time = 1234.45 ; // czas w minutach
            int time_hours = 20;
            int time_minutes = 34;
            int time_seconds = 27;
            
            Console.WriteLine($"{time_hours}:{time_minutes}:{time_seconds}");
        }
    }
}
