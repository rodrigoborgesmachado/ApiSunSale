using System.Collections.Generic;

namespace ApiSunSale.Presentation.Model.ViewModels
{
    public class RespostasquestoesViewModel : BaseViewModel
    {
        public long Id { get; set; }
        public long Idquestao { get; set; }
        public string Textoresposta { get; set; }
        public string Certa { get; set; }
        public string Observacaoresposta { get; set; }
        public QuestoesViewModel Questao { get; set; }
        public IEnumerable<RespostasavaliacoesViewModel> Respostasavaliacoes { get; set; }
        public IEnumerable<RespostasusuariosViewModel> Respostasusuarios { get; set; }
    }
}
