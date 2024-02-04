namespace lab9
{
    public class Interface
    {
        static List<string> mainMenu = new List<string>() { "╔╦╗╔═╗╦╔╗╔  ╔╦╗╔═╗╔╗╔╦ ╦\r\n║║║╠═╣║║║║  ║║║║╣ ║║║║ ║\r\n╩ ╩╩ ╩╩╝╚╝  ╩ ╩╚═╝╝╚╝╚═╝",
            "1.Задание №1", "2.Задание №2", "3.Задание №3", "4.Выход\n" };
        static List<string> exitMenu = new List<string>() { "Вы уверены, что хотите завершить работу?", "1.Да", "2.Нет" };
        static List<string> case3Menu = new List<string>() { "╔╦╗╦ ╦╦╦═╗╔╦╗  ╔╦╗╔═╗╔═╗╦╔═\r\n ║ ╠═╣║╠╦╝ ║║   ║ ╠═╣╚═╗╠╩╗\r\n ╩ ╩ ╩╩╩╚══╩╝   ╩ ╩ ╩╚═╝╩ ╩",
            "1.Заполнение по умолчанию", "2.Заполнение рандомными элементами","3.Заполнение вручную","4.Глубокое копирование","5.Дисциплины, имеющие оценку выше средней","6.Индексация","7.Выход\n"};
        public static void ChngClr(string str, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(str);
            Console.ResetColor();
        }
        public static void PrintStringList(List<string> list)
        {
            for (int i = 0; i < list.Count; i++) 
            {
                ChngClr(list[i],ConsoleColor.Green);
            }
        }
        public static void MainMenu()
        {
            ChngClr(mainMenu[0], ConsoleColor.Blue);
            for (int i = 1; i<mainMenu.Count; i++)
            {
                Console.WriteLine(mainMenu[i]);
            }
        }
        public static void ExitMenu()
        {
            for (int i = 1; i < exitMenu.Count; i++)
            {
                Console.WriteLine(exitMenu[i]);
            }
        }
        public static void Case3Menu()
        {
            ChngClr(case3Menu[0], ConsoleColor.Blue);
            for (int i = 1; i < case3Menu.Count; i++)
            {
                Console.WriteLine(case3Menu[i]);
            }
        }
        /// <summary>
        /// Функция возвращения номера пункта меню
        /// </summary>
        /// <returns>Функция возвращает номер пункта меню, вводимый пользователем с клавиатуры</returns>
        public static int Answer()
        {
            int number;
            string inputStr;
            bool isConvert;
            do
            {
                Console.WriteLine("Введите выбранный Вами номер пункта меню.");
                inputStr = Console.ReadLine();
                Console.WriteLine();
                isConvert = int.TryParse(inputStr, out number);
                if (!isConvert)
                {
                    ChngClr("Ошибка! Такого пункта меню не существует.\n \a", ConsoleColor.Red);
                }
            } while (!isConvert);
            return number;
        }
        public static void Offer(string str) 
        {
            if (str == "length" || str == "Length")
                Console.Write("Введите длину: ");
            else if (str == "num ber" || str == "Number")
                Console.Write("Введите число: ");
            else if (str == "name" || str == "Name")
                Console.Write("Введите название дисциплины: ");
            else if (str == "mark" || str == "Mark")
                Console.Write("Введите оценку: ");
        }
        public static void Error(string str = "repeat")
        {
            if (str=="repeat" || str == "Repeat")
                ChngClr("Ошибка! Повторите ввод.\n \a", ConsoleColor.Red);
            else if (str=="mark" || str=="Mark")
                ChngClr("Ошибка! Оценка должна быть в пределах от 0 до 10\nПовторите ввод. \a", ConsoleColor.Red);
        }
    }
}
