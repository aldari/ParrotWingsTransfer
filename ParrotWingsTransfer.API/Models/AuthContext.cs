using Microsoft.AspNet.Identity.EntityFramework;

namespace ParrotWingsTransfer.API.Models
{
    public class AuthContext : IdentityDbContext<IdentityUser>
    {
        public AuthContext()
            : base("AuthContext")
        {

        }
    }
}