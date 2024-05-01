using Microsoft.AspNetCore.Http;
using PampangaCommunityWebSite.Entities.Models;

namespace PampangaCommunityWebSite.BusinessLogic.Interfaces.SendContactMessage;
public interface ISendContactMessageController
{
    Task<IResult> SendMessage(ContactFormData data);
}
