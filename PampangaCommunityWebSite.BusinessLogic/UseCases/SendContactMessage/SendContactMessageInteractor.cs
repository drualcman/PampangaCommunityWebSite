using PampangaCommunityWebSire.Entities.Models;
using PampangaCommunityWebSite.BusinessLogic.Interfaces.SendContactMessage;
using System.Diagnostics;

namespace PampangaCommunityWebSite.BusinessLogic.UseCases.SendContactMessage;
internal class SendContactMessageInteractor : ISendContactMessageInputPort
{
    public async Task Handle(ContactFormData data)
    {
        Debug.WriteLine($"Receive a contact from {data.Email}");
        await Task.Delay(3000);
    }
}
