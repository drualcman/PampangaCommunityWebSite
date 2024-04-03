using PampangaCommunityWebSite.Client.Entities;
using System.Net.Http.Json;

namespace PampangaCommunityWebSite.Client.Models;

public class ContactPageModel(HttpClient Client)
{
    public async Task SendFrom(ContactFormData data)
    {
        using HttpResponseMessage response = await Client.PostAsJsonAsync("send-contact-message", data);
        response.EnsureSuccessStatusCode();
    }
}
