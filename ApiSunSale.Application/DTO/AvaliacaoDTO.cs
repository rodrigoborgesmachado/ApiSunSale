using System.Collections.Generic;

namespace ApiSunSale.Application.DTO
{
    public class AvaliacaoDTO : BaseDTO
    {
        public long Id { get; set; }
        public string Nome { get; set; }
        public string Orientação { get; set; }
        public string Ispublic { get; set; }
        public string Key { get; set; }
        public long CreatedBy { get; set; }
        public long UpdatedBy { get; set; }
        public IEnumerable<QuestoesavaliacaoDTO> Questoesavaliacao { get; set; }
        public IEnumerable<RespostasavaliacoesDTO> Respostasavaliacoes { get; set; }
    }
}
