using NUnit.Framework;

namespace FluentBoolean.Test.ComplexExpressions
{
    [TestFixture]
    public class ComplexExpressionsTest
    {
        [TestCase(false, false, false)]
        [TestCase(false, false, true)]
        [TestCase(false, true, false)]
        [TestCase(false, true, true)]
        [TestCase(true, false, false)]
        [TestCase(true, false, true)]
        [TestCase(true, true, false)]
        [TestCase(true, true, true)]
        public void Expression1_ShouldBehaveAsExpected(bool par1, bool par2, bool par3)
        {
            var expected = (par1 && par2) || (par2 && par3);
            var actual = par1.AND(par2)
                .OR(par2.AND(par3));

            Assert.AreEqual(expected, actual);
        }

        [TestCase(false, false, false)]
        [TestCase(false, false, true)]
        [TestCase(false, true, false)]
        [TestCase(false, true, true)]
        [TestCase(true, false, false)]
        [TestCase(true, false, true)]
        [TestCase(true, true, false)]
        [TestCase(true, true, true)]
        public void Expression2_ShouldBehaveAsExpected(bool par1, bool par2, bool par3)
        {
            var expected = (par1 || par2) && (par2 || par3);
            var actual = par1.OR(par2)
                .AND(par2.OR(par3));

            Assert.AreEqual(expected, actual);
        }

        [TestCase(false, false, false, false)]
        [TestCase(false, false, false, true)]
        [TestCase(false, false, true, false)]
        [TestCase(false, false, true, true)]
        [TestCase(false, true, false, false)]
        [TestCase(false, true, false, true)]
        [TestCase(false, true, true, false)]
        [TestCase(false, true, true, true)]
        [TestCase(true, false, false, false)]
        [TestCase(true, false, false, true)]
        [TestCase(true, false, true, false)]
        [TestCase(true, false, true, true)]
        [TestCase(true, true, false, false)]
        [TestCase(true, true, false, true)]
        [TestCase(true, true, true, false)]
        [TestCase(true, true, true, true)]
        public void Expression3_ShouldBehaveAsExpected(bool par1, bool par2, bool par3, bool par4)
        {
            var expected = par1 || (par2 || par3 && par4);
            var actual = par1.OR(par3.AND(par4).OR(par2)); //this because AND is executed before OR

            Assert.AreEqual(expected, actual);
        }

        [TestCase(false, false, false, false)]
        [TestCase(false, false, false, true)]
        [TestCase(false, false, true, false)]
        [TestCase(false, false, true, true)]
        [TestCase(false, true, false, false)]
        [TestCase(false, true, false, true)]
        [TestCase(false, true, true, false)]
        [TestCase(false, true, true, true)]
        [TestCase(true, false, false, false)]
        [TestCase(true, false, false, true)]
        [TestCase(true, false, true, false)]
        [TestCase(true, false, true, true)]
        [TestCase(true, true, false, false)]
        [TestCase(true, true, false, true)]
        [TestCase(true, true, true, false)]
        [TestCase(true, true, true, true)]
        public void Expression4_ShouldBehaveAsExpected(bool par1, bool par2, bool par3, bool par4)
        {
            var expected = par1 || par2 || par3 || par4;
            var actual = par1
                .OR(par2)
                .OR(par3)
                .OR(par4);

            Assert.AreEqual(expected, actual);
        }
    }
}