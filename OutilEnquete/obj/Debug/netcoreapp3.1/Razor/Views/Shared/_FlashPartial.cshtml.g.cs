#pragma checksum "C:\Users\Bernardo Estacio\Desktop\OPS2020 GUI\OutilEnquete\Views\Shared\_FlashPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "22848069011f99050de444afcd4cde1483685613"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__FlashPartial), @"mvc.1.0.view", @"/Views/Shared/_FlashPartial.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_FlashPartial.cshtml", typeof(AspNetCore.Views_Shared__FlashPartial))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"22848069011f99050de444afcd4cde1483685613", @"/Views/Shared/_FlashPartial.cshtml")]
    public class Views_Shared__FlashPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\Bernardo Estacio\Desktop\OPS2020 GUI\OutilEnquete\Views\Shared\_FlashPartial.cshtml"
 foreach (var key in TempData.Keys)
{

#line default
#line hidden
            BeginContext(40, 81, true);
            WriteLiteral("    <script type=\"text/javascript\">\r\n        $(function() {\r\n            toastr[\"");
            EndContext();
            BeginContext(123, 3, false);
#line 5 "C:\Users\Bernardo Estacio\Desktop\OPS2020 GUI\OutilEnquete\Views\Shared\_FlashPartial.cshtml"
                Write(key);

#line default
#line hidden
            EndContext();
            BeginContext(127, 4, true);
            WriteLiteral("\"](\"");
            EndContext();
            BeginContext(132, 13, false);
#line 5 "C:\Users\Bernardo Estacio\Desktop\OPS2020 GUI\OutilEnquete\Views\Shared\_FlashPartial.cshtml"
                         Write(TempData[key]);

#line default
#line hidden
            EndContext();
            BeginContext(145, 33, true);
            WriteLiteral("\");\r\n        });\r\n    </script>\r\n");
            EndContext();
#line 8 "C:\Users\Bernardo Estacio\Desktop\OPS2020 GUI\OutilEnquete\Views\Shared\_FlashPartial.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591