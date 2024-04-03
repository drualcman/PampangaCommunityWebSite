using Microsoft.AspNetCore.Components;
using PampangaCommunityWebSite.Client.ViewModels;

namespace PampangaCommunityWebSite.Client.Pages;
public partial class Contact
{
    [Inject] ContactPageViewModel ViewModel { get; set; }
}