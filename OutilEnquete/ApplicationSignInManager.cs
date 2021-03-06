﻿using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin;
using Microsoft.Owin.Security;
using OutilEnquete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace OutilEnquete
{ }
    public class ApplicationSignInManager : SignInManager<UserData, string>
{
    private ApplicationUserManager applicationUserManager;
    private IAuthenticationManager authentication;

    public ApplicationSignInManager(ApplicationUserManager userManager, IAuthenticationManager authenticationManager)
        : base(userManager, authenticationManager)
    
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
}