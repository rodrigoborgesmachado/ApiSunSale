namespace ApiSunSale.Domain.Entities
{
    public class Notascortesisu 
    {
        public long Id { get; set; }
        public long Year { get; set; }
        public string Numeroedicao { get; set; }
        public long Codigoinstituicaoensino { get; set; }
        public string Nomeinstituicao { get; set; }
        public string Siglainstituicao { get; set; }
        public string Organizacaoacademica { get; set; }
        public string Categoriaorganizacao { get; set; }
        public string Nomecampus { get; set; }
        public string Nomemunicipiocampus { get; set; }
        public string Ufcampus { get; set; }
        public string Regiaocampus { get; set; }
        public long Codigocurso { get; set; }
        public string Nomecurso { get; set; }
        public string Descricaograu { get; set; }
        public string Turno { get; set; }
        public string Modoconcorrencia { get; set; }
        public string Desricaomodoconcorrencia { get; set; }
        public decimal Bonusacaoafirmativa { get; set; }
        public long Quantidadevagas { get; set; }
        public decimal Notacorte { get; set; }
        public long Quantidadeinscricoes { get; set; }
    }
}
