#pragma checksum "C:\Users\Bernardo Estacio\Desktop\OPS2020 GUI\OutilEnquete\Views\Account\Login.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "48e4f904982b7a8728f315f57b0dbcffcfdef44e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_Login), @"mvc.1.0.view", @"/Views/Account/Login.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Account/Login.cshtml", typeof(AspNetCore.Views_Account_Login))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\Bernardo Estacio\Desktop\OPS2020 GUI\OutilEnquete\Views\Account\Login.cshtml"
using OutilEnquete.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"48e4f904982b7a8728f315f57b0dbcffcfdef44e", @"/Views/Account/Login.cshtml")]
    public class Views_Account_Login : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<LoginViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "C:\Users\Bernardo Estacio\Desktop\OPS2020 GUI\OutilEnquete\Views\Account\Login.cshtml"
  
    ViewBag.Title = "Log in";

#line default
#line hidden
            BeginContext(89, 37, true);
            WriteLiteral("\r\n<div class=\"page-header\">\r\n    <h2>");
            EndContext();
            BeginContext(127, 13, false);
#line 8 "C:\Users\Bernardo Estacio\Desktop\OPS2020 GUI\OutilEnquete\Views\Account\Login.cshtml"
   Write(ViewBag.Title);

#line default
#line hidden
            EndContext();
            BeginContext(140, 144, true);
            WriteLiteral(" <small>Use a local account to log in.</small></h2>\r\n</div>\r\n\r\n<div class=\"row\">\r\n    <div class=\"col-md-8\">\r\n        <section id=\"loginForm\">\r\n");
            EndContext();
#line 14 "C:\Users\Bernardo Estacio\Desktop\OPS2020 GUI\OutilEnquete\Views\Account\Login.cshtml"
             using (Html.BeginForm("Login", "Account", new { ReturnUrl = ViewBag.ReturnUrl }, FormMethod.Post, new { @class = "form-horizontal", role = "form" }))
            {
                

#line default
#line hidden
            BeginContext(480, 23, false);
#line 16 "C:\Users\Bernardo Estacio\Desktop\OPS2020 GUI\OutilEnquete\Views\Account\Login.cshtml"
           Write(Html.AntiForgeryToken());

#line default
#line hidden
            EndContext();
            BeginContext(522, 64, false);
#line 17 "C:\Users\Bernardo Estacio\Desktop\OPS2020 GUI\OutilEnquete\Views\Account\Login.cshtml"
           Write(Html.ValidationSummary(true, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(588, 65, true);
            WriteLiteral("                <div class=\"control-group\">\r\n                    ");
            EndContext();
            BeginContext(654, 61, false);
#line 19 "C:\Users\Bernardo Estacio\Desktop\OPS2020 GUI\OutilEnquete\Views\Account\Login.cshtml"
               Write(Html.LabelFor(m => m.Email, new { @class = "control-label" }));

#line default
#line hidden
            EndContext();
            BeginContext(715, 70, true);
            WriteLiteral("\r\n                    <div class=\"controls\">\r\n                        ");
            EndContext();
            BeginContext(786, 62, false);
#line 21 "C:\Users\Bernardo Estacio\Desktop\OPS2020 GUI\OutilEnquete\Views\Account\Login.cshtml"
                   Write(Html.TextBoxFor(m => m.Email, new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(848, 26, true);
            WriteLiteral("\r\n                        ");
            EndContext();
            BeginContext(875, 75, false);
#line 22 "C:\Users\Bernardo Estacio\Desktop\OPS2020 GUI\OutilEnquete\Views\Account\Login.cshtml"
                   Write(Html.ValidationMessageFor(m => m.Email, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(950, 119, true);
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n                <div class=\"control-group\">\r\n                    ");
            EndContext();
            BeginContext(1070, 73, false);
#line 26 "C:\Users\Bernardo Estacio\Desktop\OPS2020 GUI\OutilEnquete\Views\Account\Login.cshtml"
               Write(Html.LabelFor(m => m.Password, new { @class = "col-md-2 control-label" }));

#line default
#line hidden
            EndContext();
            BeginContext(1143, 70, true);
            WriteLiteral("\r\n                    <div class=\"controls\">\r\n                        ");
            EndContext();
            BeginContext(1214, 66, false);
#line 28 "C:\Users\Bernardo Estacio\Desktop\OPS2020 GUI\OutilEnquete\Views\Account\Login.cshtml"
                   Write(Html.PasswordFor(m => m.Password, new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(1280, 26, true);
            WriteLiteral("\r\n                        ");
            EndContext();
            BeginContext(1307, 78, false);
#line 29 "C:\Users\Bernardo Estacio\Desktop\OPS2020 GUI\OutilEnquete\Views\Account\Login.cshtml"
                   Write(Html.ValidationMessageFor(m => m.Password, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(1385, 219, true);
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n                <div class=\"control-group\">\r\n                    <div class=\"controls\">\r\n                        <div class=\"checkbox\">\r\n                            ");
            EndContext();
            BeginContext(1605, 35, false);
#line 35 "C:\Users\Bernardo Estacio\Desktop\OPS2020 GUI\OutilEnquete\Views\Account\Login.cshtml"
                       Write(Html.CheckBoxFor(m => m.RememberMe));

#line default
#line hidden
            EndContext();
            BeginContext(1640, 30, true);
            WriteLiteral("\r\n                            ");
            EndContext();
            BeginContext(1671, 32, false);
#line 36 "C:\Users\Bernardo Estacio\Desktop\OPS2020 GUI\OutilEnquete\Views\Account\Login.cshtml"
                       Write(Html.LabelFor(m => m.RememberMe));

#line default
#line hidden
            EndContext();
            BeginContext(1703, 356, true);
            WriteLiteral(@"
                        </div>
                    </div>
                </div>
                <div class=""control-group"">
                    <div class=""controls"">
                        <input type=""submit"" value=""Log in"" class=""btn btn-default"" />
                    </div>
                </div>
                <p>
                    ");
            EndContext();
            BeginContext(2060, 53, false);
#line 46 "C:\Users\Bernardo Estacio\Desktop\OPS2020 GUI\OutilEnquete\Views\Account\Login.cshtml"
               Write(Html.ActionLink("Register as a new user", "Register"));

#line default
#line hidden
            EndContext();
            BeginContext(2113, 24, true);
            WriteLiteral("\r\n                </p>\r\n");
            EndContext();
#line 51 "C:\Users\Bernardo Estacio\Desktop\OPS2020 GUI\OutilEnquete\Views\Account\Login.cshtml"
                          
            }

#line default
#line hidden
            BeginContext(2398, 112, true);
            WriteLiteral("        </section>\r\n    </div>\r\n    <div class=\"col-md-4\">\r\n        <section id=\"socialLoginForm\">\r\n            ");
            EndContext();
            BeginContext(2511, 108, false);
#line 57 "C:\Users\Bernardo Estacio\Desktop\OPS2020 GUI\OutilEnquete\Views\Account\Login.cshtml"
       Write(Html.Partial("_ExternalLoginsListPartial", new ExternalLoginListViewModel { ReturnUrl = ViewBag.ReturnUrl }));

#line default
#line hidden
            EndContext();
            BeginContext(2619, 44, true);
            WriteLiteral("\r\n        </section>\r\n    </div>\r\n</div>\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(2681, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(2688, 37, false);
#line 63 "C:\Users\Bernardo Estacio\Desktop\OPS2020 GUI\OutilEnquete\Views\Account\Login.cshtml"
Write(Scripts.Render("~/bundles/jqueryval"));

#line default
#line hidden
                EndContext();
                BeginContext(2725, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<LoginViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
