using PampangaCommunityWebSite.Client.Entities;
using PampangaCommunityWebSite.Client.Models;

namespace PampangaCommunityWebSite.Client.ViewModels;

public class ContactPageViewModel(ContactPageModel Model)
{
	public ContactFormData FormData { get; set; } = new();

    public string Message { get; set; }
    public bool IsSending { get; set; }

    public async Task SendForm()
    {
		IsSending = true;
		Message = string.Empty;
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
		finally
		{
			IsSending = false;
		}
    }
}
