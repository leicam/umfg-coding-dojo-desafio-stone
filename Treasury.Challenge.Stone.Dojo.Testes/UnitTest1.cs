using Xunit.Sdk;

namespace Treasury.Challenge.Stone.Dojo.Testes
{
    [TestClass]
    public class UnitTest1
    {
        private const string C_CATEGORIA = "Geração de código promocional";
        private const string C_DONO = "Harrison";

       [TestMethod]
        [TestCategory(C_CATEGORIA)]
        [Owner(C_DONO)]

        public void TestMethod1()
        {
            var line = Promocao.GetLine();
            Assert.IsNotNull(line);
            Assert.AreEqual(7, line.Length);
        }
    }
}