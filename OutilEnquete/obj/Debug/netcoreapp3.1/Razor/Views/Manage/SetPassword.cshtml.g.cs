#pragma checksum "C:\Users\Bernardo Estacio\Desktop\OPS2020 GUI\OutilEnquete\Views\Manage\SetPassword.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "62fcffdff9d7f815da3985c45abf2b28fbb1a2ed"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Manage_SetPassword), @"mvc.1.0.view", @"/Views/Manage/SetPassword.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Manage/SetPassword.cshtml", typeof(AspNetCore.Views_Manage_SetPassword))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"62fcffdff9d7f815da3985c45abf2b28fbb1a2ed", @"/Views/Manage/SetPassword.cshtml")]
    public class Views_Manage_SetPassword : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<OutilEnquete.Models.SetPasswordViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Bernardo Estacio\Desktop\OPS2020 GUI\OutilEnquete\Views\Manage\SetPassword.cshtml"
  
    ViewBag.Title = "Create Password";

#line default
#line hidden
            BeginContext(96, 6, true);
            WriteLiteral("\r\n<h2>");
            EndContext();
            BeginContext(103, 13, false);
#line 6 "C:\Users\Bernardo Estacio\Desktop\OPS2020 GUI\OutilEnquete\Views\Manage\SetPassword.cshtml"
Write(ViewBag.Title);

#line default
#line hidden
            EndContext();
            BeginContext(116, 171, true);
            WriteLiteral(".</h2>\r\n<p class=\"text-info\">\r\n    You do not have a local username/password for this site. Add a local\r\n    account so you can log in without an external login.\r\n</p>\r\n\r\n");
            EndContext();
#line 12 "C:\Users\Bernardo Estacio\Desktop\OPS2020 GUI\OutilEnquete\Views\Manage\SetPassword.cshtml"
 using (Html.BeginForm("SetPassword", "Manage", FormMethod.Post, new { @class = "form-horizontal", role = "form" }))
{
    

#line default
#line hidden
            BeginContext(413, 23, false);
#line 14 "C:\Users\Bernardo Estacio\Desktop\OPS2020 GUI\OutilEnquete\Views\Manage\SetPassword.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
            EndContext();
            BeginContext(440, 45, true);
            WriteLiteral("    <h4>Create Local Login</h4>\r\n    <hr />\r\n");
            EndContext();
            BeginContext(490, 58, false);
#line 18 "C:\Users\Bernardo Estacio\Desktop\OPS2020 GUI\OutilEnquete\Views\Manage\SetPassword.cshtml"
Write(Html.ValidationSummary("", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(550, 38, true);
            WriteLiteral("    <div class=\"form-group\">\r\n        ");
            EndContext();
            BeginContext(589, 76, false);
#line 20 "C:\Users\Bernardo Estacio\Desktop\OPS2020 GUI\OutilEnquete\Views\Manage\SetPassword.cshtml"
   Write(Html.LabelFor(m => m.NewPassword, new { @class = "col-md-2 control-label" }));

#line default
#line hidden
            EndContext();
            BeginContext(665, 47, true);
            WriteLiteral("\r\n        <div class=\"col-md-10\">\r\n            ");
            EndContext();
            BeginContext(713, 69, false);
#line 22 "C:\Users\Bernardo Estacio\Desktop\OPS2020 GUI\OutilEnquete\Views\Manage\SetPassword.cshtml"
       Write(Html.PasswordFor(m => m.NewPassword, new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(782, 68, true);
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n    <div class=\"form-group\">\r\n        ");
            EndContext();
            BeginContext(851, 80, false);
#line 26 "C:\Users\Bernardo Estacio\Desktop\OPS2020 GUI\OutilEnquete\Views\Manage\SetPassword.cshtml"
   Write(Html.LabelFor(m => m.ConfirmPassword, new { @class = "col-md-2 control-label" }));

#line default
#line hidden
            EndContext();
            BeginContext(931, 47, true);
            WriteLiteral("\r\n        <div class=\"col-md-10\">\r\n            ");
            EndContext();
            BeginContext(979, 73, false);
#line 28 "C:\Users\Bernardo Estacio\Desktop\OPS2020 GUI\OutilEnquete\Views\Manage\SetPassword.cshtml"
       Write(Html.PasswordFor(m => m.ConfirmPassword, new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(1052, 219, true);
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n    <div class=\"form-group\">\r\n        <div class=\"col-md-offset-2 col-md-10\">\r\n            <input type=\"submit\" value=\"Set password\" class=\"btn btn-default\" />\r\n        </div>\r\n    </div>\r\n");
            EndContext();
#line 36 "C:\Users\Bernardo Estacio\Desktop\OPS2020 GUI\OutilEnquete\Views\Manage\SetPassword.cshtml"
}

#line default
#line hidden
            DefineSection("Scripts", async() => {
                BeginContext(1292, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(1299, 37, false);
#line 38 "C:\Users\Bernardo Estacio\Desktop\OPS2020 GUI\OutilEnquete\Views\Manage\SetPassword.cshtml"
Write(Scripts.Render("~/bundles/jqueryval"));

#line default
#line hidden
                EndContext();
                BeginContext(1336, 2, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<OutilEnquete.Models.SetPasswordViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
