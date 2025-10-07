using System.Collections.Generic;

namespace ApiSunSale.Domain.Entities
{
    public class Avaliacao : BaseEntity
    {
        public long Id { get; set; }
        public string Nome { get; set; }
        public string Orientação { get; set; }
        public string Ispublic { get; set; }
        public string Key { get; set; }
        public long CreatedBy { get; set; }
        public long UpdatedBy { get; set; }

        public IEnumerable<Questoesavaliacao> Questoesavaliacao { get; set; }
        public IEnumerable<Respostasavaliacoes> Respostasavaliacoes { get; set; }
    }
}
