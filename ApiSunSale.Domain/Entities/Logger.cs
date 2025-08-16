using System.Diagnostics;
using System.Reflection;

namespace ApiSunSale.Domain.Entities
{
    public class Logger 
    {
        public Logger()
        {
            Created = DateTime.Now;
            Updated = DateTime.Now;
        }

        public Logger(Exception ex)
            : this()
        {
            Descricao = ex.Message;
            Stacktrace = ex.StackTrace.ToString();
        }

        public Logger(string message, long personCode)
            : this()
        {
            Descricao = message;
            PersonCode = personCode;
        }

        public int Id { get; set; }
        public string Descricao { get; set; }
        public int Tipo { get; set; }
        public string Stacktrace { get; set; }
        public long PersonCode { get; set; } 
        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }
    }
}
