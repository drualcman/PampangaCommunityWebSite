using Microsoft.AspNetCore.Components;
using PampangaCommunityWebSite.Client.Models;

namespace PampangaCommunityWebSite.Client.Components;
public partial class MemberCardComponent
{
    [Parameter] public MemberProfile Member { get; set; }
}