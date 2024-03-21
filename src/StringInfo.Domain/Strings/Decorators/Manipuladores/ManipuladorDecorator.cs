namespace StringInfo.Domain.Strings.Decorators.Manipuladores
{
    public abstract class ManipuladorDecorator : AbstractManipulador
    {
        private AbstractManipulador _manipulador;

        protected ManipuladorDecorator(AbstractManipulador manipulador)
        {
            _manipulador = manipulador;
        }

        public void SetManipulador(AbstractManipulador manipulador)
        {
            _manipulador = manipulador;
        }

        // The Decorator delegates all work to the wrapped component.
        public override string GetTextoLimpo()
        {
            if (_manipulador != null)
            {
                return _manipulador.GetTextoLimpo();
            }
            else
            {
                return string.Empty;
            }
        }
    }
}
