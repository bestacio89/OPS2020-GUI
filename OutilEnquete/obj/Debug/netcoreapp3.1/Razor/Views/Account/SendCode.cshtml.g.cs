#pragma checksum "C:\Users\Bernardo Estacio\Desktop\OPS2020 GUI\OutilEnquete\Views\Account\SendCode.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2b4dbd989dc6f227829a875848273ddf51148e67"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_SendCode), @"mvc.1.0.view", @"/Views/Account/SendCode.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Account/SendCode.cshtml", typeof(AspNetCore.Views_Account_SendCode))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2b4dbd989dc6f227829a875848273ddf51148e67", @"/Views/Account/SendCode.cshtml")]
    public class Views_Account_SendCode : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<OutilEnquete.Models.SendCodeViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Bernardo Estacio\Desktop\OPS2020 GUI\OutilEnquete\Views\Account\SendCode.cshtml"
  
    ViewBag.Title = "Send";

#line default
#line hidden
            BeginContext(82, 6, true);
            WriteLiteral("\r\n<h2>");
            EndContext();
            BeginContext(89, 13, false);
#line 6 "C:\Users\Bernardo Estacio\Desktop\OPS2020 GUI\OutilEnquete\Views\Account\SendCode.cshtml"
Write(ViewBag.Title);

#line default
#line hidden
            EndContext();
            BeginContext(102, 10, true);
            WriteLiteral(".</h2>\r\n\r\n");
            EndContext();
#line 8 "C:\Users\Bernardo Estacio\Desktop\OPS2020 GUI\OutilEnquete\Views\Account\SendCode.cshtml"
 using (Html.BeginForm("SendCode", "Account", new { ReturnUrl = Model.ReturnUrl }, FormMethod.Post, new { @class = "form-horizontal", role = "form" })) {
    

#line default
#line hidden
            BeginContext(272, 23, false);
#line 9 "C:\Users\Bernardo Estacio\Desktop\OPS2020 GUI\OutilEnquete\Views\Account\SendCode.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
            EndContext();
            BeginContext(302, 44, false);
#line 10 "C:\Users\Bernardo Estacio\Desktop\OPS2020 GUI\OutilEnquete\Views\Account\SendCode.cshtml"
Write(Html.Hidden("rememberMe", @Model.RememberMe));

#line default
#line hidden
            EndContext();
            BeginContext(348, 172, true);
            WriteLiteral("    <h4>Send verification code</h4>\r\n    <hr />\r\n    <div class=\"row\">\r\n        <div class=\"col-md-8\">\r\n            Select Two-Factor Authentication Provider:\r\n            ");
            EndContext();
            BeginContext(521, 70, false);
#line 16 "C:\Users\Bernardo Estacio\Desktop\OPS2020 GUI\OutilEnquete\Views\Account\SendCode.cshtml"
       Write(Html.DropDownListFor(model => model.SelectedProvider, Model.Providers));

#line default
#line hidden
            EndContext();
            BeginContext(591, 106, true);
            WriteLiteral("\r\n            <input type=\"submit\" value=\"Submit\" class=\"btn btn-default\" />\r\n        </div>\r\n    </div>\r\n");
            EndContext();
#line 20 "C:\Users\Bernardo Estacio\Desktop\OPS2020 GUI\OutilEnquete\Views\Account\SendCode.cshtml"
}

#line default
#line hidden
            BeginContext(700, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(720, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(727, 37, false);
#line 23 "C:\Users\Bernardo Estacio\Desktop\OPS2020 GUI\OutilEnquete\Views\Account\SendCode.cshtml"
Write(Scripts.Render("~/bundles/jqueryval"));

#line default
#line hidden
                EndContext();
                BeginContext(764, 2, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<OutilEnquete.Models.SendCodeViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
