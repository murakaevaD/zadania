// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadania
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("номер 1 число Е");
            double a = Math.E;
            a = Math.Round(a, 1);
            Console.WriteLine(a);
            Console.ReadLine();

            Console.WriteLine("номер 2");
            Console.WriteLine("50");
            Console.WriteLine("10");
            Console.ReadLine();

            Console.WriteLine("номер 3 любые 4 числа");
            Console.WriteLine("657");
            Console.WriteLine("67");
            Console.WriteLine("7584");
            Console.WriteLine("75499");
            Console.ReadLine();

            Console.WriteLine("номер 4 число больше на 10");
            Console.Write(" Введите число: ");
            int n = int.Parse(Console.ReadLine());
            int sum = n + 10;
            Console.WriteLine($"{sum}");
            Console.ReadLine();

            Console.WriteLine("номер 5 периметр");
            Console.Write("Сторона квадрата равна: ");
            int p = int.Parse(Console.ReadLine());
            int W = 4 * p;
            Console.WriteLine($"Периметр: " + W);
            Console.ReadLine();

            Console.WriteLine("номер 6 длина оружности и площадь круга");
            Console.Write("Укажите радиус окружности: ");
            double r = double.Parse(Console.ReadLine());
            double площ = Math.Pow(r, 2) * Math.PI;
            double длина = 2 * r * Math.PI;
            Console.WriteLine($"Длина окружности равна {длина} , а площадь равна {площ} ");
            Console.ReadLine();

            Console.WriteLine("номер 7 Вычислиние Y=cos(X) ");
            Console.Write("Введите значение X:");
            double X = double.Parse(Console.ReadLine());
            Console.WriteLine($"Y={Math.Cos(X)}");
            Console.ReadLine();

            Console.WriteLine("номер 8 периметр трапеции");
            Console.Write("нижнее основание трапеции равно: ");
            int j = int.Parse(Console.ReadLine());
            Console.Write("верхнее основание трапеции равно: ");
            int f = int.Parse(Console.ReadLine());
            Console.Write("Высота трапеции равна: ");
            int g = int.Parse(Console.ReadLine());
            float h = (float)Math.Sqrt(Math.Pow((j - f) / 2, 2) + Math.Pow(g, 2)); //боковая сторона трапеции
            float k = j + f + (h * 2);
            Console.WriteLine("Периметр трапеции равен " +k);
            Console.ReadLine();

            Console.WriteLine("номер 9 покупка конфет печенья яблок");
            Console.WriteLine("Какова стоимость кг конфет?");
            int q = int.Parse(Console.ReadLine());
            Console.WriteLine("Сколько купили кг конфет?");
            int q1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Какова стоимость кг печенья?");
            int w = int.Parse(Console.ReadLine()); ;
            Console.WriteLine("Сколько купили кг печенья?");
            int w1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Какова стоимость кг яблок?");
            int e = int.Parse(Console.ReadLine());
            Console.WriteLine("Сколько купили кг яблок?");
            int e1 = int.Parse(Console.ReadLine());
            int TotalCost = (q * q1) + (w * w1) + (e * e1);
            Console.Write("Общая стоимость покупки составит: " + TotalCost);
            Console.ReadLine();

            Console.WriteLine("номер 10");
            Console.WriteLine("Мир Труд Май");
            Console.WriteLine("Мир" + "\n" + "  " + "Труд" + "\n" + "       " + "Май");
            Console.ReadLine();

            Console.WriteLine("номер 11");
            Console.WriteLine();

            Console.WriteLine("номер 12");
            Console.ReadLine();

            Console.WriteLine("номер 13");
            Console.Write("Введите число: ");
            int t = int.Parse(Console.ReadLine());
            Console.WriteLine("Вы ввели число ", +t);
            Console.ReadLine();

            Console.WriteLine("номер 14");
            Console.WriteLine($"2 кг\n13 17");
            Console.ReadLine();

            Console.WriteLine("номер 15 вывести 4 рандомных числа");
            Random rnd = new Random();
            int z = rnd.Next();
            int x = rnd.Next();
            int v = rnd.Next();
            int d = rnd.Next();
            Console.WriteLine($"{z}\n{x}\n{v}\n{d}");
            Console.ReadLine();

            Console.WriteLine("номер 16 (вычисление корней кв.уравнения");
            Console.Write("Введите значение A1:");
            int A1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите значение B1:");
            int B1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите значение C1:");
            int C1 = Convert.ToInt32(Console.ReadLine());
            double D = B1 * B1 - 4 * A1 * C1; //дискриминант
            double Dd = Math.Sqrt(D); // вычисление корня из дискриминанта
            double k1 = (-B1 + Dd) / (2 * A1); //первый корень
            double k2 = (-B1 - Dd) / (2 * A1); // второй корень
            if (D < 0)
            {
                Console.WriteLine("Корней нет");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine($"первый корень равен " + k1);
                Console.WriteLine($"второй корень равен " + k2);
            }
            Console.ReadLine();

            Console.WriteLine("номер 17 среднее ариф и геом двух чисел");
            Console.Write("Введите первое целое число ");
            int z1 = int.Parse(Console.ReadLine());
            Console.Write("Введите второе целое число ");
            int z2 = int.Parse(Console.ReadLine());
            int arif = (z1 + z2) / 2;
            double geom = Math.Sqrt(z1 * z2);
            Console.WriteLine("Среднее арифметическое двух чисел = " + arif);
            Console.WriteLine("Среднее геометрическое двух чисел = " + geom);
            Console.ReadLine();

            Console.WriteLine("номер 18 расстояние между точками");
            Console.WriteLine("Укажи координаты x1:");
            int x1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Укажи координаты y1:");
            int y1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Укажи координаты x2:");
            int x2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Укажи координаты y2:");
            int y2 = int.Parse(Console.ReadLine());
            Console.WriteLine($"Расстояние между точками равно {Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2))}");
            Console.ReadLine();

            Console.WriteLine("номер 19 замена чисел");
            Console.Write("Введите число А:");
            int A = int.Parse(Console.ReadLine());
            Console.Write("Введите число Б:");
            int B = int.Parse(Console.ReadLine());
            Console.Write("Введите число С:");
            int C = int.Parse(Console.ReadLine());
            int buf = A;
            A = B;
            B = C;
            C = buf;
            Console.WriteLine($"A = {A} B = {B} C = {C} ");
            Console.ReadLine();

            Console.WriteLine("номер 20");
            Console.Write("Введите сколько секунд прошло с начала суток:");
            int seconds = Int32.Parse(Console.ReadLine());
            int hours = seconds / 3600;
            int min = (seconds - (hours * 3600)) / 60;
            int sek = seconds - (hours * 3600) - (min * 60);
            Console.WriteLine($"С начала суток прошло {hours} полных часов, {min} полных минут и {sek} полных секунд");
            Console.ReadLine();

            Console.WriteLine("номер 21");
            Console.WriteLine("Длина прямоугольника равна 543 мм, Ширина - 130 мм, Сторона квадрата - 130 мм");
            Console.WriteLine($"Можно отрезать {(int)(543 / 130) * (int)(130 / 130)} квадрата");
            Console.ReadLine();

            Console.WriteLine("номер 22 меняем местами цифры");
            Console.Write("Введите любое ТРЕХЗНАЧНОЕ число:");
            int c = int.Parse(Console.ReadLine());
            Console.WriteLine($"{c % 10}{c / 10}");
            Console.ReadLine();

            Console.WriteLine("номер 23 число сотен и тысяч");
            Console.Write("Введите число больше 999:");
            int N = int.Parse(Console.ReadLine());
            Console.WriteLine($"В числе {(int)(N / 100)} сотен и {(int)(N / 1000)} тысяч");
            Console.ReadLine();

            Console.WriteLine("номер 24 перестановка цифр в 4-х значном числе");
            Console.Write("Введите четырехзначное число:");
            string b = Console.ReadLine();
            Console.WriteLine($"при прочтении справа налево {b[3]}{b[2]}{b[1]}{b[0]}");
            Console.WriteLine($"при перестановке 1 и 2,3 и 4 цифр {b[1]}{b[0]}{b[3]}{b[2]}");
            Console.WriteLine($"при перестановке 2 и 3 цифр {b[0]}{b[2]}{b[1]}{b[3]}");
            Console.WriteLine($"при перестановке двух первых и двух последних цифр {b[3]}{b[2]}{b[0]}{b[1]}");
            Console.ReadLine();

            Console.WriteLine("номер 34");
            Console.Write("Как вас зовут?");
            string name = Console.ReadLine();
            Console.WriteLine($"{name}");
            Console.WriteLine($"Привет," + name);
            Console.ReadLine();

            
        }
    }
}
