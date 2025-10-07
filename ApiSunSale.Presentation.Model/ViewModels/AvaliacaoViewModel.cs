using System.Collections.Generic;

namespace ApiSunSale.Presentation.Model.ViewModels
{
    public class AvaliacaoViewModel : BaseViewModel
    {
        public string Nome { get; set; }
        public string? Orientação { get; set; }
        public string Ispublic { get; set; }
        public string? Key { get; set; }
        public long? CreatedBy { get; set; }
        public long? UpdatedBy { get; set; }

        public IEnumerable<QuestoesavaliacaoViewModel>? Questoesavaliacao { get; set; }
        public IEnumerable<RespostasavaliacoesViewModel>? Respostasavaliacoes { get; set; }
    }
}
