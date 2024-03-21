using System.Text;
using System.Text.RegularExpressions;

namespace StringInfo.Domain.Strings.Decorators.Manipuladores.Concretes
{
    public class RemoverAcentosDecorator : ManipuladorDecorator
    {
        public RemoverAcentosDecorator(AbstractManipulador manipulador) : base(manipulador)
        {
        }

        public override string GetTextoLimpo()
        {
            return RemoverAcentos(base.GetTextoLimpo());
        }


        private string RemoverAcentos(string texto)
        {
            string textoNormalizado = NormalizaTexto(texto);

            return RemoveCaracteresDiacriticos(textoNormalizado);

        }

        private static string NormalizaTexto(string texto)
        {
            return texto.Normalize(NormalizationForm.FormD);
        }

        private static string RemoveCaracteresDiacriticos(string textoNormalizado)
        {
            Regex regex = new Regex(@"[\p{Mn}]", RegexOptions.Compiled);

            return regex.Replace(textoNormalizado, string.Empty);
        }
    }
}
