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

        [Test]
        public void BuilderTeste()
        {
            var manipulador = ManipuladorBuilder.GetManipulador(" Envia-me à emaivne ");

            Assert.AreEqual("enviameaemaivne", manipulador.GetTextoLimpo());
        }
    }
}
