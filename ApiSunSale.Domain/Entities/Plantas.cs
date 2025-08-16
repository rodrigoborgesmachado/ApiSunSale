namespace ApiSunSale.Domain.Entities
{
    public class Plantas 
    {
        public long Id { get; set; }
        public long Idbioma { get; set; }
        public string Nomecientifico { get; set; }
        public string Nomepopular { get; set; }
        public string Habitate { get; set; }
        public string Folha { get; set; }
        public string Flor { get; set; }
        public string Fruto { get; set; }
        public string Familia { get; set; }
        public string Tribo { get; set; }
        public long Idusuario { get; set; }
    }
}
