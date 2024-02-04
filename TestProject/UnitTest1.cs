using lab9;
using System.Reflection.Metadata;
using System.Xml.Linq;

namespace TestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            DisciplineMark expected = new DisciplineMark("DefaultName",0);
            DisciplineMark actual = new DisciplineMark();
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod2() 
        {
            DisciplineMark expected = new DisciplineMark("DefaultName", 0);
            DisciplineMark actual = new DisciplineMark(expected);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod3()
        {
            DisciplineMark expected = new DisciplineMark("ÏĞÎÃĞÀÌÌÈĞÎÂÀÍÈÅ", 0);
            DisciplineMark actual = new DisciplineMark("ïğîãğàììèğîâàíèå",0);
            actual = !actual;
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod4()
        {
            DisciplineMark expected = new DisciplineMark("DEFAULTNAME",0);
            DisciplineMark actual = new DisciplineMark();
            actual = !actual;
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod5()
        {
            DisciplineMark expected = new DisciplineMark("ÏĞÎÃĞÀÌÌÈĞÎÂÀÍÈÅ", 11);
            DisciplineMark actual = new DisciplineMark("ÏĞÎÃĞÀÌÌÈĞÎÂÀÍÈÅ", 0);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod5_1()
        {
            DisciplineMark expected = new DisciplineMark("ÏĞÎÃĞÀÌÌÈĞÎÂÀÍÈÅ", -1);
            DisciplineMark actual = new DisciplineMark("ÏĞÎÃĞÀÌÌÈĞÎÂÀÍÈÅ", 0);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod6()
        {
            DisciplineMark expected = new DisciplineMark("ÏĞÎÃĞÀÌÌÈĞÎÂÀÍÈÅ", 0);
            DisciplineMark actual = new DisciplineMark("ÏĞÎÃĞÀÌÌÈĞÎÂÀÍÈÅ", 9);
            actual = -actual;
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod7() 
        {
            DisciplineMark expected = new DisciplineMark();
            DisciplineMark actual = new DisciplineMark("DefaultName", 0);
            actual = -actual;
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod8()
        {
            DisciplineMark expected = new DisciplineMark("DefaultName", 8);
            DisciplineMark actual = new DisciplineMark();
            actual = actual/8;
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod9()
        {
            DisciplineMark expected = new DisciplineMark("DefaultName", 8);
            DisciplineMark actual = new DisciplineMark("DefaultName", 0);
            actual = actual / 8;
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod10() 
        {
            bool expected = true;
            DisciplineMark m1 = new DisciplineMark("DefaultName", 8);
            DisciplineMark m2 = new DisciplineMark("DefaultName", 9);
            bool actual = m1 <= m2;
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod11()
        {
            bool expected = true;
            DisciplineMark m1 = new DisciplineMark("DefaultName", 9);
            DisciplineMark m2 = new DisciplineMark("DefaultName", 8);
            bool actual = m1 >= m2;
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod12()
        {
            DisciplineMark expected = new DisciplineMark("ÒÎÈ", 0);
            DisciplineMark actual = new DisciplineMark();
            actual = actual / "ÒÎÈ";
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod13()
        {
            bool expected = true;
            DisciplineMark mk1 = new DisciplineMark("ÒÎÈ",9);
            bool actual = (bool) mk1;
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod13_1()
        {
            bool expected = false;
            DisciplineMark mk1 = new DisciplineMark("ÒÎÈ", 3);
            bool actual = (bool)mk1;
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod14()
        {
            int expected = 3;
            DisciplineMark mk1 = new DisciplineMark("ÒÎè", 9);
            int actual = (int)mk1;
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod15() 
        {
            string expected = "2";
            DisciplineMark mk1 = new DisciplineMark("ÒÎÈ", 2);
            string actual = mk1.ConvertToNormal();
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod15_1()
        {
            string expected = "3";
            DisciplineMark mk1 = new DisciplineMark("ÒÎÈ", 5);
            string actual = mk1.ConvertToNormal();
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod15_2()
        {
            string expected = "4";
            DisciplineMark mk1 = new DisciplineMark("ÒÎÈ", 7);
            string actual = mk1.ConvertToNormal();
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod15_3()
        {
            string expected = "5";
            DisciplineMark mk1 = new DisciplineMark("ÒÎÈ", 9);
            string actual = mk1.ConvertToNormal();
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod16()
        {
            string expected = "2";
            DisciplineMark mk1 = new DisciplineMark("ÒÎÈ", 2);
            string actual = DisciplineMark.ConvertToNormal(mk1);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod16_1()
        {
            string expected = "3";
            DisciplineMark mk1 = new DisciplineMark("ÒÎÈ", 5);
            string actual = DisciplineMark.ConvertToNormal(mk1);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod16_2()
        {
            string expected = "4";
            DisciplineMark mk1 = new DisciplineMark("ÒÎÈ", 7);
            string actual = DisciplineMark.ConvertToNormal(mk1);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod16_3()
        {
            string expected = "5";
            DisciplineMark mk1 = new DisciplineMark("ÒÎÈ", 9);
            string actual = DisciplineMark.ConvertToNormal(mk1);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod17()
        {
            DisciplineMark mk1 = new DisciplineMark("ÒÎÈ", 9);
            string expected = $"{mk1.Name} èìÿ äèñöèïëèíû, {mk1.Mark} îöåíêà";
            string actual = mk1.ToString();
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod18()
        {
            DisciplineMarkArray expected = new(3);
            expected[0] = new DisciplineMark("Ïğîãğàììèğîâàíèå", 9);
            expected[1] = new DisciplineMark("ÒÎÈ", 6);
            expected[2] = new DisciplineMark("Ìàòàíàëèç", 8);
            DisciplineMarkArray actual = new();
            actual.Equals(expected);
        }
        [TestMethod]
        public void TestMethod19()
        {
            DisciplineMarkArray expected = new(3);
            DisciplineMarkArray actual = new(expected);
            actual.Equals(expected);
        }
        [TestMethod]
        public void TestMethod20()
        {
            DisciplineMarkArray d = new(3);
            List<string> actual= DisciplineMarkArray.DisciplinesMoreThanAvg(d);
            List<string> expected = new() { "Ïğîãğàììèğîâàíèå", "Ìàòàíàëèç" };
            expected.Equals(actual);
        }
        [TestMethod]
        public void TestMethod21()
        {
            Exception expected = new IndexOutOfRangeException(); 
            DisciplineMarkArray d1 = new DisciplineMarkArray(5);
            Assert.ThrowsException<IndexOutOfRangeException>(() => { new DisciplineMark(d1[7]); });
        }
    }

}