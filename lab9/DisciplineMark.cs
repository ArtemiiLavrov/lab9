using System.Text.RegularExpressions;

namespace lab9
{
    public class DisciplineMark
    {
        string name;
        int mark;
        public static int counter = 0;
        static int convertedMark = 0;
        public string Name
        { 
            get => name;
            private set => name = value;    
        }
        public int Mark
        {
            get => mark;
            private set
            {
                if (value < 0 || value > 10)
                {
                    Console.WriteLine("Ошибка! Оценка должна быть в пределах от 0 до 10\n");
                    mark = 0;
                }
                else
                    mark = value;
            }
        }
        public DisciplineMark()
        {
            Name = "DefaultName";
            Mark = 0;
            counter++;
        }
        public DisciplineMark(string name, int mark)
        {
            Name = name;
            Mark = mark;
            counter++;
        }
        public DisciplineMark(DisciplineMark mark)
        {
            Name = mark.Name;
            Mark = mark.Mark;
            counter++;
        }
        public string ConvertToNormal() 
        {
            if (0<=mark && mark<=3)
                convertedMark = 2;
            else if (mark==4 || mark==5)
                convertedMark = 3;
            else if (mark==6 || mark==7) 
                convertedMark = 4;
            else 
                convertedMark = 5;
            return convertedMark.ToString();
        }
        public static string ConvertToNormal(DisciplineMark d)
        {
            if (0 <= d.mark && d.mark <= 3)
                convertedMark = 2;
            else if (d.mark == 4 || d.mark == 5)
                convertedMark = 3;
            else if (d.mark == 6 || d.mark == 7)
                convertedMark = 4;
            else
               convertedMark = 5;
            return convertedMark.ToString();
        } 
        public static DisciplineMark operator -(DisciplineMark d)
        {
            d.Mark = 0;
            return d;
        }
        public static DisciplineMark operator !(DisciplineMark d)
        {
            d.Name = d.Name.ToUpper();
            return d;
        }

        public static explicit operator int(DisciplineMark d)
        {
            int count = 0;
            Regex sample1 = new Regex(@"^[А-Я]$");
            Regex sample2 = new Regex(@"^[а-я]$");
            char[] chArr = d.Name.ToCharArray();
            for (int i = 0; i<chArr.Length; i++)
            {
                if (sample1.IsMatch(chArr[i].ToString()) || sample2.IsMatch(chArr[i].ToString()) )
                    count++;
            }
            return count;
        }
        public static implicit operator bool(DisciplineMark d)
        {
            if (d.Mark > 4)
                return true;
            else
                return false;
        }
        public static DisciplineMark operator /(DisciplineMark m, string NewName)
        {
            m.Name = NewName;
            return m;
        }
        public static DisciplineMark operator /(DisciplineMark m, int newMark)
        {
            m.Mark = newMark;
            return m;
        }
        public static bool operator >=(DisciplineMark m1, DisciplineMark m2)
        {
            return m1.Mark >= m2.Mark;
        }
        public static bool operator <=(DisciplineMark m1, DisciplineMark m2)
        {
            return m1.Mark <= m2.Mark;

        }
        public override string ToString()
        {
            return $"{Name} имя дисциплины, {Mark} оценка";
        }
        public override bool Equals(object? obj)
        {
            if (obj == null) return false;
            if (obj is not DisciplineMark) return false;
            return ((DisciplineMark)obj).Mark == this.Mark && ((DisciplineMark)obj).Name == this.Name;
        }
        public void Show()
        {
            Interface.ChngClr($"Имя:{Name} Оценка:{Mark}", ConsoleColor.Green);
        }
    }
}
