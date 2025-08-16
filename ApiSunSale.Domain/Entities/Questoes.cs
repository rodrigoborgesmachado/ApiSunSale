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
    }
}
