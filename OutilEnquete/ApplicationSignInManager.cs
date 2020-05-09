using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin;
using Microsoft.Owin.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using OutilEnquete;
using System.Security.Claims;
using System.Threading.Tasks;
using OutilEnquete.ViewModels;
using System.Security.AccessControl;
using Microsoft.AspNetCore.Session

namespace OutilEnquete
{
    public class ApplicationSignInManager : SignInManager<UserData, string>
    {
        private ApplicationUserManager applicationUserManager;
        private IAuthenticationManager authentication;

        public ApplicationSignInManager(ApplicationUserManager userManager, IAuthenticationManager authenticationManager)
            : base(userManager,
                   authenticationManager);


    public ApplicationSignInManager(ApplicationUserManager applicationUserManager, IAuthenticationManager authentication)
        {
            this.applicationUserManager = applicationUserManager;
            this.authentication = authentication;
        }

        public override Task<ClaimsIdentity> CreateUserIdentityAsync(UserData user)
        {
            return user.GenerateUserIdentityAsync((ApplicationUserManager)UserManager);
        }

        public static ApplicationSignInManager Create(IdentityFactoryOptions<ApplicationSignInManager> options, IOwinContext context)
        {
            return new ApplicationSignInManager(context.GetUserManager<ApplicationUserManager>(), context.Authentication);
        }

        internal Task SignInAsync(ApplicationUser user, bool isPersistent, bool rememberBrowser)
        {
            throw new NotImplementedException();
        }
    }
 }
    