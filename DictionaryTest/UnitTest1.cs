

using DictionaryPaskaita;

namespace DictionaryTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Dictionary<string, int> vaisiai = new Dictionary<string, int> { { "apelsinas", 2 }, { "morka", 3 } };
            string pridetiVaisiu = "obuolys";
            int kiekis = 2;

            Dictionary<string, int> vaisiai2 = Program.createNewFruit(vaisiai, pridetiVaisiu, kiekis);
            Assert.IsTrue(vaisiai2.ContainsKey(pridetiVaisiu));
        }

        [TestMethod]
        public void TestMethod2()
        {
            Dictionary<string, int> vaisiai = new Dictionary<string, int> { { "apelsinas", 2 }, { "morka", 3 } };
            string pridetiVaisiu = "obuolys";
            int kiekis = 7;
            int falseKiekis = 8;

            Dictionary<string, int> vaisiai2 = Program.createNewFruit(vaisiai, pridetiVaisiu, kiekis);
            Assert.IsTrue(vaisiai2.ContainsValue(kiekis));
        }
    }
}