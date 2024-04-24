using Microsoft.AspNetCore.Http;
using PampangaCommunityWebSire.Entities.Models;
using PampangaCommunityWebSite.BusinessLogic.Interfaces.SendContactMessage;

namespace PampangaCommunityWebSite.BusinessLogic.UseCases.SendContactMessage;
internal class SendContactMessageController(ISendContactMessageInputPort inputPort) 
    : ISendContactMessageController
{
    public async Task<IResult> SendMessage(ContactFormData data)
    {
		await inputPort.Handle(data);
        return Results.Ok();
    }
}
