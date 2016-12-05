using Microsoft.AspNet.Identity.EntityFramework;

namespace ParrotWingsTransfer.API.Models
{
    public class AuthContext : IdentityDbContext<ApplicationUser>
    {
        public AuthContext()
            : base("AuthContext")
        {

        }
    }
}