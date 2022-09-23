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
            Console.WriteLine("Периметр трапеции равен " + k);
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

            Console.WriteLine("номер 11 поменять местами числа");
            Console.Write("Введите 1 число: ");
            int chis1 = int.Parse(Console.ReadLine());
            Console.Write("Введите 2 число: ");
            int chis2 = int.Parse(Console.ReadLine());
            Console.WriteLine($"{chis2}");
            Console.WriteLine($"{chis1}");
            Console.ReadKey();

            Console.WriteLine("номер 12 площадь или периметр фигур");
            Console.Write("Выберете фигуру(четырехугольник - 1, треугольник - 2 или круг - 3): ");
            int fig = int.Parse(Console.ReadLine());
            Console.Write("Искать площадь - 1 или периметр - 2?: ");
            int DD = int.Parse(Console.ReadLine());
            if (fig == 1)
            {
                if (DD == 2)
                {
                    Console.Write("Введите 1 сторну четырехугольника: ");
                    int a1 = int.Parse(Console.ReadLine());
                    Console.Write("Введите 2 сторну четырехугольника: ");
                    int b1 = int.Parse(Console.ReadLine());
                    Console.Write("Введите 3 сторну четырехугольника: ");
                    int c1 = int.Parse(Console.ReadLine());
                    Console.Write("Введите 4 сторну четырехугольника: ");
                    int dd1 = int.Parse(Console.ReadLine());
                    int per = a1 + b1 + c1 + dd1;
                    Console.WriteLine($"Периметр четырехугольника = {per}");
                }
                else
                {
                    Console.Write("Введите 1 диагональ четырехугольника: ");
                    int a2 = int.Parse(Console.ReadLine());
                    Console.Write("Введите 2 диагональ четырехугольника: ");
                    int b2 = int.Parse(Console.ReadLine());
                    Console.Write("Введите угол между диагоналями: ");
                    int c2 = int.Parse(Console.ReadLine());
                    double PL = (double)1 / 2 * a2 * b2 * Math.Sin(c2);
                    Console.WriteLine($"Площадь четырехугольника = {PL}");
                }
            }
            if (fig == 2)
            {
                if (DD == 2)
                {
                    Console.Write("Введите 1 сторну треугольника: ");
                    int a3 = int.Parse(Console.ReadLine());
                    Console.Write("Введите 2 сторну треугольника: ");
                    int b3 = int.Parse(Console.ReadLine());
                    Console.Write("Введите 3 сторну треугольника: ");
                    int c3 = int.Parse(Console.ReadLine());
                    int RED = a3 + b3 + c3;
                    Console.WriteLine($"Периметр треугольника = {RED}");
                }
                else
                {
                    Console.Write("Введите основание треугольника:");
                    int a4 = int.Parse(Console.ReadLine());
                    Console.Write("Введите высоту треугольника:");
                    int b4 = int.Parse(Console.ReadLine());
                    double TY = (double)a4 * b4 / 2;
                    Console.WriteLine($"Площадь треугольника = {TY}");
                }
            }
            if (fig == 3)
            {
                if (DD == 2)
                {
                    Console.WriteLine("Формулы для вычисления периметра круга нет");
                }
                else
                {
                    Console.Write("Введите радиус круга: ");
                    int rad = int.Parse(Console.ReadLine());
                    Console.WriteLine($"Площадь круга = {(double)(2 * rad * Math.PI)}");
                }
            }
            Console.ReadKey();

            Console.WriteLine("номер 13");
            Console.Write("Введите число: ");
            int t = int.Parse(Console.ReadLine());
            Console.WriteLine("Вы ввели число " + t);
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

            Console.WriteLine("номер 16 вычисление корней кв.уравнения");
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

            Console.WriteLine("номер 25 операции с трехзначным числом");
            Console.Write("Введите число n, такое что 100 <= n =< 999: ");
            string vvel = Console.ReadLine();
            if ((int.Parse(vvel) / 10) % 10 == 0)
            {
                Console.WriteLine("Число не удовлетворяет условию:число десятков в n не равно нулю.Ведите другое число");
            }
            else
            {
                Console.WriteLine("Число x = " + vvel[1] + vvel[2] + vvel[0]);
            }
            Console.ReadKey();

            Console.WriteLine("номер 26 ");
            Console.WriteLine();
            Console.Write("Введите время: часы (от 0 <= часы <= 23): ");
            int hour = int.Parse(Console.ReadLine());
            Console.Write("минуты (0 <= m <= 59): ");
            int mins = int.Parse(Console.ReadLine());
            Console.Write("секунды(0 <= s <= 59): ");
            int sec = Convert.ToInt32(Console.ReadLine());
            double ug = ((360 / 12) * hour + (0.5 * mins) + (0.0083 * sec));
            Console.WriteLine($"угол междe часовой стрелкой и в указанный момент времени равен {ug}");
            Console.ReadKey();

            Console.WriteLine("номер 27");
            Console.Write("Введите время: минуты(от 0 до 60): ");
            int time = int.Parse(Console.ReadLine());
            Console.WriteLine($"Значение угла для минутной стрелки составляет {(double)(((time * 60) * 0.0083) % 360)}, Полных часов: {time / 60}, Полных минут:{time % 60}");
            Console.ReadKey();

            Console.WriteLine("номер 28 минимальное по модулю число");
            Console.Write("Введите первое число: ");
            int d1 = int.Parse(Console.ReadLine());
            int D1 = Math.Abs(d1);
            Console.Write("Введите второе число: ");
            int d2 = int.Parse(Console.ReadLine());
            int D2 = Math.Abs(d2);
            Console.Write("Введите третье число: ");
            int d3 = int.Parse(Console.ReadLine());
            int D3 = Math.Abs(d3);
            double mint = Math.Min(Math.Min(d1, d2), d3);
            Console.WriteLine($"Минимальное по модулю число = {mint}");
            Console.ReadLine();

            Console.WriteLine("номер 29 сумма большего и меньшего из трёх чисел");
            Console.Write("Введите первое число: ");
            int chi1 = int.Parse(Console.ReadLine());
            Console.Write("Введите второе число: ");
            int chi2 = int.Parse(Console.ReadLine());
            Console.Write("Введите третье число: ");
            int chi3 = int.Parse(Console.ReadLine());
            double minn = Math.Min(Math.Min(chi1, chi2), chi3);
            double max = Math.Max(Math.Max(chi1, chi2), chi3);
            double summa = minn + max;
            Console.WriteLine($"Сумма большего и меньшего чисел равна {summa}");
            Console.ReadKey();

            Console.WriteLine("номер 30 подсчитать общее количество делителей натурального числа");
            Console.Write("Введите число: ");
            int fgh = int.Parse(Console.ReadLine());
            int ty = 0;
            for (int i = 1; i < fgh + 1; i++)
            {
                if (fgh % i == 0)
                {
                    ty++;
                }
            }
            Console.WriteLine($"У данного числа {ty} делителей ");
            Console.ReadKey();

            Console.WriteLine("номер 31 кубическое уравнение");
            Console.Write("Введите а: ");
            double aA = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите b: ");
            double bB = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите c: ");
            double cC = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите d: ");
            double dD = Convert.ToDouble(Console.ReadLine());
            for (int Xx = -100; Xx < 101; Xx++)
            {
                if (aA * Xx * Xx * Xx + bB * Xx * Xx + cC * Xx + dD == 0)
                {
                    Console.Write("Корень уравнения = " + Xx);
                    Console.WriteLine();
                }
            }
            Console.ReadKey();

            Console.WriteLine("номер 32 вычисление элемента прогрессии");
            Console.Write("Введите первый член прогрессии: ");
            double prog1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите второй член прогрессии: ");
            double prog2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите номер элемента прогрессии: ");
            double nom = Convert.ToDouble(Console.ReadLine());
            double isk = prog1 + ((prog2 - prog1) * (nom - 1));
            Console.WriteLine("Искомый член равен: " + isk);
            Console.ReadKey();

            Console.WriteLine("номер 33");
            Console.WriteLine("Вы пенсионер?: ");
            string question1 = Console.ReadLine();
            Console.WriteLine("Вы студент?: ");
            string question2 = Console.ReadLine();
            Console.WriteLine("Вы трудоустроен?: ");
            string question3 = Console.ReadLine();

            if ((question1 == "да" && question3 == "нет") || (question2 == "да" && question3 == "нет"))
            {
                Console.WriteLine("кредит одобрен");

            }
            else
            {
                Console.WriteLine("кредит не одобрен");
            }
            Console.ReadKey();

            Console.WriteLine("номер 34");
            Console.Write("Как вас зовут? ");
            string name = Console.ReadLine();
            Console.WriteLine($"{name}");
            Console.WriteLine("Привет," + name);
            Console.ReadLine();

            Console.WriteLine("номер 35 разговор Гарри и дневника Тома Реддла");
            Console.Write(""); //пользователь здоровается
            string hi = Console.ReadLine();
            Console.Write("Как тебя зовут?: ");
            string ima = Console.ReadLine();
            Console.WriteLine("привет," + ima);
            Console.Write(""); //подьзователь спрашивает, знает ли консоль что-то о тайной комнате
            string taina = Console.ReadLine();
            Console.WriteLine("Да");
            Console.Write(""); //пользователь спрашивает, может ли рассказать
            string rass = Console.ReadLine();
            Console.WriteLine("Нет");
            Thread.Sleep(5000);
            Console.WriteLine("Но могу показать");
            Random coll = new Random();
            Console.BackgroundColor = (ConsoleColor)coll.Next(0, 16);
            Console.Clear();
            Console.ReadKey();

            Console.WriteLine("номер 36 контрольная цифра штрихкода(EAN13)");
            Random random = new Random();
            int nr1 = random.Next(10);
            int nr2 = random.Next(10);
            int nr3 = random.Next(10);
            int nr4 = random.Next(10);
            int nr5 = random.Next(10);
            int nr6 = random.Next(10);
            int nr7 = random.Next(10);
            int nr8 = random.Next(10);
            int nr9 = random.Next(10);
            int nr10 = random.Next(10);
            int nr11 = random.Next(10);
            int nr12 = random.Next(10);
            int kontr = 10 - ((((nr2 + nr4 + nr6 + nr8 + nr10 + nr12) * 3) + (nr1 + nr3 + nr5 + nr7 + nr9 + nr11)) % 10);
            Console.WriteLine($"Контрольная цифра штрихкода {nr1}{nr2}{nr3}{nr4}{nr5}{nr6}{nr7}{nr8}{nr9}{nr10}{nr11}{nr12} равна {kontr}");
            Console.WriteLine("Введите 12 цифр (от 0 до 10)");
            int nm1 = int.Parse(Console.ReadLine());
            int nm2 = int.Parse(Console.ReadLine());
            int nm3 = int.Parse(Console.ReadLine());
            int nm4 = int.Parse(Console.ReadLine());
            int nm5 = int.Parse(Console.ReadLine());
            int nm6 = int.Parse(Console.ReadLine());
            int nm7 = int.Parse(Console.ReadLine());
            int nm8 = int.Parse(Console.ReadLine());
            int nm9 = int.Parse(Console.ReadLine());
            int nm10 = int.Parse(Console.ReadLine());
            int nm11 = int.Parse(Console.ReadLine());
            int nm12 = int.Parse(Console.ReadLine());
            int kontr2 = 10 - ((((nm2 + nm4 + nm6 + nm8 + nm10 + nm12) * 3) + (nm1 + nm3 + nm5 + nm7 + nm9 + nm11)) % 10);
            Console.WriteLine($"Контрольная цифра штрихкода {nm1}{nm2}{nm3}{nm4}{nm5}{nm6}{nm7}{nm8}{nm9}{nm10}{nm11}{nm12} равна {kontr2}");
            Console.ReadKey();
            

        }
    }
}
