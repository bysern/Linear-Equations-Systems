using System;
using NUnit.Framework;

namespace CompProject02
{
    [TestFixture]
    class ProjectTests
    {
        [Test]
        public void TestSettingEquation()
        {
            //Equation equation = new Equation();
            Assert.That(Equation.setEquation("1 2 3"), Is.EqualTo("1*x1 + 2*x2 = 3"));
        }
        

    }
}
