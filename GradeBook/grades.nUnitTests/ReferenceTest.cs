using GradeBook;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace grades.nUnitTests
{
    public delegate string FirstDelegate(string delegateMessage);
    public class ReferenceTest
    {
        public int count = 0;
        [Test]
        public void RefTest()
        {
            var book1 = new Book();
            var book2= new Book();
            var book3 = book1;
            Assert.AreNotSame(book1, book2);
            Assert.AreSame(book1, book3);
            Assert.IsTrue(Object.ReferenceEquals(book1, book3));

        }
        public string getLogDelegate1(string s)
        {
            count++;
            return s+" goodmorning";
        }
        public string getLogDelegate2(String s2)
        {
            count++;
            return s2+" vinay";
        }
        [Test]
        public void delegateTest()
        {
            FirstDelegate log;
           log = new FirstDelegate(getLogDelegate1);
            // log = getLogDelegate1;
            //var result = log("hello");
            //Assert.AreEqual("hello", result);

            log += getLogDelegate2;
            var result = log("hello");
            Assert.AreEqual(2, count);
            Assert.AreEqual("hello vinay", result);

        }
    }
}
