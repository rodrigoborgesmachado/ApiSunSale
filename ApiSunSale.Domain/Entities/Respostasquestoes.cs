using System.Collections.Generic;

namespace ApiSunSale.Domain.Entities
{
    public class Respostasquestoes : BaseEntity
    {
        public long Id { get; set; }
        public long Idquestao { get; set; }
        public string? Textoresposta { get; set; }
        public string Certa { get; set; }
        public string? Observacaoresposta { get; set; }

        public Questoes? Questao { get; set; }
        public IEnumerable<Anexoresposta> Anexosresposta { get; set; }
        public IEnumerable<Respostasavaliacoes>? Respostasavaliacoes { get; set; }
        public IEnumerable<Respostasusuarios>? Respostasusuarios { get; set; }
    }
}
