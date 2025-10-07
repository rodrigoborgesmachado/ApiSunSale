using ApiSunSale.Domain.Interfaces.Services;
using ApiSunSale.Domain.ModelClasses;
using Mailjet.Client;
using Mailjet.Client.Resources;
using Microsoft.Extensions.Options;
using Newtonsoft.Json.Linq;
using Logger = ApiSunSale.Domain.Interfaces.Repository.ILoggerRepository;
using Main = ApiSunSale.Domain.Entities.Email;

namespace ApiSunSale.Domain.Services
{
    public class MailJetService : IEmailService
    {
        private readonly Settings _settings;
        private readonly Logger _logger;

        public MailJetService(IOptions<Settings> options, Logger logger)
        {
            _settings = options.Value;
            _logger = logger;
        }

        public async Task<bool> SendMail(Main entity)
        {
            bool retorno = true;

            try
            {
                var client = new MailjetClient(_settings.MailjetApiKey, _settings.MailjetSecretKey);

                var plainTextContent = entity.Texto;
                var request = new MailjetRequest
                {
                    Resource = Send.Resource,
                }
                .Property(Send.FromEmail, _settings.EmailCredential)
                .Property(Send.Subject, entity.Assunto)
                .Property(Send.TextPart, plainTextContent)
                .Property(Send.HtmlPart, plainTextContent)
                .Property(Send.Recipients, new JArray {
                    new JObject {
                        { "Email", entity.Destinatario }
                    }
                });

                var response = await client.PostAsync(request);

                retorno = response.IsSuccessStatusCode;

                if (!retorno)
                {
                    var responseBody = response.GetData().ToString();
                    await _logger.InsertAsync(new Exception($"Mailjet send failed: {response.StatusCode} - {responseBody}"));
                }
            }
            catch (Exception ex)
            {
                await _logger.InsertAsync(ex);
                retorno = false;
            }

            return retorno;
        }
    }
}
