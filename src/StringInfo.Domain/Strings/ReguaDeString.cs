namespace StringInfo.Domain.Strings
{
    public class ReguaDeString
    {
        private string _texto;

        public ReguaDeString(string texto)
        {
            _texto = texto;
        }

        public bool EhPalindromo()
        {
            if (_texto.Equals(string.Empty)) return false;
            return _texto.SequenceEqual(_texto.Reverse());
        }

        public int NumeroCaracteres()
        {
            return _texto.Count();
        }
    }
}
