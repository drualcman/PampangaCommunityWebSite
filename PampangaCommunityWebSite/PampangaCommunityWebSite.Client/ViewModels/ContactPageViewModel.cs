using PampangaCommunityWebSite.Client.Entities;
using PampangaCommunityWebSite.Client.Models;

namespace PampangaCommunityWebSite.Client.ViewModels;

public class ContactPageViewModel(ContactPageModel Model)
{
	public ContactFormData FormData { get; set; } = new();

    public string Message { get; set; }

    public async Task SendForm()
    {
		try
		{
			await Model.SendFrom(FormData);
			Message = "Thanks for your contact. We will keep in touch soon as possible.";
			FormData = new();
        }
		catch (Exception ex)
		{
			Message = $"Huston!. We got a problem! {ex.Message}";
		}
    }
}
