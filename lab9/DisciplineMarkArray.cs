using System.Text;

namespace lab9
{
    public class DisciplineMarkArray
    {
        DisciplineMark[] arr = null;
        static Random rnd = new Random();
        static string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        public static int counter = 0;
        public int Length
        {
            get => arr.Length;
        }
        public DisciplineMarkArray()
        {
            arr = new DisciplineMark[3];
            arr[0] = new DisciplineMark("Программирование",9) ;
            arr[1] = new DisciplineMark("ТОИ",6);
            arr[2] = new DisciplineMark("Матанализ",8);
            counter++;
        }
        public DisciplineMarkArray(int size)
        {
            arr = new DisciplineMark[size];
            for (int i = 0; i < size; i++) 
            { 
                StringBuilder sb = new StringBuilder();
                for (int j = 0; j < 5; j++)
                {
                    int letterNum = rnd.Next(0, alphabet.Length);
                    sb.Append(alphabet[letterNum]);
                }
                DisciplineMark d1 = new DisciplineMark();
                d1 = d1 / sb.ToString();
                d1 = d1 / rnd.Next(0,11);
                sb.Clear();
                arr[i] = d1;
            }
            counter++;
        }
        public static int GetNumber(string str)
        {
            int number;
            string inputStr;
            bool isConvert;
            if (str=="number")
            {
                do
                {
                    inputStr = Console.ReadLine();
                    Console.WriteLine();
                    isConvert = int.TryParse(inputStr, out number);
                    if (!isConvert)
                    {
                        Interface.Error();
                    }
                } while (!isConvert);
                return number;
            }
            else
            {
                do
                {
                    inputStr = Console.ReadLine();
                    Console.WriteLine();
                    isConvert = int.TryParse(inputStr, out number);
                    if (!isConvert || number < 0)
                    {
                        Interface.Error();
                    }
                } while (!isConvert || number < 0);
                return number;
            }
        }
        public DisciplineMarkArray(string str)
        {
            Interface.Offer("length");
            int size = GetNumber("length");
            arr = new DisciplineMark[size]; 
            for (int i = 0; i < size; i++)
            {
                Interface.Offer("name");
                string name = Console.ReadLine();
                DisciplineMark d1 = new DisciplineMark();
                d1 = d1 / name;
                Interface.Offer("mark");
                int mark = GetNumber("number");
                if (mark>10 || mark<0)
                {
                    do
                    {
                        Interface.Error("mark");
                        Interface.Offer("mark");
                        mark = GetNumber("number");
                    } while (mark > 10 || mark < 0);
                }    
                d1 = d1 / mark;
                arr[i] = d1;
            }
            counter++;
        }
        public DisciplineMarkArray (DisciplineMarkArray other)
        {
            arr = new DisciplineMark[other.Length];
            for (int i = 0; i < other.Length; i++) 
                arr[i] = new DisciplineMark(other[i]);
            counter++;
        }
        public DisciplineMark this[int index]
        {
            get
            {
                if (index >= 0 && index < arr.Length)
                    return arr[index];
                throw new IndexOutOfRangeException();
            }
            set
            {
                if (index >= 0 && index < arr.Length)
                    arr[index] = value;
                else Console.WriteLine("Выход за границу массива");
            }
        }
        public static List<string> DisciplinesMoreThanAvg(DisciplineMarkArray d)
        {
            double avg = DisciplineMarkArray.CalcAvg(d);
            List<string> disciplines = new List<string> ();    
            for (int i=0; i<d.Length; i++)
            {
                if (d[i].Mark > avg)
                    disciplines.Add(d[i].Name);
            }
            return disciplines;
        }
        public static double CalcAvg(DisciplineMarkArray d)
        {
            int sum = 0;
            double avg;
            for (int i = 0; i < d.Length; i++)
            {
                sum += d[i].Mark;
            }
            avg = sum / (double)d.Length;
            return avg;
        }
        public void Show()
        {
            for (int i = 0; i < arr.Length;i++) 
            { Interface.ChngClr($"Name: {arr[i].Name}, Mark: {arr[i].Mark}", ConsoleColor.Green); }
        }

    }
}
