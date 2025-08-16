namespace ApiSunSale.Domain.Entities
{
    public class Pesos : BaseEntity
    {
        public long Id { get; set; }
        public string Faculdade { get; set; }
        public string Curso { get; set; }
        public string Turno { get; set; }
        public string Materia { get; set; }
        public decimal Peso { get; set; }
    }
}
