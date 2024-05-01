using PampangaCommunityWebSite.Entities.Models;
using PampangaCommunityWebSite.BusinessLogic.Interfaces;
using PampangaCommunityWebSite.BusinessLogic.Interfaces.SendContactMessage;

namespace PampangaCommunityWebSite.BusinessLogic.UseCases.SendContactMessage;
internal class SendContactMessageInteractor(IMailService MailService) : ISendContactMessageInputPort
{
    public async Task Handle(ContactFormData data)
    {
        string messageBody = $@"Hello {data.Name},
Thanks for your contact. We receive your message:

{data.Message}.

We will contact with your using your phone {data.Phone} or email {data.Email} soon as possible.

Pampanga Dev";
        string subject = "Thanks to contact with Pampanga Dev";
        await MailService.SendMail(subject, messageBody, data.Email);

        subject = $"{data.Name} want a response";
        messageBody = $@"Contact Name: {data.Name}
Contact Phone: {data.Phone}
Contact Email: {data.Email}
Message: 
{data.Message}";
        await MailService.SendAdministratorEmail(subject, messageBody);
    }
}
