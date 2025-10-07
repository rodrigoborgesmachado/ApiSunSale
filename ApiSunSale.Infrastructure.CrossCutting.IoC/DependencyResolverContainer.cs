using ApiSunSale.Application.Interfaces;
using ApiSunSale.Application.Services;
using ApiSunSale.Domain.Interfaces.Repository;
using ApiSunSale.Domain.Interfaces.Services;
using ApiSunSale.Domain.Services;
using ApiSunSale.Infrastructure.CrossCutting.Adapter;
using ApiSunSale.Infrastructure.Data.Repository;
using Microsoft.Extensions.DependencyInjection;
using SimpleInjector;

namespace ApiSunSale.Infrastructure.CrossCutting.IoC
{
    public class DependencyResolverContainer : Container
    {
        private static DependencyResolverContainer _instance;

        public static DependencyResolverContainer Instance => _instance ?? (_instance = new DependencyResolverContainer());

        private DependencyResolverContainer()
        {
            //RegisterServices();
        }

        public DependencyResolverContainer(IServiceCollection services)
        {
            RegisterServices(services);
        }

        public void RegisterService<TService, TImplementation>(IServiceCollection services)
            where TService : class
            where TImplementation : class, TService
        {
            services.AddScoped<TService, TImplementation>();
        }

        public void RegisterServices(IServiceCollection services)
        {
            #region Sevice

            RegisterService<IBlobStorageService, BlobAzureStorageService>(services);
            RegisterService<IEmailService, MailJetService>(services);

            #endregion

            #region Application

            RegisterService<IAcaousuarioAppService, AcaousuarioAppService>(services);
            RegisterService<IAlimentosAppService, AlimentosAppService>(services);
            RegisterService<IAnexorespostaAppService, AnexorespostaAppService>(services);
            RegisterService<IAnexosquestoesAppService, AnexosquestoesAppService>(services);
            RegisterService<IAvaliacaoAppService, AvaliacaoAppService>(services);
            RegisterService<IBiomasAppService, BiomasAppService>(services);
            RegisterService<ICartaocreditodevtoolsAppService, CartaocreditodevtoolsAppService>(services);
            RegisterService<ICategoriaalimentosAppService, CategoriaalimentosAppService>(services);
            RegisterService<IComentariosquestoesAppService, ComentariosquestoesAppService>(services);
            RegisterService<IContabancofordevAppService, ContabancofordevAppService>(services);
            RegisterService<ICrudformsinstaladorAppService, CrudformsinstaladorAppService>(services);
            RegisterService<IEmailAppService, EmailAppService>(services);
            RegisterService<IEmpresafordevAppService, EmpresafordevAppService>(services);
            RegisterService<IImagensbiomaAppService, ImagensbiomaAppService>(services);
            RegisterService<IImagensplantaAppService, ImagensplantaAppService>(services);
            RegisterService<ILicencassunsaleproAppService, LicencassunsaleproAppService>(services);
            RegisterService<ILoggerAppService, LoggerAppService>(services);
            RegisterService<IImagensbiomaAppService, ImagensbiomaAppService>(services);
            RegisterService<IImagensplantaAppService, ImagensplantaAppService>(services);
            RegisterService<IMetasAppService, MetasAppService>(services);
            RegisterService<INotascortesisuAppService, NotascortesisuAppService>(services);
            RegisterService<IPalavrasAppService, PalavrasAppService>(services);
            RegisterService<IPesosAppService, PesosAppService>(services);
            RegisterService<IPessoasfordevAppService, PessoasfordevAppService>(services);
            RegisterService<IPlantasAppService, PlantasAppService>(services);
            RegisterService<IPostagemAppService, PostagemAppService>(services);
            RegisterService<IProvaAppService, ProvaAppService>(services);
            RegisterService<IQuestoesAppService, QuestoesAppService>(services);
            RegisterService<IQuestoesavaliacaoAppService, QuestoesavaliacaoAppService>(services);
            RegisterService<IRecuperasenhaAppService, RecuperasenhaAppService>(services);
            RegisterService<IRecuperasenhacrudformsAppService, RecuperasenhacrudformsAppService>(services);
            RegisterService<IRespostasavaliacoesAppService, RespostasavaliacoesAppService>(services);
            RegisterService<IRespostasquestoesAppService, RespostasquestoesAppService>(services);
            RegisterService<IRespostasusuariosAppService, RespostasusuariosAppService>(services);
            RegisterService<IResultadossoletrandoAppService, ResultadossoletrandoAppService>(services);
            RegisterService<IResultadostabuadadivertidaAppService, ResultadostabuadadivertidaAppService>(services);
            RegisterService<ISavedresultswppAppService, SavedresultswppAppService>(services);
            RegisterService<ISimuladosAppService, SimuladosAppService>(services);
            RegisterService<ITipoperfilAppService, TipoperfilAppService>(services);
            RegisterService<ITipopostagemAppService, TipopostagemAppService>(services);
            RegisterService<ITipoprovaAppService, TipoprovaAppService>(services);
            RegisterService<ITipoprovaassociadoAppService, TipoprovaassociadoAppService>(services);
            RegisterService<IUsuariosAppService, UsuariosAppService>(services);
            RegisterService<IUsuarioscrudformsAppService, UsuarioscrudformsAppService>(services);
            RegisterService<IVeiculosfordevAppService, VeiculosfordevAppService>(services);
            RegisterService<IVerboconjugadoAppService, VerboconjugadoAppService>(services);
            RegisterService<IVerbosAppService, VerbosAppService>(services);
            RegisterService<IVerificacaousuarioAppService, VerificacaousuarioAppService>(services);
            RegisterService<IWhosthatpokemonresultAppService, WhosthatpokemonresultAppService>(services);

            #endregion

            #region Repository

            RegisterService<IAcaousuarioRepository, AcaousuarioRepository>(services);
            RegisterService<IAlimentosRepository, AlimentosRepository>(services);
            RegisterService<IAnexorespostaRepository, AnexorespostaRepository>(services);
            RegisterService<IAnexosquestoesRepository, AnexosquestoesRepository>(services);
            RegisterService<IAvaliacaoRepository, AvaliacaoRepository>(services);
            RegisterService<IBiomasRepository, BiomasRepository>(services);
            RegisterService<ICartaocreditodevtoolsRepository, CartaocreditodevtoolsRepository>(services);
            RegisterService<ICategoriaalimentosRepository, CategoriaalimentosRepository>(services);
            RegisterService<IComentariosquestoesRepository, ComentariosquestoesRepository>(services);
            RegisterService<IContabancofordevRepository, ContabancofordevRepository>(services);
            RegisterService<ICrudformsinstaladorRepository, CrudformsinstaladorRepository>(services);
            RegisterService<IEmailRepository, EmailRepository>(services);
            RegisterService<IEmpresafordevRepository, EmpresafordevRepository>(services);
            RegisterService<ILicencassunsaleproRepository, LicencassunsaleproRepository>(services);
            RegisterService<ILoggerRepository, LoggerRepository>(services);
            RegisterService<IImagensbiomaRepository, ImagensbiomaRepository>(services);
            RegisterService<IImagensplantaRepository, ImagensplantaRepository>(services);
            RegisterService<IMetasRepository, MetasRepository>(services);
            RegisterService<INotascortesisuRepository, NotascortesisuRepository>(services);
            RegisterService<IPalavrasRepository, PalavrasRepository>(services);
            RegisterService<IPesosRepository, PesosRepository>(services);
            RegisterService<IPessoasfordevRepository, PessoasfordevRepository>(services);
            RegisterService<IPlantasRepository, PlantasRepository>(services);
            RegisterService<IPostagemRepository, PostagemRepository>(services);
            RegisterService<IProvaRepository, ProvaRepository>(services);
            RegisterService<IQuestoesavaliacaoRepository, QuestoesavaliacaoRepository>(services);
            RegisterService<IQuestoesRepository, QuestoesRepository>(services);
            RegisterService<IRecuperasenhacrudformsRepository, RecuperasenhacrudformsRepository>(services);
            RegisterService<IRecuperasenhaRepository, RecuperasenhaRepository>(services);
            RegisterService<IRespostasavaliacoesRepository, RespostasavaliacoesRepository>(services);
            RegisterService<IRespostasquestoesRepository, RespostasquestoesRepository>(services);
            RegisterService<IRespostasusuariosRepository, RespostasusuariosRepository>(services);
            RegisterService<IResultadossoletrandoRepository, ResultadossoletrandoRepository>(services);
            RegisterService<IResultadostabuadadivertidaRepository, ResultadostabuadadivertidaRepository>(services);
            RegisterService<ISavedresultswppRepository, SavedresultswppRepository>(services);
            RegisterService<ISimuladosRepository, SimuladosRepository>(services);
            RegisterService<ITipoperfilRepository, TipoperfilRepository>(services);
            RegisterService<ITipopostagemRepository, TipopostagemRepository>(services);
            RegisterService<ITipoprovaassociadoRepository, TipoprovaassociadoRepository>(services);
            RegisterService<ITipoprovaRepository, TipoprovaRepository>(services);
            RegisterService<IUsuarioscrudformsRepository, UsuarioscrudformsRepository>(services);
            RegisterService<IUsuariosRepository, UsuariosRepository>(services);
            RegisterService<IVeiculosfordevRepository, VeiculosfordevRepository>(services);
            RegisterService<IVerboconjugadoRepository, VerboconjugadoRepository>(services);
            RegisterService<IVerbosRepository, VerbosRepository>(services);
            RegisterService<IVerificacaousuarioRepository, VerificacaousuarioRepository>(services);
            RegisterService<IWhosthatpokemonresultRepository, WhosthatpokemonresultRepository>(services);

            #endregion

            TypeAdapterFactory.SetCurrent(new AutomapperTypeAdapterFactory());
        }
    }
}
