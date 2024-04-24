using Microsoft.AspNetCore.Http;
using PampangaCommunityWebSire.Entities.Models;

namespace PampangaCommunityWebSite.BusinessLogic.Interfaces.SendContactMessage;
public interface ISendContactMessageController
{
    Task<IResult> SendMessage(ContactFormData data);
}
