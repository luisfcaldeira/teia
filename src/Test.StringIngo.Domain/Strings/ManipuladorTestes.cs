using StringInfo.Domain.Strings;

namespace Test.StringIngo.Domain.Strings
{

    public class ManipuladorTestes
    {
        
        [Test]
        public void TesteSeLimpaString()
        {
            var manipulador = new Manipulador(" banana ");

            Assert.AreEqual(" banana ", manipulador.GetTextoLimpo());
            Assert.AreNotEqual("banana", manipulador.GetTextoLimpo());
        }
    }
}
