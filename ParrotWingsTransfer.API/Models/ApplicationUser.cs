using Microsoft.AspNet.Identity.EntityFramework;

namespace ParrotWingsTransfer.API.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string Surname { get; set; }
    }
}