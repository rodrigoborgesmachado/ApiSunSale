using System.Collections.Generic;

namespace ApiSunSale.Application.DTO
{
    public class QuestoesDTO : BaseDTO
    {
        public long Id { get; set; }
        public string Campoquestao { get; set; }
        public string Observacaoquestao { get; set; }
        public string Materia { get; set; }
        public long Idprova { get; set; }
        public string Numeroquestao { get; set; }
        public long Updatedby { get; set; }
        public long Createdby { get; set; }
        public string Assunto { get; set; }
        public ProvaDTO Prova { get; set; }
        public IEnumerable<AnexosquestoesDTO> Anexosquestoes { get; set; }
        public IEnumerable<ComentariosquestoesDTO> Comentariosquestoes { get; set; }
        public IEnumerable<RespostasquestoesDTO> Respostasquestoes { get; set; }
        public IEnumerable<RespostasusuariosDTO> Respostasusuarios { get; set; }
        public IEnumerable<RespostasavaliacoesDTO> Respostasavaliacoes { get; set; }
        public IEnumerable<QuestoesavaliacaoDTO> Questoesavaliacao { get; set; }
    }
}
