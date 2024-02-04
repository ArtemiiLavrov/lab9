using lab9;
namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            DisciplineMark mark1 = new DisciplineMark();
            DisciplineMark mark2 = new DisciplineMark("Программирование", 8);
            DisciplineMark mark3 = new DisciplineMark(mark2);
            DisciplineMark mark4 = new DisciplineMark(mark2);
        }
    }
}