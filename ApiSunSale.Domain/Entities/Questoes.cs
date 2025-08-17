using System.Collections.Generic;

namespace ApiSunSale.Domain.Entities
{
    public class Questoes : BaseEntity
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

        public Prova Prova { get; set; }
        public IEnumerable<Anexoresposta> Anexosresposta { get; set; }
        public IEnumerable<Anexosquestoes> Anexosquestoes { get; set; }
        public IEnumerable<Comentariosquestoes> Comentariosquestoes { get; set; }
        public IEnumerable<Respostasquestoes> Respostasquestoes { get; set; }
        public IEnumerable<Respostasusuarios> Respostasusuarios { get; set; }
        public IEnumerable<Respostasavaliacoes> Respostasavaliacoes { get; set; }
        public IEnumerable<Questoesavaliacao> Questoesavaliacao { get; set; }
    }
}
