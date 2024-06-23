using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace OrganicAtelier.WEBUI.Identity
{
    public class AppIdentityDbContext:IdentityDbContext<AppUser>
    {
        public AppIdentityDbContext(DbContextOptions<AppIdentityDbContext> options):base(options)
        {
            
        }


    }
}
