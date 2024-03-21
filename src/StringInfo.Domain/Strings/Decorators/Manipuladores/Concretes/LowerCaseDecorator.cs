namespace StringInfo.Domain.Strings.Decorators.Manipuladores.Concretes
{
    public class LowerCaseDecorator : ManipuladorDecorator
    {
        public LowerCaseDecorator(AbstractManipulador manipulador) : base(manipulador)
        {
        }

        public override string GetTextoLimpo()
        {
            return base.GetTextoLimpo().ToLower();
        }
    }
}
