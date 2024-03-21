using System.Text.RegularExpressions;

namespace StringInfo.Domain.Strings.Decorators.Manipuladores.Concretes
{
    public class RemoveCaracteresEspeciaisEPontuacaoDecorator : ManipuladorDecorator
    {

        string pattern = @"[^a-zA-Z0-9\s]+";
        public RemoveCaracteresEspeciaisEPontuacaoDecorator(AbstractManipulador manipulador) : base(manipulador)
        {
        }

        public override string GetTextoLimpo()
        {
            var regex = new Regex(pattern);
            return regex.Replace(base.GetTextoLimpo(), "");
        }
    }
}
