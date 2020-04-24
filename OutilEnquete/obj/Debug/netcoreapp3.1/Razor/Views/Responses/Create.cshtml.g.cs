#pragma checksum "C:\Users\Bernardo Estacio\Desktop\OPS2020 GUI\OutilEnquete\Views\Responses\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cd85acfc8241443828b218033c44615624b6815c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Responses_Create), @"mvc.1.0.view", @"/Views/Responses/Create.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Responses/Create.cshtml", typeof(AspNetCore.Views_Responses_Create))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cd85acfc8241443828b218033c44615624b6815c", @"/Views/Responses/Create.cshtml")]
    public class Views_Responses_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<OutilEnquete.Models.Survey>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(35, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Bernardo Estacio\Desktop\OPS2020 GUI\OutilEnquete\Views\Responses\Create.cshtml"
  
    ViewBag.Title = Model.Name;

#line default
#line hidden
            BeginContext(77, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(98, 364, true);
                WriteLiteral(@"
    <script type=""text/javascript"">
        $(function() {
            $('.datepicker').datepicker({format: 'mm/dd/yyyy'});

            $(document).on('click', 'a[data-toggle=comment]', function() {
                var id = $(this).attr('href');
                $(id).toggle();
                return false;
            });
        });
    </script>
");
                EndContext();
            }
            );
            BeginContext(465, 37, true);
            WriteLiteral("\r\n<div class=\"page-header\">\r\n    <h3>");
            EndContext();
            BeginContext(503, 13, false);
#line 23 "C:\Users\Bernardo Estacio\Desktop\OPS2020 GUI\OutilEnquete\Views\Responses\Create.cshtml"
   Write(ViewBag.Title);

#line default
#line hidden
            EndContext();
            BeginContext(516, 22, true);
            WriteLiteral("</h3>\r\n</div>\r\n\r\n<form");
            EndContext();
            BeginWriteAttribute("action", " action=\"", 538, "\"", 619, 1);
#line 26 "C:\Users\Bernardo Estacio\Desktop\OPS2020 GUI\OutilEnquete\Views\Responses\Create.cshtml"
WriteAttributeValue("", 547, Url.Action("Create", "Responses", new {surveyId = Request["surveyId"]}), 547, 72, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(620, 139, true);
            WriteLiteral(" method=\"post\">\r\n    <div class=\"well well-small\">\r\n        <h4>Questions</h4>\r\n    </div>\r\n    <ul class=\"unstyled bordered skip-first\">\r\n");
            EndContext();
#line 31 "C:\Users\Bernardo Estacio\Desktop\OPS2020 GUI\OutilEnquete\Views\Responses\Create.cshtml"
         foreach (var question in Model.Questions)
        {

#line default
#line hidden
            BeginContext(822, 128, true);
            WriteLiteral("            <li class=\"row\">\r\n                <div class=\"span9\">\r\n                    <input type=\"hidden\" name=\"Answers.Index\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 950, "\"", 970, 1);
#line 35 "C:\Users\Bernardo Estacio\Desktop\OPS2020 GUI\OutilEnquete\Views\Responses\Create.cshtml"
WriteAttributeValue("", 958, question.Id, 958, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(971, 45, true);
            WriteLiteral(" />\r\n                    <input type=\"hidden\"");
            EndContext();
            BeginWriteAttribute("name", " name=\"", 1016, "\"", 1055, 3);
            WriteAttributeValue("", 1023, "Answers[", 1023, 8, true);
#line 36 "C:\Users\Bernardo Estacio\Desktop\OPS2020 GUI\OutilEnquete\Views\Responses\Create.cshtml"
WriteAttributeValue("", 1031, question.Id, 1031, 12, false);

#line default
#line hidden
            WriteAttributeValue("", 1043, "].QuestionId", 1043, 12, true);
            EndWriteAttribute();
            BeginWriteAttribute("value", " value=\"", 1056, "\"", 1076, 1);
#line 36 "C:\Users\Bernardo Estacio\Desktop\OPS2020 GUI\OutilEnquete\Views\Responses\Create.cshtml"
WriteAttributeValue("", 1064, question.Id, 1064, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1077, 25, true);
            WriteLiteral(" />\r\n                    ");
            EndContext();
            BeginContext(1103, 23, false);
#line 37 "C:\Users\Bernardo Estacio\Desktop\OPS2020 GUI\OutilEnquete\Views\Responses\Create.cshtml"
               Write(Html.Raw(question.Body));

#line default
#line hidden
            EndContext();
            BeginContext(1126, 63, true);
            WriteLiteral("\r\n                </div>\r\n                <div class=\"span3\">\r\n");
            EndContext();
#line 40 "C:\Users\Bernardo Estacio\Desktop\OPS2020 GUI\OutilEnquete\Views\Responses\Create.cshtml"
                     if (question.Type == "Yes/No")
                    {

#line default
#line hidden
            BeginContext(1265, 45, true);
            WriteLiteral("                        <select class=\"span3\"");
            EndContext();
            BeginWriteAttribute("name", " name=\"", 1310, "\"", 1344, 3);
            WriteAttributeValue("", 1317, "Answers[", 1317, 8, true);
#line 42 "C:\Users\Bernardo Estacio\Desktop\OPS2020 GUI\OutilEnquete\Views\Responses\Create.cshtml"
WriteAttributeValue("", 1325, question.Id, 1325, 12, false);

#line default
#line hidden
            WriteAttributeValue("", 1337, "].Value", 1337, 7, true);
            EndWriteAttribute();
            BeginContext(1345, 219, true);
            WriteLiteral(">\r\n                            <option disabled selected>Select a value...</option>\r\n                            <option>Yes</option>\r\n                            <option>No</option>\r\n                        </select>\r\n");
            EndContext();
#line 47 "C:\Users\Bernardo Estacio\Desktop\OPS2020 GUI\OutilEnquete\Views\Responses\Create.cshtml"
                    }

#line default
#line hidden
            BeginContext(1587, 20, true);
            WriteLiteral("                    ");
            EndContext();
#line 48 "C:\Users\Bernardo Estacio\Desktop\OPS2020 GUI\OutilEnquete\Views\Responses\Create.cshtml"
                     if (question.Type == "Number")
                    {

#line default
#line hidden
            BeginContext(1663, 56, true);
            WriteLiteral("                        <input class=\"span3\" type=\"text\"");
            EndContext();
            BeginWriteAttribute("name", " name=\"", 1719, "\"", 1753, 3);
            WriteAttributeValue("", 1726, "Answers[", 1726, 8, true);
#line 50 "C:\Users\Bernardo Estacio\Desktop\OPS2020 GUI\OutilEnquete\Views\Responses\Create.cshtml"
WriteAttributeValue("", 1734, question.Id, 1734, 12, false);

#line default
#line hidden
            WriteAttributeValue("", 1746, "].Value", 1746, 7, true);
            EndWriteAttribute();
            BeginContext(1754, 37, true);
            WriteLiteral(" placeholder=\"Enter a number...\" />\r\n");
            EndContext();
#line 51 "C:\Users\Bernardo Estacio\Desktop\OPS2020 GUI\OutilEnquete\Views\Responses\Create.cshtml"
                    }

#line default
#line hidden
            BeginContext(1814, 29, true);
            WriteLiteral("                    <textarea");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 1843, "\"", 1874, 1);
#line 52 "C:\Users\Bernardo Estacio\Desktop\OPS2020 GUI\OutilEnquete\Views\Responses\Create.cshtml"
WriteAttributeValue("", 1848, "comment" + question.Id, 1848, 26, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1875, 19, true);
            WriteLiteral(" class=\"span3 hide\"");
            EndContext();
            BeginWriteAttribute("name", " name=\"", 1894, "\"", 1930, 3);
            WriteAttributeValue("", 1901, "Answers[", 1901, 8, true);
#line 52 "C:\Users\Bernardo Estacio\Desktop\OPS2020 GUI\OutilEnquete\Views\Responses\Create.cshtml"
WriteAttributeValue("", 1909, question.Id, 1909, 12, false);

#line default
#line hidden
            WriteAttributeValue("", 1921, "].Comment", 1921, 9, true);
            EndWriteAttribute();
            BeginContext(1931, 62, true);
            WriteLiteral(" placeholder=\"Comments...\"></textarea>\r\n                    <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1993, "\"", 2028, 1);
#line 53 "C:\Users\Bernardo Estacio\Desktop\OPS2020 GUI\OutilEnquete\Views\Responses\Create.cshtml"
WriteAttributeValue("", 2000, "#comment" + @question.Id, 2000, 28, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2029, 104, true);
            WriteLiteral(" data-toggle=\"comment\"><small>Show/Hide Comment</small></a>\r\n                </div>\r\n            </li>\r\n");
            EndContext();
#line 56 "C:\Users\Bernardo Estacio\Desktop\OPS2020 GUI\OutilEnquete\Views\Responses\Create.cshtml"
        }

#line default
#line hidden
            BeginContext(2144, 290, true);
            WriteLiteral(@"    </ul>
    
    <div class=""form-actions"">
        <button class=""btn btn-inverse pull-right"" name=""action"" value=""Next"">
            Save and Enter Another
        </button>
        <input class=""btn btn-primary"" type=""submit"" name=""action"" value=""Save"" />
        <a class=""btn""");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2434, "\"", 2469, 1);
#line 64 "C:\Users\Bernardo Estacio\Desktop\OPS2020 GUI\OutilEnquete\Views\Responses\Create.cshtml"
WriteAttributeValue("", 2441, Url.Action("Index", "Home"), 2441, 28, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2470, 32, true);
            WriteLiteral(">Cancel</a>\r\n    </div>\r\n</form>");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<OutilEnquete.Models.Survey> Html { get; private set; }
    }
}
#pragma warning restore 1591
