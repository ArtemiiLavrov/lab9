using System.Security.Cryptography.X509Certificates;

namespace lab9
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            int ans;
            DisciplineMark mark1 = new DisciplineMark();
            DisciplineMark mark2 = new DisciplineMark("Программирование", 8);
            DisciplineMark mark3 = new DisciplineMark(mark2);
            DisciplineMark mark4 = new DisciplineMark(mark2);
            do
            {
                Interface.MainMenu();
                ans = Interface.Answer();
                switch (ans)
                {
                    case 1:
                        {
                            Console.Clear();
                            Console.Write("mark1 - конструктор по умолчанию: ");
                            mark1.Show();
                            Console.Write("mark2 - конструктор с параметрами: ");
                            mark2.Show();
                            Console.Write("mark3 - конструктор копирования (mark2): ");
                            mark3.Show();
                            Console.Write("Метод класса - перевод в пятибалльную шкалу (mark2): ");
                            Interface.ChngClr($"{mark2.ConvertToNormal()}", ConsoleColor.Green);
                            Console.Write("Статическая функция - перевод в пятибалльную шкалу (mark2): ");
                            Interface.ChngClr($"{DisciplineMark.ConvertToNormal(mark2)}", ConsoleColor.Green);
                            Console.WriteLine();
                            break;
                        }
                    case 2:
                        {
                            Console.Clear();
                            Console.Write($"mark1 = ");
                            mark1.Show();
                            //Console.WriteLine(mark1.ToString());    
                            Console.Write($"mark2 = ");
                            mark2.Show();
                            Console.Write($"mark3 = ");
                            mark3.Show();
                            Console.Write($"mark4 = ");
                            mark4.Show();
                            Console.Write("Zeroed mark 4 = ");
                            mark4 = -mark4;
                            mark4.Show();
                            Console.Write("Upper mark 2 = ");
                            mark2 = !mark2;
                            mark2.Show();
                            int x = (int)mark3; //explicit operator - явное приведение типов
                            Console.WriteLine($"Количество букв в названии дисциплины {mark2.Name}: {x}");
                            bool y = (bool)mark2; //implicit operator - неявное приведение типов
                            Console.WriteLine($"Оценка по предмету {mark3.Name} > 4: {y}");
                            Console.Write($"Смена дисциплины: mark4.Name = {mark4.Name}, mark4 новая дисциплина: ");
                            mark4 = mark4 / "ТОИ";
                            mark4.Show();
                            Console.WriteLine();
                            break;
                        }
                    case 3:
                        {
                            Console.Clear();
                            do
                            {
                                Interface.Case3Menu();
                                ans = Interface.Answer();
                                switch (ans)
                                {
                                    case 1:
                                        {
                                            Console.Clear();
                                            DisciplineMarkArray d1 = new DisciplineMarkArray();
                                            d1.Show();
                                            break;
                                        }
                                    case 2:
                                        {
                                            Console.Clear();
                                            Interface.Offer("length");
                                            int length = DisciplineMarkArray.GetNumber("length");
                                            DisciplineMarkArray d2 = new DisciplineMarkArray(length);
                                            d2.Show();
                                            break;
                                        }
                                    case 3:
                                        {
                                            Console.Clear();
                                            DisciplineMarkArray d3 = new DisciplineMarkArray("programming");
                                            Console.Clear();
                                            d3.Show();
                                            break;
                                        }
                                    case 4:
                                        {
                                            Console.Clear();
                                            DisciplineMarkArray d3 = new DisciplineMarkArray();
                                            DisciplineMarkArray d4 = new DisciplineMarkArray(d3);
                                            Console.WriteLine("Объект d3:");
                                            d3.Show();
                                            Console.WriteLine("Объект d4 - глубокая копия d3:");
                                            d4.Show();
                                            break;
                                        }
                                    case 5:
                                        {
                                            Console.Clear();
                                            DisciplineMarkArray d = new DisciplineMarkArray();
                                            Console.WriteLine("Объект d:");
                                            d.Show();
                                            Console.WriteLine();
                                            Console.Write("Среднее значение оценок массива = ");
                                            Interface.ChngClr(DisciplineMarkArray.CalcAvg(d).ToString(),ConsoleColor.Green);
                                            Console.WriteLine();
                                            Console.WriteLine("Дисциплины с оценкой выше средней: ");
                                            Interface.PrintStringList(DisciplineMarkArray.DisciplinesMoreThanAvg(d));
                                            Console.WriteLine();
                                            break;
                                        }
                                    case 6:
                                        {
                                            Console.Clear();
                                            DisciplineMarkArray d1 = new DisciplineMarkArray();
                                            d1[0] = new DisciplineMark();
                                            d1[0].Show(); 
                                            d1[5] = new DisciplineMark("ERROR", 9);
                                            d1[5].Show();
                                            break;
                                        }
                                    case 7:
                                        {
                                            Console.Clear();
                                            break;
                                        }
                                    default:
                                        {
                                            Console.Clear();
                                            Interface.ChngClr("Такого пункта меню не существует.\nПовторите попытку ввода.\n", ConsoleColor.Red);
                                            break;
                                        }
                                }
                            } while (ans != 7);
                            break;
                        }
                    case 4:
                        {
                            Console.Clear();
                            do
                            {
                                Interface.ExitMenu();
                                ans = Interface.Answer();
                                switch (ans)
                                {
                                    case 1:
                                        {
                                            Console.Clear();
                                            Interface.ChngClr("Программа завершена", ConsoleColor.Green);
                                            System.Environment.Exit(0);
                                            break;
                                        }
                                    case 2:
                                        {
                                            Console.Clear();
                                            break;
                                        }
                                    default:
                                        {
                                            Console.Clear();
                                            Interface.ChngClr("Нет такого пункта меню.\nПовторите попытку ввода.\n \a", ConsoleColor.Red);
                                            break;
                                        }
                                }
                            } while (ans != 2);
                            break;
                        }
                    default:
                        {
                            Console.Clear();
                            Interface.ChngClr("Такого пункта меню не существует.\nПовторите попытку ввода.\n", ConsoleColor.Red);
                            break;
                        }
                }
            } while (true);
        }
    }
}