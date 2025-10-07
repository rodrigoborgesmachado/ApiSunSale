using System;
using System.Collections.Generic;

namespace ApiSunSale.Application.DTO
{
    public class UsuariosDTO : BaseDTO
    {
        public long Id { get; set; }
        public string Login { get; set; }
        public string Pass { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public DateTime Datanascimento { get; set; }
        public string Admin { get; set; }
        public string Instituicao { get; set; }
        public TipoperfilDTO TipoPerfil { get; set; }

        public IEnumerable<ComentariosquestoesDTO> Comentariosquestoes { get; set; }
        public IEnumerable<RespostasusuariosDTO> Respostasusuarios { get; set; }
    }
}
