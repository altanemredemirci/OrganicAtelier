using Microsoft.AspNetCore.Identity;

namespace OrganicAtelier.WEBUI.Identity
{
    public class AppUser:IdentityUser
    {
        public string FullName { get; set; }
    }
}
