#pragma checksum "C:\Users\brkyc\Desktop\Karışık\Mesut_Gedik_StudentSystemInformation\StudentSystem\StudentSystem\Views\Home\Sis.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "92fec23a2ce521784d9f29d23ed15208a2dd6f19"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Sis), @"mvc.1.0.view", @"/Views/Home/Sis.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Sis.cshtml", typeof(AspNetCore.Views_Home_Sis))]
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
#line 1 "C:\Users\brkyc\Desktop\Karışık\Mesut_Gedik_StudentSystemInformation\StudentSystem\StudentSystem\Views\_ViewImports.cshtml"
using StudentSystem.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"92fec23a2ce521784d9f29d23ed15208a2dd6f19", @"/Views/Home/Sis.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"613ad7c9d83b711191b4edbc088c3d475ffe1e2a", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Sis : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Student>
    {
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\brkyc\Desktop\Karışık\Mesut_Gedik_StudentSystemInformation\StudentSystem\StudentSystem\Views\Home\Sis.cshtml"
  
    ViewData["Title"] = "Sis";


#line default
#line hidden
            BeginContext(57, 29, true);
            WriteLiteral("\r\n<!DOCTYPE html>\r\n\r\n<html>\r\n");
            EndContext();
            BeginContext(86, 451, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "88b1a117672e43bfaf6eca74f0d0eabb", async() => {
                BeginContext(92, 438, true);
                WriteLiteral(@"
    <style>
        table, th, td {
            border: 1px solid black;
            border-collapse: collapse;
        }

        th {
            padding: 10px;
            font-size:large;
        }

        td {
            padding: 5px;
            font-size: large;
            text-align: left;
        }
    </style>
    <meta name=""viewport"" content=""width=device-width"" />
    <title>SecilenDersler</title>
");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(537, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(539, 839, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6d2076bb0706453c8bd3d5408bcf7ba2", async() => {
                BeginContext(545, 60, true);
                WriteLiteral("\r\n\r\n    <div class=\"col-md-10\">\r\n        <div class=\"col\">\r\n");
                EndContext();
                BeginContext(737, 382, true);
                WriteLiteral(@"
            <table style=""width:75%"">
                <tr>
                    <th colspan=""3"" style=""text-align:center "">Öğrenci Bilgileri</th>
                </tr>
                <tr>
                    <th>Name</th>
                    <th>Surname</th>
                    <th>Student Number</th>
                </tr>
                <tr>
                    <td>");
                EndContext();
                BeginContext(1120, 10, false);
#line 50 "C:\Users\brkyc\Desktop\Karışık\Mesut_Gedik_StudentSystemInformation\StudentSystem\StudentSystem\Views\Home\Sis.cshtml"
                   Write(Model.Name);

#line default
#line hidden
                EndContext();
                BeginContext(1130, 31, true);
                WriteLiteral("</td>\r\n                    <td>");
                EndContext();
                BeginContext(1162, 13, false);
#line 51 "C:\Users\brkyc\Desktop\Karışık\Mesut_Gedik_StudentSystemInformation\StudentSystem\StudentSystem\Views\Home\Sis.cshtml"
                   Write(Model.Surname);

#line default
#line hidden
                EndContext();
                BeginContext(1175, 31, true);
                WriteLiteral("</td>\r\n                    <td>");
                EndContext();
                BeginContext(1207, 19, false);
#line 52 "C:\Users\brkyc\Desktop\Karışık\Mesut_Gedik_StudentSystemInformation\StudentSystem\StudentSystem\Views\Home\Sis.cshtml"
                   Write(Model.StudentNumber);

#line default
#line hidden
                EndContext();
                BeginContext(1226, 72, true);
                WriteLiteral("</td>\r\n                </tr>\r\n\r\n            </table>\r\n\r\n        </div>\r\n");
                EndContext();
                BeginContext(1357, 14, true);
                WriteLiteral("    </div>\r\n\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1378, 9, true);
            WriteLiteral("\r\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Student> Html { get; private set; }
    }
}
#pragma warning restore 1591
