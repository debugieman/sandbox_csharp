using ConsoleApp2;

namespace TestConsoleApp2
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            //AAA
            //Arrange przygotowuje obj pod testyt
            var testObject2 = new TestObject2();

            // typ - nazwa zmiennej/zmienna - 
            //Act wykunuje test 
            var actual = testObject2.AddString("bartek", "wiktor");
            //Assert porownanie do rezultrtatu
            var expected = "bartekwiktor";
            StringAssert.AreEqualIgnoringCase( expected,actual);
        }

        [Test]
        [TestCase("bartek",3, "tek")]
        [TestCase("wiktor",3, "tor")]
        public void Test2(string userinput, int substringIndex, string expectedResult)
        {
            //AAA
            //Arrange przygotowuje obj pod testyt
            var testObject2 = new TestObject2();

            // typ - nazwa zmiennej/zmienna - 
            //Act wykunuje test 
            var actual = testObject2.SubString(userinput, substringIndex);
            //Assert porownanie do rezultrtatu
            var expected = expectedResult;
            StringAssert.AreEqualIgnoringCase(expected, actual);
        }
    }
}



