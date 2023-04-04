using GradeBook;
using System.ComponentModel.DataAnnotations;

namespace grades.nUnitTests
{
    public delegate int sampleDelegate(int a);
    public class GradesTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Stats_Test()
        {
            //arrange
            var book = new Book();
            book.AddGrade(89.1);
            book.AddGrade(90.5);
            book.AddGrade(77.3);
            //act
            book.CalStats();
            var result = book.SetStats();
            //assert
            Assert.AreEqual(85.6, result.average, 1);
            Assert.AreEqual(90.5, result.high);
            Assert.AreEqual(77.3, result.low);
            Assert.AreEqual('B', result.letter);
        }
        [Test]
        public void delegageTest() {
            sampleDelegate d1;
            d1 = new sampleDelegate(delegateMethod1);
            d1 += delegateMethod2;
            var re = d1(10);
            Assert.AreEqual(20, re);
        }
        public int delegateMethod1(int a)
        {
            return  a+7;
        }
        public int delegateMethod2(int a)
        {
            return a * 2;
        }
    }
}