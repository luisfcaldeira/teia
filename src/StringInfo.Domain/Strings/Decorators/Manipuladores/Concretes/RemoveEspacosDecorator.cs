namespace StringInfo.Domain.Strings.Decorators.Manipuladores.Concretes
{
    public class RemoveEspacosDecorator : ManipuladorDecorator
    {
        public RemoveEspacosDecorator(AbstractManipulador manipulador) : base(manipulador)
        {
        }

        public override string GetTextoLimpo()
        {
            return base.GetTextoLimpo().Trim().Replace(" ", "");
        }
    }
}
