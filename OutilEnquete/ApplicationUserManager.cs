using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin;
using System;
using System.Threading.Tasks;
using OPS.DAL;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using OutilEnquete.ViewModels;

namespace OutilEnquete
{
    public class ApplicationUserManager : UserManager<UserData>
    {
        public ApplicationUserManager(IUserStore<UserData> store)
            : base(store)
        {
        }

        public static ApplicationUserManager Create(IdentityFactoryOptions<ApplicationUserManager> options, IOwinContext context)
        {
            var manager = new ApplicationUserManager(new UserStore<UserData>(context.Get<OPSCtx>()));
            // Configure validation logic for usernames
            manager.UserValidator = new UserValidator<UserData>(manager)
            {
                AllowOnlyAlphanumericUserNames = false,
                RequireUniqueEmail = true
            };

            // Configure validation logic for passwords
            manager.PasswordValidator = new PasswordValidator
            {
                RequiredLength = 12,
                RequireNonLetterOrDigit = false,
                RequireDigit = false,
                RequireLowercase = false,
                RequireUppercase = false,
            };

            // Configure user lockout defaults
            manager.UserLockoutEnabledByDefault = true;
            manager.DefaultAccountLockoutTimeSpan = TimeSpan.FromMinutes(5);
            manager.MaxFailedAccessAttemptsBeforeLockout = 5;

            // Register two factor authentication providers. This application uses Phone and Emails as a step of receiving a code for verifying the user
            // You can write your own provider and plug it in here.
            manager.RegisterTwoFactorProvider("Phone Code", new PhoneNumberTokenProvider<UserData>
            {
                MessageFormat = "Your security code is {0}"
            });
            manager.RegisterTwoFactorProvider("Email Code", new EmailTokenProvider<UserData>
            {
                Subject = "Security Code",
                BodyFormat = "Your security code is {0}"
            });
            manager.EmailService = new EmailService();
            manager.SmsService = new SmsService();
            var dataProtectionProvider = options.DataProtectionProvider;
            if (dataProtectionProvider != null)
            {
                manager.UserTokenProvider =
                    new Microsoft.AspNet.Identity.Owin.DataProtectorTokenProvider<UserData>(dataProtectionProvider.Create("ASP.NET Identity"));
            }
            return manager;
        }

        public static explicit operator ApplicationUserManager(Microsoft.AspNet.Identity.UserManager<UserData, string> v)
        {
            throw new NotImplementedException();
        }

        internal Task<bool> GetTwoFactorEnabledAsync(string userId)
        {
            throw new NotImplementedException();
        }

        internal Task<string> GetPhoneNumberAsync(string userId)
        {
            throw new NotImplementedException();
        }

        internal Task ChangePasswordAsync(string v, string oldPassword, string newPassword)
        {
            throw new NotImplementedException();
        }

        internal Task AddPasswordAsync(string v, string newPassword)
        {
            throw new NotImplementedException();
        }

        internal Task GetLoginsAsync(string v)
        {
            throw new NotImplementedException();
        }

        internal Task GenerateChangePhoneNumberTokenAsync(string v, string number)
        {
            throw new NotImplementedException();
        }

        internal Task CreateAsync(ApplicationUser user, string password)
        {
            throw new NotImplementedException();
        }

        internal Task ConfirmEmailAsync(string userId, string code)
        {
            throw new NotImplementedException();
        }
    }
}
