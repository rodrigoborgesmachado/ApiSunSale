using System;
using System.Collections.Generic;

namespace ApiSunSale.Domain.Entities
{
    public class Usuarios : BaseEntity
    {
        public long Id { get; set; }
        public string Login { get; set; }
        public string Pass { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public DateTime Datanascimento { get; set; }
        public string Admin { get; set; }
        public string Instituicao { get; set; }

        public IEnumerable<Comentariosquestoes> Comentariosquestoes { get; set; }
        public IEnumerable<Respostasusuarios> Respostasusuarios { get; set; }
    }
}
