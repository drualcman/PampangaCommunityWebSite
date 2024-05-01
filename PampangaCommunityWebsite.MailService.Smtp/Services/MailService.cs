using Microsoft.Extensions.Options;
using PampangaCommunityWebsite.MailService.Smtp.Options;
using PampangaCommunityWebSite.BusinessLogic.Interfaces;
using System.Net;
using System.Net.Mail;

namespace PampangaCommunityWebsite.MailService.Smtp.Services;

public class MailService(IOptions<SmtpOptions> SmtpOptions) : IMailService
{
    public Task SendAdministratorEmail(string subject, string body) =>
        SendMail(subject, body, SmtpOptions.Value.AdministratorEmail);

    public async Task SendMail(string subject, string body, string toEmail)
    {
        MailMessage message = new MailMessage(SmtpOptions.Value.SenderEmail, toEmail);
        message.Subject = subject;
        message.Body = body;

        SmtpClient smtpClient = new SmtpClient(SmtpOptions.Value.SmtpHost, SmtpOptions.Value.SmtpHostPort);
        smtpClient.Credentials = new NetworkCredential(SmtpOptions.Value.SmtpUserName, SmtpOptions.Value.SmtpPassword);
        smtpClient.EnableSsl = true;

        await smtpClient.SendMailAsync(message);
    }
}
