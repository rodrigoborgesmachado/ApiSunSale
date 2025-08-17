namespace ApiSunSale.Application.DTO
{
    public class ComentariosquestoesDTO : BaseDTO
    {
        public long Id { get; set; }
        public string Comentario { get; set; }
        public long Idusuario { get; set; }
        public long Idquestao { get; set; }
        public UsuariosDTO Usuario { get; set; }
        public QuestoesDTO Questao { get; set; }
    }
}
