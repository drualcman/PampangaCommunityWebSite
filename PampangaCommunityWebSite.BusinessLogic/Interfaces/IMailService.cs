namespace PampangaCommunityWebSite.BusinessLogic.Interfaces;
public interface IMailService
{
    Task SendMail(string subject, string body, string toEmail);
    Task SendAdministratorEmail(string subject, string body);
}
