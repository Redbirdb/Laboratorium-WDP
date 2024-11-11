namespace Laboratorium5
{
    internal class Program
    {

        public static double QuadraticEquation(double x, double a, double b, double c)
        {
            return a * x * x + b * x + c;
        }

        public static double ReadDouble(string prompt)
        {
            double result;
            while (true)
            {
                Console.Write(prompt);
                if (double.TryParse(Console.ReadLine(), out result))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Nieprawidłowy format. Proszę wprowadzić liczbę typu double.");
                }
            }
            return result;
        }

        /*public static double QuadraticEquation(double x = 0.0, double a = 1.0, double b = 1.0, double c = 1.0)
        {
            return a * x * x + b * x + c;
        }*/

        public static double CircleArea(double radius)
        {
            if (radius < 0)
            {
                return double.NaN;
            }

            return Math.PI * radius * radius;
        }

        public static void Print(double value)
        {
            Console.WriteLine($"Wartość argumentu = {value}");
        }
        static void Main(string[] args)
        {
            /*double liczba = 5.8;
            Print(liczba);*/
            /*double radius1 = 5.0;
            double area1 = CircleArea(radius1);
            Console.WriteLine($"Pole koła o promieniu {radius1} wynosi {area1}");

            double radius2 = -3.0;
            double area2 = CircleArea(radius2);
            Console.WriteLine($"Pole koła o promieniu {radius2} wynosi {area2}");*/
            /*Console.WriteLine(QuadraticEquation());
            Console.WriteLine(QuadraticEquation(2.0));
            Console.WriteLine(QuadraticEquation(2.0, 2.0));
            Console.WriteLine(QuadraticEquation(2.0, 2.0, 3.0, 4.0));*/
            /*double x = ReadDouble("Podaj wartość x: ");
            double a = ReadDouble("Podaj wartość a: ");
            double b = ReadDouble("Podaj wartość b: ");
            double c = ReadDouble("Podaj wartość c: ");
            double result = QuadraticEquation(x, a, b, c);
            Console.WriteLine($"Wartość funkcji kwadratowej dla x = {x}, a = {a}, b = {b}, c = {c} wynosi {result}");*/

            double price = 100.0;
            int code = 2;
            double tax = 0.0;

            if (code == 2)
            {
                tax = 0.17 * price;
            }
            Console.WriteLine($"Cena: {price}, Kod: {code}, Podatek: {tax}");
        }
    }
}
