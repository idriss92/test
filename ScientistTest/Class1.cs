using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using ScientistTest;

namespace ScientistTest
{
    [TestFixture]
    public class Class1
    {
        [Test]
        public void ShouldAdd()
        {
            var a = new Coeur();
            var b = a.Addition(5, 6);
            Assert.AreEqual(11, b);
        }
        

        [Test]
        public void ShouldDivide()
        {
            var a = new Coeur();
            var b = a.Division(4, 2);
            Assert.AreEqual(2, b);
        }
        

        [Test]
        public void ShouldMult()
        {
            var a = new Coeur();
            var b = a.Multiplication(5, 6);
            Assert.AreEqual(30, b);
        }


        [Test]
        public void ShouldSous()
        {
            var a = new Coeur();
            var b = a.Soustraction(7, 6);
            Assert.AreEqual(1, b);
        }
    }
}
