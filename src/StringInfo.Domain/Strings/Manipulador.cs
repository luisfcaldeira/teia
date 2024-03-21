namespace StringInfo.Domain.Strings
{
    public class Manipulador : AbstractManipulador
    {
        public Manipulador(string texto)
        {
            Texto = texto;
        }

        public string Texto { get; }

        public override string GetTextoLimpo()
        {
            return Texto;
        }
    }
}
