namespace Laboratorium_3
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
            Zadanie8();
        }

        public static void Zadanie1()
        {
            decimal balans = 56;
            bool isCreditCardValid = false;
            decimal price = 45;
            bool canPay = balans >= price && isCreditCardValid;
            Console.WriteLine(canPay);
        }
        public static void Zadanie2()
        {
            double a = 5;
            double b = 1;
            double c = 3;
            bool isTriangle = (a + b > c) && (a + c > b) && (b + c > a);
            Console.WriteLine(isTriangle);
        }
        public static void Zadanie3()
        {
            double cx = 2.56;
            double cy = 4.6;
            double cradius = 5;
            double x = 6.4;
            double y = 2.234;
            bool isOutside = Math.Pow(x - cx, 2) + Math.Pow(y - cy, 2) > Math.Pow(cradius, 2);
            Console.WriteLine(isOutside);
        }
        public static void Zadanie4()
        {
            int rx = 56;
            int ry = 34;
            int width = 23;
            int height = 12;
            int x = 23;
            int y = 11;
            bool isOnBorder = (x == rx || x == rx + width) && (y >= ry && y <= ry + height) || (y == ry || y == ry + height) && (x >= rx && x <= rx + width);
            Console.WriteLine(isOnBorder);
        }
        public static void Zadanie5()
        {
            double a = 2.5;
            double b = -0.5;
            double c = 1.5;

            double delta = b * b - 4 * a * c;

            if (delta > 0)
            {
                double root1 = (-b + Math.Sqrt(delta)) / (2 * a);
                double root2 = (-b - Math.Sqrt(delta)) / (2 * a);
                Console.WriteLine($"Pierwiastki równania kwadratowego: {root1} i {root2}");
            }
            else if (delta == 0)
            {
                double root = -b / (2 * a);
                Console.WriteLine($"Pierwiastek podwójny: {root}");
            }
            else
            {
                Console.WriteLine("Nie można otrzymać pierwiastków rzeczywistych!");
            }
        }
        public static void Zadanie6()
        {
            int code = 4;
            int quantity = 11;
            decimal price = 3.5m;
            decimal sellPrice;

            if (code < 10)
            {
                sellPrice = price;
            }
            else if (code >= 10 && code <= 15)
            { 
                sellPrice = price * 0.95m;
            }
            else
            {
                if (quantity <= 10)
                {
                    sellPrice = price * 1.05m;
                }
                else if (quantity >= 11 && quantity <= 20)
                {
                    sellPrice = price;
                }
                else if (quantity > 20 && quantity < 100)
                {
                    int discountPercentage = (quantity / 10) - 2;
                    sellPrice = price * (1 - discountPercentage * 0.01m);
                }
                else
                {
                    sellPrice = price * 0.90m;
                }
            }

            Console.WriteLine($"Price: {sellPrice}");
        }
        public static void Zadanie7()
        {
            int decimalNumber = 11;

            if (decimalNumber == 0)
            {
                Console.WriteLine("Rzymianie nie znali zera!");
            }
            else if (decimalNumber < 1 || decimalNumber > 20)
            {
                Console.WriteLine("Nie obsługuję liczb spoza zakresu od 1 do 20!");
            }
            else
            {
                string romanNumber = ConvertToRoman(decimalNumber);
                Console.WriteLine($"Liczba rzymska: {romanNumber}");
            }
        }

        private static string ConvertToRoman(int number)
        {
            switch (number)
            {
                case 1: return "I";
                case 2: return "II";
                case 3: return "III";
                case 4: return "IV";
                case 5: return "V";
                case 6: return "VI";
                case 7: return "VII";
                case 8: return "VIII";
                case 9: return "IX";
                case 10: return "X";
                case 11: return "XI";
                case 12: return "XII";
                case 13: return "XIII";
                case 14: return "XIV";
                case 15: return "XV";
                case 16: return "XVI";
                case 17: return "XVII";
                case 18: return "XVIII";
                case 19: return "XIX";
                case 20: return "XX";
                default: return "";
            }
        }
        public static void Zadanie8()
        {
            char hex = '9';
            int decimalValue;

            if (hex >= '0' && hex <= '9')
            {
                decimalValue = hex - '0';
            }
            else if (hex >= 'a' && hex <= 'f')
            {
                decimalValue = hex - 'a' + 10;
            }
            else if (hex >= 'A' && hex <= 'F')
            {
                decimalValue = hex - 'A' + 10;
            }
            else
            {
                Console.WriteLine("To nie jest cyfra szesnastkowa");
                return;
            }

            Console.WriteLine($"Wartość całkowita: {decimalValue}");
        }
    }
}
