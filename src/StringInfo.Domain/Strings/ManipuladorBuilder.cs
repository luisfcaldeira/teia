﻿using StringInfo.Domain.Strings.Decorators.Manipuladores.Concretes;

namespace StringInfo.Domain.Strings
{
    public class ManipuladorBuilder
    {
        public static AbstractManipulador GetManipulador(string texto)
        {
            var manipulador = new Manipulador(texto);
            return new LowerCaseDecorator(
                            new RemoveEspacosDecorator(
                                new RemoverAcentosDecorator(
                                    new RemoveCaracteresEspeciaisEPontuacaoDecorator(manipulador)
                                    )
                                )
                            );
        }
    }
}
