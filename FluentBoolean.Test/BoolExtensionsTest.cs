using NUnit.Framework;

namespace FluentBoolean.Test
{
    [TestFixture]
    public class BooleanExtensionsTests
    {
        [TestCase(false)]
        [TestCase(true)]
        public void NOT_ShouldBehaveAsNot(bool par)
        {
            Assert.AreEqual(!par, par.NOT());
        }

        [TestCase(false, false)]
        [TestCase(true, false)]
        [TestCase(false, true)]
        [TestCase(true, true)]
        public void OR_ShouldBehaveAsOr(bool par1, bool par2)
        {
            Assert.AreEqual(par1 || par2, par1.OR(par2));
        }

        [TestCase(false, false, false)]
        [TestCase(false, true, false)]
        [TestCase(false, false, true)]
        [TestCase(false, true, true)]
        [TestCase(true, false, false)]
        [TestCase(true, true, false)]
        [TestCase(true, false, true)]
        [TestCase(true, true, true)]
        public void OR_WithMultipleParameters_ShouldBehaveAsChainedOr(bool par1, bool par2, bool par3)
        {
            Assert.AreEqual(par1 || par2 || par3, par1.OR(par2, par3));
        }

        [TestCase(false, false)]
        [TestCase(true, false)]
        [TestCase(false, true)]
        [TestCase(true, true)]
        public void AND_ShouldBehaveAsAnd(bool par1, bool par2)
        {
            Assert.AreEqual(par1 && par2, par1.AND(par2));
        }

        [TestCase(false, false, false)]
        [TestCase(false, true, false)]
        [TestCase(false, false, true)]
        [TestCase(false, true, true)]
        [TestCase(true, false, false)]
        [TestCase(true, true, false)]
        [TestCase(true, false, true)]
        [TestCase(true, true, true)]
        public void AND_WithMultipleParameters_ShouldBehaveAsChainedAnd(bool par1, bool par2, bool par3)
        {
            Assert.AreEqual(par1 && par2 && par3, par1.AND(par2, par3));
        }

        [TestCase(false, false)]
        [TestCase(true, false)]
        [TestCase(false, true)]
        [TestCase(true, true)]
        public void XOR_ShouldBehaveAsXor(bool par1, bool par2)
        {
            Assert.AreEqual(par1 ^ par2, par1.XOR(par2));
        }

        [TestCase(false, false)]
        [TestCase(true, false)]
        [TestCase(false, true)]
        [TestCase(true, true)]
        public void NAND_ShouldBehaveAsNand(bool par1, bool par2)
        {
            Assert.AreEqual(!(par1 && par2), par1.NAND(par2));
        }

        [TestCase(false, false)]
        [TestCase(true, false)]
        [TestCase(false, true)]
        [TestCase(true, true)]
        public void NOR_ShouldBehaveAsNor(bool par1, bool par2)
        {
            Assert.AreEqual(!(par1 || par2), par1.NOR(par2));
        }

        [TestCase(false, false)]
        [TestCase(true, false)]
        [TestCase(false, true)]
        [TestCase(true, true)]
        public void XNOR_ShouldBehaveAsXnor(bool par1, bool par2)
        {
            Assert.AreEqual(!(par1 ^ par2), par1.XNOR(par2));
        }
    }
}