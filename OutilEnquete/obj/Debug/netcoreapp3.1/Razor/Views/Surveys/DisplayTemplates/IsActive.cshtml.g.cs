#pragma checksum "C:\Users\Bernardo Estacio\Desktop\OPS2020 GUI\OutilEnquete\Views\Surveys\DisplayTemplates\IsActive.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "666d90d38084f2ec7ca1d4b742c2e42abc435059"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Surveys_DisplayTemplates_IsActive), @"mvc.1.0.view", @"/Views/Surveys/DisplayTemplates/IsActive.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Surveys/DisplayTemplates/IsActive.cshtml", typeof(AspNetCore.Views_Surveys_DisplayTemplates_IsActive))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"666d90d38084f2ec7ca1d4b742c2e42abc435059", @"/Views/Surveys/DisplayTemplates/IsActive.cshtml")]
    public class Views_Surveys_DisplayTemplates_IsActive : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<System.Boolean>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(23, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Bernardo Estacio\Desktop\OPS2020 GUI\OutilEnquete\Views\Surveys\DisplayTemplates\IsActive.cshtml"
 if (Model)
{

#line default
#line hidden
            BeginContext(41, 53, true);
            WriteLiteral("    <span class=\"label label-success\">Active</span>\r\n");
            EndContext();
#line 6 "C:\Users\Bernardo Estacio\Desktop\OPS2020 GUI\OutilEnquete\Views\Surveys\DisplayTemplates\IsActive.cshtml"
}
else
{

#line default
#line hidden
            BeginContext(106, 40, true);
            WriteLiteral("    <span class=\"label\">Expired</span>\r\n");
            EndContext();
#line 10 "C:\Users\Bernardo Estacio\Desktop\OPS2020 GUI\OutilEnquete\Views\Surveys\DisplayTemplates\IsActive.cshtml"
}

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<System.Boolean> Html { get; private set; }
    }
}
#pragma warning restore 1591
