using System.Collections.Generic;

namespace ApiSunSale.Presentation.Model.ViewModels
{
    public class QuestoesViewModel : BaseViewModel
    {
        
        public string Campoquestao { get; set; }
        public string Observacaoquestao { get; set; }
        public string Materia { get; set; }
        public long Idprova { get; set; }
        public string Numeroquestao { get; set; }
        public long Updatedby { get; set; }
        public long Createdby { get; set; }
        public string? Assunto { get; set; }
        public ProvaViewModel? Prova { get; set; }
        public IEnumerable<AnexosquestoesViewModel>? Anexosquestoes { get; set; }
        public IEnumerable<ComentariosquestoesViewModel>? Comentariosquestoes { get; set; }
        public IEnumerable<RespostasquestoesViewModel>? Respostasquestoes { get; set; }
        public IEnumerable<RespostasusuariosViewModel>? Respostasusuarios { get; set; }
        public IEnumerable<RespostasavaliacoesViewModel>? Respostasavaliacoes { get; set; }
        public IEnumerable<QuestoesavaliacaoViewModel>? Questoesavaliacao { get; set; }
    }
}
