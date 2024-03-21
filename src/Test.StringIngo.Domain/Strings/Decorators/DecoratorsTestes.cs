using StringInfo.Domain.Strings;
using StringInfo.Domain.Strings.Decorators.Manipuladores.Concretes;

namespace Test.StringIngo.Domain.Strings.Decorators
{
    internal class DecoratorsTestes
    {
        private const string textoBase = " Bananã-mé em Ananab... ";
        Manipulador manipulador;

        [SetUp]
        public void Setup()
        {
            manipulador = new Manipulador(textoBase);
        }

        [Test]
        public void RemoveEspacosTeste()
        {
            var decorator = new RemoveEspacosDecorator(manipulador);
            var textoLimpo = textoBase.Replace(" ", "");

            Assert.AreNotEqual(textoBase, decorator.GetTextoLimpo());
            Assert.AreEqual(textoLimpo, decorator.GetTextoLimpo());

        }

        [Test]
        public void LowerCaseTeste()
        {
            var decorator = new LowerCaseDecorator(manipulador);
            var textoLimpo = textoBase.ToLower();

            Assert.AreEqual(textoLimpo, decorator.GetTextoLimpo());
            Assert.AreNotEqual(textoBase, decorator.GetTextoLimpo());
            
        }

        [Test]
        public void RemoveAcentosTestes()
        {
            var decorator = new RemoverAcentosDecorator(manipulador);
            var textoLimpo = " Banana-me em Ananab... ";

            Assert.AreNotEqual(textoBase, decorator.GetTextoLimpo());
            Assert.AreEqual(textoLimpo, decorator.GetTextoLimpo());
        }

        [Test]
        public void RemoveCaracteresEspeciaisEPontuacaoTeste()
        {
            var decorator = new RemoveCaracteresEspeciaisEPontuacaoDecorator(manipulador);
            var textoLimpo = " Bananm em Ananab ";

            Assert.AreNotEqual(textoBase, decorator.GetTextoLimpo());
            Assert.AreEqual(textoLimpo , decorator.GetTextoLimpo());
        }
    }
}
