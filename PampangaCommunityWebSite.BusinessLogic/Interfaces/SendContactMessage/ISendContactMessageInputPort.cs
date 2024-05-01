using PampangaCommunityWebSite.Entities.Models;

namespace PampangaCommunityWebSite.BusinessLogic.Interfaces.SendContactMessage;
public interface ISendContactMessageInputPort
{
    Task Handle(ContactFormData data);
}
