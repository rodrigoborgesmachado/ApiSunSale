using ApiSunSale.Domain.Interfaces.Services;
using ApiSunSale.Domain.ModelClasses;
using Microsoft.Extensions.Options;
using SendGrid;
using SendGrid.Helpers.Mail;
using Logger = ApiSunSale.Domain.Interfaces.Repository.ILoggerRepository;
using Main = ApiSunSale.Domain.Entities.Email;

namespace ApiSunSale.Domain.Services
{
    public class SendGridService : ISendGridService
    {
        private readonly Settings _settings;
        private readonly Logger _logger;

        public SendGridService(IOptions<Settings> options, Logger logger)
        {
            _settings = options.Value;
            _logger = logger;
        }

        public async Task<bool> SendMail(Main entity)
        {
            bool retorno = true;

            var client = new SendGridClient(_settings.SendGridApiKey);
            var from = new EmailAddress(_settings.EmailCredential);
            var subject = entity.Assunto;
            var to = new EmailAddress(entity.Destinatario);
            var htmlContent = entity.Texto.ToString();
            var msg = MailHelper.CreateSingleEmail(from, to, subject, htmlContent, htmlContent);
            var response = await client.SendEmailAsync(msg);
            retorno = response.IsSuccessStatusCode;

            if (!retorno)
            {
                await _logger.InsertAsync($"Erro ao enviar email: {response.StatusCode}", entity.Id);
            }

            return retorno;
        }
    }
}
