using System.ComponentModel.DataAnnotations;

namespace PampangaCommunityWebSire.Entities.Models;

public class ContactFormData
{
    public string Name { get; set; }
    [Required]
    [EmailAddress]
    public string Email { get; set; }
    public string Phone { get; set; }
    [Required]
    public string Message { get; set; }
}
