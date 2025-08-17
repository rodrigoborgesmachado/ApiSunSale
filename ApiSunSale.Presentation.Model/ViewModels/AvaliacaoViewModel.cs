using System.Collections.Generic;

namespace ApiSunSale.Presentation.Model.ViewModels
{
    public class AvaliacaoViewModel : BaseViewModel
    {
        public long Id { get; set; }
        public string Nome { get; set; }
        public string Orientação { get; set; }
        public string Ispublic { get; set; }
        public string Key { get; set; }

        public IEnumerable<QuestoesavaliacaoViewModel> Questoesavaliacao { get; set; }
        public IEnumerable<RespostasavaliacoesViewModel> Respostasavaliacoes { get; set; }
    }
}
