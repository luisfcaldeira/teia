namespace TEIA.ViewModels.RequestsDtos
{
    public class ManipulacaoStringDto
    {
        public string Texto { get; set; }

        public override string? ToString()
        {
            return Texto.ToString();
        }
    }
}
