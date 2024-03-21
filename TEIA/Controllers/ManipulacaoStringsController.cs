using Microsoft.AspNetCore.Mvc;
using StringInfo.Domain.Strings;
using System.Text;
using System.Text.RegularExpressions;
using TEIA.ViewModels;
using TEIA.ViewModels.RequestsDtos;

namespace TEIA.Controllers
{

    [ApiController]
    [Route("api/manipulacao-string")]
    public class ManipulacaoStringsController : ControllerBase
    {
        [HttpPost]
        public StringInfoResponseDto GetString(ManipulacaoStringDto texto)
        {
            var manipulador = ManipuladorBuilder.GetManipulador(texto.Texto);
            var contador = new Contador(manipulador.GetTextoLimpo());
            var reguaString = new ReguaDeString(manipulador.GetTextoLimpo());

            return new StringInfoResponseDto()
            {
                palindromo = reguaString.EhPalindromo(),
                ocorrencias_caracteres = contador.Contar(),
            };
        }
    }
}
