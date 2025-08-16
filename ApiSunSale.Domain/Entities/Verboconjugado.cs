namespace ApiSunSale.Domain.Entities
{
    public class Verboconjugado 
    {
        public long Codigo { get; set; }
        public DateTime Datacriacao { get; set; }
        public string Verbo { get; set; }
        public string Presente { get; set; }
        public string Preteritoimperfeito { get; set; }
        public string Preteritoperfeito { get; set; }
        public string Preteritomaisqueperfeito { get; set; }
        public string Futurodopresente { get; set; }
        public string Futurodopreterito { get; set; }
        public string Pronome { get; set; }
    }
}
