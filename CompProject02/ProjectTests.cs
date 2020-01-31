using NUnit.Framework;

namespace CompProject02
{
    [TestFixture]
    class ProjectTests
    {
        [Test]
        public void TestOfEquationForm()
        {
            Equation eq = new Equation("4 5 6");
            Assert.That(eq.GetFormOfEquation, Is.EqualTo("4*x1 + 5*x2 = 6"));
        }




    }
}
