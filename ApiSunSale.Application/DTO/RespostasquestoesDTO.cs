using System.Collections.Generic;

namespace ApiSunSale.Application.DTO
{
    public class RespostasquestoesDTO : BaseDTO
    {
        public long Id { get; set; }
        public long Idquestao { get; set; }
        public string Textoresposta { get; set; }
        public string Certa { get; set; }
        public string Observacaoresposta { get; set; }
        public QuestoesDTO Questao { get; set; }
        public IEnumerable<AnexorespostaDTO> Anexosresposta { get; set; }
        public IEnumerable<RespostasavaliacoesDTO> Respostasavaliacoes { get; set; }
        public IEnumerable<RespostasusuariosDTO> Respostasusuarios { get; set; }
    }
}
