using System;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace ParrotWingsTransfer.API.Models
{
    public class AuthRepository : IDisposable
    {
        private AuthContext _ctx;

        private ApplicationUserManager _userManager;

        public AuthRepository()
        {
            _ctx = new AuthContext();
            _userManager = new ApplicationUserManager(new UserStore<ApplicationUser>(new AuthContext()));
        }

        public async Task<IdentityResult> RegisterUser(UserModel userModel)
        {
            var user = new ApplicationUser
            {
                Email = userModel.Email,
                UserName = userModel.Email,
                Surname = userModel.UserName
            };

            var result = await _userManager.CreateAsync(user, userModel.Password);

            return result;
        }

        public async Task<ApplicationUser> FindUser(string userName, string password)
        {
            IdentityUser user = await _userManager.FindAsync(userName, password);

            return user as ApplicationUser;
        }

        public void Dispose()
        {
            _ctx.Dispose();
            _userManager.Dispose();

        }
    }
}