namespace ApiSunSale.Domain.Entities
{
    public class Respostasavaliacoes : BaseEntity
    {
        public long Id { get; set; }
        public long Createdby { get; set; }
        public long Updatedby { get; set; }
        public long Idavaliacao { get; set; }
        public long Idquestao { get; set; }
        public long Idresposta { get; set; }

        public Avaliacao Avaliacao { get; set; }
        public Questoes Questao { get; set; }
        public Respostasquestoes Resposta { get; set; }
    }
}
