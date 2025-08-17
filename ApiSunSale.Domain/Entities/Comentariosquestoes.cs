namespace ApiSunSale.Domain.Entities
{
    public class Comentariosquestoes : BaseEntity
    {
        public long Id { get; set; }
        public string Comentario { get; set; }
        public long Idusuario { get; set; }
        public long Idquestao { get; set; }

        public Usuarios Usuario { get; set; }
        public Questoes Questao { get; set; }
    }
}
