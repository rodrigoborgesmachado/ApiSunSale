using ApiSunSale.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.Extensions.Configuration;

namespace ApiSunSale.Infrastructure.Data.Context
{
    public class ApiSunSaleContext : DbContext
    {
        private readonly IConfiguration _configuration;
        private readonly string connectionString;

        private ApiSunSaleContext()
        {
            ChangeTracker.LazyLoadingEnabled = false;
        }

        public ApiSunSaleContext(IConfiguration configuration)
            : base()
        {
            _configuration = configuration;
        }

        public ApiSunSaleContext(string connectionString)
            : base()
        {
            this.connectionString = connectionString;
        }

        #region DbSet

        public DbSet<Acaousuario> Acaousuario { get; set; }
        public DbSet<Alimentos> Alimentos { get; set; }
        public DbSet<Anexoresposta> Anexoresposta { get; set; }
        public DbSet<Anexosquestoes> Anexosquestoes { get; set; }
        public DbSet<Avaliacao> Avaliacao { get; set; }
        public DbSet<Biomas> Biomas { get; set; }
        public DbSet<Campos> Campos { get; set; }
        public DbSet<Cartaocreditodevtools> Cartaocreditodevtools { get; set; }
        public DbSet<Categoriaalimentos> Categoriaalimentos { get; set; }
        public DbSet<Chavesjwt> Chavesjwt { get; set; }
        public DbSet<Clientes> Clientes { get; set; }
        public DbSet<Codigostable> Codigostable { get; set; }
        public DbSet<Comentariosquestoes> Comentariosquestoes { get; set; }
        public DbSet<Configuracaoemail> Configuracaoemail { get; set; }
        public DbSet<Consultas> Consultas { get; set; }
        public DbSet<Contabancofordev> Contabancofordev { get; set; }
        public DbSet<Crudformsinstalador> Crudformsinstalador { get; set; }
        public DbSet<Despesas> Despesas { get; set; }
        public DbSet<Email> Email { get; set; }
        public DbSet<Emailanexos> Emailanexos { get; set; }
        public DbSet<Emailbackup> Emailbackup { get; set; }
        public DbSet<Empresafordev> Empresafordev { get; set; }
        public DbSet<Imagensbioma> Imagensbioma { get; set; }
        public DbSet<Imagensplanta> Imagensplanta { get; set; }
        public DbSet<Licencassunsalepro> Licencassunsalepro { get; set; }
        public DbSet<Logg> Logg { get; set; }
        public DbSet<Logger> Logger { get; set; }
        public DbSet<Metas> Metas { get; set; }
        public DbSet<Modulos> Modulos { get; set; }
        public DbSet<Notascortesisu> Notascortesisu { get; set; }
        public DbSet<Oleosessenciais> Oleosessenciais { get; set; }
        public DbSet<Palavras> Palavras { get; set; }
        public DbSet<Parametros> Parametros { get; set; }
        public DbSet<Pesos> Pesos { get; set; }
        public DbSet<Pessoasfordev> Pessoasfordev { get; set; }
        public DbSet<Plantas> Plantas { get; set; }
        public DbSet<Postagem> Postagem { get; set; }
        public DbSet<Projeto> Projeto { get; set; }
        public DbSet<Prova> Prova { get; set; }
        public DbSet<Questoes> Questoes { get; set; }
        public DbSet<Questoesavaliacao> Questoesavaliacao { get; set; }
        public DbSet<Receitas> Receitas { get; set; }
        public DbSet<Recuperasenha> Recuperasenha { get; set; }
        public DbSet<Recuperasenhaconcursando> Recuperasenhaconcursando { get; set; }
        public DbSet<Recuperasenhacrudforms> Recuperasenhacrudforms { get; set; }
        public DbSet<Relacao> Relacao { get; set; }
        public DbSet<Respostasavaliacoes> Respostasavaliacoes { get; set; }
        public DbSet<Respostasquestoes> Respostasquestoes { get; set; }
        public DbSet<Respostasusuarios> Respostasusuarios { get; set; }
        public DbSet<Resultadossoletrando> Resultadossoletrando { get; set; }
        public DbSet<Resultadostabuadadivertida> Resultadostabuadadivertida { get; set; }
        public DbSet<Savedresultswpp> Savedresultswpp { get; set; }
        public DbSet<Simulados> Simulados { get; set; }
        public DbSet<Tabela> Tabela { get; set; }
        public DbSet<Tabelas> Tabelas { get; set; }
        public DbSet<Tabelasmodulos> Tabelasmodulos { get; set; }
        public DbSet<Temp1> Temp1 { get; set; }
        public DbSet<Teste> Teste { get; set; }
        public DbSet<Tipocampo> Tipocampo { get; set; }
        public DbSet<Tipoperfil> Tipoperfil { get; set; }
        public DbSet<Tipopostagem> Tipopostagem { get; set; }
        public DbSet<Tipoprova> Tipoprova { get; set; }
        public DbSet<Tipoprovaassociado> Tipoprovaassociado { get; set; }
        public DbSet<Tiposuporte> Tiposuporte { get; set; }
        public DbSet<Traducoes> Traducoes { get; set; }
        public DbSet<Usuarioconcursando> Usuarioconcursando { get; set; }
        public DbSet<Usuarios> Usuarios { get; set; }
        public DbSet<Usuarioscrudforms> Usuarioscrudforms { get; set; }
        public DbSet<Veiculosfordev> Veiculosfordev { get; set; }
        public DbSet<Verboconjugado> Verboconjugado { get; set; }
        public DbSet<Verbos> Verbos { get; set; }
        public DbSet<Verificacaousuario> Verificacaousuario { get; set; }
        public DbSet<Versao> Versao { get; set; }
        public DbSet<Whosthatpokemonresult> Whosthatpokemonresult { get; set; }

        #endregion

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connString = string.IsNullOrEmpty(connectionString)
                ? _configuration["ConnectionStrings"]
                : connectionString;
            
            Console.WriteLine("Here");
            Console.WriteLine(connString);

            optionsBuilder
                .UseSqlServer(connString, options =>
                {
                    options.CommandTimeout(180); // Set the timeout to 180 seconds
                })
#if DEBUG
                .LogTo(Console.WriteLine, Microsoft.Extensions.Logging.LogLevel.Information); // Log SQL queries in debug mode
#else
;
#endif
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        public void CreateDefaultData(object model)
        {
            var dateNow = TimeZoneInfo.ConvertTimeFromUtc(DateTime.UtcNow, TimeZoneInfo.FindSystemTimeZoneById("E. South America Standard Time"));

            // Recursively traverse the model and its properties
            SetPropertiesRecursively(model, dateNow);
        }

        private void SetPropertiesRecursively(object obj, DateTime dateNow)
        {
            if (obj == null)
                return;

            var properties = obj.GetType().GetProperties();

            foreach (var property in properties)
            {
                if (!property.CanRead || !property.CanWrite)
                    continue;

                var propertyType = property.PropertyType;

                // Check if the property is a collection (IEnumerable but not a string)
                if (propertyType.FullName.Contains("System.Collections.Generic.IEnumerable"))
                {
                    var list = property.GetValue(obj) as IEnumerable<object>;
                    if (list != null)
                    {
                        foreach (var item in list)
                        {
                            SetPropertiesRecursively(item, dateNow);
                        }
                    }
                }
                // For complex objects (classes) that are not string, recursively set properties
                else if (propertyType.IsClass && propertyType != typeof(string))
                {
                    var nestedObject = property.GetValue(obj);
                    if (nestedObject != null)
                    {
                        SetPropertiesRecursively(nestedObject, dateNow);
                    }
                }
                else
                {
                    // Set specific properties (Code, Created, Updated) as required
                    if (property.Name == "Code" && string.IsNullOrEmpty((string)property.GetValue(obj)))
                    {
                        property.SetValue(obj, Guid.NewGuid().ToString());
                    }
                    else if (property.Name == "Created" && (!HasValue(property.GetValue(obj)) || (DateTime)property.GetValue(obj) == DateTime.MinValue))
                    {
                        property.SetValue(obj, dateNow);
                    }
                    else if (property.Name == "Updated" && (!HasValue(property.GetValue(obj)) || (DateTime)property.GetValue(obj) == DateTime.MinValue))
                    {
                        property.SetValue(obj, dateNow);
                    }
                }
            }
        }

        private bool HasValue(object value)
        {
            if (value == null)
            {
                return false;
            }

            // If the value is a string, check if it's null or empty
            if (value is string str)
            {
                return !string.IsNullOrEmpty(str);
            }

            // If the value is a DateTime, check if it's DateTime.MinValue
            if (value is DateTime dateTime)
            {
                return dateTime != DateTime.MinValue;
            }

            // If the value is nullable, check if it has a value
            var type = value.GetType();
            if (Nullable.GetUnderlyingType(type) != null)
            {
                return ((dynamic)value).HasValue;
            }

            // For other types, assume they are valid if not null
            return true;
        }

        private void ConfigSaveUpdate()
        {
            var dateNow = TimeZoneInfo.ConvertTimeFromUtc(DateTime.UtcNow, TimeZoneInfo.FindSystemTimeZoneById("E. South America Standard Time"));

            foreach (var entry in ChangeTracker.Entries().Where(entry => entry.Entity.GetType().GetProperty("Created") != null && entry.Entity.GetType().GetProperty("Updated") != null))
            {
                switch (entry.State)
                {
                    case EntityState.Added:
                        if(entry.Property("Created").CurrentValue == null || (DateTime)entry.Property("Created").CurrentValue == DateTime.MinValue)
                            entry.Property("Created").CurrentValue = dateNow;

                        entry.Property("Updated").CurrentValue = dateNow;
                        entry.Property("IsActive").CurrentValue = (byte)1;
                        entry.Property("IsDeleted").CurrentValue = (byte)0;

                        var t = entry.Entity.GetType();

                        if (t.GetProperty("Code") == null)
                        {
                            continue;
                        }

                        string pKey = (string)t.GetProperty("Code").GetValue(entry.Entity, null);

                        if (string.IsNullOrEmpty(pKey))
                        {
                            pKey = Guid.NewGuid().ToString();
                            t.GetProperty("Code").SetValue(entry.Entity, pKey, null);
                        }

                        break;

                    case EntityState.Modified:
                        entry.Property("Created").IsModified = false;
                        entry.Property("Updated").CurrentValue = dateNow;
                        break;
                }
            }
        }

        public override async Task<int> SaveChangesAsync(CancellationToken cancellation = default)
        {
            ConfigSaveUpdate();
            return await base.SaveChangesAsync();
        }

        public override int SaveChanges()
        {
            ConfigSaveUpdate();
            return base.SaveChanges();
        }
    }
}
