namespace StringInfo.Domain.Strings
{
    public class Contador
    {
        private string _texto;

        public Contador(string texto)
        {
            _texto = texto;
        }

        public Dictionary<char, int> Contar()
        {
            var uniqueChars = _texto.GroupBy(x => x);

            Dictionary<char, int> result = new Dictionary<char, int>();

            foreach (var uniqueChar in uniqueChars)
            {
                result.Add(uniqueChar.First(), CountChar(uniqueChar.First(), _texto));
            }

            return result;
        }

        private int CountChar(char c, string str)
        {
            return str.Where(x => x == c).Count();
        }
    }
}
