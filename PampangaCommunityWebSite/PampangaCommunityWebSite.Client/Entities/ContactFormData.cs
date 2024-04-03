using System.ComponentModel.DataAnnotations;

namespace PampangaCommunityWebSite.Client.Entities;

public class ContactFormData
{
    public string Name { get; set; }
    [Required]
    public string Email { get; set; }
    public string Phone { get; set; }
    [Required]
    public string Message { get; set; }
}
