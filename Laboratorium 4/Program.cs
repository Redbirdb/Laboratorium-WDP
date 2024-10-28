using System.Diagnostics.CodeAnalysis;

namespace Laboratorium_4
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
            //Zadanie7();
            //Zadanie8();
            Zadanie9();
        }

        public static void Zadanie1()
        {
            double[] factors = {2.4, 1.9, -0.5};
            double x = 2.3;

            if (factors.Length < 3)
            {
                Console.WriteLine("Nie można obliczyć równania, nie ma wszystkich współczynników.");
            }
            else if (factors.Length > 3) 
            {
                Console.WriteLine("Tablica factors ma więcej niż 3 elementy.");
            }
            else
            {
                double a = factors[0];
                double b = factors[1];
                double c = factors[2];

                double result = a * Math.Pow(x, 2) + b * x + c;
                Console.WriteLine($"Wartość funkcji dla x = {x} wynosi: {result}");
            }
        }
        public static void Zadanie2()
        {
            double[] arr = { 12.5, 6.7, 2.89, 10.1, 2.45 };

            Console.WriteLine("Elementy tablicy od ostatniego do pierwszego:");
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(arr[i]);
            }
        }
        public static void Zadanie3()
        {
            int suma = 0;

            Console.WriteLine("Wpisuj liczby całkowite. Aby zakończyć, wpisz coś, co nie jest liczbą całkowitą.");

            while (true)
            {
                Console.Write("Podaj liczbę: ");

                if (int.TryParse(Console.ReadLine(), out int value))
                {
                    suma += value;
                }
                else
                {
                    Console.WriteLine("Nie wpisałeś liczby całkowitej! Koniec programu.");
                    break;
                }

            }
            Console.WriteLine($"Suma wpisanych liczb wynosi: {suma}");

        }
        public static void Zadanie4()
        {
            double[,] arr = { { 1.1, 3.5, 2.56 }, { 1.4, 34, 7, }, { 1.5, 56, 2.6 } };
            double b = 4.1;

            Console.WriteLine($"Liczby większe od {b}:");

            
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (arr[i, j] > b)
                    {
                        Console.WriteLine(arr[i, j]);
                    }
                }
            }
        }

        public static void Zadanie5()
        {
            int n;

          
            while (true)
            {
                Console.Write("Podaj dodatnią liczbę całkowitą n: ");

                if (int.TryParse(Console.ReadLine(), out n))
                {
                    if (n > 0)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Podana liczba jest ujemna lub równa zero. Spróbuj ponownie.");
                    }
                }
                else
                {
                    Console.WriteLine("Nie wpisałeś liczby całkowitej! Spróbuj ponownie.");
                }
            }

            
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(new string('#', i));
            }
        }
        public static void Zadanie6()
        {
            
            Console.Write("Podaj liczbę n: ");
            int n = int.Parse(Console.ReadLine());

            
            double[] values = new double[n];

            
            Console.WriteLine("Podaj liczby:");
            for (int i = 0; i < n; i++)
            {
                values[i] = double.Parse(Console.ReadLine());
            }

            
            Console.WriteLine("Co druga liczba z tablicy values w odwrotnej kolejności:");
            for (int i = n - 1; i >= 0; i -= 2)
            {
                Console.WriteLine(values[i]);
            }
        }
        public static void Zadanie7()
        {
            
            Console.Write("Podaj liczbę n (liczba wierszy): ");
            int n = int.Parse(Console.ReadLine());

            Console.Write("Podaj liczbę m (liczba kolumn): ");
            int m = int.Parse(Console.ReadLine());

            
            char[,] rectangle = new char[n, m];

            
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    
                    if (i == 0 || i == n - 1 || j == 0 || j == m - 1)
                    {
                        rectangle[i, j] = '#';
                    }
                    else
                    {
                        rectangle[i, j] = ' ';
                    }
                }
            }

            
            Console.WriteLine("Zawartość tablicy:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(rectangle[i, j]);
                }
                Console.WriteLine();
            }
        }
        public static void Zadanie8()
        {
            
            Console.Write("Podaj liczbę całkowitą n: ");
            long n = long.Parse(Console.ReadLine());

            
            int liczbaCyfr = n.ToString().Length;

            
            Console.WriteLine($"Liczba cyfr {n} to {liczbaCyfr}");
        }
        public static void Zadanie9()
        {
            
            Console.Write("Podaj wysokość trójkąta (n): ");
            int n = int.Parse(Console.ReadLine());

            
            for (int i = 0; i < n; i++)
            {
                
                Console.Write(new string(' ', i));

                
                Console.WriteLine(new string('#', 2 * (n - i) - 1));
            }
        }
    }
    
}
